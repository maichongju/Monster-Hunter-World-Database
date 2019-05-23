namespace MonsterHunterWorld.UserForm
{
    partial class Setting
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
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.CancelButtonbtn = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.OpenLogFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(73, 43);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(128, 21);
            this.LanguageComboBox.Sorted = true;
            this.LanguageComboBox.TabIndex = 0;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(70, 27);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(55, 13);
            this.LanguageLabel.TabIndex = 1;
            this.LanguageLabel.Text = "Language";
            // 
            // CancelButtonbtn
            // 
            this.CancelButtonbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonbtn.Location = new System.Drawing.Point(382, 98);
            this.CancelButtonbtn.Name = "CancelButtonbtn";
            this.CancelButtonbtn.Size = new System.Drawing.Size(75, 23);
            this.CancelButtonbtn.TabIndex = 2;
            this.CancelButtonbtn.Text = global::MonsterHunterWorld.Properties.String.SettingCancelButton;
            this.CancelButtonbtn.UseVisualStyleBackColor = true;
            this.CancelButtonbtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(301, 98);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = global::MonsterHunterWorld.Properties.String.SettingOKButton;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // OpenLogFileButton
            // 
            this.OpenLogFileButton.Location = new System.Drawing.Point(12, 98);
            this.OpenLogFileButton.Name = "OpenLogFileButton";
            this.OpenLogFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenLogFileButton.TabIndex = 3;
            this.OpenLogFileButton.Text = "Log File";
            this.OpenLogFileButton.UseVisualStyleBackColor = true;
            this.OpenLogFileButton.Click += new System.EventHandler(this.OpenLogFileButton_Click);
            // 
            // Setting
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButtonbtn;
            this.ClientSize = new System.Drawing.Size(471, 133);
            this.Controls.Add(this.OpenLogFileButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonbtn);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.LanguageComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Button CancelButtonbtn;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button OpenLogFileButton;
    }
}