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
            this.BtnBillImport = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBillExport = new Guna.UI2.WinForms.Guna2Button();
            this.panelBillContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBillExport);
            this.panel1.Controls.Add(this.BtnBillImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 60);
            this.panel1.TabIndex = 0;
            // 
            // BtnBillImport
            // 
            this.BtnBillImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBillImport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnBillImport.Checked = true;
            this.BtnBillImport.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnBillImport.CheckedState.FillColor = System.Drawing.Color.Black;
            this.BtnBillImport.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnBillImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBillImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBillImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBillImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBillImport.FillColor = System.Drawing.Color.Black;
            this.BtnBillImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBillImport.ForeColor = System.Drawing.Color.White;
            this.BtnBillImport.Location = new System.Drawing.Point(43, 12);
            this.BtnBillImport.Name = "BtnBillImport";
            this.BtnBillImport.Size = new System.Drawing.Size(285, 45);
            this.BtnBillImport.TabIndex = 1;
            this.BtnBillImport.Text = "Phiếu Nhập";
            this.BtnBillImport.Click += new System.EventHandler(this.BtnBillImport_Click);
            // 
            // BtnBillExport
            // 
            this.BtnBillExport.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.BtnBillExport.Location = new System.Drawing.Point(424, 12);
            this.BtnBillExport.Name = "BtnBillExport";
            this.BtnBillExport.Size = new System.Drawing.Size(285, 45);
            this.BtnBillExport.TabIndex = 2;
            this.BtnBillExport.Text = "Phiếu Xuất";
            this.BtnBillExport.Click += new System.EventHandler(this.BtnBillExport_Click);
            // 
            // panelBillContainer
            // 
            this.panelBillContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillContainer.Location = new System.Drawing.Point(0, 60);
            this.panelBillContainer.Name = "panelBillContainer";
            this.panelBillContainer.Size = new System.Drawing.Size(741, 600);
            this.panelBillContainer.TabIndex = 1;
            // 
            // BillGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(741, 660);
            this.Controls.Add(this.panelBillContainer);
            this.Controls.Add(this.panel1);
            this.Name = "BillGui";
            this.Text = "BillGui";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnBillImport;
        private Guna.UI2.WinForms.Guna2Button BtnBillExport;
        private System.Windows.Forms.Panel panelBillContainer;
    }
}