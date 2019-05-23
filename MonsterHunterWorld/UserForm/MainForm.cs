using MonsterHunterWorld.Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class MainForm : Form
    {
        private static MainForm _instance;

        public static MainForm Instance
        {
            get
            {
                if (_instance == null) _instance = new MainForm();
                return _instance;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            SetUpSideButton();
            // Load first page
            SideIndicatePanel.Height = SideHomeButton.Height;
            contentpanel.Controls.Add(WelcomeWindow.Instance);
        }

        private void SetUpSideButton()
        {
            Size MaxSize = new Size(32, 32);
            SideArmorButton.Image = Class.Utilities.GetImageFromSVG(Properties.Resources.ui_side_armor, MaxSize);
            SideArmorSetButton.Image = Class.Utilities.GetImageFromSVG(Properties.Resources.ui_side_armor_set, MaxSize);
            SideMonsterButton.Image = Class.Utilities.GetImageFromSVG(Properties.Resources.ui_side_monster, MaxSize);
            SideItemButton.Image = Class.Utilities.GetImageFromSVG(Properties.Resources.ui_side_item, MaxSize);
            SideWeaponButton.Image = Utilities.GetImageFromSVG(Properties.Resources.ui_side_weapon, MaxSize);
            SideDecorationButton.Image = Utilities.GetImageFromSVG(Properties.Resources.ui_side_decoration, MaxSize);
            SideSkillButton.Image = Utilities.GetImageFromSVG(Properties.Resources.ui_side_skill, MaxSize);
            SideCharmButton.Image = Utilities.GetImageFromSVG(Properties.Resources.ui_side_charm, MaxSize);
        }

        private Point lastMousePosition, lastWindowPosition;
        private bool mouseDown;

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastMousePosition = MousePosition;
            lastWindowPosition = Location;
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Side Button Click

        private void SideArmorButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideArmorButton.Height;
            SideIndicatePanel.Top = SideArmorButton.Top;
            if (!contentpanel.Controls.Contains(ArmorWindow.Instance))
            {
                contentpanel.Controls.Add(ArmorWindow.Instance);
                ArmorWindow.Instance.Dock = DockStyle.Fill;
            }

            ArmorWindow.Instance.BringToFront();
        }

        private void SideArmorSetButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideArmorSetButton.Height;
            SideIndicatePanel.Top = SideArmorSetButton.Top;
            if (!contentpanel.Controls.Contains(ArmorSetWindow.Instance))
            {
                contentpanel.Controls.Add(ArmorSetWindow.Instance);
                ArmorSetWindow.Instance.Dock = DockStyle.Fill;
            }

            ArmorSetWindow.Instance.BringToFront();
        }

        private void SideHomeButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideHomeButton.Height;
            SideIndicatePanel.Top = SideHomeButton.Top;
            if (!contentpanel.Controls.Contains(WelcomeWindow.Instance))
            {
                contentpanel.Controls.Add(WelcomeWindow.Instance);
                WelcomeWindow.Instance.Dock = DockStyle.Fill;
            }
            WelcomeWindow.Instance.BringToFront();
        }

        private void SideItemButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideItemButton.Height;
            SideIndicatePanel.Top = SideItemButton.Top;
            if (!contentpanel.Controls.Contains(ItemWindow.Instance))
            {
                contentpanel.Controls.Add(ItemWindow.Instance);
                ItemWindow.Instance.Dock = DockStyle.Fill;
            }
            ItemWindow.Instance.BringToFront();
        }

        private void SideMonsterButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideMonsterButton.Height;
            SideIndicatePanel.Top = SideMonsterButton.Top;
            if (!contentpanel.Controls.Contains(MonsterWindow.Instance))
            {
                contentpanel.Controls.Add(MonsterWindow.Instance);
                MonsterWindow.Instance.Dock = DockStyle.Fill;
            }
            MonsterWindow.Instance.BringToFront();
        }

        private void SideSkillButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideSkillButton.Height;
            SideIndicatePanel.Top = SideSkillButton.Top;
            if (!contentpanel.Controls.Contains(SkillWindow.Instance))
            {
                contentpanel.Controls.Add(SkillWindow.Instance);
                SkillWindow.Instance.Dock = DockStyle.Fill;
            }
            SkillWindow.Instance.BringToFront();
        }

        private void SideWeaponButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideWeaponButton.Height;
            SideIndicatePanel.Top = SideWeaponButton.Top;
            if (!contentpanel.Controls.Contains(WeaponWindow.Instance))
            {
                contentpanel.Controls.Add(WeaponWindow.Instance);
                WeaponWindow.Instance.Dock = DockStyle.Fill;
            }
            WeaponWindow.Instance.BringToFront();
        }

        private void SideDecorationButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideDecorationButton.Height;
            SideIndicatePanel.Top = SideDecorationButton.Top;
            if (!contentpanel.Controls.Contains(DecorationWindow.Instance))
            {
                contentpanel.Controls.Add(DecorationWindow.Instance);
                DecorationWindow.Instance.Dock = DockStyle.Fill;
            }
            DecorationWindow.Instance.BringToFront();
        }

        private void SideCharmButton_Click(object sender, EventArgs e)
        {
            SideIndicatePanel.Height = SideCharmButton.Height;
            SideIndicatePanel.Top = SideCharmButton.Top;
            if (!contentpanel.Controls.Contains(CharmWindow.Instance))
            {
                contentpanel.Controls.Add(CharmWindow.Instance);
                CharmWindow.Instance.Dock = DockStyle.Fill;
            }
            CharmWindow.Instance.BringToFront();
        }

        private void EventQuestButton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(EventQuestsWindow.Instance))
            {
                contentpanel.Controls.Add(EventQuestsWindow.Instance);
                EventQuestsWindow.Instance.Dock = DockStyle.Fill;
            }
            EventQuestsWindow.Instance.BringToFront();
        }

        #endregion Side Button Click

        public void ShowItem(int ItemID)
        {
            SideIndicatePanel.Height = SideItemButton.Height;
            SideIndicatePanel.Top = SideItemButton.Top;
            if (!contentpanel.Controls.Contains(ItemWindow.Instance))
            {
                contentpanel.Controls.Add(ItemWindow.Instance);
                ItemWindow.Instance.Dock = DockStyle.Fill;
            }
            ItemWindow.Instance.DisplayItem(ItemID);
            ItemWindow.Instance.BringToFront();
        }

        public void ShowSkill(int SkillID)
        {
            SideIndicatePanel.Height = SideSkillButton.Height;
            SideIndicatePanel.Top = SideSkillButton.Top;
            if (!contentpanel.Controls.Contains(SkillWindow.Instance))
            {
                contentpanel.Controls.Add(SkillWindow.Instance);
                SkillWindow.Instance.Dock = DockStyle.Fill;
            }
            SkillWindow.Instance.Display(SkillID);
            SkillWindow.Instance.BringToFront();
        }

        public void ShowArmor(ArmorSetArmors armorSetArmors)
        {
            SideIndicatePanel.Height = SideArmorButton.Height;
            SideIndicatePanel.Top = SideArmorButton.Top;
            if (!contentpanel.Controls.Contains(ArmorWindow.Instance))
            {
                contentpanel.Controls.Add(ArmorWindow.Instance);
                ArmorWindow.Instance.Dock = DockStyle.Fill;
            }
            ArmorWindow.Instance.DisplayArmor(armorSetArmors);
            ArmorWindow.Instance.BringToFront();
        }

        public void ShowArmorSet(int ArmorSetID)
        {
            SideIndicatePanel.Height = SideArmorSetButton.Height;
            SideIndicatePanel.Top = SideArmorSetButton.Top;
            if (!contentpanel.Controls.Contains(ArmorSetWindow.Instance))
            {
                contentpanel.Controls.Add(ArmorSetWindow.Instance);
                ArmorSetWindow.Instance.Dock = DockStyle.Fill;
            }
            ArmorSetWindow.Instance.DisplayArmorSet(ArmorSetID);
            ArmorSetWindow.Instance.BringToFront();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            UserForm.Setting settingForm = new Setting();
            settingForm.ShowDialog();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = lastWindowPosition.X - (lastMousePosition.X - MousePosition.X);
                int y = lastWindowPosition.Y - (lastMousePosition.Y - MousePosition.Y);
                this.SetDesktopLocation(x, y);
            }
        }
    }
}