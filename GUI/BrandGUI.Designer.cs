namespace GUI
{
    partial class BrandGUI
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
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_brand = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_exportExcelBrand = new Guna.UI2.WinForms.Guna2Button();
            this.btn_importExcelBrand = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deleteBrand = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editBrand = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addBrand = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_nameBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MaBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brand)).BeginInit();
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
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txt_Search);
            this.guna2Panel2.Controls.Add(this.dgv_brand);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(4, 114);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(799, 483);
            this.guna2Panel2.TabIndex = 3;
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.BorderColor = System.Drawing.Color.White;
            this.txt_Search.BorderRadius = 5;
            this.txt_Search.BorderThickness = 2;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.IconRight = global::GUI.Properties.Resources.icon_search;
            this.txt_Search.IconRightOffset = new System.Drawing.Point(15, 0);
            this.txt_Search.Location = new System.Drawing.Point(495, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Tìm kiếm";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(294, 36);
            this.txt_Search.TabIndex = 19;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // dgv_brand
            // 
            this.dgv_brand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_brand.BackgroundColor = System.Drawing.Color.White;
            this.dgv_brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_brand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgv_brand.Location = new System.Drawing.Point(3, 46);
            this.dgv_brand.Name = "dgv_brand";
            this.dgv_brand.RowHeadersVisible = false;
            this.dgv_brand.RowHeadersWidth = 51;
            this.dgv_brand.Size = new System.Drawing.Size(793, 434);
            this.dgv_brand.TabIndex = 11;
            this.dgv_brand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_brand_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã Thương Hiệu";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Thương Hiệu";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách thương hiệu";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btn_exportExcelBrand);
            this.guna2Panel1.Controls.Add(this.btn_importExcelBrand);
            this.guna2Panel1.Controls.Add(this.btn_deleteBrand);
            this.guna2Panel1.Controls.Add(this.btn_editBrand);
            this.guna2Panel1.Controls.Add(this.btn_addBrand);
            this.guna2Panel1.Controls.Add(this.Txt_nameBrand);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.Txt_MaBrand);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 119);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btn_exportExcelBrand
            // 
            this.btn_exportExcelBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exportExcelBrand.BorderColor = System.Drawing.Color.White;
            this.btn_exportExcelBrand.BorderRadius = 5;
            this.btn_exportExcelBrand.BorderThickness = 3;
            this.btn_exportExcelBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exportExcelBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exportExcelBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exportExcelBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exportExcelBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.btn_exportExcelBrand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_exportExcelBrand.ForeColor = System.Drawing.Color.White;
            this.btn_exportExcelBrand.Location = new System.Drawing.Point(682, 66);
            this.btn_exportExcelBrand.Name = "btn_exportExcelBrand";
            this.btn_exportExcelBrand.Size = new System.Drawing.Size(108, 39);
            this.btn_exportExcelBrand.TabIndex = 8;
            this.btn_exportExcelBrand.Text = "Xuất Excel";
            this.btn_exportExcelBrand.Click += new System.EventHandler(this.btn_exportExcelBrand_Click);
            // 
            // btn_importExcelBrand
            // 
            this.btn_importExcelBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_importExcelBrand.BorderColor = System.Drawing.Color.White;
            this.btn_importExcelBrand.BorderRadius = 5;
            this.btn_importExcelBrand.BorderThickness = 3;
            this.btn_importExcelBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_importExcelBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_importExcelBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_importExcelBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_importExcelBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.btn_importExcelBrand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_importExcelBrand.ForeColor = System.Drawing.Color.White;
            this.btn_importExcelBrand.Location = new System.Drawing.Point(515, 66);
            this.btn_importExcelBrand.Name = "btn_importExcelBrand";
            this.btn_importExcelBrand.Size = new System.Drawing.Size(108, 39);
            this.btn_importExcelBrand.TabIndex = 7;
            this.btn_importExcelBrand.Text = "Nhập Excel";
            this.btn_importExcelBrand.Click += new System.EventHandler(this.btn_importExcelBrand_Click);
            // 
            // btn_deleteBrand
            // 
            this.btn_deleteBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteBrand.BorderColor = System.Drawing.Color.White;
            this.btn_deleteBrand.BorderRadius = 5;
            this.btn_deleteBrand.BorderThickness = 3;
            this.btn_deleteBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.btn_deleteBrand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_deleteBrand.ForeColor = System.Drawing.Color.White;
            this.btn_deleteBrand.Location = new System.Drawing.Point(352, 66);
            this.btn_deleteBrand.Name = "btn_deleteBrand";
            this.btn_deleteBrand.Size = new System.Drawing.Size(97, 39);
            this.btn_deleteBrand.TabIndex = 6;
            this.btn_deleteBrand.Text = "Xóa";
            this.btn_deleteBrand.Click += new System.EventHandler(this.btn_deleteBrand_Click);
            // 
            // btn_editBrand
            // 
            this.btn_editBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_editBrand.BorderColor = System.Drawing.Color.White;
            this.btn_editBrand.BorderRadius = 5;
            this.btn_editBrand.BorderThickness = 3;
            this.btn_editBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.btn_editBrand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_editBrand.ForeColor = System.Drawing.Color.White;
            this.btn_editBrand.Location = new System.Drawing.Point(189, 66);
            this.btn_editBrand.Name = "btn_editBrand";
            this.btn_editBrand.Size = new System.Drawing.Size(97, 39);
            this.btn_editBrand.TabIndex = 5;
            this.btn_editBrand.Text = "Sửa";
            this.btn_editBrand.Click += new System.EventHandler(this.btn_editBrand_Click);
            // 
            // btn_addBrand
            // 
            this.btn_addBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addBrand.BorderColor = System.Drawing.Color.White;
            this.btn_addBrand.BorderRadius = 5;
            this.btn_addBrand.BorderThickness = 3;
            this.btn_addBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.btn_addBrand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_addBrand.ForeColor = System.Drawing.Color.White;
            this.btn_addBrand.Location = new System.Drawing.Point(24, 66);
            this.btn_addBrand.Name = "btn_addBrand";
            this.btn_addBrand.Size = new System.Drawing.Size(97, 39);
            this.btn_addBrand.TabIndex = 4;
            this.btn_addBrand.Text = "Thêm";
            this.btn_addBrand.Click += new System.EventHandler(this.btn_addBrand_Click);
            // 
            // Txt_nameBrand
            // 
            this.Txt_nameBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_nameBrand.BorderRadius = 5;
            this.Txt_nameBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_nameBrand.DefaultText = "";
            this.Txt_nameBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_nameBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_nameBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nameBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nameBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nameBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nameBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nameBrand.Location = new System.Drawing.Point(534, 17);
            this.Txt_nameBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_nameBrand.Name = "Txt_nameBrand";
            this.Txt_nameBrand.PasswordChar = '\0';
            this.Txt_nameBrand.PlaceholderText = "";
            this.Txt_nameBrand.SelectedText = "";
            this.Txt_nameBrand.Size = new System.Drawing.Size(244, 29);
            this.Txt_nameBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(435, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên";
            // 
            // Txt_MaBrand
            // 
            this.Txt_MaBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_MaBrand.BorderRadius = 5;
            this.Txt_MaBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_MaBrand.DefaultText = "";
            this.Txt_MaBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_MaBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_MaBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_MaBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_MaBrand.Enabled = false;
            this.Txt_MaBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_MaBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MaBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_MaBrand.Location = new System.Drawing.Point(111, 17);
            this.Txt_MaBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_MaBrand.Name = "Txt_MaBrand";
            this.Txt_MaBrand.PasswordChar = '\0';
            this.Txt_MaBrand.PlaceholderText = "";
            this.Txt_MaBrand.SelectedText = "";
            this.Txt_MaBrand.Size = new System.Drawing.Size(244, 29);
            this.Txt_MaBrand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã";
            // 
            // BrandGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 600);
            this.Controls.Add(this.panel1);
            this.Name = "BrandGUI";
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.BrandGUI_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brand)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dgv_brand;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_exportExcelBrand;
        private Guna.UI2.WinForms.Guna2Button btn_importExcelBrand;
        private Guna.UI2.WinForms.Guna2Button btn_deleteBrand;
        private Guna.UI2.WinForms.Guna2Button btn_editBrand;
        private Guna.UI2.WinForms.Guna2Button btn_addBrand;
        private Guna.UI2.WinForms.Guna2TextBox Txt_nameBrand;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Txt_MaBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
    }
}