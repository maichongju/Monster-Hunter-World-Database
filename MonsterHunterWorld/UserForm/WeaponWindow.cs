using MonsterHunterWorld.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class WeaponWindow : UserControl
    {
        private static WeaponWindow _instance;

        public static WeaponWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WeaponWindow();
                }
                return _instance;
            }
        }

        private readonly static List<NavigateItem> WeaponTypeList = new List<NavigateItem>()
        {
             new NavigateItem("great-sword",Properties.String.WeaponTypeGreatSword),
             new NavigateItem("long-sword",Properties.String.WeaponTypeLongSword),
             new NavigateItem("sword-and-shield",Properties.String.WeaponTypeSwordAndShield),
             new NavigateItem("dual-blades",Properties.String.WeaponTypeDualBlades),
             new NavigateItem("hammer",Properties.String.WeaponTypeHammer),
             new NavigateItem("hunting-horn",Properties.String.WeaponTypeHuntingHorn),
             new NavigateItem("lance",Properties.String.WeaponTypeLance),
             new NavigateItem("gunlance",Properties.String.WeaponTypeGunlance),
             new NavigateItem("switch-axe",Properties.String.WeaponTypeSwitchAxe),
             new NavigateItem("charge-blade",Properties.String.WeaponTypeChargeBlade),
             new NavigateItem("insect-glaive",Properties.String.WeaponTypeInsectGlaive),
             new NavigateItem("light-bowgun",Properties.String.WeaponTypeLightBowgun),
             new NavigateItem("heavy-bowgun",Properties.String.WeaponTypeHeavyBowgun),
             new NavigateItem("bow",Properties.String.WeaponTypeBow)
        };

        private readonly string WeaponIconPrefix = "weapon_";
        private readonly string WeaponElementImageKeyPrefix = "weapon_element_";
        private List<List<Weapon>> WeaponList = new List<List<Weapon>>();

        //Get Weapon Melodies
        private List<WeaponMelody> WeaponMelodies = WeaponSQL.GetMelodies();

        //Get Weapon Ammos
        private List<WeaponAmmo> WeaponAmmos = WeaponSQL.GetAmmos();

        // Act as a Image Cache
        private Dictionary<string, Image> ImageDictionary = new Dictionary<string, Image>();

        private Size CraftIconSize = new Size(35, 35);
        private readonly static Color ListBackgroundColor = Color.White;
        private readonly static Color ListSelectedColor = Color.FromArgb(209, 223, 250);

        public WeaponWindow()
        {
            InitializeComponent();
            SetUpUI();
            SetUpWeaponTypeListBox();
            SetUpWeaponListBox();
            SetUpSpecialListBox();
            SetUpCraftUpgradeListBox();
            SetUpCraftCreateListBox();
        }

        private void SetUpUI()
        {
            AttackPictureBox.BackgroundImage = Utilities.GetImage("weapon_attack");
            AttackTruePictureBox.BackgroundImage = Utilities.GetImage("weapon_attack");
            AffinityPictureBox.BackgroundImage = Utilities.GetImage("weapon_affinity");
            ElementPictureBox.BackgroundImage = Utilities.GetImage("weapon_element");
            SlotsPictureBox.BackgroundImage = Utilities.GetImage("weapon_slots");
            EldersealPictureBox.BackgroundImage = Utilities.GetImage("weapon_elderseal");
            DefensePictureBox.BackgroundImage = Utilities.GetImage("ui_defense");
            SharpnessPictureBox.BackgroundImage = Utilities.GetImage("weapon_sharpness");
            SkillLabel.Cursor = Cursors.Hand;
        }

        #region Weapon Type List Box

        private void SetUpWeaponTypeListBox()
        {
            foreach (NavigateItem item in WeaponTypeList)
            {
                WeaponList.Add(WeaponSQL.GetWeapons(item.Key));
            }
            WeaponTypeListBox.DataSource = WeaponTypeList;
            WeaponTypeListBox.DrawMode = DrawMode.OwnerDrawVariable;
            WeaponTypeListBox.MeasureItem += new MeasureItemEventHandler(WeaponTypeListBox_MeasureItem);
            WeaponTypeListBox.DrawItem += new DrawItemEventHandler(WeaponTypeListBox_DrawItem);
        }

        private void WeaponTypeListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // If the item is the selected item, then draw the rectangle
            // filled in blue. The item is selected when a bitwise And
            // of the State property and the DrawItemState.Selected
            // property is true.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                Rectangle Indicator = new Rectangle(e.Bounds.X, e.Bounds.Y + 13, e.Bounds.Width / 25, 25);
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, Indicator);
            }
            else
            {
                // Otherwise, draw the rectangle filled in beige.
                e.Graphics.FillRectangle(new SolidBrush(WeaponTypeListBox.BackColor), e.Bounds);
            }
            Size IconSize = new Size(32, 32);
            string IconPath = Properties.Resources.ResourceManager.GetString(WeaponIconPrefix
                + (WeaponTypeListBox.Items[e.Index] as NavigateItem).Key.Replace('-', '_'));
            Image IconImage = Utilities.GetImageFromSVG(IconPath, IconSize);
            e.Graphics.DrawImage(IconImage, e.Bounds.X + 20, e.Bounds.Y + 10);
            e.Graphics.DrawString((WeaponTypeListBox.Items[e.Index] as NavigateItem).Value,
                WeaponTypeListBox.Font, Brushes.White, e.Bounds.X + 65, e.Bounds.Y + 13);
        }

        private void WeaponTypeListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 50;
        }

        #endregion Weapon Type List Box

        #region Weapon List Box

        private void SetUpWeaponListBox()
        {
            WeaponListBox.DrawMode = DrawMode.OwnerDrawVariable;
            WeaponListBox.DrawItem += new DrawItemEventHandler(WeaponListBox_DrawItem);
            WeaponListBox.MeasureItem += new MeasureItemEventHandler(WeaponListBox_MeasureItem);
        }

        private void WeaponListBox_DrawItem(object sender, DrawItemEventArgs e)
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
                e.Graphics.FillRectangle(new SolidBrush(WeaponListBox.BackColor), e.Bounds);
            }
            e.Graphics.DrawString((WeaponListBox.Items[e.Index] as Weapon).Name,
                WeaponListBox.Font, Brushes.White, e.Bounds.X + 5, e.Bounds.Y + 10);
        }

        private void WeaponListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        #endregion Weapon List Box

        #region Special List Box

        private void SetUpSpecialListBox()
        {
            SpecialListBox.DrawMode = DrawMode.OwnerDrawVariable;
            SpecialListBox.DrawItem += new DrawItemEventHandler(SpecialListBox_DrawItem);
            SpecialListBox.MeasureItem += new MeasureItemEventHandler(SpecialListBox_MeasureItem);
        }

        private void SpecialListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            if ((WeaponTypeListBox.SelectedItem as NavigateItem).Key == "hunting-horn")
            {
                #region For Hunting Horn

                WeaponMelody CurrentMelody = ((WeaponMelody)SpecialListBox.Items[e.Index]);
                string WeaponNotes = ((Weapon)WeaponListBox.SelectedItem).Notes;
                string Notes = CurrentMelody.Notes;
                int ImageDrawX = 5;
                int ImageDrawY = 5;
                foreach (char note in Notes)
                {
                    Image MelodyImage = Utilities.GetImage($"weapon_note_{WeaponNotes.IndexOf(note) + 1}", note, new Size(30, 30));
                    e.Graphics.DrawImage(MelodyImage, e.Bounds.X + ImageDrawX, e.Bounds.Y + ImageDrawY);
                    ImageDrawX += 30;
                }
                e.Graphics.DrawString($"{CurrentMelody.Effect1}", SpecialListBox.Font,
                    new SolidBrush(SpecialListBox.ForeColor), e.Bounds.X + 5, e.Bounds.Y + 40);
                e.Graphics.DrawString($"{CurrentMelody.Effect2}", SpecialListBox.Font,
                    new SolidBrush(SpecialListBox.ForeColor), e.Bounds.X + 5, e.Bounds.Y + 60);

                e.Graphics.DrawString(String.Format("{0,10}{1}{2,15}", CurrentMelody.Duration, new String(' ', 35), $"{CurrentMelody.Extension}")
                    , SpecialListBox.Font,
                    new SolidBrush(SpecialListBox.ForeColor), e.Bounds.X + 250, e.Bounds.Y + 15);
                e.Graphics.DrawLine(new Pen(Color.DarkGray, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash },
                                    new Point(e.Bounds.X, e.Bounds.Y + e.Bounds.Height - 2),
                                    new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height - 2));

                #endregion For Hunting Horn
            }
            else if ((WeaponTypeListBox.SelectedItem as NavigateItem).Key.Contains("bowgun"))
            {
                #region For Bow Gun

                Ammo ammo = (Ammo)SpecialListBox.Items[e.Index];
                Size IconSize = new Size(25, 25);
                Item ammoItem = ItemSQL.GetItem(ammo.ItemID);
                Image IconImage = Utilities.GetImage($"item_{ammoItem.IconName}", Color.White, MonsterHunterColor.IconColor[ammoItem.IconColor], IconSize);
                int OffsetY = 6;
                // Because somehow string format is not working
                e.Graphics.DrawImage(IconImage, e.Bounds.X + 5, e.Bounds.Y);
                e.Graphics.DrawString(ammo.AmmoName, SpecialListBox.Font, new SolidBrush(SpecialListBox.ForeColor), e.Bounds.X + 35, e.Bounds.Y + OffsetY);
                e.Graphics.DrawString(ammo.AmmoClip.ToString(), SpecialListBox.Font, new SolidBrush(SpecialListBox.ForeColor), e.Bounds.X + 180, e.Bounds.Y + OffsetY);
                e.Graphics.DrawString(String.Format("{0} - {1}", ammo.AmmoRapid ? Properties.String.AmmoRapidTrue : Properties.String.AmmoRapidFalse, ammo.AmmoRecoil)
                    , SpecialListBox.Font, new SolidBrush(SpecialListBox.ForeColor), e.Bounds.X + 280, e.Bounds.Y + OffsetY);
                e.Graphics.DrawString(ammo.AmmoReload.ToString(), SpecialListBox.Font, new SolidBrush(SpecialListBox.ForeColor), e.Bounds.X + 450, e.Bounds.Y + OffsetY);
                e.Graphics.DrawLine(new Pen(Color.DarkGray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash },
                     new Point(e.Bounds.X, e.Bounds.Y + e.Bounds.Height - 1),
                     new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height - 1));

                #endregion For Bow Gun
            }
        }

        private void SpecialListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if ((WeaponTypeListBox.SelectedItem as NavigateItem).Key == "hunting-horn")
            {
                e.ItemHeight = 90;
            }
            else if ((WeaponTypeListBox.SelectedItem as NavigateItem).Key.Contains("bowgun"))
            {
                e.ItemHeight = 30;
            }
        }

        #endregion Special List Box

        #region Craft Upgrade List Box

        private void SetUpCraftUpgradeListBox()
        {
            CraftUpgradeListBox.DrawMode = DrawMode.OwnerDrawVariable;
            CraftUpgradeListBox.DrawItem += new DrawItemEventHandler(CraftUpgradeListBox_DrawItem);
            CraftUpgradeListBox.MeasureItem += new MeasureItemEventHandler(CraftUpgradeListBox_MeasureItem);
        }

        private void CraftUpgradeListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                //Shape for the List Item background
                Rectangle BackgroundRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 5, e.Bounds.Width - 15, e.Bounds.Height - 5);
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
                CraftItem CurrentItem = CraftUpgradeListBox.Items[e.Index] as CraftItem;
                Image IconIamge = Utilities.GetImage($"item_{CurrentItem.IconName}", Color.White, MonsterHunterColor.IconColor[CurrentItem.IconColor], CraftIconSize);
                e.Graphics.DrawImage(IconIamge, e.Bounds.X + 5, e.Bounds.Y + 5);
                e.Graphics.DrawString($"{CurrentItem.ItemName} x {CurrentItem.Quantity}", CraftCreateListBox.Font, new SolidBrush(CraftCreateListBox.ForeColor), e.Bounds.X + 40, e.Bounds.Y + 17);
            }
        }

        private void CraftUpgradeListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        #endregion Craft Upgrade List Box

        #region Craft Create List Box

        private void SetUpCraftCreateListBox()
        {
            CraftCreateListBox.DrawMode = DrawMode.OwnerDrawVariable;
            CraftCreateListBox.DrawItem += new DrawItemEventHandler(CraftCreateListBox_DrawItem);
            CraftCreateListBox.MeasureItem += new MeasureItemEventHandler(CraftCreateListBox_MeasureItem);
        }

        private void CraftCreateListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                //Shape for the List Item background
                Rectangle BackgroundRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 5, e.Bounds.Width - 15, e.Bounds.Height - 5);
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
                CraftItem CurrentItem = CraftCreateListBox.Items[e.Index] as CraftItem;
                Image IconIamge = Utilities.GetImage($"item_{CurrentItem.IconName}", Color.White, MonsterHunterColor.IconColor[CurrentItem.IconColor], CraftIconSize);
                e.Graphics.DrawImage(IconIamge, e.Bounds.X + 5, e.Bounds.Y + 5);
                e.Graphics.DrawString($"{CurrentItem.ItemName} x {CurrentItem.Quantity}", CraftCreateListBox.Font, new SolidBrush(CraftCreateListBox.ForeColor), e.Bounds.X + 40, e.Bounds.Y + 17);
            }
        }

        private void CraftCreateListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        #endregion Craft Create List Box

        private void DisplayWeapon(Weapon weapon)
        {
            if (weapon != null)
            {
                //Try to change Rarity number color
                try
                {
                    RarityLabel.ForeColor = MonsterHunterColor.RarityColor[weapon.Rarity - 1];
                }
                catch (IndexOutOfRangeException)
                {
                    LogWritter.Instance.Write($"Weapon ({weapon.WeaponID}) Rarity Invalid"
                        , LogCategory.Error);
                }
                RarityLabel.Text = weapon.Rarity.ToString();
                WeaponNameLabel.Text = weapon.Name;
                AttackLabel.Text = weapon.Attack.ToString();
                AttackTrueLabel.Text = weapon.AttackTrue.ToString();
                AffinityLabel.Text = weapon.Affinity.ToString() + "%";
                EldersealLabel.Text = WeaponElderSeal.GetWeaponElderSeal(weapon.ElderSeal).ToString();
                DefenseLabel.Text = weapon.Defense.ToString();
                if (weapon.Sharpness != null)
                {
                    if (weapon.SharpnessImage == null)
                    {
                        weapon.SharpnessImage = GetSharpnessImage(weapon.Sharpness, weapon.SharpnessMaxed);
                    }
                    SharpnessBarPictureBox.BackgroundImage = weapon.SharpnessImage;
                }
                else
                {
                    SharpnessBarPictureBox.BackgroundImage = null;
                }
                if (weapon.SkillName == null)
                {
                    WeaponSkillPanel.Visible = false;
                }
                else
                {
                    WeaponSkillPanel.Visible = true;
                    SkillPictureBox.BackgroundImage = Utilities.GetImage("ui_armor_skill", Color.White, MonsterHunterColor.IconColor[weapon.SkillIconColor]);
                    SkillLabel.Text = weapon.SkillName;
                    SkillLevelLabel.Text = $"LV{weapon.SkillLevel}";
                    SkillLevelPictureBox.Image = Utilities.GetSkillBar(weapon.SkillMaxLevel, weapon.SkillLevel);
                }

                #region Weapon Element

                if (weapon.Element1 != null)
                {
                    Element1Label.Text = weapon.ElementHidden ? $"({weapon.Element1Attack})" : weapon.Element1Attack.ToString();
                    Element1PictureBox.BackgroundImage = Utilities.GetImage($"{WeaponElementImageKeyPrefix}{weapon.Element1.ToLower()}");
                    ToolTip.SetToolTip(Element1PictureBox, weapon.Element1);
                    ToolTip.SetToolTip(Element1Label, weapon.ElementHidden ? Properties.String.WeaponElementHidden : null);
                    if (weapon.Element2 != null)
                    {
                        Element2Label.Text = weapon.ElementHidden ? $"({weapon.Element2Attack})" : weapon.Element2Attack.ToString();
                        Element2PictureBox.BackgroundImage = Utilities.GetImage($"{WeaponElementImageKeyPrefix}{weapon.Element2.ToLower()}");
                        ToolTip.SetToolTip(Element2Label, weapon.ElementHidden ? Properties.String.WeaponElementHidden : null);
                        ToolTip.SetToolTip(Element2PictureBox, weapon.Element2);
                    }
                    else
                    {
                        Element2Label.Text = "";
                        Element2PictureBox.BackgroundImage = null;
                        ToolTip.SetToolTip(Element2PictureBox, null);
                        ToolTip.SetToolTip(Element2Label, null);
                    }
                }
                else
                {
                    Element1Label.Text = "-";
                    Element1PictureBox.BackgroundImage = null;
                    ToolTip.SetToolTip(Element1PictureBox, null);
                    Element2Label.Text = "";
                    Element2PictureBox.BackgroundImage = null;
                    ToolTip.SetToolTip(Element1Label, null);
                    ToolTip.SetToolTip(Element2Label, null);
                }

                #endregion Weapon Element

                #region Weapon Slots

                string SlotPrefix = "ui_slot_empty_";
                Slot1PictureBox.BackgroundImage = Utilities.GetImage($"{SlotPrefix}{weapon.Slot1}");
                Slot2PictureBox.BackgroundImage = Utilities.GetImage($"{SlotPrefix}{weapon.Slot2}");
                Slot3PictureBox.BackgroundImage = Utilities.GetImage($"{SlotPrefix}{weapon.Slot3}");

                #endregion Weapon Slots

                #region Special Area

                //Bowgun
                if ((WeaponTypeListBox.SelectedItem as NavigateItem).Key.Contains("bowgun"))
                {
                    NotePanel.Visible = false;
                    SpecialListBox.Visible = true;
                    MelodyPanel.Visible = false;
                    AmmoPanel.Visible = true;
                    WeaponAmmo weaponAmmo = GetWeaponAmmo(weapon.AmmoID);
                    CoatingsPanel.Visible = false;
                    SpecialListBox.DataSource = weaponAmmo.Ammos;
                    SpecialLabel.Visible = true;
                    SpecialLabel.Text = weaponAmmo.SpecialAmmo.ToString();
                    SpecialNameLabel.Visible = true;
                    SpecialNameLabel.Text = Properties.String.WeaponSpecialAmmo;
                    SpecialPictureBox.BackgroundImage = Utilities.GetImage("weapon_special_ammo");
                    DeviationPanel.Visible = true;
                    DeviationLabel.Text = weaponAmmo.Deviation.ToString();
                    DeviationPictureBox.BackgroundImage = Utilities.GetImage("weapon_deviation");
                }
                //Hunting Horn
                else if ((WeaponTypeListBox.SelectedItem as NavigateItem).Key == "hunting-horn")
                {
                    NotePanel.Visible = true;
                    SpecialLabel.Visible = false;
                    DeviationPanel.Visible = false;
                    SpecialListBox.Visible = true;
                    MelodyPanel.Visible = true;
                    AmmoPanel.Visible = false;
                    CoatingsPanel.Visible = false;
                    SpecialNameLabel.Visible = true;
                    SpecialNameLabel.Text = Properties.String.WeaponNotes;
                    SpecialPictureBox.BackgroundImage = Utilities.GetImage("weapon_notes");
                    SpecialListBox.DataSource = GetWeaponMelodies(weapon.Notes);

                    Note1PictureBox.BackgroundImage = Utilities.GetImage("weapon_note_1", weapon.Notes[0], Note1PictureBox.Size);
                    Note2PictureBox.BackgroundImage = Utilities.GetImage("weapon_note_2", weapon.Notes[1], Note2PictureBox.Size);
                    Note3PictureBox.BackgroundImage = Utilities.GetImage("weapon_note_3", weapon.Notes[2], Note3PictureBox.Size);
                }
                //Bow
                else if ((WeaponTypeListBox.SelectedItem as NavigateItem).Key == "bow")
                {
                    //Basic Setup
                    CoatingsPanel.Visible = true;
                    SpecialLabel.Visible = false;
                    SpecialNameLabel.Visible = true;
                    SpecialNameLabel.Text = Properties.String.WeaponBowCostings;
                    SpecialPictureBox.BackgroundImage = null;
                    SpecialListBox.Visible = false;
                    NotePanel.Visible = false;
                    MelodyPanel.Visible = false;
                    AmmoPanel.Visible = false;
                    DeviationPanel.Visible = false;
                    //Set up Coatings Image
                    Image Empty = null;
                    if (weapon.CoatingClose)
                    {
                        Item AmmoItem = GetItem(ItemSQL.CoatingPower);
                        Image IconImage = Utilities.GetImage($"item_{AmmoItem.IconName}");
                        ToolTip.SetToolTip(ClosePictureBox, Properties.String.WeaponBowCostingsClose);
                        ClosePictureBox.BackgroundImage = IconImage;
                    }
                    else
                    {
                        ClosePictureBox.BackgroundImage = Empty;
                        ToolTip.SetToolTip(ClosePictureBox, null);
                    }
                    if (weapon.CoatingPower)
                    {
                        Item AmmoItem = GetItem(ItemSQL.CoatingPower);
                        Image IconImage = Utilities.GetImage($"item_{AmmoItem.IconName}", Color.White, MonsterHunterColor.IconColor[AmmoItem.IconColor]);
                        ToolTip.SetToolTip(PowerPictureBox, AmmoItem.Name);
                        PowerPictureBox.BackgroundImage = IconImage;
                    }
                    else
                    {
                        PowerPictureBox.BackgroundImage = Empty;
                        ToolTip.SetToolTip(PowerPictureBox, null);
                    }
                    if (weapon.CoatingParalysis)
                    {
                        Item AmmoItem = GetItem(ItemSQL.CoatingParalysis);
                        Image IconImage = Utilities.GetImage($"item_{AmmoItem.IconName}", Color.White, MonsterHunterColor.IconColor[AmmoItem.IconColor]);
                        ToolTip.SetToolTip(ParaPictureBox, AmmoItem.Name);
                        ParaPictureBox.BackgroundImage = IconImage;
                    }
                    else
                    {
                        ToolTip.SetToolTip(ParaPictureBox, null);
                        ParaPictureBox.BackgroundImage = Empty;
                    }
                    if (weapon.CoatingPoison)
                    {
                        Item AmmoItem = GetItem(ItemSQL.CoatingPoison);
                        Image IconImage = Utilities.GetImage($"item_{AmmoItem.IconName}", Color.White, MonsterHunterColor.IconColor[AmmoItem.IconColor]);
                        ToolTip.SetToolTip(PoisonPictureBox, AmmoItem.Name);
                        PoisonPictureBox.BackgroundImage = IconImage;
                    }
                    else
                    {
                        ToolTip.SetToolTip(PoisonPictureBox, null);
                        PoisonPictureBox.BackgroundImage = Empty;
                    }
                    if (weapon.CoatingSleep)
                    {
                        Item AmmoItem = GetItem(ItemSQL.CoatingSleep);
                        Image IconImage = Utilities.GetImage($"item_{AmmoItem.IconName}", Color.White, MonsterHunterColor.IconColor[AmmoItem.IconColor]);
                        ToolTip.SetToolTip(SleepPictureBox, AmmoItem.Name);
                        SleepPictureBox.BackgroundImage = IconImage;
                    }
                    else
                    {
                        ToolTip.SetToolTip(SleepPictureBox, null);
                        SleepPictureBox.BackgroundImage = Empty;
                    }
                    if (weapon.CoatingBlast)
                    {
                        Item AmmoItem = GetItem(ItemSQL.CoatingBlast);
                        Image IconImage = Utilities.GetImage($"item_{AmmoItem.IconName}", Color.White, MonsterHunterColor.IconColor[AmmoItem.IconColor]);
                        ToolTip.SetToolTip(BlastPictureBox, AmmoItem.Name);
                        BlastPictureBox.BackgroundImage = IconImage;
                    }
                    else
                    {
                        ToolTip.SetToolTip(BlastPictureBox, null);
                        BlastPictureBox.BackgroundImage = Empty;
                    }
                }
                else
                {
                    //Disable all the component don't need it
                    CoatingsPanel.Visible = false;
                    NotePanel.Visible = false;
                    SpecialPictureBox.BackgroundImage = null;
                    SpecialLabel.Visible = false;
                    SpecialNameLabel.Visible = false;
                    DeviationPanel.Visible = false;
                    SpecialLabel.Visible = true;
                    SpecialListBox.Visible = false;
                    SpecialLabel.Visible = false;
                    MelodyPanel.Visible = false;
                    AmmoPanel.Visible = false;
                    SpecialPictureBox.BackgroundImage = null;
                }

                #endregion Special Area

                #region Craft Area

                if (weapon.ItemName == null)
                {
                    CraftPanel.Visible = false;
                }
                else
                {
                    CraftPanel.Visible = true;
                    if (weapon.CraftCreateList.Count == 0)
                    {
                        CraftCreateTabPage.Parent = null;
                    }
                    else
                    {
                        CraftCreateListBox.DataSource = weapon.CraftCreateList;

                        if (!CraftTabControl.Contains(CraftCreateTabPage))
                        {
                            CraftTabControl.TabPages.Insert(0, CraftCreateTabPage);
                        }
                    }
                    if (weapon.CraftUpgradeList.Count == 0)
                    {
                        CraftUpgradeTabPage.Parent = null;
                    }
                    else
                    {
                        CraftUpgradeListBox.DataSource = weapon.CraftUpgradeList;

                        if (!CraftTabControl.Contains(CraftUpgradeTabPage))
                        {
                            CraftTabControl.TabPages.Insert(CraftTabControl.TabCount == 1 ? 1 : 0, CraftUpgradeTabPage);
                        }
                    }
                    CraftUpgradeListBox.SelectedItem = null;
                    CraftCreateListBox.SelectedItem = null;
                }

                #endregion Craft Area
            }
        }

        /// <summary>
        /// Get the bitmap that represent the sharpness
        /// </summary>
        /// <param name="Sharpness"></param>
        /// <param name="SharpnessMax"></param>
        /// <returns>The Image of the element</returns>
        private Bitmap GetSharpnessImage(string Sharpness, bool SharpnessMax)
        {
            int SharpnessWidht = SharpnessMax ? 400 : 450;
            int SharpnessHeight = 40;
            int DrawStartX = 10;
            int DrawStartY = 5;
            Bitmap bm = new Bitmap(SharpnessWidht + DrawStartX * 2, SharpnessHeight);
            SharpnessHeight -= DrawStartY * 2;
            using (Graphics g = Graphics.FromImage(bm))
            {
                // Fill Background
                g.FillRectangle(new SolidBrush(MonsterHunterColor.SNone), new Rectangle(new Point(0, 0), bm.Size));
                int[] SharpnessArray = Sharpness.Split(',').Select(Int32.Parse).ToArray();
                int ColorIndex = 0;
                foreach (int data in SharpnessArray)
                {
                    if (data > 0)
                    {
                        Rectangle DrawRect = new Rectangle(DrawStartX, DrawStartY, data, SharpnessHeight);
                        g.FillRectangle(new SolidBrush(MonsterHunterColor.SharpnessColor[ColorIndex]), DrawRect);
                        DrawStartX += data;
                        ColorIndex++;
                    }
                }
            }
            return bm;
        }

        /// <summary>
        /// Get the item for with the ItemID, if the item can be found in the cache
        /// then it will return the item that found in the cache, otherwise it will
        /// get the Item from database and store into the cache.
        /// </summary>
        /// <param name="ItemID">Item ID for the item</param>
        /// <returns>Item Object for the given Item ID</returns>
        private Item GetItem(int ItemID)
        {
            Item item = null;
            string CacheKey = $"item_{ItemID}";
            ObjectCache cache = MemoryCache.Default;
            if (cache.Contains(CacheKey))
            {
                item = (Item)cache.Get(CacheKey);
            }
            else
            {
                item = ItemSQL.GetItem(ItemID);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(5.0)
                };
                cache.Add(CacheKey, item, cacheItemPolicy);
            }
            return item;
        }

        /// <summary>
        /// Get the List of <class>WeaponMelody</class> for the given Notes
        /// </summary>
        /// <param name="Melody"></param>
        /// <returns></returns>
        private List<WeaponMelody> GetWeaponMelodies(string Melody)
        {
            List<WeaponMelody> melodies = new List<WeaponMelody>();
            string CacheKey = $"WeaponMelody_{Melody}";
            ObjectCache cache = MemoryCache.Default;
            if (cache.Contains(CacheKey))
            {
                melodies = (List<WeaponMelody>)cache.Get(CacheKey);
            }
            else
            {
                //Search the Weapon Melody and add the correct one
                foreach (WeaponMelody melody in WeaponMelodies)
                {
                    bool AddMelody = true;
                    foreach (char word in melody.Notes)
                    {
                        if (!Melody.Contains(word)) { AddMelody = false; break; }
                    }
                    if (AddMelody)
                    {
                        melodies.Add(melody);
                    }
                }
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(30.0)
                };
                cache.Add(CacheKey, melodies, cacheItemPolicy);
            }
            return melodies;
        }

        /// <summary>
        /// Get the <class>WeaponAmmo</class> for the given AmmoID, if no AmmoID find
        /// it will return null
        /// </summary>
        /// <param name="AmmoID"></param>
        /// <returns></returns>
        private WeaponAmmo GetWeaponAmmo(int AmmoID)
        {
            foreach (WeaponAmmo ammo in WeaponAmmos)
            {
                if (ammo.AmmoID == AmmoID)
                {
                    return ammo;
                }
            }
            return null;
        }

        /// <summary>
        /// Function When index change, it will also change the source of the Weapon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeaponTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponListBox.DataSource = WeaponList[WeaponTypeListBox.SelectedIndex];
        }

        private void WeaponListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayWeapon(WeaponListBox.SelectedItem as Weapon);
        }

        private void CraftListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.ShowItem(CraftTabControl.SelectedTab.Text == "Upgrade" ?
                (CraftUpgradeListBox.SelectedItem as CraftItem).ItemID :
                 (CraftCreateListBox.SelectedItem as CraftItem).ItemID
                );
        }

        private void WeaponWindow_MouseClick(object sender, MouseEventArgs e)
        {
            CraftUpgradeListBox.SelectedItem = null;
            CraftCreateListBox.SelectedItem = null;
        }

        private void SkillLabel_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.ShowSkill((WeaponListBox.SelectedItem as Weapon).SkillID);
        }
    }
}