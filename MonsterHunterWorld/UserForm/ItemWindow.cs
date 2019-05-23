using MonsterHunterWorld.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class ItemWindow : UserControl
    {
        private static ItemWindow _instance;

        public static ItemWindow Instance
        {
            get
            {
                if (_instance == null) _instance = new ItemWindow();
                return _instance;
            }
        }

        private List<List<Item>> Items = new List<List<Item>>();
        private static Size DefaultIconSize = new Size(32, 32);
        private readonly Image ImageZenny = Utilities.GetImageFromSVG(Properties.Resources.ui_zenny, DefaultIconSize);
        private readonly Image ImageResearchPoints = Utilities.GetImageFromSVG(Properties.Resources.ui_research_points, DefaultIconSize);
        private readonly string ItemImageIconPrefix = "item_";

        private readonly List<NavigateItem> CategoryList = new List<NavigateItem>()
        {
            new NavigateItem("item",Properties.String.ItemCategoryItem),
            new NavigateItem("material",Properties.String.ItemCategoryMaterial),
            new NavigateItem("ammo",Properties.String.ItemCategoryAmmo),
            new NavigateItem("misc",Properties.String.ItemCategoryMisc)
        };

        public ItemWindow()
        {
            InitializeComponent();
            DebugButton.Visible = Utilities.Debug;
            DebugTextBox.Visible = Utilities.Debug;
            Items.Add(ItemSQL.GetAllItem(ItemSQL.CATEGORYITEM));
            Items.Add(ItemSQL.GetAllItem(ItemSQL.CATEGORYMATERIAL));
            Items.Add(ItemSQL.GetAllItem(ItemSQL.CATEGORYAMMO));
            Items.Add(ItemSQL.GetAllItem(ItemSQL.CATEGORYMISC));
            SetUpCategoryListBox();
            SetUpItemListBox();
            BuyPricePictureBox.Image = ImageZenny;
        }

        #region CategoryListBox Customize function

        private void SetUpCategoryListBox()
        {
            CategoryListBox.DataSource = CategoryList;
            CategoryListBox.DrawMode = DrawMode.OwnerDrawVariable;
            CategoryListBox.MeasureItem += new MeasureItemEventHandler(CategoryListBox_MeasureItem);
            CategoryListBox.DrawItem += new DrawItemEventHandler(CategoryListBox_DrawItem);
        }

        private void CategoryListBox_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.FillRectangle(new SolidBrush(CategoryListBox.BackColor), e.Bounds);
            }

            // Draw the text in the item.
            e.Graphics.DrawString((CategoryListBox.Items[e.Index] as NavigateItem).Value,
                CategoryListBox.Font, Brushes.White, e.Bounds.X + 65, e.Bounds.Y + 20);
            //Draw the Icon in the item
            Image IconImage = Utilities.GetImage("ui_item_" + (CategoryListBox.Items[e.Index] as NavigateItem).Key, DefaultIconSize);
            e.Graphics.DrawImage(IconImage, e.Bounds.X + 20, e.Bounds.Y + 15);
        }

        private void CategoryListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 60;
        }

        #endregion CategoryListBox Customize function

        #region ItemListBox Customize function

        private void SetUpItemListBox()
        {
            UpdateItemListBox();
            ItemListBox.DrawMode = DrawMode.OwnerDrawVariable;
            ItemListBox.MeasureItem += new MeasureItemEventHandler(ItemListBox_MeasureItem);
            ItemListBox.DrawItem += new DrawItemEventHandler(ItemListBox_DrawItem);
        }

        private void ItemListBox_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.FillRectangle(new SolidBrush(ItemListBox.BackColor), e.Bounds);
            }

            // Draw the text in the item.
            e.Graphics.DrawString((ItemListBox.Items[e.Index] as Item).Name,
                ItemListBox.Font, Brushes.White, e.Bounds.X + 5, e.Bounds.Y + 10);
        }

        private void ItemListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        #endregion ItemListBox Customize function

        private int SelectedIndex = 0;
        private bool IsMouseDown;

        private void CategoryListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (SelectedIndex != CategoryListBox.SelectedIndex)
            {
                UpdateItemListBox();
                IsMouseDown = false;
            }
        }

        private void CategoryListBox_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsMouseDown)
                UpdateItemListBox();
        }

        private void UpdateItemListBox()
        {
            ItemListBox.DataSource = Items[CategoryListBox.SelectedIndex];
            SelectedIndex = CategoryListBox.SelectedIndex;
        }

        private void DisplayItem(Item item)
        {
            ItemNameLabel.Text = item.Name;
            RarityLabel.Text = item.Rarity.ToString();

            if (item.Rarity != 0)
                RarityLabel.ForeColor = MonsterHunterColor.RarityColor[item.Rarity - 1];
            BuyPriceLabel.Text = item.BuyPrice == 0 ? "-" : item.BuyPrice.ToString();
            //Set up Sell Price
            if (item.SellPrice == 0 && item.Points == 0)
            {
                SellPriceLabel.Text = "-";
                SellPricePictureBox.Image = ImageZenny;
            }
            else
            {
                //If Sell Price > 0 then put Sell Price to Sell Price Label, otherwise put points there
                SellPriceLabel.Text = item.SellPrice > 0 ? item.SellPrice.ToString() : item.Points.ToString();
                SellPricePictureBox.Image = item.SellPrice > 0 ? ImageZenny : ImageResearchPoints;
            }
            CarryLimitLabel.Text = item.CarryLimit == 0 ? "-" : item.CarryLimit.ToString();
            // Only display Icon if there is one for this
            Image ItemImage = null;
            Color SourceColor = Color.White;
            if (item.IconName != null)
            {
                //Replace Icon color with Icon Color
                ItemImage = Utilities.GetImage(ItemImageIconPrefix + item.IconName, SourceColor, MonsterHunterColor.IconColor[item.IconColor]);

                ItemPictureBox.Image = ItemImage;
            }
            else
            {
                //If there is no Image then put it to unknown image
                ItemPictureBox.Image = null;
            }
            DescriptionLabel.Text = item.Description;

            //Set up the first Obtain Panel
            if (item.GetCraftList().Count > 0)
            {
                ItemCraft CurrentItemCraft = item.GetCraftList().ElementAt(0);
                // Always setup the Obtain Panel1 result item image
                ObtainPanel1ResultItemPictureBox.Image = ItemImage;
                ObtainPanel1ResultLabel.Text = $"x {CurrentItemCraft.Quantity.ToString()}";
                ToolTip.SetToolTip(ObtainPanel1ResultItemPictureBox, item.Name);
                //Enable ObtainPanel1
                ObtainPanel1.Visible = true;
                Image ObtainItemImage = Utilities.GetImage(ItemImageIconPrefix + CurrentItemCraft.FirstIconName, SourceColor, MonsterHunterColor.IconColor[CurrentItemCraft.FirstIconColor]);
                ObtainPanel1FirstItemPictureBox.Image = ObtainItemImage;
                ToolTip.SetToolTip(ObtainPanel1FirstItemPictureBox, CurrentItemCraft.FirstName);
                //Show the second part of picture
                if (CurrentItemCraft.SecondIconName != null)
                {
                    ObtainItemImage = Utilities.GetImage(ItemImageIconPrefix + CurrentItemCraft.SecondIconName, SourceColor, MonsterHunterColor.IconColor[CurrentItemCraft.SecondIconColor]);
                    ObtainPanel1SecondItemPictureBox.Image = ObtainItemImage;
                    ObtainPanel1SecondItemPictureBox.Visible = true;
                    ObtainPanel1PlusLabel.Visible = true;
                    ToolTip.SetToolTip(ObtainPanel1SecondItemPictureBox, CurrentItemCraft.SecondName);
                }
                else
                {//No need second item picture
                    ObtainPanel1PlusLabel.Visible = false;
                    ObtainPanel1SecondItemPictureBox.Visible = false;

                    ToolTip.SetToolTip(ObtainPanel1SecondItemPictureBox, null);
                }
                if (item.GetCraftList().Count > 1)
                {
                    ObtainPanel2.Visible = true;
                    CurrentItemCraft = item.GetCraftList().ElementAt(1);
                    // Always setup the Obtain Panel2 result item image
                    ObtainPanel2ResultItemPictureBox.Image = ItemImage;
                    ObtainPanel2ResultLabel.Text = "x" + CurrentItemCraft.Quantity.ToString();
                    ToolTip.SetToolTip(ObtainPanel2ResultItemPictureBox, item.Name);
                    //Enable ObtainPanel2
                    ObtainPanel2.Visible = true;
                    ObtainItemImage = Utilities.GetImage(ItemImageIconPrefix + CurrentItemCraft.FirstIconName, SourceColor, MonsterHunterColor.IconColor[CurrentItemCraft.FirstIconColor]);
                    ObtainPanel2FirstItemPictureBox.Image = ObtainItemImage;
                    ToolTip.SetToolTip(ObtainPanel2FirstItemPictureBox, CurrentItemCraft.FirstName);
                    //Show the second part of picture
                    if (CurrentItemCraft.SecondIconName != null)
                    {
                        ObtainItemImage = Utilities.GetImage(ItemImageIconPrefix + CurrentItemCraft.SecondIconName, SourceColor, MonsterHunterColor.IconColor[CurrentItemCraft.SecondIconColor], ObtainPanel2FirstItemPictureBox.Size);
                        ObtainPanel2SecondItemPictureBox.Image = ObtainItemImage;
                        ObtainPanel2SecondItemPictureBox.Visible = true;
                        ObtainPanel2PlusLabel.Visible = true;
                        ToolTip.SetToolTip(ObtainPanel2SecondItemPictureBox, CurrentItemCraft.SecondName);
                    }
                    else
                    {//No need second item picture
                        ObtainPanel2PlusLabel.Visible = false;
                        ObtainPanel2SecondItemPictureBox.Visible = false;
                        ToolTip.SetToolTip(ObtainPanel2SecondItemPictureBox, null);
                    }
                }
                else
                {
                    ObtainPanel2.Visible = false;
                }
            }
            else
            {
                ObtainPanel1.Visible = false;
                ObtainPanel2.Visible = false;
            }
        }

        /// <summary>
        /// Find the item with it's given item ID
        /// </summary>
        /// <param name="ItemID"></param>
        public void DisplayItem(int ItemID)
        {
            Item ResultItem = ItemSQL.GetItem(ItemID);
            Console.WriteLine(ResultItem.Id);
            //If Item is not found show up a pop up windows and show the
            //default item for ItemWindow
            if (ResultItem == null)
            {
                //Show a warning if the item is not found
                MessageBox.Show($"{ItemID} can not find", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CategoryListBox.SelectedIndex = 0;
                ItemListBox.SelectedIndex = 0;
            }
            else
            {
                // Find the Category Item
                foreach (NavigateItem item in CategoryList)
                {
                    if (item.Key == ResultItem.Category)
                    {
                        CategoryListBox.SelectedItem = item;
                        break;
                    }
                }
                // Find the item with ItemID
                foreach (Item item in ItemListBox.Items)
                {
                    if (item.Id == ItemID)
                    {
                        ItemListBox.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemListBox.SelectedIndex != -1)
                DisplayItem(ItemListBox.Items[ItemListBox.SelectedIndex] as Item);
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
        }
    }
}