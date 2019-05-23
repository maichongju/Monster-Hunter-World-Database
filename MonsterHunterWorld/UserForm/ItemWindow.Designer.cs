namespace MonsterHunterWorld.UserForm
{
    partial class ItemWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemWindow));
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.DebugButton = new System.Windows.Forms.Button();
            this.DebugTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.RarityNameLabel = new System.Windows.Forms.Label();
            this.BuyPriceNameLabel = new System.Windows.Forms.Label();
            this.SellPriceNameLabel = new System.Windows.Forms.Label();
            this.CarryLimitNameLabel = new System.Windows.Forms.Label();
            this.RarityLabel = new System.Windows.Forms.Label();
            this.BuyPriceLabel = new System.Windows.Forms.Label();
            this.SellPriceLabel = new System.Windows.Forms.Label();
            this.CarryLimitLabel = new System.Windows.Forms.Label();
            this.BuyPricePictureBox = new System.Windows.Forms.PictureBox();
            this.SellPricePictureBox = new System.Windows.Forms.PictureBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ObtainNameLabel = new System.Windows.Forms.Label();
            this.ObtainPanel1 = new System.Windows.Forms.Panel();
            this.ObtainPanel1ResultLabel = new System.Windows.Forms.Label();
            this.ObtainPanel1EqualLabel = new System.Windows.Forms.Label();
            this.ObtainPanel1PlusLabel = new System.Windows.Forms.Label();
            this.ObtainPanel1ResultItemPictureBox = new System.Windows.Forms.PictureBox();
            this.ObtainPanel1FirstItemPictureBox = new System.Windows.Forms.PictureBox();
            this.ObtainPanel1SecondItemPictureBox = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ObtainPanel2 = new System.Windows.Forms.Panel();
            this.ObtainPanel2ResultLabel = new System.Windows.Forms.Label();
            this.ObtainPanel2EqualLabel = new System.Windows.Forms.Label();
            this.ObtainPanel2PlusLabel = new System.Windows.Forms.Label();
            this.ObtainPanel2ResultItemPictureBox = new System.Windows.Forms.PictureBox();
            this.ObtainPanel2FirstItemPictureBox = new System.Windows.Forms.PictureBox();
            this.ObtainPanel2SecondItemPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryPanel.SuspendLayout();
            this.ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPricePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellPricePictureBox)).BeginInit();
            this.ObtainPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel1ResultItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel1FirstItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel1SecondItemPictureBox)).BeginInit();
            this.ObtainPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel2ResultItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel2FirstItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel2SecondItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.CategoryPanel.Controls.Add(this.CategoryListBox);
            this.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoryPanel.Location = new System.Drawing.Point(0, 0);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(163, 750);
            this.CategoryPanel.TabIndex = 2;
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.CategoryListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CategoryListBox.ForeColor = System.Drawing.Color.White;
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 25;
            this.CategoryListBox.Location = new System.Drawing.Point(0, 223);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(188, 275);
            this.CategoryListBox.TabIndex = 0;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            this.CategoryListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CategoryListBox_MouseDown);
            this.CategoryListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CategoryListBox_MouseUp);
            // 
            // ItemPanel
            // 
            this.ItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.ItemPanel.Controls.Add(this.ItemListBox);
            this.ItemPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemPanel.Location = new System.Drawing.Point(163, 0);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(249, 750);
            this.ItemPanel.TabIndex = 3;
            // 
            // ItemListBox
            // 
            this.ItemListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.ItemListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemListBox.ForeColor = System.Drawing.Color.White;
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 24;
            this.ItemListBox.Location = new System.Drawing.Point(0, 14);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(272, 720);
            this.ItemListBox.TabIndex = 0;
            this.ItemListBox.SelectedIndexChanged += new System.EventHandler(this.ItemListBox_SelectedIndexChanged);
            // 
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(1045, 3);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(52, 20);
            this.DebugButton.TabIndex = 1;
            this.DebugButton.Text = "Debug";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Visible = false;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.BackColor = System.Drawing.Color.White;
            this.DebugTextBox.Location = new System.Drawing.Point(960, 3);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.Size = new System.Drawing.Size(79, 20);
            this.DebugTextBox.TabIndex = 0;
            this.DebugTextBox.Visible = false;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(421, 100);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(679, 61);
            this.ItemNameLabel.TabIndex = 5;
            this.ItemNameLabel.Text = "Item Name";
            this.ItemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RarityNameLabel
            // 
            this.RarityNameLabel.AutoSize = true;
            this.RarityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RarityNameLabel.Location = new System.Drawing.Point(504, 241);
            this.RarityNameLabel.Name = "RarityNameLabel";
            this.RarityNameLabel.Size = new System.Drawing.Size(61, 25);
            this.RarityNameLabel.TabIndex = 6;
            this.RarityNameLabel.Text = "Rarity";
            // 
            // BuyPriceNameLabel
            // 
            this.BuyPriceNameLabel.AutoSize = true;
            this.BuyPriceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyPriceNameLabel.Location = new System.Drawing.Point(504, 283);
            this.BuyPriceNameLabel.Name = "BuyPriceNameLabel";
            this.BuyPriceNameLabel.Size = new System.Drawing.Size(95, 25);
            this.BuyPriceNameLabel.TabIndex = 7;
            this.BuyPriceNameLabel.Text = "Buy Price";
            // 
            // SellPriceNameLabel
            // 
            this.SellPriceNameLabel.AutoSize = true;
            this.SellPriceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceNameLabel.Location = new System.Drawing.Point(504, 327);
            this.SellPriceNameLabel.Name = "SellPriceNameLabel";
            this.SellPriceNameLabel.Size = new System.Drawing.Size(94, 25);
            this.SellPriceNameLabel.TabIndex = 8;
            this.SellPriceNameLabel.Text = "Sell Price";
            // 
            // CarryLimitNameLabel
            // 
            this.CarryLimitNameLabel.AutoSize = true;
            this.CarryLimitNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarryLimitNameLabel.Location = new System.Drawing.Point(504, 371);
            this.CarryLimitNameLabel.Name = "CarryLimitNameLabel";
            this.CarryLimitNameLabel.Size = new System.Drawing.Size(105, 25);
            this.CarryLimitNameLabel.TabIndex = 9;
            this.CarryLimitNameLabel.Text = "Carry Limit";
            // 
            // RarityLabel
            // 
            this.RarityLabel.AutoSize = true;
            this.RarityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RarityLabel.Location = new System.Drawing.Point(726, 241);
            this.RarityLabel.Name = "RarityLabel";
            this.RarityLabel.Size = new System.Drawing.Size(24, 25);
            this.RarityLabel.TabIndex = 10;
            this.RarityLabel.Text = "8";
            // 
            // BuyPriceLabel
            // 
            this.BuyPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyPriceLabel.Location = new System.Drawing.Point(645, 283);
            this.BuyPriceLabel.Name = "BuyPriceLabel";
            this.BuyPriceLabel.Size = new System.Drawing.Size(100, 25);
            this.BuyPriceLabel.TabIndex = 11;
            this.BuyPriceLabel.Text = "-";
            this.BuyPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SellPriceLabel
            // 
            this.SellPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceLabel.Location = new System.Drawing.Point(641, 327);
            this.SellPriceLabel.Name = "SellPriceLabel";
            this.SellPriceLabel.Size = new System.Drawing.Size(105, 25);
            this.SellPriceLabel.TabIndex = 12;
            this.SellPriceLabel.Text = "-";
            this.SellPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarryLimitLabel
            // 
            this.CarryLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarryLimitLabel.Location = new System.Drawing.Point(704, 371);
            this.CarryLimitLabel.Name = "CarryLimitLabel";
            this.CarryLimitLabel.Size = new System.Drawing.Size(41, 25);
            this.CarryLimitLabel.TabIndex = 13;
            this.CarryLimitLabel.Text = "-";
            this.CarryLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BuyPricePictureBox
            // 
            this.BuyPricePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuyPricePictureBox.Location = new System.Drawing.Point(752, 283);
            this.BuyPricePictureBox.Name = "BuyPricePictureBox";
            this.BuyPricePictureBox.Size = new System.Drawing.Size(32, 32);
            this.BuyPricePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuyPricePictureBox.TabIndex = 14;
            this.BuyPricePictureBox.TabStop = false;
            // 
            // SellPricePictureBox
            // 
            this.SellPricePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SellPricePictureBox.Location = new System.Drawing.Point(752, 327);
            this.SellPricePictureBox.Name = "SellPricePictureBox";
            this.SellPricePictureBox.Size = new System.Drawing.Size(32, 32);
            this.SellPricePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SellPricePictureBox.TabIndex = 15;
            this.SellPricePictureBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(503, 457);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.DescriptionLabel.Size = new System.Drawing.Size(277, 206);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ObtainNameLabel
            // 
            this.ObtainNameLabel.AutoSize = true;
            this.ObtainNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainNameLabel.Location = new System.Drawing.Point(913, 469);
            this.ObtainNameLabel.Name = "ObtainNameLabel";
            this.ObtainNameLabel.Size = new System.Drawing.Size(76, 25);
            this.ObtainNameLabel.TabIndex = 0;
            this.ObtainNameLabel.Text = "Obtain";
            // 
            // ObtainPanel1
            // 
            this.ObtainPanel1.Controls.Add(this.ObtainPanel1ResultLabel);
            this.ObtainPanel1.Controls.Add(this.ObtainPanel1EqualLabel);
            this.ObtainPanel1.Controls.Add(this.ObtainPanel1PlusLabel);
            this.ObtainPanel1.Controls.Add(this.ObtainPanel1ResultItemPictureBox);
            this.ObtainPanel1.Controls.Add(this.ObtainPanel1FirstItemPictureBox);
            this.ObtainPanel1.Controls.Add(this.ObtainPanel1SecondItemPictureBox);
            this.ObtainPanel1.Location = new System.Drawing.Point(824, 505);
            this.ObtainPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel1.Name = "ObtainPanel1";
            this.ObtainPanel1.Size = new System.Drawing.Size(260, 75);
            this.ObtainPanel1.TabIndex = 0;
            // 
            // ObtainPanel1ResultLabel
            // 
            this.ObtainPanel1ResultLabel.AutoSize = true;
            this.ObtainPanel1ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ObtainPanel1ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainPanel1ResultLabel.Location = new System.Drawing.Point(199, 24);
            this.ObtainPanel1ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ObtainPanel1ResultLabel.Name = "ObtainPanel1ResultLabel";
            this.ObtainPanel1ResultLabel.Size = new System.Drawing.Size(49, 25);
            this.ObtainPanel1ResultLabel.TabIndex = 5;
            this.ObtainPanel1ResultLabel.Text = "x -1";
            // 
            // ObtainPanel1EqualLabel
            // 
            this.ObtainPanel1EqualLabel.AutoSize = true;
            this.ObtainPanel1EqualLabel.BackColor = System.Drawing.Color.Transparent;
            this.ObtainPanel1EqualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainPanel1EqualLabel.Location = new System.Drawing.Point(126, 24);
            this.ObtainPanel1EqualLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ObtainPanel1EqualLabel.Name = "ObtainPanel1EqualLabel";
            this.ObtainPanel1EqualLabel.Size = new System.Drawing.Size(25, 25);
            this.ObtainPanel1EqualLabel.TabIndex = 4;
            this.ObtainPanel1EqualLabel.Text = "=";
            // 
            // ObtainPanel1PlusLabel
            // 
            this.ObtainPanel1PlusLabel.AutoSize = true;
            this.ObtainPanel1PlusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ObtainPanel1PlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainPanel1PlusLabel.Location = new System.Drawing.Point(53, 24);
            this.ObtainPanel1PlusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ObtainPanel1PlusLabel.Name = "ObtainPanel1PlusLabel";
            this.ObtainPanel1PlusLabel.Size = new System.Drawing.Size(25, 25);
            this.ObtainPanel1PlusLabel.TabIndex = 3;
            this.ObtainPanel1PlusLabel.Text = "+";
            // 
            // ObtainPanel1ResultItemPictureBox
            // 
            this.ObtainPanel1ResultItemPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObtainPanel1ResultItemPictureBox.BackgroundImage")));
            this.ObtainPanel1ResultItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObtainPanel1ResultItemPictureBox.Location = new System.Drawing.Point(157, 14);
            this.ObtainPanel1ResultItemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel1ResultItemPictureBox.Name = "ObtainPanel1ResultItemPictureBox";
            this.ObtainPanel1ResultItemPictureBox.Size = new System.Drawing.Size(38, 41);
            this.ObtainPanel1ResultItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObtainPanel1ResultItemPictureBox.TabIndex = 2;
            this.ObtainPanel1ResultItemPictureBox.TabStop = false;
            // 
            // ObtainPanel1FirstItemPictureBox
            // 
            this.ObtainPanel1FirstItemPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObtainPanel1FirstItemPictureBox.BackgroundImage")));
            this.ObtainPanel1FirstItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObtainPanel1FirstItemPictureBox.Location = new System.Drawing.Point(80, 14);
            this.ObtainPanel1FirstItemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel1FirstItemPictureBox.Name = "ObtainPanel1FirstItemPictureBox";
            this.ObtainPanel1FirstItemPictureBox.Size = new System.Drawing.Size(38, 41);
            this.ObtainPanel1FirstItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObtainPanel1FirstItemPictureBox.TabIndex = 1;
            this.ObtainPanel1FirstItemPictureBox.TabStop = false;
            // 
            // ObtainPanel1SecondItemPictureBox
            // 
            this.ObtainPanel1SecondItemPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObtainPanel1SecondItemPictureBox.BackgroundImage")));
            this.ObtainPanel1SecondItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObtainPanel1SecondItemPictureBox.Location = new System.Drawing.Point(14, 14);
            this.ObtainPanel1SecondItemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel1SecondItemPictureBox.Name = "ObtainPanel1SecondItemPictureBox";
            this.ObtainPanel1SecondItemPictureBox.Size = new System.Drawing.Size(38, 41);
            this.ObtainPanel1SecondItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObtainPanel1SecondItemPictureBox.TabIndex = 0;
            this.ObtainPanel1SecondItemPictureBox.TabStop = false;
            // 
            // ObtainPanel2
            // 
            this.ObtainPanel2.Controls.Add(this.ObtainPanel2ResultLabel);
            this.ObtainPanel2.Controls.Add(this.ObtainPanel2EqualLabel);
            this.ObtainPanel2.Controls.Add(this.ObtainPanel2PlusLabel);
            this.ObtainPanel2.Controls.Add(this.ObtainPanel2ResultItemPictureBox);
            this.ObtainPanel2.Controls.Add(this.ObtainPanel2FirstItemPictureBox);
            this.ObtainPanel2.Controls.Add(this.ObtainPanel2SecondItemPictureBox);
            this.ObtainPanel2.Location = new System.Drawing.Point(824, 584);
            this.ObtainPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel2.Name = "ObtainPanel2";
            this.ObtainPanel2.Size = new System.Drawing.Size(260, 75);
            this.ObtainPanel2.TabIndex = 6;
            // 
            // ObtainPanel2ResultLabel
            // 
            this.ObtainPanel2ResultLabel.AutoSize = true;
            this.ObtainPanel2ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ObtainPanel2ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainPanel2ResultLabel.Location = new System.Drawing.Point(199, 24);
            this.ObtainPanel2ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ObtainPanel2ResultLabel.Name = "ObtainPanel2ResultLabel";
            this.ObtainPanel2ResultLabel.Size = new System.Drawing.Size(49, 25);
            this.ObtainPanel2ResultLabel.TabIndex = 5;
            this.ObtainPanel2ResultLabel.Text = "x -1";
            // 
            // ObtainPanel2EqualLabel
            // 
            this.ObtainPanel2EqualLabel.AutoSize = true;
            this.ObtainPanel2EqualLabel.BackColor = System.Drawing.Color.Transparent;
            this.ObtainPanel2EqualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainPanel2EqualLabel.Location = new System.Drawing.Point(126, 24);
            this.ObtainPanel2EqualLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ObtainPanel2EqualLabel.Name = "ObtainPanel2EqualLabel";
            this.ObtainPanel2EqualLabel.Size = new System.Drawing.Size(25, 25);
            this.ObtainPanel2EqualLabel.TabIndex = 4;
            this.ObtainPanel2EqualLabel.Text = "=";
            // 
            // ObtainPanel2PlusLabel
            // 
            this.ObtainPanel2PlusLabel.AutoSize = true;
            this.ObtainPanel2PlusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ObtainPanel2PlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainPanel2PlusLabel.Location = new System.Drawing.Point(53, 24);
            this.ObtainPanel2PlusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ObtainPanel2PlusLabel.Name = "ObtainPanel2PlusLabel";
            this.ObtainPanel2PlusLabel.Size = new System.Drawing.Size(25, 25);
            this.ObtainPanel2PlusLabel.TabIndex = 3;
            this.ObtainPanel2PlusLabel.Text = "+";
            // 
            // ObtainPanel2ResultItemPictureBox
            // 
            this.ObtainPanel2ResultItemPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObtainPanel2ResultItemPictureBox.BackgroundImage")));
            this.ObtainPanel2ResultItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObtainPanel2ResultItemPictureBox.Location = new System.Drawing.Point(157, 14);
            this.ObtainPanel2ResultItemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel2ResultItemPictureBox.Name = "ObtainPanel2ResultItemPictureBox";
            this.ObtainPanel2ResultItemPictureBox.Size = new System.Drawing.Size(38, 41);
            this.ObtainPanel2ResultItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObtainPanel2ResultItemPictureBox.TabIndex = 2;
            this.ObtainPanel2ResultItemPictureBox.TabStop = false;
            // 
            // ObtainPanel2FirstItemPictureBox
            // 
            this.ObtainPanel2FirstItemPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObtainPanel2FirstItemPictureBox.BackgroundImage")));
            this.ObtainPanel2FirstItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObtainPanel2FirstItemPictureBox.Location = new System.Drawing.Point(80, 14);
            this.ObtainPanel2FirstItemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel2FirstItemPictureBox.Name = "ObtainPanel2FirstItemPictureBox";
            this.ObtainPanel2FirstItemPictureBox.Size = new System.Drawing.Size(38, 41);
            this.ObtainPanel2FirstItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObtainPanel2FirstItemPictureBox.TabIndex = 1;
            this.ObtainPanel2FirstItemPictureBox.TabStop = false;
            // 
            // ObtainPanel2SecondItemPictureBox
            // 
            this.ObtainPanel2SecondItemPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObtainPanel2SecondItemPictureBox.BackgroundImage")));
            this.ObtainPanel2SecondItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObtainPanel2SecondItemPictureBox.Location = new System.Drawing.Point(14, 14);
            this.ObtainPanel2SecondItemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ObtainPanel2SecondItemPictureBox.Name = "ObtainPanel2SecondItemPictureBox";
            this.ObtainPanel2SecondItemPictureBox.Size = new System.Drawing.Size(38, 41);
            this.ObtainPanel2SecondItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObtainPanel2SecondItemPictureBox.TabIndex = 0;
            this.ObtainPanel2SecondItemPictureBox.TabStop = false;
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ItemPictureBox.BackgroundImage = global::MonsterHunterWorld.Properties.Resources.ui_item_background;
            this.ItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemPictureBox.Location = new System.Drawing.Point(904, 259);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(100, 100);
            this.ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPictureBox.TabIndex = 4;
            this.ItemPictureBox.TabStop = false;
            // 
            // ItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ItemPictureBox);
            this.Controls.Add(this.ObtainPanel2);
            this.Controls.Add(this.ObtainPanel1);
            this.Controls.Add(this.ObtainNameLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SellPricePictureBox);
            this.Controls.Add(this.BuyPricePictureBox);
            this.Controls.Add(this.CarryLimitLabel);
            this.Controls.Add(this.SellPriceLabel);
            this.Controls.Add(this.BuyPriceLabel);
            this.Controls.Add(this.RarityLabel);
            this.Controls.Add(this.CarryLimitNameLabel);
            this.Controls.Add(this.SellPriceNameLabel);
            this.Controls.Add(this.BuyPriceNameLabel);
            this.Controls.Add(this.RarityNameLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.DebugButton);
            this.Controls.Add(this.DebugTextBox);
            this.Name = "ItemWindow";
            this.Size = new System.Drawing.Size(1100, 750);
            this.CategoryPanel.ResumeLayout(false);
            this.ItemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyPricePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellPricePictureBox)).EndInit();
            this.ObtainPanel1.ResumeLayout(false);
            this.ObtainPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel1ResultItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel1FirstItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel1SecondItemPictureBox)).EndInit();
            this.ObtainPanel2.ResumeLayout(false);
            this.ObtainPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel2ResultItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel2FirstItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainPanel2SecondItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.TextBox DebugTextBox;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label RarityNameLabel;
        private System.Windows.Forms.Label BuyPriceNameLabel;
        private System.Windows.Forms.Label SellPriceNameLabel;
        private System.Windows.Forms.Label CarryLimitNameLabel;
        private System.Windows.Forms.Label RarityLabel;
        private System.Windows.Forms.Label BuyPriceLabel;
        private System.Windows.Forms.Label SellPriceLabel;
        private System.Windows.Forms.Label CarryLimitLabel;
        private System.Windows.Forms.PictureBox BuyPricePictureBox;
        private System.Windows.Forms.PictureBox SellPricePictureBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ObtainNameLabel;
        private System.Windows.Forms.Panel ObtainPanel1;
        private System.Windows.Forms.Label ObtainPanel1ResultLabel;
        private System.Windows.Forms.Label ObtainPanel1EqualLabel;
        private System.Windows.Forms.Label ObtainPanel1PlusLabel;
        private System.Windows.Forms.PictureBox ObtainPanel1ResultItemPictureBox;
        private System.Windows.Forms.PictureBox ObtainPanel1FirstItemPictureBox;
        private System.Windows.Forms.PictureBox ObtainPanel1SecondItemPictureBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Panel ObtainPanel2;
        private System.Windows.Forms.Label ObtainPanel2ResultLabel;
        private System.Windows.Forms.Label ObtainPanel2EqualLabel;
        private System.Windows.Forms.Label ObtainPanel2PlusLabel;
        private System.Windows.Forms.PictureBox ObtainPanel2ResultItemPictureBox;
        private System.Windows.Forms.PictureBox ObtainPanel2FirstItemPictureBox;
        private System.Windows.Forms.PictureBox ObtainPanel2SecondItemPictureBox;
        private System.Windows.Forms.PictureBox ItemPictureBox;
    }
}
