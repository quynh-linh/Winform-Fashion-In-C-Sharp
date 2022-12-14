namespace GUI
{
    partial class UC_Sell_Item
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
            this.ptc_imageProductItem = new System.Windows.Forms.PictureBox();
            this.lb_nameProductItem = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_imageProductItem)).BeginInit();
            this.SuspendLayout();
            // 
            // ptc_imageProductItem
            // 
            this.ptc_imageProductItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptc_imageProductItem.Image = global::GUI.Properties.Resources.demo_fashion;
            this.ptc_imageProductItem.Location = new System.Drawing.Point(3, 3);
            this.ptc_imageProductItem.Name = "ptc_imageProductItem";
            this.ptc_imageProductItem.Size = new System.Drawing.Size(75, 98);
            this.ptc_imageProductItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptc_imageProductItem.TabIndex = 0;
            this.ptc_imageProductItem.TabStop = false;
            this.ptc_imageProductItem.Click += new System.EventHandler(this.ptc_imageProductItem_Click);
            this.ptc_imageProductItem.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // lb_nameProductItem
            // 
            this.lb_nameProductItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nameProductItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameProductItem.ForeColor = System.Drawing.Color.Black;
            this.lb_nameProductItem.Location = new System.Drawing.Point(84, 3);
            this.lb_nameProductItem.Name = "lb_nameProductItem";
            this.lb_nameProductItem.Size = new System.Drawing.Size(96, 54);
            this.lb_nameProductItem.TabIndex = 2;
            this.lb_nameProductItem.Text = "Nakaroth";
            this.lb_nameProductItem.Click += new System.EventHandler(this.ptc_imageProductItem_Click);
            this.lb_nameProductItem.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(104, 60);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedDepth = 0;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(59, 30);
            this.guna2CircleButton1.TabIndex = 3;
            this.guna2CircleButton1.Text = "-20%";
            this.guna2CircleButton1.Click += new System.EventHandler(this.ptc_imageProductItem_Click);
            this.guna2CircleButton1.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.guna2CircleButton1.MouseLeave += new System.EventHandler(this.UC_Sell_Item_MouseLeave);
            // 
            // UC_Sell_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.lb_nameProductItem);
            this.Controls.Add(this.ptc_imageProductItem);
            this.Name = "UC_Sell_Item";
            this.Size = new System.Drawing.Size(183, 104);
            this.Click += new System.EventHandler(this.ptc_imageProductItem_Click);
            this.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_Sell_Item_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ptc_imageProductItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ptc_imageProductItem;
        public System.Windows.Forms.Label lb_nameProductItem;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}
