using MonsterHunterWorld.Class;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class ArmorWindow : UserControl
    {
        private static ArmorWindow _instance;

        public static ArmorWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ArmorWindow();
                }

                return _instance;
            }
        }

        private readonly List<List<Armor>> Armors = new List<List<Armor>>();

        private readonly List<NavigateItem> ArmorTypeList = new List<NavigateItem>()
        {
            new NavigateItem("head",Properties.String.ArmorHead),
            new NavigateItem("chest",Properties.String.ArmorChest ),
            new NavigateItem("arms",Properties.String.ArmorArms ),
            new NavigateItem("waist",Properties.String.ArmorWaist),
            new NavigateItem("legs",Properties.String.ArmorLegs )
        };

        private readonly static string UIArmorTypePrefix = "ui_armor_";
        private readonly static string UIPrefix = "ui_";
        private readonly static string UIElement = "ui_element_";
        private readonly static string UISlotempty = "ui_slot_empty_";
        private readonly static string ItemPrefix = "item_";
        private readonly static Color ItemIconBaseColor = Color.White;
        private readonly Size CraftIconSize = new Size(35, 35);
        private readonly static Color ListBackgroundColor = Color.FromArgb(221, 222, 225);
        private readonly static Color ListSelectedColor = Color.FromArgb(209, 223, 250);

        public ArmorWindow()
        {
            InitializeComponent();
            Armors.Add(ArmorSQL.GetArmor(ArmorSQL.ARMORTYPEHEAD));
            Armors.Add(ArmorSQL.GetArmor(ArmorSQL.ARMORTYPECHEST));
            Armors.Add(ArmorSQL.GetArmor(ArmorSQL.ARMORTYPEARM));
            Armors.Add(ArmorSQL.GetArmor(ArmorSQL.ARMORTYPEWAIST));
            Armors.Add(ArmorSQL.GetArmor(ArmorSQL.ARMORTYPELEG));
            SetUpBasic();
        }

        /// <summary>
        /// Should Call this method when this bring to front,
        /// this function will change the Selected in
        /// </summary>
        public void EnterWindow()
        {
            DisplayArmor(ArmorListBox.SelectedItem as Armor);
        }

        /// <summary>
        /// Will set up all the basic stuff for Item Window
        /// </summary>
        private void SetUpBasic()
        {
            SetUpArmorListBox();
            SetUpArmorTypeListBox();
            SetUpCraftListBox();
            SetUpSkillListBox();
            ArmorListBox.SelectedIndex = 0;
            FirePictureBox.Image = Utilities.GetImage(UIElement + "fire");
            WaterPictureBox.Image = Utilities.GetImage(UIElement + "water");
            ThunderPictureBox.Image = Utilities.GetImage(UIElement + "thunder");
            IcePictureBox.Image = Utilities.GetImage(UIElement + "ice");
            DragonPictureBox.Image = Utilities.GetImage(UIElement + "dragon");
            DefensePictureBox.Image = Utilities.GetImage(UIPrefix + "defense");
            ToolTip.SetToolTip(FirePictureBox, Properties.String.ToolTipFire);
            ToolTip.SetToolTip(WaterPictureBox, Properties.String.ToolTipWater);
            ToolTip.SetToolTip(ThunderPictureBox, Properties.String.ToolTipThunder);
            ToolTip.SetToolTip(IcePictureBox, Properties.String.ToolTipIce);
            ToolTip.SetToolTip(DragonPictureBox, Properties.String.ToolTipDragon);
            ToolTip.SetToolTip(DefensePictureBox, Properties.String.ToolTipDefense);
            ToolTip.SetToolTip(ArmorTypeButton, Properties.String.ToolTipArmorDisplayArmorSet);
        }

        #region ArmorTypeListBox Customize function

        /// <summary>
        /// Setup everything relate to Type List Box
        /// </summary>
        private void SetUpArmorTypeListBox()
        {
            ArmorTypeListBox.DataSource = ArmorTypeList;
            ArmorTypeListBox.DrawMode = DrawMode.OwnerDrawVariable;
            ArmorTypeListBox.MeasureItem += new MeasureItemEventHandler(ArmorTypeListBox_MeasureItem);
            ArmorTypeListBox.DrawItem += new DrawItemEventHandler(ArmorTypeListBox_DrawItem);
        }

        private void ArmorTypeListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // If the item is the selected item, then draw the rectangle
            // filled in blue. The item is selected when a bitwise And
            // of the State property and the DrawItemState.Selected
            // property is true.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                Rectangle Indicator = new Rectangle(e.Bounds.X, e.Bounds.Y + 10, e.Bounds.Width / 20, 40);
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, Indicator);
            }
            else
            {
                // Otherwise, draw the rectangle filled in beige.
                e.Graphics.FillRectangle(new SolidBrush(ArmorTypeListBox.BackColor), e.Bounds);
            }

            // Draw the text in the item.
            e.Graphics.DrawString((ArmorTypeListBox.Items[e.Index] as NavigateItem).Value,
                ArmorTypeListBox.Font, Brushes.White, e.Bounds.X + 65, e.Bounds.Y + 20);
            //Draw the Icon in the item
            Size IconSize = new Size(30, 30);
            string IconPath = Properties.Resources.ResourceManager.GetString(UIArmorTypePrefix + (ArmorTypeListBox.Items[e.Index] as NavigateItem).Key);
            Image IconImage = Utilities.GetImageFromSVG(IconPath, IconSize);
            e.Graphics.DrawImage(IconImage, e.Bounds.X + 20, e.Bounds.Y + 17);
        }

        private void ArmorTypeListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 80;
        }

        #endregion ArmorTypeListBox Customize function

        #region ArmorListBox Customize function

        private void SetUpArmorListBox()
        {
            ArmorListBox.DrawMode = DrawMode.OwnerDrawVariable;
            ArmorListBox.MeasureItem += new MeasureItemEventHandler(ArmorListBox_MeasureItem);
            ArmorListBox.DrawItem += new DrawItemEventHandler(ArmorListBox_DrawArmor);
        }

        private void UpdateArmorListBox()
        {
            ArmorListBox.DataSource = Armors[ArmorTypeListBox.SelectedIndex];
        }

        private void ArmorListBox_DrawArmor(object sender, DrawItemEventArgs e)
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
                // Otherwise, draw the rectangle filled in ListBox background color
                e.Graphics.FillRectangle(new SolidBrush(ArmorListBox.BackColor), e.Bounds);
            }

            // Draw the text in the item
            e.Graphics.DrawString((ArmorListBox.Items[e.Index] as Armor).Name,
                ArmorListBox.Font, Brushes.White, e.Bounds.X + 5, e.Bounds.Y + 10);
        }

        private void ArmorListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        #endregion ArmorListBox Customize function

        #region CraftListBox Customize function

        private void SetUpCraftListBox()
        {
            CraftListBox.DrawMode = DrawMode.OwnerDrawVariable;
            CraftListBox.MeasureItem += new MeasureItemEventHandler(CraftListBox_MeasureItem);
            CraftListBox.DrawItem += new DrawItemEventHandler(CraftListBox_DrawItem);
        }

        private void UpdateCraftListBox(List<CraftItem> craftArmorItems)
        {
            CraftListBox.DataSource = craftArmorItems;
            CraftListBox.SelectedItem = null;
        }

        private void CraftListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Shape for the List Item background
            Rectangle BackgroundRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 5, e.Bounds.Width - 35, e.Bounds.Height - 5);
            //if item is selected, then draw the BackgroundRect fill with ListBackground
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillPath(new SolidBrush(ListSelectedColor), Utilities.RoundRect(BackgroundRect, 10));
            }
            else
            {
                // Otherwise, draw the rectangle filled in ListBox background color
                e.Graphics.FillPath(new SolidBrush(ListBackgroundColor), Utilities.RoundRect(BackgroundRect, 10));
            }
            // Only update the list if it is a new one
            CraftItem item = CraftListBox.Items[e.Index] as CraftItem;
            if (item.IconName != null)
            {
                string IconImagePath = Properties.Resources.ResourceManager.GetString(ItemPrefix + item.IconName);
                Image IconImage = Utilities.GetImageFromSVG(IconImagePath, ItemIconBaseColor, MonsterHunterColor.IconColor[item.IconColor], CraftIconSize);
                e.Graphics.DrawImage(IconImage, e.Bounds.X + 15, e.Bounds.Y + 15);
            }

            e.Graphics.DrawString(item.ItemName + " x " + item.Quantity.ToString(),
                CraftListBox.Font, Brushes.Black, e.Bounds.X + 50, e.Bounds.Y + 25);
        }

        private void CraftListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = CraftListBox.Height / 4;
        }

        #endregion CraftListBox Customize function

        #region SkillListBox Customize function

        private void SetUpSkillListBox()
        {
            SkillListBox.DrawMode = DrawMode.OwnerDrawVariable;
            SkillListBox.MeasureItem += new MeasureItemEventHandler(SkillListBox_MeasureItem);
            SkillListBox.DrawItem += new DrawItemEventHandler(SkillListBox_DrawItem);
        }

        private void UpdateSkillListBox(List<Skill> skills)
        {
            SkillListBox.DataSource = skills;
            SkillListBox.SelectedItem = null;
        }

        private void SkillListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle BackgroundRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 5, e.Bounds.Width - 35, e.Bounds.Height - 5);
            //if item is selected, then draw the BackgroundRect fill with ListBackground
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillPath(new SolidBrush(ListSelectedColor), Utilities.RoundRect(BackgroundRect, 10));
            }
            else
            {
                // Otherwise, draw the rectangle filled in ListBox background color
                e.Graphics.FillPath(new SolidBrush(ListBackgroundColor), Utilities.RoundRect(BackgroundRect, 10));
            }

            Skill skill = SkillListBox.Items[e.Index] as Skill;
            e.Graphics.DrawImage(Utilities.GetSkillBar(skill.MaxLevel, skill.Level), e.Bounds.X + 22, e.Bounds.Y + 75);
            e.Graphics.DrawString("LV" + skill.Level,
                new Font(SkillListBox.Font, FontStyle.Bold), Brushes.Black, e.Bounds.X + e.Bounds.Width - 100, e.Bounds.Y + 75);
            e.Graphics.DrawString(skill.Name,
                SkillListBox.Font, Brushes.Black, e.Bounds.X + 22, e.Bounds.Y + 30);
        }

        private void SkillListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = SkillPanel.Height / 2;
        }

        #endregion SkillListBox Customize function

        // Variable improve performance
        // Check if user clicking the same item
        private int ArmorSelectedIndex = -2;

        private int ArmorTypeSelectedIndex = -2;

        /// <summary>
        /// Only Update Armor if the item is different
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArmorListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ArmorSelectedIndex != ArmorListBox.SelectedIndex)
            {
                DisplayArmor(ArmorListBox.SelectedItem as Armor);
                ArmorSelectedIndex = ArmorListBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Only Update ArmorListBox if armor type is different
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArmorTypeListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ArmorTypeSelectedIndex != ArmorTypeListBox.SelectedIndex)
            {
                UpdateArmorListBox();
                ArmorTypeSelectedIndex = ArmorTypeListBox.SelectedIndex;
            }
        }

        private void DisplayArmor(Armor armor)
        {
            //Only update if armor is not null
            if (armor != null)
            {
                // Set up Armor Type picture
                string ArmorTypePath = Properties.Resources.ResourceManager.GetObject(UIArmorTypePrefix + (ArmorTypeListBox.SelectedItem as NavigateItem).Key) as string;
                ArmorTypeButton.BackgroundImage =
                    Utilities.GetImageFromSVG(ArmorTypePath, MonsterHunterColor.UIARMORBASE, MonsterHunterColor.RarityColor[armor.Rarity - 1], ArmorTypeButton.Size);
                ArmorNameLabel.Text = armor.Name;
                //Update all element data
                FireLable.Text = armor.Fire.ToString();
                WaterLable.Text = armor.Water.ToString();
                ThunderLable.Text = armor.Thunder.ToString();
                IceLable.Text = armor.Ice.ToString();
                DragonLable.Text = armor.Dragon.ToString();
                DefenseBaseLable.Text = armor.DefenseBase.ToString();
                DefenseMaxLable.Text = armor.DefenseMax.ToString();
                ToolTip.SetToolTip(DefenseMaxLable, Properties.String.ToolTipDefenseMax);
                ToolTip.SetToolTip(DefenseBaseLable, Properties.String.ToolTipDefenseBase);
                Slot1PictureBox.Image = Utilities.GetImage(UISlotempty + armor.Slot1);
                Slot2PictureBox.Image = Utilities.GetImage(UISlotempty + armor.Slot2);
                Slot3PictureBox.Image = Utilities.GetImage(UISlotempty + armor.Slot3);
                UpdateCraftListBox(armor.CraftArmorItems);
                UpdateSkillListBox(armor.SkillList);
            }
        }

        public void DisplayArmor(ArmorSetArmors armor)
        {
            foreach (NavigateItem item in ArmorTypeListBox.Items)
            {
                if (item.Key == armor.ArmorType.ToLower())
                {
                    ArmorTypeListBox.SelectedItem = item;
                    break;
                }
            }
            foreach (Armor armoritem in ArmorListBox.Items)
            {
                if (armoritem.ArmorID == armor.ArmorID)
                {
                    ArmorListBox.SelectedItem = armoritem;
                    break;
                }
            }
        }

        /// <summary>
        /// Source https://stackoverflow.com/questions/4454423/c-sharp-listbox-item-double-click-event
        /// If there is a item is selected then is will lead to the item point to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CraftListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.ShowItem(((CraftItem)CraftListBox.SelectedItem).ItemID);
        }

        private void ArmorWindow_MouseClick(object sender, MouseEventArgs e)
        {
            CraftListBox.SelectedItem = null;
            SkillListBox.SelectedItem = null;
        }

        private void SkillListBox_DoubleClick(object sender, System.EventArgs e)
        {
            MainForm.Instance.ShowSkill(((Skill)SkillListBox.SelectedItem).SkillId);
        }

        private void ArmorTypeButton_Click(object sender, System.EventArgs e)
        {
            MainForm.Instance.ShowArmorSet((ArmorListBox.SelectedItem as Armor).ArmorsetId);
        }
    }
}