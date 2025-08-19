using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBDWinstreakTracker
{
    public class StreakSaveFile
    {
        public List<StreakData> Streaks { get; set; }
    }
    [XmlInclude(typeof(Random2v8StreakData))]
    public class StreakData
    {      
        public virtual string StreakType { get { return "Basic Streak"; } }
        public virtual string StreakDisplayString { get { return $"{StreakType} - {Killer.GetByID(CharacterID).Name} - {Wins} wins"; } }
        public int StreakID { get; set; }
        public int CharacterID { get; set; }
        public int Wins { get; set; }
        public int TargetWins { get; set; }
        public bool IsStreakEnded { get; set; }
        public DateTime LastEdited { get; set; }
        public StreakData(int characterID,int targetWins) 
        {
            CharacterID = characterID;
            TargetWins = targetWins;
            IsStreakEnded = false;
            LastEdited = DateTime.Now;
        }
        public StreakData() { }
        
    }
    public class GenericStreak
    {
        public StreakData SaveData { get; set; }
        public ICharacter Character { get; set; }
        public bool UnsavedChanges { get; set; }
        public GenericStreak(StreakData data)
        {
            SaveData = data;
            Character = Killer.Killers.Where(x => x.Character_ID == data.CharacterID).First();
            UnsavedChanges = false;
        }
        public virtual void IncrementWins()
        {
            SaveData.Wins++;
            UnsavedChanges = true;
        }
        public virtual void EndStreak()
        {
            SaveData.IsStreakEnded = true;
            UnsavedChanges = true;
        }
    }

    public class Random2v8StreakData : StreakData
    {
        public List<int> AllKillers { get; set; }
        public List<Tag> KillerRepeatList { get; set; }
        public Tag ActiveKiller1 { get; set; }
        public Tag ActiveKiller2 { get; set; }
        public int KillerRepeatMatches { get; set; }
        public override string StreakType { get { return "2v8 Random Streak"; } }
        public override string StreakDisplayString { get { return $"{StreakType} - {Wins} wins"; } }

        public Random2v8StreakData(int targetWins):base(268435456, targetWins)
        {
            AllKillers = new List<int>();
            foreach (Killer k in Killer.Killers)
            {
                if (k.Tags["2v8"] == "Yes")
                {
                    AllKillers.Add(k.Character_ID);
                }
            }
            KillerRepeatList = new List<Tag>();
            int test = AllKillers[0];
            KillerRepeatMatches = 1;           
        }
        public Random2v8StreakData() : base()
        {
            
        }
    }
    public class Random2v8Streak : GenericStreak
    {
        public Random rnd { get; set; }
        public List<Killer> AllowedKillers { get; set; }
        public Dictionary<Killer,int> KillerRepeatPrevention { get; set; }
        public Killer Player1 { get; set; }
        public string Player1Class { get; set; }
        public Killer Player2 { get; set; }
        public string Player2Class { get; set; }
        public List<string> KillerClasses { get; set; }
        public Random2v8StreakData StreakData { get { return SaveData as Random2v8StreakData; } }

        public Random2v8Streak(Random2v8StreakData data) : base(data) 
        {
            rnd = new Random();
            SaveData = data;
            AllowedKillers = new List<Killer>();
            KillerRepeatPrevention = new Dictionary<Killer,int>();
            KillerClasses = new List<string> { "Brute","Enforcer","Shadow","Fearmonger"};
            foreach(int i in data.AllKillers)
            {
                AllowedKillers.Add(Killer.GetByID(i));
            }
            foreach(Tag tag in data.KillerRepeatList)
            {
                Killer killer = Killer.GetByID(int.Parse(tag.Key));
                AllowedKillers.Remove(killer);
                KillerRepeatPrevention.Add(killer, int.Parse(tag.Value));
            }
            if(data.ActiveKiller1 == null)
            {
                data.ActiveKiller1 = new Tag();
                data.ActiveKiller2 = new Tag();
                RollNextKillers();
            }
            else
            {
                Player1 = Killer.GetByID(int.Parse(data.ActiveKiller1.Key));
                Player2 = Killer.GetByID(int.Parse(data.ActiveKiller2.Key));
                Player1Class = data.ActiveKiller1.Value;
                Player2Class = data.ActiveKiller2.Value;

                AllowedKillers.Remove(Player1);
                AllowedKillers.Remove(Player2);
            }
        }

        public void RollNextKillers()
        {
            if(KillerRepeatPrevention.Count > 0)
            {
                foreach(Killer k in KillerRepeatPrevention.Keys.ToList())
                {
                    KillerRepeatPrevention[k]--;
                    if (KillerRepeatPrevention[k] == 0)
                    {
                        AllowedKillers.Add(k);
                        KillerRepeatPrevention.Remove(k);
                    }
                }
            }
            if(Player1 != null)
            {
                KillerRepeatPrevention.Add(Player1, StreakData.KillerRepeatMatches);
                KillerRepeatPrevention.Add(Player2, StreakData.KillerRepeatMatches);                
            }   
            if(KillerClasses.Count < 4)
            {
                KillerClasses.Add(Player1Class);
                KillerClasses.Add(Player2Class);
            }

            Player1 = AllowedKillers[rnd.Next(0, AllowedKillers.Count)];
            AllowedKillers.Remove(Player1);
            Player2 = AllowedKillers[rnd.Next(0, AllowedKillers.Count)];
            AllowedKillers.Remove(Player2);
            Player1Class = KillerClasses[rnd.Next(0, KillerClasses.Count)];
            KillerClasses.Remove(Player1Class);
            Player2Class = KillerClasses[rnd.Next(0, KillerClasses.Count)];
            KillerClasses.Remove(Player2Class);
        }
        public void SetSaveData()
        {
            StreakData.ActiveKiller1.Key = Player1.Character_ID.ToString();
            StreakData.ActiveKiller1.Value = Player1Class;
            StreakData.ActiveKiller2.Key = Player2.Character_ID.ToString();
            StreakData.ActiveKiller2.Value = Player2Class;

            StreakData.KillerRepeatList.Clear();
            foreach(var k in KillerRepeatPrevention)
            {
                StreakData.KillerRepeatList.Add(new Tag(k.Key.Character_ID.ToString(), k.Value.ToString()));
            }

        }
        public override void IncrementWins()
        {
            base.IncrementWins();
            RollNextKillers();
            SetSaveData();
        }
        public override void EndStreak()
        {
            base.EndStreak();
        }
    }
}
