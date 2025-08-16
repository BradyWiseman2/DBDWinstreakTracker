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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBasicCharacter).BeginInit();
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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1057, 522);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            // btn_LoadStreak
            // 
            btn_LoadStreak.Location = new Point(739, 90);
            btn_LoadStreak.Name = "btn_LoadStreak";
            btn_LoadStreak.Size = new Size(289, 75);
            btn_LoadStreak.TabIndex = 1;
            btn_LoadStreak.Text = "Load Streak";
            btn_LoadStreak.UseVisualStyleBackColor = true;
            btn_LoadStreak.Click += btn_LoadStreak_Click;
            // 
            // lBox_SavedStreaks
            // 
            lBox_SavedStreaks.FormattingEnabled = true;
            lBox_SavedStreaks.ItemHeight = 15;
            lBox_SavedStreaks.Location = new Point(298, 90);
            lBox_SavedStreaks.Name = "lBox_SavedStreaks";
            lBox_SavedStreaks.Size = new Size(419, 229);
            lBox_SavedStreaks.TabIndex = 0;
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
            BtnStartStreak.Location = new Point(394, 142);
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
            cBoxCharacterSelector.Location = new Point(394, 96);
            cBoxCharacterSelector.Name = "cBoxCharacterSelector";
            cBoxCharacterSelector.Size = new Size(231, 23);
            cBoxCharacterSelector.TabIndex = 3;
            // 
            // cBoxStreakTypeSelect
            // 
            cBoxStreakTypeSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxStreakTypeSelect.FormattingEnabled = true;
            cBoxStreakTypeSelect.Items.AddRange(new object[] { "Basic Streak", "Random Perk Streak", "2v8 Random Streak" });
            cBoxStreakTypeSelect.Location = new Point(394, 54);
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
    }
}
