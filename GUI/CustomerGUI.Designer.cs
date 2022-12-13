namespace GUI
{
    partial class CustomerGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.radioOther = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radiobtnNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhoneCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxaddressCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 600);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.dataGridViewCustomer);
            this.guna2Panel2.Controls.Add(this.guna2TextBox4);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 240);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(797, 356);
            this.guna2Panel2.TabIndex = 3;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCustomer,
            this.nameCustomer,
            this.address,
            this.phone,
            this.sex});
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 40);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(791, 313);
            this.dataGridViewCustomer.TabIndex = 19;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            // 
            // idCustomer
            // 
            this.idCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCustomer.DataPropertyName = "idCustomer";
            this.idCustomer.DividerWidth = 1;
            this.idCustomer.HeaderText = "Mã Khách Hàng";
            this.idCustomer.MinimumWidth = 6;
            this.idCustomer.Name = "idCustomer";
            // 
            // nameCustomer
            // 
            this.nameCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCustomer.DataPropertyName = "nameCustomer";
            this.nameCustomer.HeaderText = "Tên Khách Hàng";
            this.nameCustomer.MinimumWidth = 6;
            this.nameCustomer.Name = "nameCustomer";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Số điện thoại";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "Giới Tính";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 125;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox4.BorderRadius = 5;
            this.guna2TextBox4.BorderThickness = 2;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.IconRight = global::GUI.Properties.Resources.icon_search;
            this.guna2TextBox4.Location = new System.Drawing.Point(504, 4);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(289, 33);
            this.guna2TextBox4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Danh sách khách hàng";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Button5);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.radioOther);
            this.guna2Panel1.Controls.Add(this.radioNu);
            this.guna2Panel1.Controls.Add(this.radiobtnNam);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.textBoxPhoneCustomer);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.textBoxaddressCustomer);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.textBoxNameCustomer);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.textBoxIdCustomer);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(797, 229);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button5.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.BorderRadius = 5;
            this.guna2Button5.BorderThickness = 3;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(660, 174);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(110, 40);
            this.guna2Button5.TabIndex = 16;
            this.guna2Button5.Text = "Xuất Excel";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button4.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.BorderThickness = 3;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(481, 174);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(110, 40);
            this.guna2Button4.TabIndex = 15;
            this.guna2Button4.Text = "Nhập Excel";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.BorderThickness = 3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(325, 174);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(91, 40);
            this.guna2Button3.TabIndex = 14;
            this.guna2Button3.Text = "Xóa";
            this.guna2Button3.Click += new System.EventHandler(this.removeCustomer);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(170, 174);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(91, 40);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Sửa";
            this.guna2Button2.Click += new System.EventHandler(this.updateCustomer);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(20, 174);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(91, 40);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Thêm";
            this.guna2Button1.Click += new System.EventHandler(this.addCustomerDB);
            // 
            // radioOther
            // 
            this.radioOther.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioOther.AutoSize = true;
            this.radioOther.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioOther.CheckedState.BorderThickness = 0;
            this.radioOther.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.radioOther.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioOther.CheckedState.InnerOffset = -4;
            this.radioOther.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioOther.ForeColor = System.Drawing.Color.White;
            this.radioOther.Location = new System.Drawing.Point(305, 130);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(63, 25);
            this.radioOther.TabIndex = 11;
            this.radioOther.Text = "Khác";
            this.radioOther.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.radioOther.UncheckedState.BorderThickness = 2;
            this.radioOther.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioOther.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioNu
            // 
            this.radioNu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioNu.AutoSize = true;
            this.radioNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioNu.CheckedState.BorderThickness = 0;
            this.radioNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.radioNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioNu.CheckedState.InnerOffset = -4;
            this.radioNu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioNu.ForeColor = System.Drawing.Color.White;
            this.radioNu.Location = new System.Drawing.Point(211, 130);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(50, 25);
            this.radioNu.TabIndex = 10;
            this.radioNu.Text = "Nữ";
            this.radioNu.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.radioNu.UncheckedState.BorderThickness = 2;
            this.radioNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radiobtnNam
            // 
            this.radiobtnNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radiobtnNam.AutoSize = true;
            this.radiobtnNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobtnNam.CheckedState.BorderThickness = 0;
            this.radiobtnNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.radiobtnNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiobtnNam.CheckedState.InnerOffset = -4;
            this.radiobtnNam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radiobtnNam.ForeColor = System.Drawing.Color.White;
            this.radiobtnNam.Location = new System.Drawing.Point(117, 130);
            this.radiobtnNam.Name = "radiobtnNam";
            this.radiobtnNam.Size = new System.Drawing.Size(62, 25);
            this.radiobtnNam.TabIndex = 9;
            this.radiobtnNam.Text = "Nam";
            this.radiobtnNam.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.radiobtnNam.UncheckedState.BorderThickness = 2;
            this.radiobtnNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiobtnNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới tính";
            // 
            // textBoxPhoneCustomer
            // 
            this.textBoxPhoneCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneCustomer.BorderRadius = 5;
            this.textBoxPhoneCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhoneCustomer.DefaultText = "";
            this.textBoxPhoneCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhoneCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhoneCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhoneCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhoneCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhoneCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPhoneCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhoneCustomer.Location = new System.Drawing.Point(539, 72);
            this.textBoxPhoneCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhoneCustomer.Name = "textBoxPhoneCustomer";
            this.textBoxPhoneCustomer.PasswordChar = '\0';
            this.textBoxPhoneCustomer.PlaceholderText = "";
            this.textBoxPhoneCustomer.SelectedText = "";
            this.textBoxPhoneCustomer.Size = new System.Drawing.Size(250, 33);
            this.textBoxPhoneCustomer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(426, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // textBoxaddressCustomer
            // 
            this.textBoxaddressCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxaddressCustomer.BorderRadius = 5;
            this.textBoxaddressCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxaddressCustomer.DefaultText = "";
            this.textBoxaddressCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxaddressCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxaddressCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxaddressCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxaddressCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxaddressCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxaddressCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxaddressCustomer.Location = new System.Drawing.Point(539, 18);
            this.textBoxaddressCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxaddressCustomer.Name = "textBoxaddressCustomer";
            this.textBoxaddressCustomer.PasswordChar = '\0';
            this.textBoxaddressCustomer.PlaceholderText = "";
            this.textBoxaddressCustomer.SelectedText = "";
            this.textBoxaddressCustomer.Size = new System.Drawing.Size(250, 33);
            this.textBoxaddressCustomer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(426, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // textBoxNameCustomer
            // 
            this.textBoxNameCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNameCustomer.BorderRadius = 5;
            this.textBoxNameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNameCustomer.DefaultText = "";
            this.textBoxNameCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNameCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNameCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNameCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNameCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNameCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxNameCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNameCustomer.Location = new System.Drawing.Point(117, 72);
            this.textBoxNameCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameCustomer.Name = "textBoxNameCustomer";
            this.textBoxNameCustomer.PasswordChar = '\0';
            this.textBoxNameCustomer.PlaceholderText = "";
            this.textBoxNameCustomer.SelectedText = "";
            this.textBoxNameCustomer.Size = new System.Drawing.Size(250, 33);
            this.textBoxNameCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên";
            // 
            // textBoxIdCustomer
            // 
            this.textBoxIdCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdCustomer.BorderRadius = 5;
            this.textBoxIdCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIdCustomer.DefaultText = "";
            this.textBoxIdCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIdCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIdCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIdCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIdCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIdCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxIdCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIdCustomer.Location = new System.Drawing.Point(117, 18);
            this.textBoxIdCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdCustomer.Name = "textBoxIdCustomer";
            this.textBoxIdCustomer.PasswordChar = '\0';
            this.textBoxIdCustomer.PlaceholderText = "";
            this.textBoxIdCustomer.SelectedText = "";
            this.textBoxIdCustomer.Size = new System.Drawing.Size(250, 33);
            this.textBoxIdCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã";
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 600);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerGUI";
            this.Text = "CustomerGUI";
            this.Load += new System.EventHandler(this.CustomerGUI_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2RadioButton radioOther;
        private Guna.UI2.WinForms.Guna2RadioButton radioNu;
        private Guna.UI2.WinForms.Guna2RadioButton radiobtnNam;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhoneCustomer;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxaddressCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNameCustomer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIdCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
    }
}