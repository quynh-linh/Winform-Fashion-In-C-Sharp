namespace GUI
{
    partial class UC_Role_GUI
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Fix = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.btn_Delete);
            this.guna2Panel3.Controls.Add(this.btn_Fix);
            this.guna2Panel3.Controls.Add(this.btn_Add);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(783, 82);
            this.guna2Panel3.TabIndex = 16;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.Black;
            this.btn_Delete.BorderRadius = 5;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(575, 21);
            this.btn_Delete.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 40);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Xóa";
            // 
            // btn_Fix
            // 
            this.btn_Fix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Fix.BackColor = System.Drawing.Color.Black;
            this.btn_Fix.BorderRadius = 5;
            this.btn_Fix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Fix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Fix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Fix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Fix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.btn_Fix.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Fix.ForeColor = System.Drawing.Color.White;
            this.btn_Fix.Location = new System.Drawing.Point(349, 21);
            this.btn_Fix.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(130, 40);
            this.btn_Fix.TabIndex = 17;
            this.btn_Fix.Text = "Sửa";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.Black;
            this.btn_Add.BorderRadius = 5;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(89, 21);
            this.btn_Add.MaximumSize = new System.Drawing.Size(200, 200);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(130, 40);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Thêm";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.TbSearch);
            this.guna2Panel2.Controls.Add(this.dataGridViewCategory);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(783, 406);
            this.guna2Panel2.TabIndex = 17;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.role_name});
            this.dataGridViewCategory.Location = new System.Drawing.Point(3, 67);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.Size = new System.Drawing.Size(778, 336);
            this.dataGridViewCategory.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Danh sách vai trò";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã vai trò";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // role_name
            // 
            this.role_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role_name.DataPropertyName = "role_name";
            this.role_name.HeaderText = "Tên vai trò";
            this.role_name.Name = "role_name";
            this.role_name.ReadOnly = true;
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.TbSearch.BorderRadius = 15;
            this.TbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearch.DefaultText = "";
            this.TbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearch.IconRight = global::GUI.Properties.Resources.icon_search;
            this.TbSearch.IconRightOffset = new System.Drawing.Point(15, 0);
            this.TbSearch.Location = new System.Drawing.Point(480, 15);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.PasswordChar = '\0';
            this.TbSearch.PlaceholderText = "Tìm kiếm";
            this.TbSearch.SelectedText = "";
            this.TbSearch.Size = new System.Drawing.Size(300, 36);
            this.TbSearch.TabIndex = 18;
            // 
            // UC_Role_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Name = "UC_Role_GUI";
            this.Size = new System.Drawing.Size(783, 509);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Fix;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_name;
        private Guna.UI2.WinForms.Guna2TextBox TbSearch;
    }
}
