namespace GUI
{
    partial class BillGui
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
            this.TabControlBill = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage_phieu_xuat = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.bill_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelBill = new System.Windows.Forms.FlowLayoutPanel();
            this.label_total_bill = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_date_bill = new System.Windows.Forms.Label();
            this.label_staff_bill = new System.Windows.Forms.Label();
            this.label_customer_bill = new System.Windows.Forms.Label();
            this.label_ma_bill = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_phieu_nhap = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_import_bill = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namencc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelBillImport = new System.Windows.Forms.FlowLayoutPanel();
            this.label_total_import = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_time_import = new System.Windows.Forms.Label();
            this.label_ncc_import = new System.Windows.Forms.Label();
            this.label_ma_import = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateTimePicker_search = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_refesh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_refesh_import = new Guna.UI2.WinForms.Guna2Button();
            this.DateTimePickerSearchImport = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControlBill.SuspendLayout();
            this.tabPage_phieu_xuat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.tabPage_phieu_nhap.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_import_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlBill
            // 
            this.TabControlBill.Controls.Add(this.tabPage_phieu_xuat);
            this.TabControlBill.Controls.Add(this.tabPage_phieu_nhap);
            this.TabControlBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlBill.ItemSize = new System.Drawing.Size(180, 40);
            this.TabControlBill.Location = new System.Drawing.Point(0, 0);
            this.TabControlBill.Name = "TabControlBill";
            this.TabControlBill.SelectedIndex = 0;
            this.TabControlBill.Size = new System.Drawing.Size(800, 660);
            this.TabControlBill.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlBill.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControlBill.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControlBill.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControlBill.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControlBill.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlBill.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControlBill.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControlBill.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControlBill.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControlBill.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlBill.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabControlBill.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControlBill.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabControlBill.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControlBill.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabControlBill.TabIndex = 4;
            this.TabControlBill.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControlBill.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage_phieu_xuat
            // 
            this.tabPage_phieu_xuat.Controls.Add(this.btn_refesh);
            this.tabPage_phieu_xuat.Controls.Add(this.DateTimePicker_search);
            this.tabPage_phieu_xuat.Controls.Add(this.label11);
            this.tabPage_phieu_xuat.Controls.Add(this.guna2Button1);
            this.tabPage_phieu_xuat.Controls.Add(this.panel1);
            this.tabPage_phieu_xuat.Controls.Add(this.label2);
            this.tabPage_phieu_xuat.Controls.Add(this.flowLayoutPanelBill);
            this.tabPage_phieu_xuat.Controls.Add(this.label_total_bill);
            this.tabPage_phieu_xuat.Controls.Add(this.label9);
            this.tabPage_phieu_xuat.Controls.Add(this.label_date_bill);
            this.tabPage_phieu_xuat.Controls.Add(this.label_staff_bill);
            this.tabPage_phieu_xuat.Controls.Add(this.label_customer_bill);
            this.tabPage_phieu_xuat.Controls.Add(this.label_ma_bill);
            this.tabPage_phieu_xuat.Controls.Add(this.label8);
            this.tabPage_phieu_xuat.Controls.Add(this.label7);
            this.tabPage_phieu_xuat.Controls.Add(this.label6);
            this.tabPage_phieu_xuat.Controls.Add(this.label5);
            this.tabPage_phieu_xuat.Controls.Add(this.label1);
            this.tabPage_phieu_xuat.ForeColor = System.Drawing.Color.Black;
            this.tabPage_phieu_xuat.Location = new System.Drawing.Point(4, 44);
            this.tabPage_phieu_xuat.Name = "tabPage_phieu_xuat";
            this.tabPage_phieu_xuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_phieu_xuat.Size = new System.Drawing.Size(792, 612);
            this.tabPage_phieu_xuat.TabIndex = 0;
            this.tabPage_phieu_xuat.Text = "Phiếu Xuất";
            this.tabPage_phieu_xuat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewBill);
            this.panel1.Location = new System.Drawing.Point(2, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 493);
            this.panel1.TabIndex = 20;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bill_Id,
            this.bill_Time,
            this.name,
            this.namecustomer,
            this.bill_Total});
            this.dataGridViewBill.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewBill.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewBill.RowHeadersVisible = false;
            this.dataGridViewBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewBill.Size = new System.Drawing.Size(342, 477);
            this.dataGridViewBill.TabIndex = 0;
            this.dataGridViewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellClick);
            // 
            // bill_Id
            // 
            this.bill_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bill_Id.DataPropertyName = "bill_Id";
            this.bill_Id.HeaderText = "Mã Bill";
            this.bill_Id.Name = "bill_Id";
            // 
            // bill_Time
            // 
            this.bill_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bill_Time.DataPropertyName = "bill_Time";
            this.bill_Time.HeaderText = "Date";
            this.bill_Time.Name = "bill_Time";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nhân Viên";
            this.name.Name = "name";
            // 
            // namecustomer
            // 
            this.namecustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namecustomer.DataPropertyName = "namecustomer";
            this.namecustomer.HeaderText = "Khách Hàng";
            this.namecustomer.Name = "namecustomer";
            this.namecustomer.Visible = false;
            // 
            // bill_Total
            // 
            this.bill_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bill_Total.DataPropertyName = "bill_Total";
            this.bill_Total.HeaderText = "Tổng Tiền";
            this.bill_Total.Name = "bill_Total";
            this.bill_Total.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(559, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Chi tiết phiếu xuất";
            // 
            // flowLayoutPanelBill
            // 
            this.flowLayoutPanelBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBill.AutoScroll = true;
            this.flowLayoutPanelBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelBill.Location = new System.Drawing.Point(354, 189);
            this.flowLayoutPanelBill.Name = "flowLayoutPanelBill";
            this.flowLayoutPanelBill.Size = new System.Drawing.Size(435, 302);
            this.flowLayoutPanelBill.TabIndex = 18;
            // 
            // label_total_bill
            // 
            this.label_total_bill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_total_bill.AutoSize = true;
            this.label_total_bill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_bill.ForeColor = System.Drawing.Color.Black;
            this.label_total_bill.Location = new System.Drawing.Point(668, 537);
            this.label_total_bill.Name = "label_total_bill";
            this.label_total_bill.Size = new System.Drawing.Size(0, 21);
            this.label_total_bill.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(572, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng tiền :";
            // 
            // label_date_bill
            // 
            this.label_date_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date_bill.AutoSize = true;
            this.label_date_bill.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_bill.ForeColor = System.Drawing.Color.Black;
            this.label_date_bill.Location = new System.Drawing.Point(660, 116);
            this.label_date_bill.Name = "label_date_bill";
            this.label_date_bill.Size = new System.Drawing.Size(0, 13);
            this.label_date_bill.TabIndex = 15;
            // 
            // label_staff_bill
            // 
            this.label_staff_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_staff_bill.AutoSize = true;
            this.label_staff_bill.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staff_bill.ForeColor = System.Drawing.Color.Black;
            this.label_staff_bill.Location = new System.Drawing.Point(521, 153);
            this.label_staff_bill.Name = "label_staff_bill";
            this.label_staff_bill.Size = new System.Drawing.Size(0, 13);
            this.label_staff_bill.TabIndex = 14;
            // 
            // label_customer_bill
            // 
            this.label_customer_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_customer_bill.AutoSize = true;
            this.label_customer_bill.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_bill.ForeColor = System.Drawing.Color.Black;
            this.label_customer_bill.Location = new System.Drawing.Point(521, 116);
            this.label_customer_bill.Name = "label_customer_bill";
            this.label_customer_bill.Size = new System.Drawing.Size(0, 13);
            this.label_customer_bill.TabIndex = 13;
            // 
            // label_ma_bill
            // 
            this.label_ma_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ma_bill.AutoSize = true;
            this.label_ma_bill.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ma_bill.ForeColor = System.Drawing.Color.Black;
            this.label_ma_bill.Location = new System.Drawing.Point(521, 76);
            this.label_ma_bill.Name = "label_ma_bill";
            this.label_ma_bill.Size = new System.Drawing.Size(0, 13);
            this.label_ma_bill.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(594, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thời gian :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(441, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thu ngân :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(441, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Khách hàng :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(441, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã hóa đơn :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách phiếu xuất";
            // 
            // tabPage_phieu_nhap
            // 
            this.tabPage_phieu_nhap.Controls.Add(this.btn_refesh_import);
            this.tabPage_phieu_nhap.Controls.Add(this.DateTimePickerSearchImport);
            this.tabPage_phieu_nhap.Controls.Add(this.label4);
            this.tabPage_phieu_nhap.Controls.Add(this.guna2Button2);
            this.tabPage_phieu_nhap.Controls.Add(this.panel2);
            this.tabPage_phieu_nhap.Controls.Add(this.label3);
            this.tabPage_phieu_nhap.Controls.Add(this.flowLayoutPanelBillImport);
            this.tabPage_phieu_nhap.Controls.Add(this.label_total_import);
            this.tabPage_phieu_nhap.Controls.Add(this.label10);
            this.tabPage_phieu_nhap.Controls.Add(this.label_time_import);
            this.tabPage_phieu_nhap.Controls.Add(this.label_ncc_import);
            this.tabPage_phieu_nhap.Controls.Add(this.label_ma_import);
            this.tabPage_phieu_nhap.Controls.Add(this.label15);
            this.tabPage_phieu_nhap.Controls.Add(this.label17);
            this.tabPage_phieu_nhap.Controls.Add(this.label18);
            this.tabPage_phieu_nhap.Controls.Add(this.label19);
            this.tabPage_phieu_nhap.Location = new System.Drawing.Point(4, 44);
            this.tabPage_phieu_nhap.Name = "tabPage_phieu_nhap";
            this.tabPage_phieu_nhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_phieu_nhap.Size = new System.Drawing.Size(792, 612);
            this.tabPage_phieu_nhap.TabIndex = 1;
            this.tabPage_phieu_nhap.Text = "Phiếu Nhập";
            this.tabPage_phieu_nhap.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_import_bill);
            this.panel2.Location = new System.Drawing.Point(3, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 493);
            this.panel2.TabIndex = 36;
            // 
            // dgv_import_bill
            // 
            this.dgv_import_bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_import_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_import_bill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_import_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_import_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.date,
            this.dataGridViewTextBoxColumn3,
            this.namencc,
            this.tongtien});
            this.dgv_import_bill.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_import_bill.Location = new System.Drawing.Point(3, 0);
            this.dgv_import_bill.Name = "dgv_import_bill";
            this.dgv_import_bill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_import_bill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_import_bill.RowHeadersVisible = false;
            this.dgv_import_bill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_import_bill.Size = new System.Drawing.Size(340, 477);
            this.dgv_import_bill.TabIndex = 0;
            this.dgv_import_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_import_bill_CellClick);
            // 
            // ma
            // 
            this.ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ma.DataPropertyName = "ma";
            this.ma.HeaderText = "Mã Bill";
            this.ma.Name = "ma";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nhân Viên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // namencc
            // 
            this.namencc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namencc.DataPropertyName = "namencc";
            this.namencc.HeaderText = "Khách Hàng";
            this.namencc.Name = "namencc";
            this.namencc.Visible = false;
            // 
            // tongtien
            // 
            this.tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(559, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Chi tiết phiếu nhập";
            // 
            // flowLayoutPanelBillImport
            // 
            this.flowLayoutPanelBillImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBillImport.AutoScroll = true;
            this.flowLayoutPanelBillImport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelBillImport.Location = new System.Drawing.Point(353, 192);
            this.flowLayoutPanelBillImport.Name = "flowLayoutPanelBillImport";
            this.flowLayoutPanelBillImport.Size = new System.Drawing.Size(435, 302);
            this.flowLayoutPanelBillImport.TabIndex = 34;
            // 
            // label_total_import
            // 
            this.label_total_import.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_total_import.AutoSize = true;
            this.label_total_import.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_import.ForeColor = System.Drawing.Color.Black;
            this.label_total_import.Location = new System.Drawing.Point(673, 540);
            this.label_total_import.Name = "label_total_import";
            this.label_total_import.Size = new System.Drawing.Size(0, 21);
            this.label_total_import.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(577, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tổng tiền :";
            // 
            // label_time_import
            // 
            this.label_time_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time_import.AutoSize = true;
            this.label_time_import.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_import.ForeColor = System.Drawing.Color.Black;
            this.label_time_import.Location = new System.Drawing.Point(659, 148);
            this.label_time_import.Name = "label_time_import";
            this.label_time_import.Size = new System.Drawing.Size(0, 13);
            this.label_time_import.TabIndex = 31;
            // 
            // label_ncc_import
            // 
            this.label_ncc_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ncc_import.AutoSize = true;
            this.label_ncc_import.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ncc_import.ForeColor = System.Drawing.Color.Black;
            this.label_ncc_import.Location = new System.Drawing.Point(514, 148);
            this.label_ncc_import.Name = "label_ncc_import";
            this.label_ncc_import.Size = new System.Drawing.Size(0, 13);
            this.label_ncc_import.TabIndex = 29;
            // 
            // label_ma_import
            // 
            this.label_ma_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ma_import.AutoSize = true;
            this.label_ma_import.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ma_import.ForeColor = System.Drawing.Color.Black;
            this.label_ma_import.Location = new System.Drawing.Point(514, 108);
            this.label_ma_import.Name = "label_ma_import";
            this.label_ma_import.Size = new System.Drawing.Size(0, 13);
            this.label_ma_import.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(584, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Thời gian :";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(423, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Nhà cung cấp :";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(423, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Mã hóa đơn :";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(76, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(202, 25);
            this.label19.TabIndex = 23;
            this.label19.Text = "Danh sách phiếu nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tìm :";
            // 
            // DateTimePicker_search
            // 
            this.DateTimePicker_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker_search.BorderRadius = 5;
            this.DateTimePicker_search.Checked = true;
            this.DateTimePicker_search.CustomFormat = " ";
            this.DateTimePicker_search.FillColor = System.Drawing.Color.White;
            this.DateTimePicker_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DateTimePicker_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePicker_search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_search.Location = new System.Drawing.Point(59, 55);
            this.DateTimePicker_search.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_search.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_search.Name = "DateTimePicker_search";
            this.DateTimePicker_search.Size = new System.Drawing.Size(234, 34);
            this.DateTimePicker_search.TabIndex = 26;
            this.DateTimePicker_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateTimePicker_search.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.DateTimePicker_search.ValueChanged += new System.EventHandler(this.DateTimePicker_search_ValueChanged);
            // 
            // btn_refesh
            // 
            this.btn_refesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refesh.BorderRadius = 5;
            this.btn_refesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refesh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_refesh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_refesh.ForeColor = System.Drawing.Color.Black;
            this.btn_refesh.Image = global::GUI.Properties.Resources.refresh;
            this.btn_refesh.Location = new System.Drawing.Point(313, 56);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(34, 34);
            this.btn_refesh.TabIndex = 27;
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::GUI.Properties.Resources.print_icon;
            this.guna2Button1.Location = new System.Drawing.Point(411, 519);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(110, 39);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "In Hóa Đơn";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::GUI.Properties.Resources.print_icon;
            this.guna2Button2.Location = new System.Drawing.Point(408, 522);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(110, 39);
            this.guna2Button2.TabIndex = 37;
            this.guna2Button2.Text = "In Hóa Đơn";
            // 
            // btn_refesh_import
            // 
            this.btn_refesh_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refesh_import.BorderRadius = 5;
            this.btn_refesh_import.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh_import.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh_import.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refesh_import.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refesh_import.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_refesh_import.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_refesh_import.ForeColor = System.Drawing.Color.Black;
            this.btn_refesh_import.Image = global::GUI.Properties.Resources.refresh;
            this.btn_refesh_import.Location = new System.Drawing.Point(311, 59);
            this.btn_refesh_import.Name = "btn_refesh_import";
            this.btn_refesh_import.Size = new System.Drawing.Size(34, 34);
            this.btn_refesh_import.TabIndex = 40;
            this.btn_refesh_import.Click += new System.EventHandler(this.btn_refesh_import_Click);
            // 
            // DateTimePickerSearchImport
            // 
            this.DateTimePickerSearchImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerSearchImport.BorderRadius = 5;
            this.DateTimePickerSearchImport.Checked = true;
            this.DateTimePickerSearchImport.CustomFormat = " ";
            this.DateTimePickerSearchImport.FillColor = System.Drawing.Color.White;
            this.DateTimePickerSearchImport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerSearchImport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePickerSearchImport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerSearchImport.Location = new System.Drawing.Point(57, 58);
            this.DateTimePickerSearchImport.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerSearchImport.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerSearchImport.Name = "DateTimePickerSearchImport";
            this.DateTimePickerSearchImport.Size = new System.Drawing.Size(234, 34);
            this.DateTimePickerSearchImport.TabIndex = 39;
            this.DateTimePickerSearchImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateTimePickerSearchImport.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.DateTimePickerSearchImport.ValueChanged += new System.EventHandler(this.DateTimePickerSearchImport_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tìm :";
            // 
            // BillGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.TabControlBill);
            this.Name = "BillGui";
            this.Text = "BillGui";
            this.Load += new System.EventHandler(this.BillGui_Load);
            this.TabControlBill.ResumeLayout(false);
            this.tabPage_phieu_xuat.ResumeLayout(false);
            this.tabPage_phieu_xuat.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.tabPage_phieu_nhap.ResumeLayout(false);
            this.tabPage_phieu_nhap.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_import_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_phieu_xuat;
        private System.Windows.Forms.TabPage tabPage_phieu_nhap;
        internal Guna.UI2.WinForms.Guna2TabControl TabControlBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Label label_total_bill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_date_bill;
        private System.Windows.Forms.Label label_staff_bill;
        private System.Windows.Forms.Label label_customer_bill;
        private System.Windows.Forms.Label label_ma_bill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_Total;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_import_bill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBillImport;
        private System.Windows.Forms.Label label_total_import;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_time_import;
        private System.Windows.Forms.Label label_ncc_import;
        private System.Windows.Forms.Label label_ma_import;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn namencc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_search;
        private Guna.UI2.WinForms.Guna2Button btn_refesh;
        private Guna.UI2.WinForms.Guna2Button btn_refesh_import;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerSearchImport;
        private System.Windows.Forms.Label label4;
    }
}