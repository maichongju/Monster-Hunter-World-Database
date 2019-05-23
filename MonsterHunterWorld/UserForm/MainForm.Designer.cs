using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.EventQuestButton = new System.Windows.Forms.Button();
            this.SideSkillButton = new System.Windows.Forms.Button();
            this.SideCharmButton = new System.Windows.Forms.Button();
            this.SideDecorationButton = new System.Windows.Forms.Button();
            this.SideWeaponButton = new System.Windows.Forms.Button();
            this.SideIndicatePanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.SideMonsterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SideHomeButton = new System.Windows.Forms.Button();
            this.SideArmorSetButton = new System.Windows.Forms.Button();
            this.SideArmorButton = new System.Windows.Forms.Button();
            this.SideItemButton = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SidePanel.Controls.Add(this.EventQuestButton);
            this.SidePanel.Controls.Add(this.SideSkillButton);
            this.SidePanel.Controls.Add(this.SideCharmButton);
            this.SidePanel.Controls.Add(this.SideDecorationButton);
            this.SidePanel.Controls.Add(this.SideWeaponButton);
            this.SidePanel.Controls.Add(this.SideIndicatePanel);
            this.SidePanel.Controls.Add(this.MinimizeButton);
            this.SidePanel.Controls.Add(this.SettingButton);
            this.SidePanel.Controls.Add(this.SideMonsterButton);
            this.SidePanel.Controls.Add(this.ExitButton);
            this.SidePanel.Controls.Add(this.AboutButton);
            this.SidePanel.Controls.Add(this.SideHomeButton);
            this.SidePanel.Controls.Add(this.SideArmorSetButton);
            this.SidePanel.Controls.Add(this.SideArmorButton);
            this.SidePanel.Controls.Add(this.SideItemButton);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 10);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 750);
            this.SidePanel.TabIndex = 0;
            // 
            // EventQuestButton
            // 
            this.EventQuestButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EventQuestButton.BackgroundImage")));
            this.EventQuestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EventQuestButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventQuestButton.FlatAppearance.BorderSize = 0;
            this.EventQuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventQuestButton.ForeColor = System.Drawing.Color.Transparent;
            this.EventQuestButton.Location = new System.Drawing.Point(197, 703);
            this.EventQuestButton.Name = "EventQuestButton";
            this.EventQuestButton.Size = new System.Drawing.Size(35, 35);
            this.EventQuestButton.TabIndex = 7;
            this.EventQuestButton.TabStop = false;
            this.ToolTip.SetToolTip(this.EventQuestButton, global::MonsterHunterWorld.Properties.String.ToolTipQuestEvent);
            this.EventQuestButton.UseVisualStyleBackColor = true;
            this.EventQuestButton.Click += new System.EventHandler(this.EventQuestButton_Click);
            // 
            // SideSkillButton
            // 
            this.SideSkillButton.FlatAppearance.BorderSize = 0;
            this.SideSkillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideSkillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideSkillButton.ForeColor = System.Drawing.Color.White;
            this.SideSkillButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideSkillButton.Location = new System.Drawing.Point(13, 603);
            this.SideSkillButton.Name = "SideSkillButton";
            this.SideSkillButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideSkillButton.Size = new System.Drawing.Size(235, 60);
            this.SideSkillButton.TabIndex = 6;
            this.SideSkillButton.TabStop = false;
            this.SideSkillButton.Text = global::MonsterHunterWorld.Properties.String.UISideSkill;
            this.SideSkillButton.UseVisualStyleBackColor = true;
            this.SideSkillButton.Click += new System.EventHandler(this.SideSkillButton_Click);
            // 
            // SideCharmButton
            // 
            this.SideCharmButton.FlatAppearance.BorderSize = 0;
            this.SideCharmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideCharmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideCharmButton.ForeColor = System.Drawing.Color.White;
            this.SideCharmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideCharmButton.Location = new System.Drawing.Point(13, 537);
            this.SideCharmButton.Name = "SideCharmButton";
            this.SideCharmButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideCharmButton.Size = new System.Drawing.Size(235, 60);
            this.SideCharmButton.TabIndex = 5;
            this.SideCharmButton.TabStop = false;
            this.SideCharmButton.Text = global::MonsterHunterWorld.Properties.String.UISideCharms;
            this.SideCharmButton.UseVisualStyleBackColor = true;
            this.SideCharmButton.Click += new System.EventHandler(this.SideCharmButton_Click);
            // 
            // SideDecorationButton
            // 
            this.SideDecorationButton.FlatAppearance.BorderSize = 0;
            this.SideDecorationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideDecorationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideDecorationButton.ForeColor = System.Drawing.Color.White;
            this.SideDecorationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideDecorationButton.Location = new System.Drawing.Point(13, 471);
            this.SideDecorationButton.Name = "SideDecorationButton";
            this.SideDecorationButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideDecorationButton.Size = new System.Drawing.Size(235, 60);
            this.SideDecorationButton.TabIndex = 4;
            this.SideDecorationButton.TabStop = false;
            this.SideDecorationButton.Text = global::MonsterHunterWorld.Properties.String.UISideDecorations;
            this.SideDecorationButton.UseVisualStyleBackColor = true;
            this.SideDecorationButton.Click += new System.EventHandler(this.SideDecorationButton_Click);
            // 
            // SideWeaponButton
            // 
            this.SideWeaponButton.FlatAppearance.BorderSize = 0;
            this.SideWeaponButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideWeaponButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideWeaponButton.ForeColor = System.Drawing.Color.White;
            this.SideWeaponButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideWeaponButton.Location = new System.Drawing.Point(13, 273);
            this.SideWeaponButton.Name = "SideWeaponButton";
            this.SideWeaponButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideWeaponButton.Size = new System.Drawing.Size(235, 60);
            this.SideWeaponButton.TabIndex = 3;
            this.SideWeaponButton.TabStop = false;
            this.SideWeaponButton.Text = global::MonsterHunterWorld.Properties.String.UISideWeapon;
            this.SideWeaponButton.UseVisualStyleBackColor = true;
            this.SideWeaponButton.Click += new System.EventHandler(this.SideWeaponButton_Click);
            // 
            // SideIndicatePanel
            // 
            this.SideIndicatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.SideIndicatePanel.Location = new System.Drawing.Point(0, 81);
            this.SideIndicatePanel.Name = "SideIndicatePanel";
            this.SideIndicatePanel.Size = new System.Drawing.Size(13, 61);
            this.SideIndicatePanel.TabIndex = 0;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(50, 6);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(35, 35);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingButton.BackgroundImage")));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.ForeColor = System.Drawing.Color.Transparent;
            this.SettingButton.Location = new System.Drawing.Point(50, 703);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(35, 35);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.TabStop = false;
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // SideMonsterButton
            // 
            this.SideMonsterButton.FlatAppearance.BorderSize = 0;
            this.SideMonsterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideMonsterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideMonsterButton.ForeColor = System.Drawing.Color.White;
            this.SideMonsterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideMonsterButton.Location = new System.Drawing.Point(13, 405);
            this.SideMonsterButton.Name = "SideMonsterButton";
            this.SideMonsterButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideMonsterButton.Size = new System.Drawing.Size(235, 60);
            this.SideMonsterButton.TabIndex = 1;
            this.SideMonsterButton.TabStop = false;
            this.SideMonsterButton.Text = global::MonsterHunterWorld.Properties.String.UISideMonster;
            this.SideMonsterButton.UseVisualStyleBackColor = true;
            this.SideMonsterButton.Click += new System.EventHandler(this.SideMonsterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(9, 6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 35);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutButton.BackgroundImage")));
            this.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutButton.ForeColor = System.Drawing.Color.Transparent;
            this.AboutButton.Location = new System.Drawing.Point(9, 703);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(35, 35);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.TabStop = false;
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SideHomeButton
            // 
            this.SideHomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SideHomeButton.FlatAppearance.BorderSize = 0;
            this.SideHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideHomeButton.ForeColor = System.Drawing.Color.White;
            this.SideHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideHomeButton.Location = new System.Drawing.Point(13, 81);
            this.SideHomeButton.Name = "SideHomeButton";
            this.SideHomeButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideHomeButton.Size = new System.Drawing.Size(235, 60);
            this.SideHomeButton.TabIndex = 0;
            this.SideHomeButton.TabStop = false;
            this.SideHomeButton.Text = global::MonsterHunterWorld.Properties.String.UISideHome;
            this.SideHomeButton.UseVisualStyleBackColor = false;
            this.SideHomeButton.Click += new System.EventHandler(this.SideHomeButton_Click);
            // 
            // SideArmorSetButton
            // 
            this.SideArmorSetButton.FlatAppearance.BorderSize = 0;
            this.SideArmorSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideArmorSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideArmorSetButton.ForeColor = System.Drawing.Color.White;
            this.SideArmorSetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideArmorSetButton.Location = new System.Drawing.Point(13, 207);
            this.SideArmorSetButton.Name = "SideArmorSetButton";
            this.SideArmorSetButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideArmorSetButton.Size = new System.Drawing.Size(235, 60);
            this.SideArmorSetButton.TabIndex = 0;
            this.SideArmorSetButton.TabStop = false;
            this.SideArmorSetButton.Text = global::MonsterHunterWorld.Properties.String.UISideArmorSet;
            this.SideArmorSetButton.UseVisualStyleBackColor = true;
            this.SideArmorSetButton.Click += new System.EventHandler(this.SideArmorSetButton_Click);
            // 
            // SideArmorButton
            // 
            this.SideArmorButton.FlatAppearance.BorderSize = 0;
            this.SideArmorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideArmorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideArmorButton.ForeColor = System.Drawing.Color.White;
            this.SideArmorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideArmorButton.Location = new System.Drawing.Point(13, 144);
            this.SideArmorButton.Margin = new System.Windows.Forms.Padding(0);
            this.SideArmorButton.Name = "SideArmorButton";
            this.SideArmorButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideArmorButton.Size = new System.Drawing.Size(235, 60);
            this.SideArmorButton.TabIndex = 0;
            this.SideArmorButton.TabStop = false;
            this.SideArmorButton.Text = global::MonsterHunterWorld.Properties.String.UISideArmor;
            this.SideArmorButton.UseVisualStyleBackColor = true;
            this.SideArmorButton.Click += new System.EventHandler(this.SideArmorButton_Click);
            // 
            // SideItemButton
            // 
            this.SideItemButton.FlatAppearance.BorderSize = 0;
            this.SideItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideItemButton.ForeColor = System.Drawing.Color.White;
            this.SideItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideItemButton.Location = new System.Drawing.Point(13, 339);
            this.SideItemButton.Name = "SideItemButton";
            this.SideItemButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SideItemButton.Size = new System.Drawing.Size(235, 60);
            this.SideItemButton.TabIndex = 2;
            this.SideItemButton.TabStop = false;
            this.SideItemButton.Text = global::MonsterHunterWorld.Properties.String.UISideItem;
            this.SideItemButton.UseVisualStyleBackColor = true;
            this.SideItemButton.Click += new System.EventHandler(this.SideItemButton_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(1350, 10);
            this.DragPanel.TabIndex = 0;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // contentpanel
            // 
            this.contentpanel.Location = new System.Drawing.Point(250, 10);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1100, 750);
            this.contentpanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 760);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.DragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonsterHunterWorld";
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Button SideArmorButton;
        private System.Windows.Forms.Button SideArmorSetButton;
        private System.Windows.Forms.Panel SideIndicatePanel;
        private Button SettingButton;
        private Button SideHomeButton;
        private Button MinimizeButton;
        private Button AboutButton;
        private Button SideMonsterButton;
        private Button SideItemButton;
        private Button SideWeaponButton;
        private Button SideSkillButton;
        private Button SideCharmButton;
        private Button SideDecorationButton;
        private Button EventQuestButton;
        private ToolTip ToolTip;
    }
}