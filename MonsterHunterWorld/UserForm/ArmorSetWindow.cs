using MonsterHunterWorld.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class ArmorSetWindow : UserControl
    {
        private static ArmorSetWindow _instance;

        public static ArmorSetWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ArmorSetWindow();
                }

                return _instance;
            }
        }

        private List<List<ArmorSet>> ArmorSets = new List<List<ArmorSet>>();

        private List<NavigateItem> RankList = new List<NavigateItem>()
        {   new NavigateItem("LR",Properties.String.GeneraLowRank),
            new NavigateItem("HR",Properties.String.GeneralHighRank)
        };

        private readonly static Color ListBackgroundColor = Color.FromArgb(221, 222, 225);
        private readonly static Color ListSelectedColor = Color.FromArgb(209, 223, 250);

        public ArmorSetWindow()
        {
            InitializeComponent();
            DebugButton.Visible = Utilities.Debug;
            DebugTextBox.Visible = Utilities.Debug;
            foreach (NavigateItem item in RankList)
            {
                ArmorSets.Add(ArmorSetSQL.GetArmorSet(item.Key));
            }
            SetUpArmorSetListBox();
            SetUpArmorSkillListBox();
            SetUpRankListBox();
        }

        #region Rank List Box

        private void SetUpRankListBox()
        {
            RankListBox.DataSource = RankList;
            RankListBox.DrawMode = DrawMode.OwnerDrawVariable;
            RankListBox.MeasureItem += new MeasureItemEventHandler(RankListBox_MeasureItem);
            RankListBox.DrawItem += new DrawItemEventHandler(RankListBox_DrawItem);
        }

        private void RankListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // If the item is the selected item, then draw the rectangle
            // filled in blue. The item is selected when a bitwise And
            // of the State property and the DrawItemState.Selected
            // property is true.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                Rectangle Indicator = new Rectangle(e.Bounds.X, e.Bounds.Y + 10, e.Bounds.Width / 15, 40);
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, Indicator);
            }
            else
            {
                // Otherwise, draw the rectangle filled in beige.
                e.Graphics.FillRectangle(new SolidBrush(RankListBox.BackColor), e.Bounds);
            }
            e.Graphics.DrawString((RankListBox.Items[e.Index] as NavigateItem).Value, RankListBox.Font,
                new SolidBrush(RankListBox.ForeColor), e.Bounds.X + 15, e.Bounds.Y + 20);
        }

        private void RankListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 70;
        }

        #endregion Rank List Box

        #region Armor Set ListBox Customize function

        private void SetUpArmorSetListBox()
        {
            ArmorSetListBox.DrawMode = DrawMode.OwnerDrawVariable;
            ArmorSetListBox.MeasureItem += new MeasureItemEventHandler(ArmorSetListBox_MeasureItem);
            ArmorSetListBox.DrawItem += new DrawItemEventHandler(ArmorSetListBox_DrawItem);
        }

        private void ArmorSetListBox_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.FillRectangle(new SolidBrush(ArmorSetListBox.BackColor), e.Bounds);
            }

            // Draw the text in the item.
            e.Graphics.DrawString((ArmorSetListBox.Items[e.Index] as ArmorSet).Name,
                ArmorSetListBox.Font, Brushes.White, e.Bounds.X + 10, e.Bounds.Y + 10);
        }

        private void ArmorSetListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 45;
        }

        #endregion Armor Set ListBox Customize function

        #region Armor Set Bonus Skill

        private void SetUpArmorSkillListBox()
        {
            ArmorSkillListBox.DrawMode = DrawMode.OwnerDrawVariable;
            ArmorSkillListBox.MeasureItem += new MeasureItemEventHandler(ArmorSkillListBox_MeasureItem);
            ArmorSkillListBox.DrawItem += new DrawItemEventHandler(ArmorSkillListBox_DrawItem);
        }

        private void ArmorSkillListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle BackgroundRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 10, e.Bounds.Width, e.Bounds.Height - 10);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillPath(new SolidBrush(ListSelectedColor), Utilities.RoundRect(BackgroundRect, 10));
            }
            else
            {
                // Otherwise, draw the rectangle filled in ListBox background color
                e.Graphics.FillPath(new SolidBrush(ListBackgroundColor), Utilities.RoundRect(BackgroundRect, 10));
            }
            ArmorSetBonusSkill bonusSkill = (ArmorSetBonusSkill)ArmorSkillListBox.Items[e.Index];
            e.Graphics.DrawString($"{bonusSkill.SetBonusName}({bonusSkill.Required})",
                ArmorSkillListBox.Font, new SolidBrush(ArmorSkillListBox.ForeColor), e.Bounds.X + 10, e.Bounds.Y + 20);
        }

        private void ArmorSkillListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 60;
        }

        #endregion Armor Set Bonus Skill

        /// <summary>
        /// Display the given armor set to the screen
        /// </summary>
        /// <param name="armorSet"></param>
        private void DisplayArmorSet(ArmorSet armorSet)
        {
            //TODO add exception if armorSet is null
            ArmorSetNameLabel.Text = armorSet.Name;
            RarityLabel.Text = $"{Properties.String.GeneralRarity} {armorSet.Rarity.ToString()}";
            RarityLabel.ForeColor = MonsterHunterColor.RarityColor[armorSet.Rarity - 1]; //Change rarity color
            FireLable.Text = armorSet.Fire.ToString();
            WaterLable.Text = armorSet.Water.ToString();
            ThunderLable.Text = armorSet.Thunder.ToString();
            IceLable.Text = armorSet.Ice.ToString();
            DargonLable.Text = armorSet.Dragon.ToString();
            DefenceBaseLable.Text = armorSet.DefenseBase.ToString();
            DefenceMaxLable.Text = armorSet.DefenseMax.ToString();
            // Set up bonus skill text
            ArmorSkillListBox.DataSource = armorSet.GetBonusSkills();
            ArmorSkillListBox.SelectedItem = null;
            ToolTip.SetToolTip(ArmorSkillListBox, (ArmorSkillListBox.DataSource == null) ? null : Properties.String.ToolTipArmorSetBonusSkill);
            //update monster image if there is
            MonsterPicture.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Monster_" + armorSet.MonsterID.ToString());
            //Change Cursor if there is picture
            MonsterPicture.Cursor = MonsterPicture.BackgroundImage == null ? Cursors.Default : Cursors.Hand;
            ToolTip.SetToolTip(MonsterPicture, MonsterPicture.BackgroundImage == null ? null : armorSet.MonsterName);

            //reset all Armor Set button
            List<Button> armorButton = new List<Button>();
            armorButton.Add(HeadButton);
            armorButton.Add(ChestButton);
            armorButton.Add(ArmButton);
            armorButton.Add(WaistButton);
            armorButton.Add(LegButton);
            bool[] buttonChanged = new bool[5] { false, false, false, false, false };
            // Set armor icon
            foreach (ArmorSetArmors armor in armorSet.ArmorSetArmors)
            {
                Color DesColor = MonsterHunterColor.RarityColor[armorSet.Rarity - 1];
                switch (armor.ArmorType)
                {
                    case "head":
                        {
                            HeadButton.BackgroundImage = Utilities.GetImageFromSVG(Properties.Resources.ui_head, MonsterHunterColor.UIARMORBASE, DesColor);
                            HeadButton.Enabled = true;
                            // Store the Armor Set Armor to the button
                            HeadButton.Tag = armor;
                            HeadButton.Cursor = Cursors.Hand;
                            buttonChanged[0] = true;
                            break;
                        }
                    case "chest":
                        {
                            ChestButton.Enabled = true;
                            ChestButton.BackgroundImage = Utilities.GetImageFromSVG(Properties.Resources.ui_chest, MonsterHunterColor.UIARMORBASE, DesColor);
                            ChestButton.Tag = armor;
                            ChestButton.Cursor = Cursors.Hand;
                            buttonChanged[1] = true;
                            break;
                        }
                    case "arms":
                        {
                            ArmButton.Enabled = true;
                            ArmButton.BackgroundImage = Utilities.GetImageFromSVG(Properties.Resources.ui_arm, MonsterHunterColor.UIARMORBASE, DesColor);
                            ArmButton.Tag = armor;
                            ArmButton.Cursor = Cursors.Hand;
                            buttonChanged[2] = true;
                            break;
                        }
                    case "waist":
                        {
                            WaistButton.Enabled = true;
                            WaistButton.BackgroundImage = Utilities.GetImageFromSVG(Properties.Resources.ui_waist, MonsterHunterColor.UIARMORBASE, DesColor);
                            WaistButton.Tag = armor;
                            WaistButton.Cursor = Cursors.Hand;
                            buttonChanged[3] = true;
                            break;
                        }
                    case "legs":
                        {
                            LegButton.Enabled = true;
                            LegButton.BackgroundImage = Utilities.GetImageFromSVG(Properties.Resources.ui_leg, MonsterHunterColor.UIARMORBASE, DesColor);
                            LegButton.Tag = armor;
                            LegButton.Cursor = Cursors.Hand;
                            buttonChanged[4] = true;
                            break;
                        }
                }
            }

            for (int index = 0; index < 5; index++)
            {
                if (!buttonChanged[index])
                {
                    ResetArmorButton(armorButton[index]);
                }
            }
        }

        public void DisplayArmorSet(int ArmorSetID)
        {
            int ArmorSetRank = 0;
            //Search each sub list in the ArmoSet list
            foreach (List<ArmorSet> armorSetList in ArmorSets)
            {
                foreach (ArmorSet armorSet in armorSetList)
                {
                    if (armorSet.ArmorSetID == ArmorSetID)
                    {
                        ArmorSetListBox.SelectedItem = armorSet;
                        RankListBox.SelectedIndex = ArmorSetRank;
                        return;
                    }
                }
                ArmorSetRank++;
            }
            // If cannot find the armor set, show the first one in the list
            ArmorSetListBox.SelectedIndex = 0;
        }

        private void ResetArmorButton(Button Armorbutton)
        {
            Armorbutton.Enabled = false;
            Armorbutton.BackgroundImage = Utilities.GetImageFromSVG(Properties.Resources.ui_armorset_empty);
            Armorbutton.Tag = null;
            Armorbutton.Cursor = Cursors.Default;
        }

        private void ArmorButton_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.ShowArmor((sender as Button).Tag as ArmorSetArmors);
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(DebugTextBox.Text, out int armorsetID))
                {
                    DisplayArmorSet(ArmorSetSQL.GetArmorSet(armorsetID));
                }
                else
                {
                    throw new Exception("Invalid number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Debug Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Call this function when selected is changed in the ArmorSet list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArmorSetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayArmorSet(ArmorSetListBox.SelectedItem as ArmorSet);
        }

        private void ArmorSetWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (ArmorSkillListBox.SelectedItem != null)
            {
                ArmorSkillListBox.SelectedItem = null;
            }
        }

        private void ArmorSkillListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ArmorSkillListBox.SelectedItem != null)
            {
                MainForm.Instance.ShowSkill(((ArmorSetBonusSkill)ArmorSkillListBox.SelectedItem).SkillId);
            }
        }

        private void RankListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArmorSetListBox.DataSource = ArmorSets[RankListBox.SelectedIndex];
        }
    }
}