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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBillExport = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBillImport = new Guna.UI2.WinForms.Guna2Button();
            this.panelBillContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.BtnBillExport);
            this.panel1.Controls.Add(this.BtnBillImport);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 67);
            this.panel1.TabIndex = 0;
            // 
            // BtnBillExport
            // 
            this.BtnBillExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBillExport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnBillExport.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnBillExport.CheckedState.FillColor = System.Drawing.Color.Black;
            this.BtnBillExport.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnBillExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBillExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBillExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBillExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBillExport.FillColor = System.Drawing.Color.Black;
            this.BtnBillExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBillExport.ForeColor = System.Drawing.Color.White;
            this.BtnBillExport.Location = new System.Drawing.Point(424, 15);
            this.BtnBillExport.Name = "BtnBillExport";
            this.BtnBillExport.Size = new System.Drawing.Size(285, 45);
            this.BtnBillExport.TabIndex = 2;
            this.BtnBillExport.Text = "Phiếu Xuất";
            this.BtnBillExport.Click += new System.EventHandler(this.BtnBillExport_Click);
            // 
            // BtnBillImport
            // 
            this.BtnBillImport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnBillImport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnBillImport.Checked = true;
            this.BtnBillImport.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnBillImport.CheckedState.FillColor = System.Drawing.Color.Black;
            this.BtnBillImport.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnBillImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBillImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBillImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBillImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBillImport.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBillImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBillImport.ForeColor = System.Drawing.Color.White;
            this.BtnBillImport.Location = new System.Drawing.Point(43, 15);
            this.BtnBillImport.Name = "BtnBillImport";
            this.BtnBillImport.PressedColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnBillImport.Size = new System.Drawing.Size(285, 45);
            this.BtnBillImport.TabIndex = 1;
            this.BtnBillImport.Text = "Phiếu Nhập";
            this.BtnBillImport.Click += new System.EventHandler(this.BtnBillImport_Click);
            // 
            // panelBillContainer
            // 
            this.panelBillContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBillContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panelBillContainer.Location = new System.Drawing.Point(0, 115);
            this.panelBillContainer.Name = "panelBillContainer";
            this.panelBillContainer.Size = new System.Drawing.Size(741, 581);
            this.panelBillContainer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.TbSearch);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 36);
            this.panel2.TabIndex = 2;
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbSearch.BorderColor = System.Drawing.Color.White;
            this.TbSearch.BorderRadius = 15;
            this.TbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearch.DefaultText = "Tìm kiếm";
            this.TbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearch.IconRight = global::GUI.Properties.Resources.icon_search;
            this.TbSearch.IconRightOffset = new System.Drawing.Point(15, 0);
            this.TbSearch.Location = new System.Drawing.Point(230, 0);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.PasswordChar = '\0';
            this.TbSearch.PlaceholderText = "";
            this.TbSearch.SelectedText = "";
            this.TbSearch.Size = new System.Drawing.Size(374, 36);
            this.TbSearch.TabIndex = 3;
            // 
            // BillGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(741, 660);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBillContainer);
            this.Controls.Add(this.panel1);
            this.Name = "BillGui";
            this.Text = "BillGui";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnBillImport;
        private Guna.UI2.WinForms.Guna2Button BtnBillExport;
        private System.Windows.Forms.Panel panelBillContainer;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox TbSearch;
    }
}