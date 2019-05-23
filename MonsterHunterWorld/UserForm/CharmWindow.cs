using MonsterHunterWorld.Class;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class CharmWindow : UserControl
    {
        private static CharmWindow _instance;

        public static CharmWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CharmWindow();
                }
                return _instance;
            }
        }

        private List<Charm> Charms = CharmSQL.GetCharm();
        private readonly static Color ListBackgroundColor = Color.FromArgb(221, 222, 225);
        private readonly static Color ListSelectedColor = Color.FromArgb(209, 223, 250);

        public CharmWindow()
        {
            InitializeComponent();
            SetUpCharmListBox();
            SetUpCraftListBox();
            SetUpBasic();
        }

        private void SetUpBasic()
        {
            UpgradeLabel.Text = Properties.String.CharmUpgradeFrom;
        }

        #region Charm List Box

        private void SetUpCharmListBox()
        {
            CharmListBox.DataSource = Charms;
            CharmListBox.DrawMode = DrawMode.OwnerDrawVariable;
            CharmListBox.DrawItem += new DrawItemEventHandler(CharmListBox_DrawItem);
            CharmListBox.MeasureItem += new MeasureItemEventHandler(CharmListBox_MeasureItem);
        }

        private void CharmListBox_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.FillRectangle(new SolidBrush(CharmListBox.BackColor), e.Bounds);
            }
            e.Graphics.DrawString((CharmListBox.Items[e.Index] as Charm).Name,
                CharmListBox.Font, new SolidBrush(CharmListBox.ForeColor), e.Bounds.X + 25, e.Bounds.Y + 8);
        }

        private void CharmListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        #endregion Charm List Box

        #region Craft List Box

        private void SetUpCraftListBox()
        {
            CraftListBox.DrawMode = DrawMode.OwnerDrawVariable;
            CraftListBox.DrawItem += new DrawItemEventHandler(CraftListBox_DrawItem);
            CraftListBox.MeasureItem += new MeasureItemEventHandler(CraftListBox_MeasureItem);
        }

        private void CraftListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Rectangle BackgroundRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 5, e.Bounds.Width - 5, e.Bounds.Height - 5);
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
                CraftItem item = CraftListBox.Items[e.Index] as CraftItem;
                Size IconSize = new Size(35, 35);
                if (item.IconName != null)
                {
                    e.Graphics.DrawImage(Utilities.GetImage($"item_{item.IconName}", Color.White, MonsterHunterColor.IconColor[item.IconColor], IconSize),
                        e.Bounds.X + 10, e.Bounds.Y + 10);
                }
                e.Graphics.DrawString($"{item.ItemName} x {item.Quantity}",
                    CraftListBox.Font, new SolidBrush(CraftListBox.ForeColor), e.Bounds.X + 45, e.Bounds.Y + 20);
            }
        }

        private void CraftListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 50;
        }

        #endregion Craft List Box

        private void DisplayCharm(Charm charm)
        {
            // Only display if charm is not null
            if (charm != null)
            {
                CharmNameLabel.Text = charm.Name;
                RarityLabel.Text = $"{Properties.String.GeneralRarity}   {charm.Rarity}";
                RarityLabel.ForeColor = MonsterHunterColor.RarityColor[charm.Rarity - 1];
                CharmPictureBox.Image = Utilities.GetImage("ui_charm", Color.White, MonsterHunterColor.RarityColor[charm.Rarity - 1]);
                SkillLabel.Text = charm.SkillName;
                SkillLevelLabel.Text = $"{Properties.String.GeneralLevel} {charm.SkillLevel}";
                SkillPictureBox.Image = Utilities.GetSkillBar(charm.MaxLevel, charm.SkillLevel);
                CraftListBox.DataSource = charm.CraftItems;
                CraftListBox.SelectedItem = null;
                if (charm.PreviousID != 0)
                {
                    Upgradepanel.Visible = true;
                    Charm PreviousCharm = GetCharm(charm.PreviousID);
                    PreviousCharmPictureBox.Image = Utilities.GetImage("ui_charm", Color.White, MonsterHunterColor.RarityColor[PreviousCharm.Rarity - 1]);
                    PreviousCharmNameLabel.Text = PreviousCharm.Name;
                }
                else
                {
                    Upgradepanel.Visible = false;
                }
            }
        }

        private Charm GetCharm(int charmID)
        {
            foreach (Charm charm in Charms)
            {
                if (charm.CharmID == charmID)
                {
                    return charm;
                }
            }
            return null;
        }

        private void CharmListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayCharm(CharmListBox.SelectedItem as Charm);
        }

        private void CraftListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CraftListBox.SelectedItem != null)
            {
                MainForm.Instance.ShowItem((CraftListBox.SelectedItem as CraftItem).ItemID);
            }
        }

        private void CharmWindow_MouseClick(object sender, MouseEventArgs e)
        {
            CraftListBox.SelectedItem = null;
        }

        private void PreviousCharmNameLabel_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Charm charm in CharmListBox.Items)
            {
                if (charm.CharmID == (CharmListBox.SelectedItem as Charm).PreviousID)
                {
                    CharmListBox.SelectedItem = charm;
                    break;
                }
            }
        }
    }
}