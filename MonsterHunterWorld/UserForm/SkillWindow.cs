using MonsterHunterWorld.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class SkillWindow : UserControl
    {
        private static SkillWindow _instance;

        public static SkillWindow Instance
        {
            get
            {
                if (_instance == null) _instance = new SkillWindow();
                return _instance;
            }
        }

        private List<Skill> Skills = SKillSQL.GetAllSkill();

        public SkillWindow()
        {
            InitializeComponent();
            SetUpSkillListBox();
            SetUpSkillDetailListBox();
        }

        #region Skill List Box

        private void SetUpSkillListBox()
        {
            SkillListBox.DataSource = Skills;
            SkillListBox.DrawMode = DrawMode.OwnerDrawVariable;
            SkillListBox.MeasureItem += new MeasureItemEventHandler(SkillListBox_MeasureItem);
            SkillListBox.DrawItem += new DrawItemEventHandler(SkillListBox_DrawItem);
        }

        private void SkillListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // If the item is the selected item, then draw the rectangle
            // filled in blue. The item is selected when a bitwise And
            // of the State property and the DrawItemState.Selected
            // property is true.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                // Otherwise, draw the rectangle filled in beige.
                e.Graphics.FillRectangle(new SolidBrush(SkillListBox.BackColor), e.Bounds);
            }

            e.Graphics.DrawString((SkillListBox.Items[e.Index] as Skill).Name,
                SkillListBox.Font, Brushes.White, e.Bounds.X + 5, e.Bounds.Y + 10);
        }

        private void SkillListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        #endregion Skill List Box

        #region Skill Detail

        private void SetUpSkillDetailListBox()
        {
            SkillDetailListBox.DrawMode = DrawMode.OwnerDrawVariable;
            SkillDetailListBox.MeasureItem += new MeasureItemEventHandler(SKillDetailListBox_MeasureItem);
            SkillDetailListBox.DrawItem += new DrawItemEventHandler(SkillDetailListBox_DrawItem);
        }

        private void SkillDetailListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(SkillDetailListBox.BackColor), e.Bounds);

            SkillLevel skillLevel = SkillDetailListBox.Items[e.Index] as SkillLevel;
            e.Graphics.DrawString($"LV {skillLevel.Level.ToString()} \t {skillLevel.Description}",
                SkillDetailListBox.Font, Brushes.Black, e.Bounds);
        }

        private void SKillDetailListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            SkillLevel skillLevel = (SkillLevel)SkillDetailListBox.Items[e.Index];
            e.ItemHeight = (int)e.Graphics.MeasureString($"LV {skillLevel.Level.ToString()} \t {skillLevel.Description}",
                SkillDetailListBox.Font, SkillDetailListBox.Width).Height + 30;
        }

        #endregion Skill Detail

        /// <summary>
        /// Display the given Skill Object
        /// </summary>
        /// <param name="skill"> SKill Object need to display</param>
        private void Display(Skill skill)
        {
            if (skill != null)
            {
                SkillNameLabel.Text = skill.Name;
                SkillTitleLabel.Text = skill.SkillTitle;
                SkillDetailListBox.DataSource = skill.LevelDeatil;
                string ImagePath = Properties.Resources.ResourceManager.GetString("ui_armor_skill");
                Image ArmorSkillImage = Utilities.GetImageFromSVG(ImagePath, Color.White, MonsterHunterColor.IconColor[skill.IconColor], ArmorSkillPictureBox.Size);
                ArmorSkillPictureBox.BackgroundImage = ArmorSkillImage;
            }
        }

        public void Display(int SkillId)
        {
            foreach (Skill skill in SkillListBox.Items)
            {
                if (skill.SkillId == SkillId)
                {
                    SkillListBox.SelectedItem = skill;
                    return;
                }
            }
            //If cannot find the Skill it will display the first skill
            SkillListBox.SelectedIndex = 0;
        }

        private void SkillListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display(SkillListBox.SelectedItem as Skill);
        }
    }
}