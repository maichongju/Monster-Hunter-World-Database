namespace MonsterHunterWorld.UserForm
{
    partial class SkillWindow
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
            this.SkillPanel = new System.Windows.Forms.Panel();
            this.SkillListBox = new System.Windows.Forms.ListBox();
            this.SkillDetailListBox = new System.Windows.Forms.ListBox();
            this.SkillTitleLabel = new System.Windows.Forms.Label();
            this.ArmorSkillPictureBox = new System.Windows.Forms.PictureBox();
            this.SkillNameLabel = new System.Windows.Forms.Label();
            this.SkillDetailPanel = new System.Windows.Forms.Panel();
            this.SkillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArmorSkillPictureBox)).BeginInit();
            this.SkillDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SkillPanel
            // 
            this.SkillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.SkillPanel.Controls.Add(this.SkillListBox);
            this.SkillPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SkillPanel.Location = new System.Drawing.Point(0, 0);
            this.SkillPanel.Name = "SkillPanel";
            this.SkillPanel.Size = new System.Drawing.Size(310, 750);
            this.SkillPanel.TabIndex = 0;
            // 
            // SkillListBox
            // 
            this.SkillListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.SkillListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SkillListBox.FormattingEnabled = true;
            this.SkillListBox.ItemHeight = 25;
            this.SkillListBox.Location = new System.Drawing.Point(0, 14);
            this.SkillListBox.Name = "SkillListBox";
            this.SkillListBox.Size = new System.Drawing.Size(339, 725);
            this.SkillListBox.TabIndex = 0;
            this.SkillListBox.SelectedIndexChanged += new System.EventHandler(this.SkillListBox_SelectedIndexChanged);
            // 
            // SkillDetailListBox
            // 
            this.SkillDetailListBox.BackColor = System.Drawing.SystemColors.Control;
            this.SkillDetailListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillDetailListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SkillDetailListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SkillDetailListBox.FormattingEnabled = true;
            this.SkillDetailListBox.ItemHeight = 25;
            this.SkillDetailListBox.Location = new System.Drawing.Point(0, 0);
            this.SkillDetailListBox.Name = "SkillDetailListBox";
            this.SkillDetailListBox.Size = new System.Drawing.Size(488, 458);
            this.SkillDetailListBox.TabIndex = 2;
            this.SkillDetailListBox.TabStop = false;
            this.SkillDetailListBox.UseTabStops = false;
            // 
            // SkillTitleLabel
            // 
            this.SkillTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SkillTitleLabel.Location = new System.Drawing.Point(418, 168);
            this.SkillTitleLabel.MaximumSize = new System.Drawing.Size(600, 100);
            this.SkillTitleLabel.Name = "SkillTitleLabel";
            this.SkillTitleLabel.Size = new System.Drawing.Size(600, 100);
            this.SkillTitleLabel.TabIndex = 5;
            this.SkillTitleLabel.Text = "Skill title";
            this.SkillTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ArmorSkillPictureBox
            // 
            this.ArmorSkillPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ArmorSkillPictureBox.Location = new System.Drawing.Point(979, 32);
            this.ArmorSkillPictureBox.Name = "ArmorSkillPictureBox";
            this.ArmorSkillPictureBox.Size = new System.Drawing.Size(105, 105);
            this.ArmorSkillPictureBox.TabIndex = 6;
            this.ArmorSkillPictureBox.TabStop = false;
            // 
            // SkillNameLabel
            // 
            this.SkillNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SkillNameLabel.Location = new System.Drawing.Point(490, 68);
            this.SkillNameLabel.Name = "SkillNameLabel";
            this.SkillNameLabel.Size = new System.Drawing.Size(463, 69);
            this.SkillNameLabel.TabIndex = 7;
            this.SkillNameLabel.Text = "Skill Name";
            this.SkillNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillDetailPanel
            // 
            this.SkillDetailPanel.Controls.Add(this.SkillDetailListBox);
            this.SkillDetailPanel.Location = new System.Drawing.Point(497, 271);
            this.SkillDetailPanel.Name = "SkillDetailPanel";
            this.SkillDetailPanel.Size = new System.Drawing.Size(491, 458);
            this.SkillDetailPanel.TabIndex = 8;
            // 
            // SkillWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SkillDetailPanel);
            this.Controls.Add(this.SkillNameLabel);
            this.Controls.Add(this.ArmorSkillPictureBox);
            this.Controls.Add(this.SkillTitleLabel);
            this.Controls.Add(this.SkillPanel);
            this.Name = "SkillWindow";
            this.Size = new System.Drawing.Size(1100, 750);
            this.SkillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArmorSkillPictureBox)).EndInit();
            this.SkillDetailPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SkillPanel;
        private System.Windows.Forms.ListBox SkillListBox;
        private System.Windows.Forms.ListBox SkillDetailListBox;
        private System.Windows.Forms.Label SkillTitleLabel;
        private System.Windows.Forms.PictureBox ArmorSkillPictureBox;
        private System.Windows.Forms.Label SkillNameLabel;
        private System.Windows.Forms.Panel SkillDetailPanel;
    }
}
