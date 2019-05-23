using Dapper;
using MonsterHunterWorld.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class Setting : Form
    {
        private List<Language> LanguageList;

        public Setting()
        {
            InitializeComponent();
            SetupDropDownList();
        }

        private void SetupDropDownList()
        {
            LanguageList = SQLDataAccess.ExecuteSQL<Language>(SQLDataAccess.SQLStatement.Language, new DynamicParameters(), Utilities.Debug);
            LanguageComboBox.DataSource = LanguageList;
            LanguageComboBox.DisplayMember = "Name";
            LanguageComboBox.SelectedItem = GetLanguage(Properties.Settings.Default.Language);
        }

        private Language GetLanguage(string LanguageId)
        {
            foreach (Language language in LanguageList)
            {
                if (language.Id == LanguageId)
                {
                    return language;
                }
            }
            return null;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Save all the change the setting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            //Check if customer change the language
            if ((LanguageComboBox.SelectedItem as Language).Id != Properties.Settings.Default.Language)
            {
                Properties.Settings.Default.Language = (LanguageComboBox.SelectedItem as Language).Id;
                Properties.Settings.Default.Save();
                // Restart Application if user want to
                if (MessageBox.Show(Properties.String.SettingConfirmText
                    , Properties.String.SettingConfirmTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
            Close();
        }

        private void OpenLogFileButton_Click(object sender, EventArgs e)
        {
            LogWritter.Instance.OpenLogFile();
        }
    }
}