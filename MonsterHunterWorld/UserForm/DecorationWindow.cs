using MonsterHunterWorld.Class;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class DecorationWindow : UserControl
    {
        private static DecorationWindow _instance;

        public static DecorationWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DecorationWindow();
                }
                return _instance;
            }
        }

        private List<Decoration> DecorationList = DecorationSQL.GetDecorations();

        public DecorationWindow()
        {
            InitializeComponent();
            SetUpBasic();
            SetUpDecorationListBox();
        }

        private void SetUpBasic()
        {
            Item tempitem = ItemSQL.GetItem(Decoration.MysteriousFeystoneID);
            MysteriousFeystonePictureBox.Image = Utilities.GetImage($"item_{tempitem.IconName}", Color.White, MonsterHunterColor.IconColor[tempitem.IconColor]);
            ToolTip.SetToolTip(MysteriousFeystonePictureBox, tempitem.Name);
            tempitem = ItemSQL.GetItem(Decoration.GlowingFeystoneID);
            GlowingFeystonePictureBox.Image = Utilities.GetImage($"item_{tempitem.IconName}", Color.White, MonsterHunterColor.IconColor[tempitem.IconColor]);
            ToolTip.SetToolTip(GlowingFeystonePictureBox, tempitem.Name);
            tempitem = ItemSQL.GetItem(Decoration.WornFeystoneID);
            WornFeystonePictureBox.Image = Utilities.GetImage($"item_{tempitem.IconName}", Color.White, MonsterHunterColor.IconColor[tempitem.IconColor]);
            ToolTip.SetToolTip(WornFeystonePictureBox, tempitem.Name);
            tempitem = ItemSQL.GetItem(Decoration.WarpedFeystoneID);
            WarpedFeystonePictureBox.Image = Utilities.GetImage($"item_{tempitem.IconName}", Color.White, MonsterHunterColor.IconColor[tempitem.IconColor]);
            ToolTip.SetToolTip(WarpedFeystonePictureBox, tempitem.Name);
            SkillNameLabel.Text = Properties.String.DecorationSkill;
            DropRateLabel.Text = Properties.String.DecorationDropRate;
        }

        #region Decoration List Box

        private void SetUpDecorationListBox()
        {
            DecorationListBox.DataSource = DecorationList;
            DecorationListBox.DrawMode = DrawMode.OwnerDrawVariable;
            DecorationListBox.MeasureItem += new MeasureItemEventHandler(DecorationListBox_MeasureItem);
            DecorationListBox.DrawItem += new DrawItemEventHandler(DecorationListBox_DrawItem);
        }

        private void DecorationListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                // Otherwise, draw the rectangle filled in beige.
                e.Graphics.FillRectangle(new SolidBrush(DecorationListBox.BackColor), e.Bounds);
            }
            e.Graphics.DrawString((DecorationListBox.Items[e.Index] as Decoration).Name,
                DecorationListBox.Font, new SolidBrush(DecorationListBox.ForeColor), e.Bounds.X + 10, e.Bounds.Y + 10);
        }

        private void DecorationListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 45;
        }

        #endregion Decoration List Box

        private void DisplayDecoration(Decoration decoration)
        {
            if (decoration != null)
            {
                DecorationPictureBox.Image = Utilities.GetImage($"ui_decoration_{decoration.Slot}", Color.White, MonsterHunterColor.IconColor[decoration.IconColor]);
                DecorationNameLabel.Text = decoration.Name;
                SkillLabel.Text = decoration.SkillName;
                MysteriousFeystoneLabel.Text = decoration.MysteriousFeystonePercent == 0 ? "None" : decoration.MysteriousFeystonePercent.ToString("F3") + "%";
                GlowingFeystoneLabel.Text = decoration.GlowingFeystonePercent == 0 ? "None" : decoration.GlowingFeystonePercent.ToString("F3") + "%";
                WornFeystoneLabel.Text = decoration.WornFeystonePercent == 0 ? "None" : decoration.WornFeystonePercent.ToString("F3") + "%";
                WarpedFeystoneLabel.Text = decoration.WarpedFeystonePercent == 0 ? "None" : decoration.WarpedFeystonePercent.ToString("F3") + "%";
                SkillLevelPictureBox.Image = Utilities.GetSkillBar(decoration.MaxLevel, 1);
            }
        }

        private void DecorationListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayDecoration(DecorationListBox.SelectedItem as Decoration);
        }

        private void SkillLabel_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.ShowSkill((DecorationListBox.SelectedItem as Decoration).SkillTreeID);
        }
    }
}