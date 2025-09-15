using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace DBDWinstreakTracker
{
    public partial class Form1 : Form
    {
        protected List<ICharacter> LoadedCharacters { get; set; }
        protected StreakSaveFile SavedStreaks { get; set; }
        protected XmlSerializer PerkSerializer;
        protected XmlSerializer KillerSerializer;
        protected XmlSerializer AddonSerializer;
        protected XmlSerializer StreakSerializer;
        protected GenericStreak ActiveStreak { get; set; }
        protected Dictionary<int, Color> StreakDisplayColors { get; set; }
        public Form1()
        {
            InitializeComponent();
            LoadedCharacters = new List<ICharacter>();
            PerkSerializer = new XmlSerializer(typeof(List<PerkData>));
            KillerSerializer = new XmlSerializer(typeof(List<KillerData>));
            AddonSerializer = new XmlSerializer(typeof(List<KillerAddonData>));
            StreakSerializer = new XmlSerializer(typeof(StreakSaveFile)); //Note to self, there's gotta be a better way than having individual Serializers per type
            StreakDisplayColors = new Dictionary<int, Color>();
            ReloadCharactersAndPerks();
        }
        private void StupidMethodThatShouldntBeNeeded() //Easily the worst bit of code I've ever written instead of learning how to do something right
        {
            string json = File.ReadAllText("Resources/Characters/addons.json");
            List<KillerAddonData> data = WeirdJsonConvert.ParseAddons(json);
            using (StreamWriter sr = new StreamWriter("Resources/addons.xml"))
            {
                AddonSerializer.Serialize(sr, data);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StupidMethodThatShouldntBeNeeded();
            cBoxStreakTypeSelect.SelectedIndex = 0;
            ReloadStreaks();
        }
        private void ReloadCharactersAndPerks()
        {
            Perk.Perks.Clear();
            LoadedCharacters.Clear();
            Killer.Killers.Clear();
            GC.Collect();


            using (StreamReader sr = new StreamReader("Resources/Killers.xml"))
            {
                List<KillerData> killers = (List<KillerData>)KillerSerializer.Deserialize(sr);
                foreach (KillerData k in killers)
                {
                    LoadedCharacters.Add(new Killer(k));
                }
            }

            using (StreamReader sr = new StreamReader("Resources/Perks.xml"))
            {
                List<PerkData> perks = (List<PerkData>)PerkSerializer.Deserialize(sr);
                foreach (PerkData p in perks)
                {
                    Perk a = new Perk(p);
                    if (LoadedCharacters.Where(x => x.Character_ID == p.Character_ID).Count() > 0)
                    {
                        ICharacter character = LoadedCharacters.Where(x => x.Character_ID == p.Character_ID).First();
                        Perk.Perks.Last().Perk_Owner = character;
                        character.Character_Perks.Add(Perk.Perks.Last());
                    }

                }
            }
            UpdateComboBox();
        }
        private void ReloadStreaks()
        {
            ActiveStreak = null;
            SavedStreaks = null;
            StreakDisplayColors.Clear();
            lBox_SavedStreaks.Items.Clear();
            GC.Collect();
            if (!Directory.Exists("SavedStreaks"))
            {
                Directory.CreateDirectory("SavedStreaks");
            }
            if (!File.Exists("SavedStreaks/Streaks.xml"))
            {
                SavedStreaks = new StreakSaveFile();
            }
            else
            {
                using (StreamReader sr = new StreamReader("SavedStreaks/Streaks.xml"))
                {
                    SavedStreaks = (StreakSaveFile)StreakSerializer.Deserialize(sr);
                    SavedStreaks.Streaks.Sort((x, y) => DateTime.Compare(x.LastEdited, y.LastEdited));
                    SavedStreaks.Streaks.Reverse();
                    foreach (StreakData s in SavedStreaks.Streaks)
                    {
                        lBox_SavedStreaks.Items.Add(s.StreakDisplayString);
                        if (s.IsStreakEnded)
                        {
                            StreakDisplayColors.Add(lBox_SavedStreaks.Items.Count - 1, Color.Red);
                        }
                        else
                        {
                            StreakDisplayColors.Add(lBox_SavedStreaks.Items.Count - 1, Color.Green);
                        }
                    }

                }
            }
            if (SavedStreaks.Streaks == null)
            {
                SavedStreaks.Streaks = new List<StreakData>();
                lBox_SavedStreaks.Items.Add("You have no saved streaks. Start a new streak by pressing New Streak.");
            }
        }
        private void UpdateComboBox()
        {
            cBoxCharacterSelector.Items.Clear();
            foreach (ICharacter character in LoadedCharacters)
            {
                cBoxCharacterSelector.Items.Add(character.Name);
            }
        }
        private void UpdateCharacterFlowBox()
        {
            int lastRowCount = 0;
            int margin = (CharacterFlowPanel.Width - (CharacterFlowPanel.Controls[0].Width * 4)) / 5;
            int lastRowMargin = 0;
            bool lastRow = false;
            for (int i = 0; i < CharacterFlowPanel.Controls.Count; i++)
            {
                CharacterFlowPanel.Controls[i].Margin = new Padding(margin, 0, 0, 40);
                if (CharacterFlowPanel.Controls.Count - i < 4 && i % 4 == 0)
                {
                    lastRowCount = CharacterFlowPanel.Controls.Count - i;
                    lastRow = true;
                    lastRowMargin = (CharacterFlowPanel.Width - (CharacterFlowPanel.Controls[0].Width * lastRowCount)) / (lastRowCount + 1);
                }
                if (lastRow)
                {
                    CharacterFlowPanel.Controls[i].Margin = new Padding(lastRowMargin, 0, 0, 40);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStartStreak_Click(object sender, EventArgs e)
        {
            string name = tBoxStreakName.Text;
            switch (cBoxStreakTypeSelect.SelectedIndex)
            {
                case 0:
                    if (cBoxCharacterSelector.SelectedIndex != -1)
                    {
                        
                        if(name == string.Empty)
                        {
                            name = "Generic Streak";
                        }
                        ActiveStreak = new GenericStreak(
                            new StreakData(LoadedCharacters[cBoxCharacterSelector.SelectedIndex].Character_ID, 0, name));
                        SavedStreaks.Streaks.Add(ActiveStreak.SaveData);
                        GoToStreakPage(3);
                    }
                    break;
                case 2:
                    name = tBoxStreakName.Text;
                    if (name == string.Empty)
                    {
                        name = "2v8 Randomizer Streak";
                    }
                    ActiveStreak = new Random2v8Streak(new Random2v8StreakData(0,name));
                    SavedStreaks.Streaks.Add(ActiveStreak.SaveData);
                    GoToStreakPage(4);
                    break;
            }


        }

        private void btnBasicWin_Click(object sender, EventArgs e)
        {
            ActiveStreak.IncrementWins();
            lblBasicWins.Text = $"Wins: {ActiveStreak.SaveData.Wins}";
        }
        private void GoToStreakPage(int page)
        {
            switch (page)
            {
                case 3:
                    tabControl1.SelectedIndex = 3;
                    pBoxBasicCharacter.Image = ActiveStreak.Character.Character_Portrait;
                    lblBasicWins.Text = $"Wins: {ActiveStreak.SaveData.Wins}";
                    break;
                case 4:
                    tabControl1.SelectedIndex = 4;
                    Set2v8Visuals();
                    break;
            }
        }

        private void btnLoseStreak_Click(object sender, EventArgs e)
        {
            ActiveStreak.EndStreak();
            SaveStreaks();
            ReloadStreaks();
            tabControl1.SelectedIndex = 0;
        }
        private void Set2v8Visuals()
        {
            Random2v8Streak streak = ActiveStreak as Random2v8Streak;
            pBox2v8P1.Image = streak.Player1.Character_Portrait;
            pBox2v8P2.Image = streak.Player2.Character_Portrait;

            lbl2v8P1Killer.Text = streak.Player1.Name;
            lbl2v8P1Class.Text = streak.Player1Class;

            lbl2v8P2Killer.Text = streak.Player2.Name;
            lbl2v8P2Class.Text = streak.Player2Class;
            lbl2v8Wins.Text = $"Wins: {streak.SaveData.Wins}";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ActiveStreak != null)
            {
                if (ActiveStreak.UnsavedChanges)
                {
                    if (MessageBox.Show("Do you want to save changes to your streaks before closing?", "",
      MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveStreaks();
                    }
                }
            }

        }
        private void SaveStreaks()
        {
            using (StreamWriter sr = new StreamWriter("SavedStreaks/Streaks.xml"))
            {
                StreakSerializer.Serialize(sr, SavedStreaks);
            }
        }
        private void btn_LoadStreak_Click(object sender, EventArgs e)
        {
            if (lBox_SavedStreaks.SelectedIndex != -1)
            {
                StreakData a = SavedStreaks.Streaks[lBox_SavedStreaks.SelectedIndex];
                if (!a.IsStreakEnded)
                {
                    switch (a.StreakType)
                    {
                        case "Basic Streak":
                            ActiveStreak = new GenericStreak(a);
                            GoToStreakPage(3);
                            break;
                        case "2v8 Random Streak":
                            ActiveStreak = new Random2v8Streak(a as Random2v8StreakData);
                            GoToStreakPage(4);
                            Set2v8Visuals();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("A streak marked as Ended cannot be loaded directly");
                }
            }
            else
            {
                MessageBox.Show("Select a streak first");
            }
        }

        private void btn2v8Win_Click(object sender, EventArgs e)
        {
            ActiveStreak.IncrementWins();
            Set2v8Visuals();
        }

        private void btnNewStreak_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btn2v8Loss_Click(object sender, EventArgs e)
        {
            ActiveStreak.EndStreak();
            SaveandQuitButton(sender,e);
        }

        private void lBox_SavedStreaks_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            if (e.Index == lBox_SavedStreaks.SelectedIndex)
            {
                g.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }
            ListBox lb = (ListBox)sender;

            g.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(StreakDisplayColors[e.Index]), new PointF(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        private void lBox_SavedStreaks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBox_SavedStreaks.Invalidate();
        }
        private void SaveandQuitButton(object sender, EventArgs e)
        {
            SaveStreaks();
            ReloadStreaks();
            tabControl1.SelectedIndex = 0;
        }
    }
}
