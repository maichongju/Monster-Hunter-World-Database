using MonsterHunterWorld.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class MonsterWindow : UserControl
    {
        private static MonsterWindow _instance;

        public static MonsterWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MonsterWindow();
                }

                return _instance;
            }
        }

        private List<List<Monster>> monsters = new List<List<Monster>>()
        {
            new List<Monster>(),
            new List<Monster>()
        };

        private readonly List<NavigateItem> MonsterSizeList = new List<NavigateItem>
        {
            new NavigateItem("large",Properties.String.MonsterSizeLarge),
            new NavigateItem("small",Properties.String.MonsterSizeSmall)
        };

        private List<List<PictureBox>> WeaknessPictureBoxes = new List<List<PictureBox>>();
        private List<List<PictureBox>> AltWeaknessPictureBoxes = new List<List<PictureBox>>();
        private Size IconSize = new Size(35, 35);

        private ImageList imageList = new ImageList
        {
            ImageSize = new Size(35, 35)
        };

        public MonsterWindow()
        {
            InitializeComponent();
            //Add All Monster in to list
            foreach (Monster monster in MonsterSQL.GetMonsters())
            {
                if (monster.Size == "large")
                {
                    monsters.ElementAt(0).Add(monster);
                }
                else
                {
                    monsters.ElementAt(1).Add(monster);
                }
            }
            SetUpWeaknessPictureBox();
            SetUpMonsterSizeListBox();
            SetUpMonsterListBox();
            SetUpDamageElementListView();
            SetUpDamageBreaksListView();
            SetUpAilmentListBox();
        }

        /// <summary>
        /// This function will create all the picture box use for weakness panel
        /// </summary>
        private void SetUpWeaknessPictureBox()
        {
            Size PictureSize = new Size(30, 30);
            int Y = 0;
            // Normal weakness
            for (int i = 0; i < 10; i++)
            {
                List<PictureBox> WeaknessPictureBoxList = new List<PictureBox>();
                for (int m = 0; m < 4; m++)
                {
                    PictureBox CurrentPictureBox = new PictureBox();
                    WeaknessPanel.Controls.Add(CurrentPictureBox);
                    CurrentPictureBox.Location = new Point((PictureSize.Width + 5) * m, Y);
                    CurrentPictureBox.Size = PictureSize;
                    CurrentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    WeaknessPictureBoxList.Add(CurrentPictureBox);
                }
                WeaknessPictureBoxes.Add(WeaknessPictureBoxList);
                Y += PictureSize.Height + 5;
            }
            // AltPictureBox
            Y = 0;
            for (int i = 0; i < 5; i++)
            {
                int X = 0;
                Label LeftLabel = CreateLabel("(", new Point(X, Y));
                AltWeaknessPanel.Controls.Add(LeftLabel);
                X += LeftLabel.Width - 5;
                List<PictureBox> AltWeaknessPictureBoxList = new List<PictureBox>();
                for (int m = 0; m < 3; m++)
                {
                    PictureBox CurrentPictureBox = new PictureBox();
                    AltWeaknessPanel.Controls.Add(CurrentPictureBox);
                    CurrentPictureBox.Location = new Point(X, Y);
                    CurrentPictureBox.Size = PictureSize;
                    CurrentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    AltWeaknessPictureBoxList.Add(CurrentPictureBox);
                    X += PictureSize.Width + 5;
                }
                AltWeaknessPictureBoxes.Add(AltWeaknessPictureBoxList);
                AltWeaknessPanel.Controls.Add(CreateLabel(")", new Point(X - 5, Y)));
                Y += PictureSize.Height + 5;
            }
        }

        /// <summary>
        /// Function for create Label
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        private Label CreateLabel(string Text, Point Location, float Size = 16)
        {
            Label label = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", Size),
                Location = Location,
                Text = Text,
                BackColor = Color.Transparent
            };
            return label;
        }

        #region Monster Size List Box

        /// <summary>
        /// private function for set up <see cref="MonsterSizeListBox"/>
        /// </summary>
        private void SetUpMonsterSizeListBox()
        {
            MonsterSizeListBox.DataSource = MonsterSizeList;
            MonsterSizeListBox.DrawMode = DrawMode.OwnerDrawVariable;
            MonsterSizeListBox.DrawItem += new DrawItemEventHandler(MonsterSizeListBox_DrawItem);
            MonsterSizeListBox.MeasureItem += new MeasureItemEventHandler(MonsterSizeListBox_MeasureItem);
        }

        private void MonsterSizeListBox_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.FillRectangle(new SolidBrush(MonsterSizeListBox.BackColor), e.Bounds);
            }

            // Draw the text in the item.
            e.Graphics.DrawString((MonsterSizeListBox.Items[e.Index] as NavigateItem).Value,
                MonsterSizeListBox.Font, Brushes.White, e.Bounds.X + 20, e.Bounds.Y + 15);
        }

        private void MonsterSizeListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 80;
        }

        #endregion Monster Size List Box

        #region Monster List Box

        private void SetUpMonsterListBox()
        {
            MonsterListBox.DrawMode = DrawMode.OwnerDrawVariable;
            MonsterListBox.DrawItem += new DrawItemEventHandler(MonsterListBox_DrawItem);
            MonsterListBox.MeasureItem += new MeasureItemEventHandler(MonsterListBox_MeasureItem);
        }

        private void MonsterListBox_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.FillRectangle(new SolidBrush(MonsterListBox.BackColor), e.Bounds);
            }

            e.Graphics.DrawString((MonsterListBox.Items[e.Index] as Monster).Name, MonsterListBox.Font,
                new SolidBrush(MonsterListBox.ForeColor), e.Bounds.X + 10, e.Bounds.Y + 5);
        }

        private void MonsterListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 35;
        }

        #endregion Monster List Box

        #region Damage Element List View

        private void SetUpDamageElementListView()
        {
            DamageElementListView.OwnerDraw = true;
            DamageElementListView.DrawItem += new
                DrawListViewItemEventHandler(DamageElementListView_DrawItem);
            DamageElementListView.DrawSubItem += new
                DrawListViewSubItemEventHandler(DamageElementListView_DrawSubItem);
            DamageElementListView.DrawColumnHeader += new
                DrawListViewColumnHeaderEventHandler(DamageElementListView_DrawColumnHeader);
        }

        private void DamageElementListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // There is a bug for this
            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.listview.drawitem?redirectedfrom=MSDN&view=netframework-4.8
        }

        private void DamageElementListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Brush fontColor = Brushes.Black;
            FontStyle fontStyle = FontStyle.Regular;
            StringFormat stringFormat = new StringFormat();
            // Set up Alignment
            if (e.ColumnIndex == 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(DamageElementListView.BackColor), e.Bounds);
                stringFormat.Alignment = StringAlignment.Near;
            }
            else
            {
                stringFormat.Alignment = StringAlignment.Center;
            }

            // Check if the current text is number
            int num;
            if (int.TryParse(e.SubItem.Text, out num))
            {
                // Check if the number need to be bold
                if ((e.ColumnIndex > 3 && num >= 20) || (e.ColumnIndex > 0 && num >= 45))
                {
                    fontStyle = FontStyle.Bold;
                }

                //Change the number to its color
                if (e.ColumnIndex > 3 && num >= 20)
                {
                    // Make sure no exception happen
                    if (MonsterHunterColor.ElementColor.ContainsKey(DamageElementListView.Columns[e.ColumnIndex].Text))
                    {
                        fontColor = new SolidBrush(MonsterHunterColor.ElementColor[DamageElementListView.Columns[e.ColumnIndex].Text]);
                    }
                }
            }

            using (Font font = new Font("Microsoft Sans Serif", DamageElementListView.Font.Size, fontStyle))
            {
                e.Graphics.DrawString(e.SubItem.Text,
                    font, fontColor, e.Bounds, stringFormat);
            }
        }

        private void DamageElementListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawBackground();
            // Only the first one is string
            if (e.Header.Index == 0)
            {
                using (Font headerFont = new Font("Microsoft Sans Serif", 12F))
                {
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Black, e.Bounds);
                }
            }
            else
            // Other column use image as column
            {
                try
                {
                    using (Image headerImage = Utilities.GetImage($"monster_damage_{e.Header.Text}", new Size(25, 25)))
                    {
                        if (headerImage != null)
                        {
                            e.Graphics.DrawImage(headerImage, e.Bounds.X + 5, e.Bounds.Y);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogWritter.Instance.Write(ex.StackTrace, LogCategory.Error);
                }
            }
        }

        #endregion Damage Element List View

        #region Damage Breaks List View

        private void SetUpDamageBreaksListView()
        {
            DamageBreaksListView.OwnerDraw = true;
            DamageBreaksListView.DrawItem += new DrawListViewItemEventHandler(DamageBreaksListView_DrawListViewItem);
            DamageBreaksListView.DrawSubItem += new DrawListViewSubItemEventHandler(DamgaeBreaksListView_DrawSubItem);
            DamageBreaksListView.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(DamageBreaksListView_DrawColumnHeader);
        }

        private void DamageBreaksListView_DrawListViewItem(object sender, DrawListViewItemEventArgs e)
        {
        }

        private void DamgaeBreaksListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Brush fontColor = Brushes.Black;
            FontStyle fontStyle = FontStyle.Regular;
            StringFormat stringFormat = new StringFormat();
            if (e.ColumnIndex == 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(DamageBreaksListView.BackColor), e.Bounds);
                stringFormat.Alignment = StringAlignment.Near;
            }
            else
            {
                stringFormat.Alignment = StringAlignment.Center;
            }

            if (int.TryParse(e.SubItem.Text, out _))
            {
                fontStyle = FontStyle.Bold;
            }
            using (Font font = new Font("Microsoft Sans Serif", DamageElementListView.Font.Size, fontStyle))
            {
                e.Graphics.DrawString(e.SubItem.Text,
                    font, fontColor, e.Bounds, stringFormat);
            }
        }

        private void DamageBreaksListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawBackground();
            // The current one is the last column, show the image
            if (e.ColumnIndex == DamageBreaksListView.Columns.Count - 1)
            {
                try
                {
                    using (Image headerImage = Utilities.GetImage($"monster_kinsect", new Size(25, 25)))
                    {
                        if (headerImage != null)
                        {
                            e.Graphics.DrawImage(headerImage, e.Bounds.X + 10, e.Bounds.Y);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogWritter.Instance.Write(ex.StackTrace, LogCategory.Error);
                }
            }
            else
            {
                using (Font headerFont = new Font("Microsoft Sans Serif", 12F))
                {
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Black, e.Bounds);
                }
            }
        }

        #endregion Damage Breaks List View

        #region Ailment List Box

        private void SetUpAilmentListBox()
        {
            AilmentListBox.DrawMode = DrawMode.OwnerDrawVariable;
            AilmentListBox.DrawItem += new DrawItemEventHandler(AilmentListBox_DrawItem);
            AilmentListBox.MeasureItem += new MeasureItemEventHandler(AilmentListBox_MeasureItem);
        }

        private void AilmentListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                string drawstring = (AilmentListBox.Items[e.Index] as MonsterAilment).AilmentName;
                drawstring += (AilmentListBox.Items[e.Index] as MonsterAilment).ExtraInfo == null ? "" : " (" + (AilmentListBox.Items[e.Index] as MonsterAilment).ExtraInfo + ")";
                e.Graphics.FillRectangle(new SolidBrush(AilmentListBox.BackColor), e.Bounds);
                e.Graphics.DrawString(drawstring, AilmentListBox.Font, new SolidBrush(AilmentListBox.ForeColor), e.Bounds.X + 5, e.Bounds.Y + 3);
                e.Graphics.DrawLine(new Pen(Color.DarkGray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash },
                    new Point(e.Bounds.X, e.Bounds.Y + e.Bounds.Height - 1),
                    new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height - 1));
            }
        }

        private void AilmentListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 20;
        }

        #endregion Ailment List Box

        /// <summary>
        /// Display the given <see cref="Monster"/>
        /// </summary>
        /// <param name="monster"><see cref="Monster"/> need to display </param>
        public void DisplayMonster(Monster monster)
        {
            if (monster != null)
            {
                MonsterNameLabel.Text = monster.Name;
                MonsterDescriptionTextBox.Text = monster.Description;
                //update monster image if there is
                MonsterPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject($"Monster_{monster.MonsterID.ToString()}");
                EcologyLabel.Text = monster.Ecology;

                #region Weakness

                //Weakness Panel
                if (monster.MonsterWeakness.Count > 0)
                {
                    WeaknessPanel.Visible = true;
                    int IndexWeakness = 0;
                    foreach (MonsterWeakness weakness in monster.MonsterWeakness)
                    {
                        WeaknessPictureBoxes.ElementAt(IndexWeakness).ElementAt(0).Image = Utilities.GetImage($"monster_weakness_{weakness.WeaknessName}");
                        int Level = 0;
                        while (Level < 3)
                        {
                            // Effect star
                            if (Level < weakness.Weakness)
                            {
                                WeaknessPictureBoxes.ElementAt(IndexWeakness).ElementAt(Level + 1).Image = Utilities.GetImage("ui_weakness_effect_star");
                            }
                            //No effect star
                            else
                            {
                                WeaknessPictureBoxes.ElementAt(IndexWeakness).ElementAt(Level + 1).Image = Utilities.GetImage("ui_weakness_no_effect_star");
                            }
                            Level++;
                        }
                        IndexWeakness++;
                    }
                }
                else
                {
                    WeaknessPanel.Visible = false;
                }

                // If there is Alt Weakness then show the Alt Weakness panel
                if (monster.MonsterAltWeakness.Count > 0)
                {
                    AltWeaknessPanel.Visible = true;
                    int IndexWeakness = 0;
                    foreach (MonsterWeakness weakness in monster.MonsterAltWeakness)
                    {
                        int Level = 0;
                        while (Level < 3)
                        {
                            //Effect star
                            if (Level < weakness.Weakness)
                            {
                                AltWeaknessPictureBoxes.ElementAt(IndexWeakness).ElementAt(Level).Image = Utilities.GetImage("ui_weakness_effect_star");
                            }
                            else
                            //No Effect star
                            {
                                AltWeaknessPictureBoxes.ElementAt(IndexWeakness).ElementAt(Level).Image = Utilities.GetImage("ui_weakness_no_effect_star");
                            }
                            Level++;
                        }
                        IndexWeakness++;
                    }
                    AltLabel.Visible = true;
                    AltLabel.Text = $"( )={monster.AltStateDescription}";
                }
                else
                {
                    AltWeaknessPanel.Visible = false;
                    AltLabel.Visible = false;
                }

                // No Weakness At all, change alt label to None
                if (monster.MonsterWeakness.Count + monster.MonsterAltWeakness.Count == 0)
                {
                    AltLabel.Text = Properties.String.MonsterAltNone;
                    AltLabel.Visible = true;
                }

                #endregion Weakness

                #region HitZone

                // Only Add Monster Hit Zone if there is
                if (monster.MonsterHitZones.Count > 0)
                {
                    if (!DamageTabControl.Contains(DamageElementTabPage))
                    {
                        DamageTabControl.TabPages.Insert(0, DamageElementTabPage);
                    }
                    // Clear Damage Element List View
                    DamageElementListView.Items.Clear();
                    List<ListViewItem> listViewItems = new List<ListViewItem>();
                    foreach (MonsterHitZone hitzone in monster.MonsterHitZones)
                    {
                        //https://www.akadia.com/services/dotnet_listview_sort_dataset.html
                        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.listview.ownerdraw?view=netframework-4.8
                        listViewItems.Add(new ListViewItem(new string[] {
                    hitzone.PartName,
                    ConvertIntToString(hitzone.Cut),
                    ConvertIntToString(hitzone.Impact),
                    ConvertIntToString(hitzone.Shot),
                    ConvertIntToString(hitzone.Fire),
                    ConvertIntToString(hitzone.Water),
                    ConvertIntToString(hitzone.Thunder),
                    ConvertIntToString(hitzone.Ice),
                    ConvertIntToString(hitzone.Dragon)
                }));
                    }
                    DamageElementListView.Items.AddRange(listViewItems.ToArray());
                }
                else
                {
                    if (DamageTabControl.Contains(DamageElementTabPage))
                    {
                        DamageTabControl.TabPages.Remove(DamageElementTabPage);
                    }
                }

                #endregion HitZone

                #region Breaks

                // Only Add Break Tab Page if there is
                if (monster.MonsterBreaks.Count > 0)
                {
                    if (!DamageTabControl.Contains(DamageBreakTabPage))
                    {
                        DamageTabControl.TabPages.Add(DamageBreakTabPage);
                    }
                    DamageBreaksListView.Items.Clear();
                    List<ListViewItem> listViewItems = new List<ListViewItem>();
                    foreach (MonsterBreak monsterBreak in monster.MonsterBreaks)
                    {
                        listViewItems.Add(new ListViewItem(new string[] {
                        monsterBreak.PartName,
                        ConvertIntToString(monsterBreak.Flinch),
                        ConvertIntToString(monsterBreak.Wound),
                        ConvertIntToString(monsterBreak.Sever),
                        monsterBreak.Extract
                    }));
                    }
                    DamageBreaksListView.Items.AddRange(listViewItems.ToArray());
                }
                else
                {
                    if (DamageTabControl.Contains(DamageBreakTabPage))
                    {
                        DamageTabControl.TabPages.Remove(DamageBreakTabPage);
                    }
                }

                #endregion Breaks

                #region Ailment

                if (monster.MonsterAilments.Count > 0)
                {
                    AilmentListBox.DataSource = monster.MonsterAilments;
                }
                else
                {
                    AilmentListBox.DataSource = new List<MonsterAilment>()
                    {
                        new MonsterAilment("None")
                    };
                }

                #endregion Ailment

                #region Obtain

                if (monster.MonsterRewards["HR"].Count > 0)
                {
                    if (!ObtainTabControl.Contains(ObtainHRTabPage))
                    {
                        ObtainTabControl.TabPages.Insert(0, ObtainHRTabPage);
                    }
                    ConfigObtainListView(ObtainHRListView, monster, imageList, "HR");
                }
                else
                {
                    if (ObtainTabControl.Contains(ObtainHRTabPage))
                    {
                        ObtainTabControl.TabPages.Remove(ObtainHRTabPage);
                    }
                }
                if (monster.MonsterRewards["LR"].Count > 0)
                {
                    if (!ObtainTabControl.Contains(ObtainLRTabPage))
                    {
                        ObtainTabControl.TabPages.Add(ObtainLRTabPage);
                    }
                    ConfigObtainListView(ObtainLRListView, monster, imageList, "LR");
                }
                else
                {
                    if (ObtainTabControl.Contains(ObtainLRTabPage))
                    {
                        ObtainTabControl.TabPages.Remove(ObtainLRTabPage);
                    }
                }

                #endregion Obtain
            }
        }

        private void ConfigObtainListView(ListView listView, Monster monster, ImageList imageList, string Rarity)
        {
            listView.Items.Clear();
            listView.SmallImageList = imageList;
            foreach (KeyValuePair<string, List<MonsterReward>> rewards in monster.MonsterRewards[Rarity])
            {
                ListViewGroup listViewGroup = new ListViewGroup(rewards.Key);
                listView.Groups.Add(listViewGroup);
                foreach (MonsterReward monsterReward in rewards.Value)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[]
                    {
                                $"{monsterReward.ItemName} x {monsterReward.Stack}"
                                ,$"{monsterReward.Percentage}%",
                                monsterReward.ItemID.ToString()
                    }, listViewGroup)
                    {
                        ImageKey = $"{monsterReward.IconName},{monsterReward.IconColor}"
                    };
                    // Only add image if there is not exist
                    if (!imageList.Images.ContainsKey($"{monsterReward.IconName},{monsterReward.IconColor}"))
                    {
                        Image IconImage = Utilities.GetImage($"item_{monsterReward.IconName}", Color.White, MonsterHunterColor.IconColor[monsterReward.IconColor], IconSize);
                        if (IconImage != null)
                        {
                            imageList.Images.Add($"{monsterReward.IconName},{monsterReward.IconColor}", IconImage);
                        }
                    }
                    listView.Items.Add(listViewItem);
                }
            }
        }

        /// <summary>
        /// This function will return the string of the number and replace 0 with -
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string ConvertIntToString(int num)
        {
            return num == 0 ? "-" : num.ToString();
        }

        private void MonsterSizeListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            MonsterListBox.DataSource = monsters.ElementAt(MonsterSizeListBox.SelectedIndex);
        }

        /// <summary>
        /// Function will be call when <see cref="MonsterListBox"/> change selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonsterListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayMonster(MonsterListBox.SelectedItem as Monster);
        }

        private void ListView_NoColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void ObtainListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.ShowItem(int.Parse(((ListView)sender).SelectedItems[0].SubItems[2].Text));
        }
    }
}