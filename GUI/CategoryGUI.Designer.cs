namespace GUI
{
    partial class CategoryGUI
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.export = new Guna.UI2.WinForms.Guna2Button();
            this.import = new Guna.UI2.WinForms.Guna2Button();
            this.create_Id = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Fix = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name_Category = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id_Category = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.guna2Panel3);
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 600);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.export);
            this.guna2Panel3.Controls.Add(this.import);
            this.guna2Panel3.Controls.Add(this.create_Id);
            this.guna2Panel3.Controls.Add(this.btn_Delete);
            this.guna2Panel3.Controls.Add(this.btn_Fix);
            this.guna2Panel3.Controls.Add(this.btn_Add);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.txt_Name_Category);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.txt_Id_Category);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(807, 123);
            this.guna2Panel3.TabIndex = 15;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // export
            // 
            this.export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.export.BackColor = System.Drawing.Color.Black;
            this.export.BorderColor = System.Drawing.Color.White;
            this.export.BorderRadius = 5;
            this.export.BorderThickness = 3;
            this.export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.export.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.Location = new System.Drawing.Point(557, 71);
            this.export.MaximumSize = new System.Drawing.Size(200, 200);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(111, 40);
            this.export.TabIndex = 23;
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 
            this.import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.import.BackColor = System.Drawing.Color.Black;
            this.import.BorderColor = System.Drawing.Color.White;
            this.import.BorderRadius = 5;
            this.import.BorderThickness = 3;
            this.import.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.import.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.import.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.import.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.import.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.import.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.import.ForeColor = System.Drawing.Color.White;
            this.import.Location = new System.Drawing.Point(691, 71);
            this.import.MaximumSize = new System.Drawing.Size(200, 200);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(111, 40);
            this.import.TabIndex = 22;
            this.import.Text = "Import";
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // create_Id
            // 
            this.create_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_Id.BackColor = System.Drawing.Color.Black;
            this.create_Id.BorderColor = System.Drawing.Color.White;
            this.create_Id.BorderRadius = 5;
            this.create_Id.BorderThickness = 3;
            this.create_Id.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.create_Id.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.create_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.create_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.create_Id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.create_Id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.create_Id.ForeColor = System.Drawing.Color.White;
            this.create_Id.Location = new System.Drawing.Point(8, 71);
            this.create_Id.MaximumSize = new System.Drawing.Size(200, 200);
            this.create_Id.Name = "create_Id";
            this.create_Id.Size = new System.Drawing.Size(111, 40);
            this.create_Id.TabIndex = 21;
            this.create_Id.Text = "Refresh";
            this.create_Id.Click += new System.EventHandler(this.create_Id_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.Black;
            this.btn_Delete.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.BorderRadius = 5;
            this.btn_Delete.BorderThickness = 3;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(418, 71);
            this.btn_Delete.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(111, 40);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Fix
            // 
            this.btn_Fix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Fix.BackColor = System.Drawing.Color.Black;
            this.btn_Fix.BorderColor = System.Drawing.Color.White;
            this.btn_Fix.BorderRadius = 5;
            this.btn_Fix.BorderThickness = 3;
            this.btn_Fix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Fix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Fix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Fix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Fix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_Fix.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Fix.ForeColor = System.Drawing.Color.White;
            this.btn_Fix.Location = new System.Drawing.Point(279, 71);
            this.btn_Fix.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(111, 40);
            this.btn_Fix.TabIndex = 17;
            this.btn_Fix.Text = "Sửa";
            this.btn_Fix.Click += new System.EventHandler(this.btn_Fix_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.Black;
            this.btn_Add.BorderColor = System.Drawing.Color.White;
            this.btn_Add.BorderRadius = 5;
            this.btn_Add.BorderThickness = 3;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(145, 71);
            this.btn_Add.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 40);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên loại";
            // 
            // txt_Name_Category
            // 
            this.txt_Name_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Name_Category.BorderRadius = 5;
            this.txt_Name_Category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name_Category.DefaultText = "";
            this.txt_Name_Category.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name_Category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name_Category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name_Category.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name_Category.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txt_Name_Category.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name_Category.Location = new System.Drawing.Point(519, 11);
            this.txt_Name_Category.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Name_Category.Name = "txt_Name_Category";
            this.txt_Name_Category.PasswordChar = '\0';
            this.txt_Name_Category.PlaceholderText = "";
            this.txt_Name_Category.SelectedText = "";
            this.txt_Name_Category.Size = new System.Drawing.Size(283, 33);
            this.txt_Name_Category.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã loại";
            // 
            // txt_Id_Category
            // 
            this.txt_Id_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Id_Category.BorderRadius = 5;
            this.txt_Id_Category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Id_Category.DefaultText = "";
            this.txt_Id_Category.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Id_Category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Id_Category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Id_Category.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Id_Category.Enabled = false;
            this.txt_Id_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Id_Category.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txt_Id_Category.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Id_Category.Location = new System.Drawing.Point(107, 11);
            this.txt_Id_Category.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Id_Category.Name = "txt_Id_Category";
            this.txt_Id_Category.PasswordChar = '\0';
            this.txt_Id_Category.PlaceholderText = "";
            this.txt_Id_Category.ReadOnly = true;
            this.txt_Id_Category.SelectedText = "";
            this.txt_Id_Category.Size = new System.Drawing.Size(283, 33);
            this.txt_Id_Category.TabIndex = 12;
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
            this.guna2Panel2.Controls.Add(this.txt_Search);
            this.guna2Panel2.Controls.Add(this.dataGridViewCategory);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 129);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(802, 470);
            this.guna2Panel2.TabIndex = 14;
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.BorderColor = System.Drawing.Color.White;
            this.txt_Search.BorderRadius = 15;
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
            this.txt_Search.Location = new System.Drawing.Point(507, 10);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Tìm kiếm";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(294, 36);
            this.txt_Search.TabIndex = 18;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameCategory});
            this.dataGridViewCategory.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.Size = new System.Drawing.Size(796, 415);
            this.dataGridViewCategory.TabIndex = 16;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã loại sản phẩm";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nameCategory
            // 
            this.nameCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCategory.DataPropertyName = "nameCategory";
            this.nameCategory.HeaderText = "Tên loại sản phẩm";
            this.nameCategory.MinimumWidth = 6;
            this.nameCategory.Name = "nameCategory";
            this.nameCategory.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Danh sách danh mục";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CategoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 600);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(807, 591);
            this.Name = "CategoryGUI";
            this.Text = "CategoryGUI";
            this.Load += new System.EventHandler(this.CategoryGUI_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Fix;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name_Category;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Id_Category;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button create_Id;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button export;
        private Guna.UI2.WinForms.Guna2Button import;
    }
}