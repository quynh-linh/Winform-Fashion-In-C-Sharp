namespace GUI
{
    partial class DiscountGUI
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_discount = new System.Windows.Forms.DataGridView();
            this.maDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_maproduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_delete_discount = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit_discount = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_discount = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_endday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_startday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_giamgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_madiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_discount)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.dgv_discount);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.guna2TextBox3);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 197);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(871, 355);
            this.guna2Panel1.TabIndex = 8;
            // 
            // dgv_discount
            // 
            this.dgv_discount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_discount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiscount,
            this.nameProduct,
            this.sale_percent,
            this.start_day,
            this.end_day});
            this.dgv_discount.Location = new System.Drawing.Point(0, 65);
            this.dgv_discount.Name = "dgv_discount";
            this.dgv_discount.Size = new System.Drawing.Size(865, 290);
            this.dgv_discount.TabIndex = 30;
            this.dgv_discount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_discount_CellClick);
            // 
            // maDiscount
            // 
            this.maDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maDiscount.DataPropertyName = "maDiscount";
            this.maDiscount.HeaderText = "Mã Giảm Giá";
            this.maDiscount.Name = "maDiscount";
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameProduct.DataPropertyName = "nameProduct";
            this.nameProduct.HeaderText = "Tên Sản Phẩm";
            this.nameProduct.Name = "nameProduct";
            // 
            // sale_percent
            // 
            this.sale_percent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sale_percent.DataPropertyName = "sale_percent";
            this.sale_percent.HeaderText = "Giảm Giá";
            this.sale_percent.Name = "sale_percent";
            // 
            // start_day
            // 
            this.start_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_day.DataPropertyName = "start_day";
            this.start_day.HeaderText = "Ngày Bắt Đầu";
            this.start_day.Name = "start_day";
            // 
            // end_day
            // 
            this.end_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_day.DataPropertyName = "end_day";
            this.end_day.HeaderText = "Ngày Kết Thúc";
            this.end_day.Name = "end_day";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::GUI.Properties.Resources.find;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(823, 10);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(43, 28);
            this.guna2ImageButton1.TabIndex = 29;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(599, 10);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox3.MaximumSize = new System.Drawing.Size(300, 28);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Tìm kiếm mã khuyễn mãi";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(223, 28);
            this.guna2TextBox3.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Danh Sách Mã Khuyễn Mãi";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.cbb_maproduct);
            this.guna2Panel2.Controls.Add(this.btn_delete_discount);
            this.guna2Panel2.Controls.Add(this.btn_edit_discount);
            this.guna2Panel2.Controls.Add(this.btn_add_discount);
            this.guna2Panel2.Controls.Add(this.dtp_endday);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.dtp_startday);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.tb_giamgia);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.tb_madiscount);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(871, 200);
            this.guna2Panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(721, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Giảm Giá";
            // 
            // cbb_maproduct
            // 
            this.cbb_maproduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_maproduct.BackColor = System.Drawing.Color.Transparent;
            this.cbb_maproduct.BorderColor = System.Drawing.Color.White;
            this.cbb_maproduct.BorderRadius = 15;
            this.cbb_maproduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_maproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maproduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_maproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_maproduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_maproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_maproduct.ItemHeight = 30;
            this.cbb_maproduct.Location = new System.Drawing.Point(518, 12);
            this.cbb_maproduct.Name = "cbb_maproduct";
            this.cbb_maproduct.Size = new System.Drawing.Size(160, 36);
            this.cbb_maproduct.TabIndex = 34;
            // 
            // btn_delete_discount
            // 
            this.btn_delete_discount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_delete_discount.BorderColor = System.Drawing.Color.White;
            this.btn_delete_discount.BorderRadius = 5;
            this.btn_delete_discount.BorderThickness = 3;
            this.btn_delete_discount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_discount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_discount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_delete_discount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_discount.ForeColor = System.Drawing.Color.White;
            this.btn_delete_discount.Location = new System.Drawing.Point(613, 136);
            this.btn_delete_discount.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_delete_discount.Name = "btn_delete_discount";
            this.btn_delete_discount.PressedColor = System.Drawing.Color.Aqua;
            this.btn_delete_discount.Size = new System.Drawing.Size(121, 40);
            this.btn_delete_discount.TabIndex = 33;
            this.btn_delete_discount.Text = "Xóa";
            this.btn_delete_discount.Click += new System.EventHandler(this.btn_delete_discount_Click);
            // 
            // btn_edit_discount
            // 
            this.btn_edit_discount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_edit_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_edit_discount.BorderColor = System.Drawing.Color.White;
            this.btn_edit_discount.BorderRadius = 5;
            this.btn_edit_discount.BorderThickness = 3;
            this.btn_edit_discount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_discount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit_discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit_discount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_edit_discount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_discount.ForeColor = System.Drawing.Color.White;
            this.btn_edit_discount.Location = new System.Drawing.Point(432, 136);
            this.btn_edit_discount.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_edit_discount.Name = "btn_edit_discount";
            this.btn_edit_discount.PressedColor = System.Drawing.Color.Aqua;
            this.btn_edit_discount.Size = new System.Drawing.Size(121, 40);
            this.btn_edit_discount.TabIndex = 32;
            this.btn_edit_discount.Text = "Sửa";
            this.btn_edit_discount.Click += new System.EventHandler(this.btn_edit_discount_Click);
            // 
            // btn_add_discount
            // 
            this.btn_add_discount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_add_discount.BorderColor = System.Drawing.Color.White;
            this.btn_add_discount.BorderRadius = 5;
            this.btn_add_discount.BorderThickness = 3;
            this.btn_add_discount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_discount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_discount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_add_discount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_discount.ForeColor = System.Drawing.Color.White;
            this.btn_add_discount.Location = new System.Drawing.Point(267, 136);
            this.btn_add_discount.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_add_discount.Name = "btn_add_discount";
            this.btn_add_discount.PressedColor = System.Drawing.Color.Aqua;
            this.btn_add_discount.Size = new System.Drawing.Size(121, 40);
            this.btn_add_discount.TabIndex = 31;
            this.btn_add_discount.Text = "Thêm";
            this.btn_add_discount.Click += new System.EventHandler(this.btn_add_discount_Click);
            // 
            // dtp_endday
            // 
            this.dtp_endday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_endday.BorderColor = System.Drawing.Color.White;
            this.dtp_endday.BorderRadius = 15;
            this.dtp_endday.BorderThickness = 1;
            this.dtp_endday.Checked = true;
            this.dtp_endday.CustomFormat = "dd/MM/yyy";
            this.dtp_endday.FillColor = System.Drawing.Color.White;
            this.dtp_endday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_endday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endday.Location = new System.Drawing.Point(518, 69);
            this.dtp_endday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_endday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_endday.Name = "dtp_endday";
            this.dtp_endday.Size = new System.Drawing.Size(160, 36);
            this.dtp_endday.TabIndex = 15;
            this.dtp_endday.Value = new System.DateTime(2022, 10, 10, 18, 50, 59, 959);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(378, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày Kết Thúc :";
            // 
            // dtp_startday
            // 
            this.dtp_startday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_startday.BorderColor = System.Drawing.Color.White;
            this.dtp_startday.BorderRadius = 15;
            this.dtp_startday.BorderThickness = 1;
            this.dtp_startday.Checked = true;
            this.dtp_startday.CustomFormat = "dd/MM/yyy";
            this.dtp_startday.FillColor = System.Drawing.Color.White;
            this.dtp_startday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_startday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startday.Location = new System.Drawing.Point(195, 69);
            this.dtp_startday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_startday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_startday.Name = "dtp_startday";
            this.dtp_startday.Size = new System.Drawing.Size(160, 36);
            this.dtp_startday.TabIndex = 13;
            this.dtp_startday.Value = new System.DateTime(2022, 10, 10, 18, 50, 59, 959);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày Áp Dụng :";
            // 
            // tb_giamgia
            // 
            this.tb_giamgia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_giamgia.BorderColor = System.Drawing.Color.White;
            this.tb_giamgia.BorderRadius = 15;
            this.tb_giamgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_giamgia.DefaultText = "";
            this.tb_giamgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_giamgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_giamgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_giamgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_giamgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_giamgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_giamgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_giamgia.Location = new System.Drawing.Point(709, 69);
            this.tb_giamgia.Name = "tb_giamgia";
            this.tb_giamgia.PasswordChar = '\0';
            this.tb_giamgia.PlaceholderText = "";
            this.tb_giamgia.SelectedText = "";
            this.tb_giamgia.Size = new System.Drawing.Size(95, 36);
            this.tb_giamgia.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(378, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Sản Phẩm :";
            // 
            // tb_madiscount
            // 
            this.tb_madiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_madiscount.BorderColor = System.Drawing.Color.White;
            this.tb_madiscount.BorderRadius = 15;
            this.tb_madiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_madiscount.DefaultText = "";
            this.tb_madiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_madiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_madiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_madiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_madiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_madiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_madiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_madiscount.Location = new System.Drawing.Point(195, 16);
            this.tb_madiscount.Name = "tb_madiscount";
            this.tb_madiscount.PasswordChar = '\0';
            this.tb_madiscount.PlaceholderText = "";
            this.tb_madiscount.SelectedText = "";
            this.tb_madiscount.Size = new System.Drawing.Size(160, 36);
            this.tb_madiscount.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Khuyễn Mãi :";
            // 
            // DiscountGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(878, 554);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DiscountGUI";
            this.Text = "SaleGui";
            this.Load += new System.EventHandler(this.DiscountGUI_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_discount)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_delete_discount;
        private Guna.UI2.WinForms.Guna2Button btn_edit_discount;
        private Guna.UI2.WinForms.Guna2Button btn_add_discount;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_endday;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_startday;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tb_giamgia;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tb_madiscount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.DataGridView dgv_discount;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_maproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_day;
    }
}