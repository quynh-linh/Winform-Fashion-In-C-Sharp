namespace GUI
{
    partial class Sell_DetailGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_subtracQuantity = new FontAwesome.Sharp.IconButton();
            this.tb_quantityProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_addQuantity = new FontAwesome.Sharp.IconButton();
            this.rdb_sizeS = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_sizeL = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_sizeM = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tb_nameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_priceProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_buy = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_discountProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ptb_imageDetailProduct = new System.Windows.Forms.PictureBox();
            this.rdo_XL = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imageDetailProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT MUA HÀNG";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lượng :";
            // 
            // btn_subtracQuantity
            // 
            this.btn_subtracQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_subtracQuantity.FlatAppearance.BorderSize = 0;
            this.btn_subtracQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subtracQuantity.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_subtracQuantity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.btn_subtracQuantity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_subtracQuantity.Location = new System.Drawing.Point(162, 530);
            this.btn_subtracQuantity.Name = "btn_subtracQuantity";
            this.btn_subtracQuantity.Size = new System.Drawing.Size(25, 25);
            this.btn_subtracQuantity.TabIndex = 6;
            this.btn_subtracQuantity.UseVisualStyleBackColor = true;
            this.btn_subtracQuantity.Click += new System.EventHandler(this.btn_subtracQuantity_Click);
            // 
            // tb_quantityProduct
            // 
            this.tb_quantityProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_quantityProduct.BorderColor = System.Drawing.Color.Fuchsia;
            this.tb_quantityProduct.BorderRadius = 15;
            this.tb_quantityProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_quantityProduct.DefaultText = "1";
            this.tb_quantityProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_quantityProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_quantityProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_quantityProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_quantityProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_quantityProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_quantityProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_quantityProduct.Location = new System.Drawing.Point(207, 525);
            this.tb_quantityProduct.Name = "tb_quantityProduct";
            this.tb_quantityProduct.PasswordChar = '\0';
            this.tb_quantityProduct.PlaceholderText = "";
            this.tb_quantityProduct.SelectedText = "";
            this.tb_quantityProduct.Size = new System.Drawing.Size(95, 36);
            this.tb_quantityProduct.TabIndex = 7;
            this.tb_quantityProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_quantityProduct.TextChanged += new System.EventHandler(this.tb_quantityProduct_TextChanged);
            this.tb_quantityProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_quantityProduct_KeyPress);
            // 
            // btn_addQuantity
            // 
            this.btn_addQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addQuantity.FlatAppearance.BorderSize = 0;
            this.btn_addQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addQuantity.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_addQuantity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.btn_addQuantity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_addQuantity.Location = new System.Drawing.Point(323, 530);
            this.btn_addQuantity.Name = "btn_addQuantity";
            this.btn_addQuantity.Size = new System.Drawing.Size(25, 25);
            this.btn_addQuantity.TabIndex = 8;
            this.btn_addQuantity.UseVisualStyleBackColor = true;
            this.btn_addQuantity.Click += new System.EventHandler(this.btn_addQuantity_Click);
            // 
            // rdb_sizeS
            // 
            this.rdb_sizeS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_sizeS.AutoSize = true;
            this.rdb_sizeS.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_sizeS.CheckedState.BorderThickness = 2;
            this.rdb_sizeS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdb_sizeS.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdb_sizeS.CheckedState.InnerOffset = -4;
            this.rdb_sizeS.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdb_sizeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdb_sizeS.ForeColor = System.Drawing.Color.White;
            this.rdb_sizeS.Location = new System.Drawing.Point(424, 531);
            this.rdb_sizeS.Name = "rdb_sizeS";
            this.rdb_sizeS.Size = new System.Drawing.Size(37, 20);
            this.rdb_sizeS.TabIndex = 10;
            this.rdb_sizeS.Text = "   ";
            this.rdb_sizeS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_sizeS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.rdb_sizeS.UncheckedState.BorderThickness = 2;
            this.rdb_sizeS.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_sizeS.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdb_sizeS.CheckedChanged += new System.EventHandler(this.rdb_sizeS_CheckedChanged);
            // 
            // rdb_sizeL
            // 
            this.rdb_sizeL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_sizeL.AutoSize = true;
            this.rdb_sizeL.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_sizeL.CheckedState.BorderThickness = 2;
            this.rdb_sizeL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdb_sizeL.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdb_sizeL.CheckedState.InnerOffset = -4;
            this.rdb_sizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdb_sizeL.ForeColor = System.Drawing.Color.White;
            this.rdb_sizeL.Location = new System.Drawing.Point(579, 529);
            this.rdb_sizeL.Name = "rdb_sizeL";
            this.rdb_sizeL.Size = new System.Drawing.Size(37, 20);
            this.rdb_sizeL.TabIndex = 11;
            this.rdb_sizeL.Text = "   ";
            this.rdb_sizeL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_sizeL.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.rdb_sizeL.UncheckedState.BorderThickness = 2;
            this.rdb_sizeL.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_sizeL.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdb_sizeL.CheckedChanged += new System.EventHandler(this.rdb_sizeS_CheckedChanged);
            // 
            // rdb_sizeM
            // 
            this.rdb_sizeM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_sizeM.AutoSize = true;
            this.rdb_sizeM.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_sizeM.CheckedState.BorderThickness = 2;
            this.rdb_sizeM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdb_sizeM.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdb_sizeM.CheckedState.InnerOffset = -4;
            this.rdb_sizeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdb_sizeM.ForeColor = System.Drawing.Color.White;
            this.rdb_sizeM.Location = new System.Drawing.Point(503, 531);
            this.rdb_sizeM.Name = "rdb_sizeM";
            this.rdb_sizeM.Size = new System.Drawing.Size(37, 20);
            this.rdb_sizeM.TabIndex = 12;
            this.rdb_sizeM.Text = "   ";
            this.rdb_sizeM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_sizeM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.rdb_sizeM.UncheckedState.BorderThickness = 2;
            this.rdb_sizeM.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_sizeM.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdb_sizeM.CheckedChanged += new System.EventHandler(this.rdb_sizeS_CheckedChanged);
            // 
            // tb_nameProduct
            // 
            this.tb_nameProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_nameProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.tb_nameProduct.BorderRadius = 10;
            this.tb_nameProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nameProduct.DefaultText = "";
            this.tb_nameProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nameProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nameProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nameProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nameProduct.Enabled = false;
            this.tb_nameProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nameProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_nameProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nameProduct.Location = new System.Drawing.Point(163, 407);
            this.tb_nameProduct.Name = "tb_nameProduct";
            this.tb_nameProduct.PasswordChar = '\0';
            this.tb_nameProduct.PlaceholderText = "";
            this.tb_nameProduct.SelectedText = "";
            this.tb_nameProduct.Size = new System.Drawing.Size(542, 36);
            this.tb_nameProduct.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(53, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Sản Phẩm :";
            // 
            // tb_priceProduct
            // 
            this.tb_priceProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_priceProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.tb_priceProduct.BorderRadius = 10;
            this.tb_priceProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_priceProduct.DefaultText = "";
            this.tb_priceProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_priceProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_priceProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_priceProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_priceProduct.Enabled = false;
            this.tb_priceProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_priceProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_priceProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_priceProduct.Location = new System.Drawing.Point(163, 464);
            this.tb_priceProduct.Name = "tb_priceProduct";
            this.tb_priceProduct.PasswordChar = '\0';
            this.tb_priceProduct.PlaceholderText = "";
            this.tb_priceProduct.SelectedText = "";
            this.tb_priceProduct.Size = new System.Drawing.Size(542, 36);
            this.tb_priceProduct.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Giá Sản Phẩm :";
            // 
            // btn_buy
            // 
            this.btn_buy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buy.BorderColor = System.Drawing.Color.White;
            this.btn_buy.BorderRadius = 25;
            this.btn_buy.BorderThickness = 3;
            this.btn_buy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buy.FillColor = System.Drawing.Color.Transparent;
            this.btn_buy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.HoverState.FillColor = System.Drawing.Color.HotPink;
            this.btn_buy.Image = global::GUI.Properties.Resources.Cart_add_icon;
            this.btn_buy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_buy.ImageOffset = new System.Drawing.Point(20, 0);
            this.btn_buy.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_buy.Location = new System.Drawing.Point(307, 599);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(192, 56);
            this.btn_buy.TabIndex = 28;
            this.btn_buy.Text = "MUA";
            this.btn_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_buy.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // cbb_discountProduct
            // 
            this.cbb_discountProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_discountProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbb_discountProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.cbb_discountProduct.BorderRadius = 10;
            this.cbb_discountProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_discountProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_discountProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_discountProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_discountProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_discountProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_discountProduct.ItemHeight = 30;
            this.cbb_discountProduct.Items.AddRange(new object[] {
            "Select"});
            this.cbb_discountProduct.Location = new System.Drawing.Point(163, 344);
            this.cbb_discountProduct.Name = "cbb_discountProduct";
            this.cbb_discountProduct.Size = new System.Drawing.Size(542, 36);
            this.cbb_discountProduct.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(53, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Mã Giảm Giá :";
            // 
            // ptb_imageDetailProduct
            // 
            this.ptb_imageDetailProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_imageDetailProduct.Location = new System.Drawing.Point(275, 61);
            this.ptb_imageDetailProduct.Name = "ptb_imageDetailProduct";
            this.ptb_imageDetailProduct.Size = new System.Drawing.Size(292, 255);
            this.ptb_imageDetailProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_imageDetailProduct.TabIndex = 35;
            this.ptb_imageDetailProduct.TabStop = false;
            // 
            // rdo_XL
            // 
            this.rdo_XL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdo_XL.AutoSize = true;
            this.rdo_XL.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdo_XL.CheckedState.BorderThickness = 2;
            this.rdo_XL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdo_XL.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdo_XL.CheckedState.InnerOffset = -4;
            this.rdo_XL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdo_XL.ForeColor = System.Drawing.Color.White;
            this.rdo_XL.Location = new System.Drawing.Point(645, 529);
            this.rdo_XL.Name = "rdo_XL";
            this.rdo_XL.Size = new System.Drawing.Size(33, 20);
            this.rdo_XL.TabIndex = 36;
            this.rdo_XL.Text = "  ";
            this.rdo_XL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdo_XL.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.rdo_XL.UncheckedState.BorderThickness = 2;
            this.rdo_XL.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_XL.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo_XL.CheckedChanged += new System.EventHandler(this.rdb_sizeS_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(535, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "M";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(609, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(674, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "XL";
            // 
            // Sell_DetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(781, 667);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdo_XL);
            this.Controls.Add(this.ptb_imageDetailProduct);
            this.Controls.Add(this.cbb_discountProduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.tb_priceProduct);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_nameProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdb_sizeM);
            this.Controls.Add(this.rdb_sizeL);
            this.Controls.Add(this.rdb_sizeS);
            this.Controls.Add(this.btn_addQuantity);
            this.Controls.Add(this.tb_quantityProduct);
            this.Controls.Add(this.btn_subtracQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Sell_DetailGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imageDetailProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_subtracQuantity;
        private Guna.UI2.WinForms.Guna2TextBox tb_quantityProduct;
        private FontAwesome.Sharp.IconButton btn_addQuantity;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_sizeS;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_sizeL;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_sizeM;
        private Guna.UI2.WinForms.Guna2TextBox tb_nameProduct;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox tb_priceProduct;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btn_buy;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_discountProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox ptb_imageDetailProduct;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_XL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}