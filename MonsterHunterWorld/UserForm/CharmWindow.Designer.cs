namespace MonsterHunterWorld.UserForm
{
    partial class CharmWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CharmPanel = new System.Windows.Forms.Panel();
            this.CharmListBox = new System.Windows.Forms.ListBox();
            this.CharmNameLabel = new System.Windows.Forms.Label();
            this.CharmPictureBox = new System.Windows.Forms.PictureBox();
            this.SkillLabel = new System.Windows.Forms.Label();
            this.SkillPictureBox = new System.Windows.Forms.PictureBox();
            this.SkillLevelLabel = new System.Windows.Forms.Label();
            this.CraftListBox = new System.Windows.Forms.ListBox();
            this.Upgradepanel = new System.Windows.Forms.Panel();
            this.UpgradeLabel = new System.Windows.Forms.Label();
            this.PreviousCharmNameLabel = new System.Windows.Forms.Label();
            this.PreviousCharmPictureBox = new System.Windows.Forms.PictureBox();
            this.RarityLabel = new System.Windows.Forms.Label();
            this.CraftLabel = new System.Windows.Forms.Label();
            this.CharmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillPictureBox)).BeginInit();
            this.Upgradepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousCharmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CharmPanel
            // 
            this.CharmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.CharmPanel.Controls.Add(this.CharmListBox);
            this.CharmPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CharmPanel.Location = new System.Drawing.Point(0, 0);
            this.CharmPanel.Name = "CharmPanel";
            this.CharmPanel.Size = new System.Drawing.Size(248, 750);
            this.CharmPanel.TabIndex = 0;
            // 
            // CharmListBox
            // 
            this.CharmListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.CharmListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharmListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CharmListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CharmListBox.ForeColor = System.Drawing.Color.White;
            this.CharmListBox.FormattingEnabled = true;
            this.CharmListBox.ItemHeight = 25;
            this.CharmListBox.Location = new System.Drawing.Point(0, 0);
            this.CharmListBox.Name = "CharmListBox";
            this.CharmListBox.Size = new System.Drawing.Size(273, 750);
            this.CharmListBox.TabIndex = 1;
            this.CharmListBox.SelectedIndexChanged += new System.EventHandler(this.CharmListBox_SelectedIndexChanged);
            // 
            // CharmNameLabel
            // 
            this.CharmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.CharmNameLabel.Location = new System.Drawing.Point(422, 48);
            this.CharmNameLabel.Name = "CharmNameLabel";
            this.CharmNameLabel.Size = new System.Drawing.Size(545, 58);
            this.CharmNameLabel.TabIndex = 2;
            this.CharmNameLabel.Text = "Charm Name";
            this.CharmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharmPictureBox
            // 
            this.CharmPictureBox.BackgroundImage = global::MonsterHunterWorld.Properties.Resources.ui_item_background;
            this.CharmPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CharmPictureBox.Location = new System.Drawing.Point(316, 30);
            this.CharmPictureBox.Name = "CharmPictureBox";
            this.CharmPictureBox.Size = new System.Drawing.Size(100, 100);
            this.CharmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharmPictureBox.TabIndex = 3;
            this.CharmPictureBox.TabStop = false;
            // 
            // SkillLabel
            // 
            this.SkillLabel.AutoSize = true;
            this.SkillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SkillLabel.Location = new System.Drawing.Point(573, 203);
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(105, 25);
            this.SkillLabel.TabIndex = 5;
            this.SkillLabel.Text = "Skill Name";
            // 
            // SkillPictureBox
            // 
            this.SkillPictureBox.Location = new System.Drawing.Point(578, 244);
            this.SkillPictureBox.Name = "SkillPictureBox";
            this.SkillPictureBox.Size = new System.Drawing.Size(180, 20);
            this.SkillPictureBox.TabIndex = 6;
            this.SkillPictureBox.TabStop = false;
            // 
            // SkillLevelLabel
            // 
            this.SkillLevelLabel.AutoSize = true;
            this.SkillLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SkillLevelLabel.Location = new System.Drawing.Point(764, 239);
            this.SkillLevelLabel.Name = "SkillLevelLabel";
            this.SkillLevelLabel.Size = new System.Drawing.Size(38, 25);
            this.SkillLevelLabel.TabIndex = 7;
            this.SkillLevelLabel.Text = "Lv ";
            // 
            // CraftListBox
            // 
            this.CraftListBox.BackColor = System.Drawing.SystemColors.Control;
            this.CraftListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CraftListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CraftListBox.FormattingEnabled = true;
            this.CraftListBox.ItemHeight = 20;
            this.CraftListBox.Location = new System.Drawing.Point(534, 473);
            this.CraftListBox.Name = "CraftListBox";
            this.CraftListBox.Size = new System.Drawing.Size(335, 240);
            this.CraftListBox.TabIndex = 8;
            this.CraftListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CraftListBox_MouseDoubleClick);
            // 
            // Upgradepanel
            // 
            this.Upgradepanel.Controls.Add(this.UpgradeLabel);
            this.Upgradepanel.Controls.Add(this.PreviousCharmNameLabel);
            this.Upgradepanel.Controls.Add(this.PreviousCharmPictureBox);
            this.Upgradepanel.Location = new System.Drawing.Point(544, 296);
            this.Upgradepanel.Name = "Upgradepanel";
            this.Upgradepanel.Size = new System.Drawing.Size(305, 126);
            this.Upgradepanel.TabIndex = 9;
            // 
            // UpgradeLabel
            // 
            this.UpgradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.UpgradeLabel.Location = new System.Drawing.Point(31, 10);
            this.UpgradeLabel.Name = "UpgradeLabel";
            this.UpgradeLabel.Size = new System.Drawing.Size(244, 26);
            this.UpgradeLabel.TabIndex = 2;
            this.UpgradeLabel.Text = global::MonsterHunterWorld.Properties.String.CharmUpgradeFrom;
            this.UpgradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousCharmNameLabel
            // 
            this.PreviousCharmNameLabel.AutoSize = true;
            this.PreviousCharmNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousCharmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PreviousCharmNameLabel.Location = new System.Drawing.Point(92, 70);
            this.PreviousCharmNameLabel.Name = "PreviousCharmNameLabel";
            this.PreviousCharmNameLabel.Size = new System.Drawing.Size(149, 17);
            this.PreviousCharmNameLabel.TabIndex = 1;
            this.PreviousCharmNameLabel.Text = "Previous Charm Name";
            this.PreviousCharmNameLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PreviousCharmNameLabel_MouseClick);
            // 
            // PreviousCharmPictureBox
            // 
            this.PreviousCharmPictureBox.BackgroundImage = global::MonsterHunterWorld.Properties.Resources.ui_item_background;
            this.PreviousCharmPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousCharmPictureBox.Location = new System.Drawing.Point(34, 54);
            this.PreviousCharmPictureBox.Name = "PreviousCharmPictureBox";
            this.PreviousCharmPictureBox.Size = new System.Drawing.Size(45, 45);
            this.PreviousCharmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousCharmPictureBox.TabIndex = 0;
            this.PreviousCharmPictureBox.TabStop = false;
            // 
            // RarityLabel
            // 
            this.RarityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RarityLabel.Location = new System.Drawing.Point(658, 106);
            this.RarityLabel.Name = "RarityLabel";
            this.RarityLabel.Size = new System.Drawing.Size(100, 24);
            this.RarityLabel.TabIndex = 10;
            this.RarityLabel.Text = "Rarity 8";
            // 
            // CraftLabel
            // 
            this.CraftLabel.AutoSize = true;
            this.CraftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CraftLabel.Location = new System.Drawing.Point(625, 439);
            this.CraftLabel.Name = "CraftLabel";
            this.CraftLabel.Size = new System.Drawing.Size(160, 22);
            this.CraftLabel.TabIndex = 11;
            this.CraftLabel.Text = global::MonsterHunterWorld.Properties.String.GeneralRequiredMaterials;
            // 
            // CharmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CraftLabel);
            this.Controls.Add(this.RarityLabel);
            this.Controls.Add(this.Upgradepanel);
            this.Controls.Add(this.CraftListBox);
            this.Controls.Add(this.SkillLevelLabel);
            this.Controls.Add(this.SkillPictureBox);
            this.Controls.Add(this.SkillLabel);
            this.Controls.Add(this.CharmPictureBox);
            this.Controls.Add(this.CharmNameLabel);
            this.Controls.Add(this.CharmPanel);
            this.Name = "CharmWindow";
            this.Size = new System.Drawing.Size(1100, 750);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CharmWindow_MouseClick);
            this.CharmPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CharmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillPictureBox)).EndInit();
            this.Upgradepanel.ResumeLayout(false);
            this.Upgradepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousCharmPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CharmPanel;
        private System.Windows.Forms.ListBox CharmListBox;
        private System.Windows.Forms.Label CharmNameLabel;
        private System.Windows.Forms.PictureBox CharmPictureBox;
        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.PictureBox SkillPictureBox;
        private System.Windows.Forms.Label SkillLevelLabel;
        private System.Windows.Forms.ListBox CraftListBox;
        private System.Windows.Forms.Panel Upgradepanel;
        private System.Windows.Forms.Label UpgradeLabel;
        private System.Windows.Forms.Label PreviousCharmNameLabel;
        private System.Windows.Forms.PictureBox PreviousCharmPictureBox;
        private System.Windows.Forms.Label RarityLabel;
        private System.Windows.Forms.Label CraftLabel;
    }
}
