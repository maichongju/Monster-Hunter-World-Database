namespace MonsterHunterWorld.UserForm
{
    partial class ArmorWindow
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
            this.components = new System.ComponentModel.Container();
            this.ArmorListBox = new System.Windows.Forms.ListBox();
            this.ArmorPanel = new System.Windows.Forms.Panel();
            this.ArmorTypeListBox = new System.Windows.Forms.ListBox();
            this.ArmorTypePanel = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ArmorNameLabel = new System.Windows.Forms.Label();
            this.FirePictureBox = new System.Windows.Forms.PictureBox();
            this.WaterPictureBox = new System.Windows.Forms.PictureBox();
            this.ThunderPictureBox = new System.Windows.Forms.PictureBox();
            this.IcePictureBox = new System.Windows.Forms.PictureBox();
            this.DragonPictureBox = new System.Windows.Forms.PictureBox();
            this.CraftListBox = new System.Windows.Forms.ListBox();
            this.Slot1PictureBox = new System.Windows.Forms.PictureBox();
            this.Slot2PictureBox = new System.Windows.Forms.PictureBox();
            this.Slot3PictureBox = new System.Windows.Forms.PictureBox();
            this.CraftPanel = new System.Windows.Forms.Panel();
            this.DefensePictureBox = new System.Windows.Forms.PictureBox();
            this.SkillPanel = new System.Windows.Forms.Panel();
            this.SkillListBox = new System.Windows.Forms.ListBox();
            this.DefenseMaxLable = new System.Windows.Forms.Label();
            this.DefenseBaseLable = new System.Windows.Forms.Label();
            this.DragonLable = new System.Windows.Forms.Label();
            this.IceLable = new System.Windows.Forms.Label();
            this.ThunderLable = new System.Windows.Forms.Label();
            this.WaterLable = new System.Windows.Forms.Label();
            this.FireLable = new System.Windows.Forms.Label();
            this.CraftLabel = new System.Windows.Forms.Label();
            this.SkillLabel = new System.Windows.Forms.Label();
            this.SlotLabel = new System.Windows.Forms.Label();
            this.ArmorTypeButton = new System.Windows.Forms.Button();
            this.ArmorPanel.SuspendLayout();
            this.ArmorTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThunderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3PictureBox)).BeginInit();
            this.CraftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefensePictureBox)).BeginInit();
            this.SkillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArmorListBox
            // 
            this.ArmorListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.ArmorListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArmorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ArmorListBox.ForeColor = System.Drawing.Color.White;
            this.ArmorListBox.FormattingEnabled = true;
            this.ArmorListBox.ItemHeight = 24;
            this.ArmorListBox.Location = new System.Drawing.Point(0, 14);
            this.ArmorListBox.Name = "ArmorListBox";
            this.ArmorListBox.Size = new System.Drawing.Size(272, 720);
            this.ArmorListBox.TabIndex = 0;
            this.ArmorListBox.SelectedIndexChanged += new System.EventHandler(this.ArmorListBox_SelectedIndexChanged);
            // 
            // ArmorPanel
            // 
            this.ArmorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.ArmorPanel.Controls.Add(this.ArmorListBox);
            this.ArmorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ArmorPanel.Location = new System.Drawing.Point(157, 0);
            this.ArmorPanel.Name = "ArmorPanel";
            this.ArmorPanel.Size = new System.Drawing.Size(249, 750);
            this.ArmorPanel.TabIndex = 13;
            // 
            // ArmorTypeListBox
            // 
            this.ArmorTypeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.ArmorTypeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArmorTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ArmorTypeListBox.ForeColor = System.Drawing.Color.White;
            this.ArmorTypeListBox.FormattingEnabled = true;
            this.ArmorTypeListBox.ItemHeight = 25;
            this.ArmorTypeListBox.Location = new System.Drawing.Point(3, 143);
            this.ArmorTypeListBox.Name = "ArmorTypeListBox";
            this.ArmorTypeListBox.Size = new System.Drawing.Size(188, 450);
            this.ArmorTypeListBox.TabIndex = 0;
            this.ArmorTypeListBox.SelectedIndexChanged += new System.EventHandler(this.ArmorTypeListBox_SelectedIndexChanged);
            // 
            // ArmorTypePanel
            // 
            this.ArmorTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.ArmorTypePanel.Controls.Add(this.ArmorTypeListBox);
            this.ArmorTypePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ArmorTypePanel.Location = new System.Drawing.Point(0, 0);
            this.ArmorTypePanel.Name = "ArmorTypePanel";
            this.ArmorTypePanel.Size = new System.Drawing.Size(157, 750);
            this.ArmorTypePanel.TabIndex = 12;
            // 
            // ArmorNameLabel
            // 
            this.ArmorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.ArmorNameLabel.Location = new System.Drawing.Point(555, 46);
            this.ArmorNameLabel.Name = "ArmorNameLabel";
            this.ArmorNameLabel.Size = new System.Drawing.Size(421, 57);
            this.ArmorNameLabel.TabIndex = 14;
            this.ArmorNameLabel.Text = "Armor Name";
            this.ArmorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirePictureBox
            // 
            this.FirePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirePictureBox.Location = new System.Drawing.Point(481, 174);
            this.FirePictureBox.Name = "FirePictureBox";
            this.FirePictureBox.Size = new System.Drawing.Size(60, 60);
            this.FirePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FirePictureBox.TabIndex = 15;
            this.FirePictureBox.TabStop = false;
            // 
            // WaterPictureBox
            // 
            this.WaterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WaterPictureBox.Location = new System.Drawing.Point(571, 174);
            this.WaterPictureBox.Name = "WaterPictureBox";
            this.WaterPictureBox.Size = new System.Drawing.Size(60, 60);
            this.WaterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WaterPictureBox.TabIndex = 16;
            this.WaterPictureBox.TabStop = false;
            // 
            // ThunderPictureBox
            // 
            this.ThunderPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ThunderPictureBox.Location = new System.Drawing.Point(661, 174);
            this.ThunderPictureBox.Name = "ThunderPictureBox";
            this.ThunderPictureBox.Size = new System.Drawing.Size(60, 60);
            this.ThunderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThunderPictureBox.TabIndex = 17;
            this.ThunderPictureBox.TabStop = false;
            // 
            // IcePictureBox
            // 
            this.IcePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IcePictureBox.Location = new System.Drawing.Point(751, 174);
            this.IcePictureBox.Name = "IcePictureBox";
            this.IcePictureBox.Size = new System.Drawing.Size(60, 60);
            this.IcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcePictureBox.TabIndex = 18;
            this.IcePictureBox.TabStop = false;
            // 
            // DragonPictureBox
            // 
            this.DragonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DragonPictureBox.Location = new System.Drawing.Point(841, 174);
            this.DragonPictureBox.Name = "DragonPictureBox";
            this.DragonPictureBox.Size = new System.Drawing.Size(60, 60);
            this.DragonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DragonPictureBox.TabIndex = 19;
            this.DragonPictureBox.TabStop = false;
            // 
            // CraftListBox
            // 
            this.CraftListBox.BackColor = System.Drawing.SystemColors.Control;
            this.CraftListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CraftListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CraftListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CraftListBox.FormattingEnabled = true;
            this.CraftListBox.ItemHeight = 20;
            this.CraftListBox.Location = new System.Drawing.Point(0, 0);
            this.CraftListBox.Name = "CraftListBox";
            this.CraftListBox.Size = new System.Drawing.Size(330, 261);
            this.CraftListBox.TabIndex = 21;
            this.CraftListBox.TabStop = false;
            this.CraftListBox.UseTabStops = false;
            this.CraftListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CraftListBox_MouseDoubleClick);
            // 
            // Slot1PictureBox
            // 
            this.Slot1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Slot1PictureBox.Location = new System.Drawing.Point(644, 356);
            this.Slot1PictureBox.Name = "Slot1PictureBox";
            this.Slot1PictureBox.Size = new System.Drawing.Size(55, 55);
            this.Slot1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slot1PictureBox.TabIndex = 22;
            this.Slot1PictureBox.TabStop = false;
            // 
            // Slot2PictureBox
            // 
            this.Slot2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Slot2PictureBox.Location = new System.Drawing.Point(734, 356);
            this.Slot2PictureBox.Name = "Slot2PictureBox";
            this.Slot2PictureBox.Size = new System.Drawing.Size(55, 55);
            this.Slot2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slot2PictureBox.TabIndex = 23;
            this.Slot2PictureBox.TabStop = false;
            // 
            // Slot3PictureBox
            // 
            this.Slot3PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Slot3PictureBox.Location = new System.Drawing.Point(824, 356);
            this.Slot3PictureBox.Name = "Slot3PictureBox";
            this.Slot3PictureBox.Size = new System.Drawing.Size(55, 55);
            this.Slot3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slot3PictureBox.TabIndex = 24;
            this.Slot3PictureBox.TabStop = false;
            // 
            // CraftPanel
            // 
            this.CraftPanel.Controls.Add(this.CraftListBox);
            this.CraftPanel.Location = new System.Drawing.Point(441, 465);
            this.CraftPanel.Name = "CraftPanel";
            this.CraftPanel.Size = new System.Drawing.Size(310, 261);
            this.CraftPanel.TabIndex = 25;
            // 
            // DefensePictureBox
            // 
            this.DefensePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DefensePictureBox.Location = new System.Drawing.Point(964, 174);
            this.DefensePictureBox.Name = "DefensePictureBox";
            this.DefensePictureBox.Size = new System.Drawing.Size(60, 60);
            this.DefensePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DefensePictureBox.TabIndex = 26;
            this.DefensePictureBox.TabStop = false;
            // 
            // SkillPanel
            // 
            this.SkillPanel.Controls.Add(this.SkillListBox);
            this.SkillPanel.Location = new System.Drawing.Point(777, 465);
            this.SkillPanel.Name = "SkillPanel";
            this.SkillPanel.Size = new System.Drawing.Size(294, 261);
            this.SkillPanel.TabIndex = 27;
            // 
            // SkillListBox
            // 
            this.SkillListBox.BackColor = System.Drawing.SystemColors.Control;
            this.SkillListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SkillListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SkillListBox.FormattingEnabled = true;
            this.SkillListBox.ItemHeight = 20;
            this.SkillListBox.Location = new System.Drawing.Point(0, 0);
            this.SkillListBox.Name = "SkillListBox";
            this.SkillListBox.Size = new System.Drawing.Size(308, 261);
            this.SkillListBox.TabIndex = 21;
            this.SkillListBox.DoubleClick += new System.EventHandler(this.SkillListBox_DoubleClick);
            // 
            // DefenseMaxLable
            // 
            this.DefenseMaxLable.BackColor = System.Drawing.Color.Transparent;
            this.DefenseMaxLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DefenseMaxLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(46)))), ((int)(((byte)(38)))));
            this.DefenseMaxLable.Location = new System.Drawing.Point(1011, 244);
            this.DefenseMaxLable.Name = "DefenseMaxLable";
            this.DefenseMaxLable.Size = new System.Drawing.Size(60, 25);
            this.DefenseMaxLable.TabIndex = 34;
            this.DefenseMaxLable.Text = "100";
            // 
            // DefenseBaseLable
            // 
            this.DefenseBaseLable.BackColor = System.Drawing.Color.Transparent;
            this.DefenseBaseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DefenseBaseLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.DefenseBaseLable.Location = new System.Drawing.Point(924, 244);
            this.DefenseBaseLable.Name = "DefenseBaseLable";
            this.DefenseBaseLable.Size = new System.Drawing.Size(60, 25);
            this.DefenseBaseLable.TabIndex = 33;
            this.DefenseBaseLable.Text = "100";
            // 
            // DragonLable
            // 
            this.DragonLable.BackColor = System.Drawing.Color.Transparent;
            this.DragonLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DragonLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.DragonLable.Location = new System.Drawing.Point(841, 244);
            this.DragonLable.Name = "DragonLable";
            this.DragonLable.Size = new System.Drawing.Size(60, 25);
            this.DragonLable.TabIndex = 32;
            this.DragonLable.Text = "-1";
            this.DragonLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IceLable
            // 
            this.IceLable.BackColor = System.Drawing.Color.Transparent;
            this.IceLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IceLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(159)))));
            this.IceLable.Location = new System.Drawing.Point(751, 244);
            this.IceLable.Name = "IceLable";
            this.IceLable.Size = new System.Drawing.Size(60, 25);
            this.IceLable.TabIndex = 31;
            this.IceLable.Text = "-1";
            this.IceLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThunderLable
            // 
            this.ThunderLable.BackColor = System.Drawing.Color.Transparent;
            this.ThunderLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThunderLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.ThunderLable.Location = new System.Drawing.Point(661, 244);
            this.ThunderLable.Name = "ThunderLable";
            this.ThunderLable.Size = new System.Drawing.Size(60, 25);
            this.ThunderLable.TabIndex = 30;
            this.ThunderLable.Text = "-1";
            this.ThunderLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaterLable
            // 
            this.WaterLable.BackColor = System.Drawing.Color.Transparent;
            this.WaterLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WaterLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
            this.WaterLable.Location = new System.Drawing.Point(571, 244);
            this.WaterLable.Name = "WaterLable";
            this.WaterLable.Size = new System.Drawing.Size(60, 25);
            this.WaterLable.TabIndex = 29;
            this.WaterLable.Text = "-1";
            this.WaterLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FireLable
            // 
            this.FireLable.BackColor = System.Drawing.Color.Transparent;
            this.FireLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FireLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.FireLable.Location = new System.Drawing.Point(481, 244);
            this.FireLable.Name = "FireLable";
            this.FireLable.Size = new System.Drawing.Size(60, 25);
            this.FireLable.TabIndex = 28;
            this.FireLable.Text = "-1";
            this.FireLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CraftLabel
            // 
            this.CraftLabel.AutoSize = true;
            this.CraftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CraftLabel.Location = new System.Drawing.Point(476, 425);
            this.CraftLabel.Name = "CraftLabel";
            this.CraftLabel.Size = new System.Drawing.Size(192, 25);
            this.CraftLabel.TabIndex = 35;
            this.CraftLabel.Text = "Required Materials";
            // 
            // SkillLabel
            // 
            this.SkillLabel.AutoSize = true;
            this.SkillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillLabel.Location = new System.Drawing.Point(909, 425);
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(53, 25);
            this.SkillLabel.TabIndex = 36;
            this.SkillLabel.Text = "Skill";
            // 
            // SlotLabel
            // 
            this.SlotLabel.AutoSize = true;
            this.SlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SlotLabel.Location = new System.Drawing.Point(736, 310);
            this.SlotLabel.Name = "SlotLabel";
            this.SlotLabel.Size = new System.Drawing.Size(50, 25);
            this.SlotLabel.TabIndex = 37;
            this.SlotLabel.Text = "Slot";
            // 
            // ArmorTypeButton
            // 
            this.ArmorTypeButton.BackColor = System.Drawing.SystemColors.Control;
            this.ArmorTypeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ArmorTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArmorTypeButton.FlatAppearance.BorderSize = 0;
            this.ArmorTypeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ArmorTypeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ArmorTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArmorTypeButton.ForeColor = System.Drawing.Color.Transparent;
            this.ArmorTypeButton.Location = new System.Drawing.Point(991, 23);
            this.ArmorTypeButton.Name = "ArmorTypeButton";
            this.ArmorTypeButton.Size = new System.Drawing.Size(80, 80);
            this.ArmorTypeButton.TabIndex = 0;
            this.ArmorTypeButton.TabStop = false;
            this.ArmorTypeButton.UseVisualStyleBackColor = false;
            this.ArmorTypeButton.Click += new System.EventHandler(this.ArmorTypeButton_Click);
            // 
            // ArmorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.ArmorTypeButton);
            this.Controls.Add(this.SlotLabel);
            this.Controls.Add(this.SkillLabel);
            this.Controls.Add(this.CraftLabel);
            this.Controls.Add(this.DefenseMaxLable);
            this.Controls.Add(this.DefenseBaseLable);
            this.Controls.Add(this.DragonLable);
            this.Controls.Add(this.IceLable);
            this.Controls.Add(this.ThunderLable);
            this.Controls.Add(this.WaterLable);
            this.Controls.Add(this.FireLable);
            this.Controls.Add(this.SkillPanel);
            this.Controls.Add(this.DefensePictureBox);
            this.Controls.Add(this.CraftPanel);
            this.Controls.Add(this.Slot3PictureBox);
            this.Controls.Add(this.Slot2PictureBox);
            this.Controls.Add(this.Slot1PictureBox);
            this.Controls.Add(this.DragonPictureBox);
            this.Controls.Add(this.IcePictureBox);
            this.Controls.Add(this.ThunderPictureBox);
            this.Controls.Add(this.WaterPictureBox);
            this.Controls.Add(this.FirePictureBox);
            this.Controls.Add(this.ArmorNameLabel);
            this.Controls.Add(this.ArmorPanel);
            this.Controls.Add(this.ArmorTypePanel);
            this.Name = "ArmorWindow";
            this.Size = new System.Drawing.Size(1100, 750);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ArmorWindow_MouseClick);
            this.ArmorPanel.ResumeLayout(false);
            this.ArmorTypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThunderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3PictureBox)).EndInit();
            this.CraftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DefensePictureBox)).EndInit();
            this.SkillPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ArmorListBox;
        private System.Windows.Forms.Panel ArmorPanel;
        private System.Windows.Forms.ListBox ArmorTypeListBox;
        private System.Windows.Forms.Panel ArmorTypePanel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label ArmorNameLabel;
        private System.Windows.Forms.PictureBox FirePictureBox;
        private System.Windows.Forms.PictureBox WaterPictureBox;
        private System.Windows.Forms.PictureBox ThunderPictureBox;
        private System.Windows.Forms.PictureBox IcePictureBox;
        private System.Windows.Forms.PictureBox DragonPictureBox;
        private System.Windows.Forms.ListBox CraftListBox;
        private System.Windows.Forms.PictureBox Slot1PictureBox;
        private System.Windows.Forms.PictureBox Slot2PictureBox;
        private System.Windows.Forms.PictureBox Slot3PictureBox;
        private System.Windows.Forms.Panel CraftPanel;
        private System.Windows.Forms.PictureBox DefensePictureBox;
        private System.Windows.Forms.Panel SkillPanel;
        private System.Windows.Forms.ListBox SkillListBox;
        private System.Windows.Forms.Label DefenseMaxLable;
        private System.Windows.Forms.Label DefenseBaseLable;
        private System.Windows.Forms.Label DragonLable;
        private System.Windows.Forms.Label IceLable;
        private System.Windows.Forms.Label ThunderLable;
        private System.Windows.Forms.Label WaterLable;
        private System.Windows.Forms.Label FireLable;
        private System.Windows.Forms.Label CraftLabel;
        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.Label SlotLabel;
        private System.Windows.Forms.Button ArmorTypeButton;
    }
}
