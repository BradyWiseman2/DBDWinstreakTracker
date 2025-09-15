namespace DBDWinstreakTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CharacterFlowPanel = new FlowLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnNewStreak = new Button();
            btn_LoadStreak = new Button();
            lBox_SavedStreaks = new ListBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            BtnStartStreak = new Button();
            label2 = new Label();
            cBoxCharacterSelector = new ComboBox();
            cBoxStreakTypeSelect = new ComboBox();
            label1 = new Label();
            tabPage4 = new TabPage();
            btnLoseStreak = new Button();
            btnBasicWin = new Button();
            lblBasicWins = new Label();
            pBoxBasicCharacter = new PictureBox();
            tabPage5 = new TabPage();
            btnSaveAndQuit = new Button();
            btn2v8Loss = new Button();
            btn2v8Win = new Button();
            lbl2v8Wins = new Label();
            lbl2v8P2Class = new Label();
            lbl2v8P1Class = new Label();
            lbl2v8P2Killer = new Label();
            lbl2v8P1Killer = new Label();
            pBox2v8P2 = new PictureBox();
            pBox2v8P1 = new PictureBox();
            tBoxStreakName = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBasicCharacter).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBox2v8P2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBox2v8P1).BeginInit();
            SuspendLayout();
            // 
            // CharacterFlowPanel
            // 
            CharacterFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CharacterFlowPanel.AutoScroll = true;
            CharacterFlowPanel.BackColor = SystemColors.ActiveCaption;
            CharacterFlowPanel.Location = new Point(145, 22);
            CharacterFlowPanel.Name = "CharacterFlowPanel";
            CharacterFlowPanel.Size = new Size(707, 435);
            CharacterFlowPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1057, 522);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNewStreak);
            tabPage1.Controls.Add(btn_LoadStreak);
            tabPage1.Controls.Add(lBox_SavedStreaks);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1049, 494);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home Page";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNewStreak
            // 
            btnNewStreak.Location = new Point(604, 6);
            btnNewStreak.Name = "btnNewStreak";
            btnNewStreak.Size = new Size(289, 75);
            btnNewStreak.TabIndex = 2;
            btnNewStreak.Text = "New Streak";
            btnNewStreak.UseVisualStyleBackColor = true;
            btnNewStreak.Click += btnNewStreak_Click;
            // 
            // btn_LoadStreak
            // 
            btn_LoadStreak.Location = new Point(3, 224);
            btn_LoadStreak.Name = "btn_LoadStreak";
            btn_LoadStreak.Size = new Size(289, 75);
            btn_LoadStreak.TabIndex = 1;
            btn_LoadStreak.Text = "Load Streak";
            btn_LoadStreak.UseVisualStyleBackColor = true;
            btn_LoadStreak.Click += btn_LoadStreak_Click;
            // 
            // lBox_SavedStreaks
            // 
            lBox_SavedStreaks.DrawMode = DrawMode.OwnerDrawFixed;
            lBox_SavedStreaks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBox_SavedStreaks.FormattingEnabled = true;
            lBox_SavedStreaks.ItemHeight = 31;
            lBox_SavedStreaks.Location = new Point(5, 6);
            lBox_SavedStreaks.Name = "lBox_SavedStreaks";
            lBox_SavedStreaks.Size = new Size(594, 190);
            lBox_SavedStreaks.TabIndex = 0;
            lBox_SavedStreaks.DrawItem += lBox_SavedStreaks_DrawItem;
            lBox_SavedStreaks.SelectedIndexChanged += lBox_SavedStreaks_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CharacterFlowPanel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1049, 494);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Test Page";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(tBoxStreakName);
            tabPage3.Controls.Add(BtnStartStreak);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(cBoxCharacterSelector);
            tabPage3.Controls.Add(cBoxStreakTypeSelect);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1049, 494);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "New Streak";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnStartStreak
            // 
            BtnStartStreak.Location = new Point(412, 166);
            BtnStartStreak.Name = "BtnStartStreak";
            BtnStartStreak.Size = new Size(231, 23);
            BtnStartStreak.TabIndex = 5;
            BtnStartStreak.Text = "Create new streak";
            BtnStartStreak.UseVisualStyleBackColor = true;
            BtnStartStreak.Click += BtnStartStreak_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 99);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Character";
            // 
            // cBoxCharacterSelector
            // 
            cBoxCharacterSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxCharacterSelector.FormattingEnabled = true;
            cBoxCharacterSelector.Items.AddRange(new object[] { "Basic Streak", "Random Perk Streak" });
            cBoxCharacterSelector.Location = new Point(412, 96);
            cBoxCharacterSelector.Name = "cBoxCharacterSelector";
            cBoxCharacterSelector.Size = new Size(231, 23);
            cBoxCharacterSelector.TabIndex = 3;
            // 
            // cBoxStreakTypeSelect
            // 
            cBoxStreakTypeSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxStreakTypeSelect.FormattingEnabled = true;
            cBoxStreakTypeSelect.Items.AddRange(new object[] { "Basic Streak", "Random Perk Streak", "2v8 Random Streak" });
            cBoxStreakTypeSelect.Location = new Point(412, 54);
            cBoxStreakTypeSelect.Name = "cBoxStreakTypeSelect";
            cBoxStreakTypeSelect.Size = new Size(231, 23);
            cBoxStreakTypeSelect.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Streak type";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnLoseStreak);
            tabPage4.Controls.Add(btnBasicWin);
            tabPage4.Controls.Add(lblBasicWins);
            tabPage4.Controls.Add(pBoxBasicCharacter);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1049, 494);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Basic Streak";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnLoseStreak
            // 
            btnLoseStreak.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoseStreak.Location = new Point(265, 91);
            btnLoseStreak.Name = "btnLoseStreak";
            btnLoseStreak.Size = new Size(224, 37);
            btnLoseStreak.TabIndex = 3;
            btnLoseStreak.Text = "Take an L";
            btnLoseStreak.UseVisualStyleBackColor = true;
            btnLoseStreak.Click += btnLoseStreak_Click;
            // 
            // btnBasicWin
            // 
            btnBasicWin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBasicWin.Location = new Point(265, 48);
            btnBasicWin.Name = "btnBasicWin";
            btnBasicWin.Size = new Size(224, 37);
            btnBasicWin.TabIndex = 2;
            btnBasicWin.Text = "Increment Wins";
            btnBasicWin.UseVisualStyleBackColor = true;
            btnBasicWin.Click += btnBasicWin_Click;
            // 
            // lblBasicWins
            // 
            lblBasicWins.AutoSize = true;
            lblBasicWins.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasicWins.Location = new Point(265, 13);
            lblBasicWins.Name = "lblBasicWins";
            lblBasicWins.Size = new Size(99, 32);
            lblBasicWins.TabIndex = 1;
            lblBasicWins.Text = "Wins: 0";
            // 
            // pBoxBasicCharacter
            // 
            pBoxBasicCharacter.Location = new Point(3, 3);
            pBoxBasicCharacter.Name = "pBoxBasicCharacter";
            pBoxBasicCharacter.Size = new Size(256, 256);
            pBoxBasicCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxBasicCharacter.TabIndex = 0;
            pBoxBasicCharacter.TabStop = false;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnSaveAndQuit);
            tabPage5.Controls.Add(btn2v8Loss);
            tabPage5.Controls.Add(btn2v8Win);
            tabPage5.Controls.Add(lbl2v8Wins);
            tabPage5.Controls.Add(lbl2v8P2Class);
            tabPage5.Controls.Add(lbl2v8P1Class);
            tabPage5.Controls.Add(lbl2v8P2Killer);
            tabPage5.Controls.Add(lbl2v8P1Killer);
            tabPage5.Controls.Add(pBox2v8P2);
            tabPage5.Controls.Add(pBox2v8P1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1049, 494);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "2v8RandomStreak";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndQuit
            // 
            btnSaveAndQuit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveAndQuit.Location = new Point(406, 148);
            btnSaveAndQuit.Name = "btnSaveAndQuit";
            btnSaveAndQuit.Size = new Size(224, 37);
            btnSaveAndQuit.TabIndex = 10;
            btnSaveAndQuit.Text = "Save and Quit";
            btnSaveAndQuit.UseVisualStyleBackColor = true;
            btnSaveAndQuit.Click += SaveandQuitButton;
            // 
            // btn2v8Loss
            // 
            btn2v8Loss.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2v8Loss.Location = new Point(406, 105);
            btn2v8Loss.Name = "btn2v8Loss";
            btn2v8Loss.Size = new Size(224, 37);
            btn2v8Loss.TabIndex = 9;
            btn2v8Loss.Text = "Take an L";
            btn2v8Loss.UseVisualStyleBackColor = true;
            btn2v8Loss.Click += btn2v8Loss_Click;
            // 
            // btn2v8Win
            // 
            btn2v8Win.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2v8Win.Location = new Point(406, 62);
            btn2v8Win.Name = "btn2v8Win";
            btn2v8Win.Size = new Size(224, 37);
            btn2v8Win.TabIndex = 8;
            btn2v8Win.Text = "Increment Wins";
            btn2v8Win.UseVisualStyleBackColor = true;
            btn2v8Win.Click += btn2v8Win_Click;
            // 
            // lbl2v8Wins
            // 
            lbl2v8Wins.AutoSize = true;
            lbl2v8Wins.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2v8Wins.Location = new Point(463, 11);
            lbl2v8Wins.Name = "lbl2v8Wins";
            lbl2v8Wins.Size = new Size(99, 32);
            lbl2v8Wins.TabIndex = 7;
            lbl2v8Wins.Text = "Wins: 0";
            // 
            // lbl2v8P2Class
            // 
            lbl2v8P2Class.AutoSize = true;
            lbl2v8P2Class.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2v8P2Class.Location = new Point(783, 307);
            lbl2v8P2Class.Name = "lbl2v8P2Class";
            lbl2v8P2Class.Size = new Size(152, 32);
            lbl2v8P2Class.TabIndex = 6;
            lbl2v8P2Class.Text = "Fearmonger";
            // 
            // lbl2v8P1Class
            // 
            lbl2v8P1Class.AutoSize = true;
            lbl2v8P1Class.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2v8P1Class.Location = new Point(12, 307);
            lbl2v8P1Class.Name = "lbl2v8P1Class";
            lbl2v8P1Class.Size = new Size(76, 32);
            lbl2v8P1Class.TabIndex = 5;
            lbl2v8P1Class.Text = "Brute";
            // 
            // lbl2v8P2Killer
            // 
            lbl2v8P2Killer.AutoSize = true;
            lbl2v8P2Killer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2v8P2Killer.Location = new Point(783, 276);
            lbl2v8P2Killer.Name = "lbl2v8P2Killer";
            lbl2v8P2Killer.Size = new Size(123, 32);
            lbl2v8P2Killer.TabIndex = 4;
            lbl2v8P2Killer.Text = "The Spirit";
            // 
            // lbl2v8P1Killer
            // 
            lbl2v8P1Killer.AutoSize = true;
            lbl2v8P1Killer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2v8P1Killer.Location = new Point(12, 276);
            lbl2v8P1Killer.Name = "lbl2v8P1Killer";
            lbl2v8P1Killer.Size = new Size(207, 32);
            lbl2v8P1Killer.TabIndex = 3;
            lbl2v8P1Killer.Text = "The Deathslinger";
            // 
            // pBox2v8P2
            // 
            pBox2v8P2.Location = new Point(783, 11);
            pBox2v8P2.Name = "pBox2v8P2";
            pBox2v8P2.Size = new Size(256, 256);
            pBox2v8P2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox2v8P2.TabIndex = 2;
            pBox2v8P2.TabStop = false;
            // 
            // pBox2v8P1
            // 
            pBox2v8P1.Location = new Point(12, 11);
            pBox2v8P1.Name = "pBox2v8P1";
            pBox2v8P1.Size = new Size(256, 256);
            pBox2v8P1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox2v8P1.TabIndex = 1;
            pBox2v8P1.TabStop = false;
            // 
            // tBoxStreakName
            // 
            tBoxStreakName.Location = new Point(412, 137);
            tBoxStreakName.Name = "tBoxStreakName";
            tBoxStreakName.Size = new Size(231, 23);
            tBoxStreakName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 140);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Streak name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 581);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBasicCharacter).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBox2v8P2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBox2v8P1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel CharacterFlowPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private ComboBox cBoxStreakTypeSelect;
        private Button BtnStartStreak;
        private Label label2;
        private ComboBox cBoxCharacterSelector;
        private TabPage tabPage4;
        private Button btnBasicWin;
        private Label lblBasicWins;
        private PictureBox pBoxBasicCharacter;
        private Button btnLoseStreak;
        private ListBox lBox_SavedStreaks;
        private Button btn_LoadStreak;
        private TabPage tabPage5;
        private PictureBox pBox2v8P2;
        private PictureBox pBox2v8P1;
        private Label lbl2v8P2Killer;
        private Label lbl2v8P1Killer;
        private Label lbl2v8Wins;
        private Label lbl2v8P2Class;
        private Label lbl2v8P1Class;
        private Button btn2v8Loss;
        private Button btn2v8Win;
        private Button btnNewStreak;
        private Button btnSaveAndQuit;
        private Label label3;
        private TextBox tBoxStreakName;
    }
}
