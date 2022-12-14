namespace GUI
{
    partial class UC_Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lb_priceOder = new System.Windows.Forms.Label();
            this.lbl_Quantity_X_Price = new System.Windows.Forms.Label();
            this.lb_nameOder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "100,000 d";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(333, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedDepth = 0;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(59, 27);
            this.guna2CircleButton1.TabIndex = 10;
            this.guna2CircleButton1.Text = "-20%";
            // 
            // lb_priceOder
            // 
            this.lb_priceOder.AutoSize = true;
            this.lb_priceOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_priceOder.ForeColor = System.Drawing.Color.Black;
            this.lb_priceOder.Location = new System.Drawing.Point(330, 56);
            this.lb_priceOder.Name = "lb_priceOder";
            this.lb_priceOder.Size = new System.Drawing.Size(62, 15);
            this.lb_priceOder.TabIndex = 8;
            this.lb_priceOder.Text = "100,000 d";
            this.lb_priceOder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Quantity_X_Price
            // 
            this.lbl_Quantity_X_Price.AutoSize = true;
            this.lbl_Quantity_X_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity_X_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quantity_X_Price.Location = new System.Drawing.Point(21, 56);
            this.lbl_Quantity_X_Price.Name = "lbl_Quantity_X_Price";
            this.lbl_Quantity_X_Price.Size = new System.Drawing.Size(27, 15);
            this.lbl_Quantity_X_Price.TabIndex = 7;
            this.lbl_Quantity_X_Price.Text = "x10";
            // 
            // lb_nameOder
            // 
            this.lb_nameOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameOder.ForeColor = System.Drawing.Color.Black;
            this.lb_nameOder.Location = new System.Drawing.Point(21, 12);
            this.lb_nameOder.Name = "lb_nameOder";
            this.lb_nameOder.Size = new System.Drawing.Size(293, 34);
            this.lb_nameOder.TabIndex = 6;
            this.lb_nameOder.Text = "name san pham";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 1);
            this.label2.TabIndex = 12;
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.lb_priceOder);
            this.Controls.Add(this.lbl_Quantity_X_Price);
            this.Controls.Add(this.lb_nameOder);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(395, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        public System.Windows.Forms.Label lb_priceOder;
        private System.Windows.Forms.Label lbl_Quantity_X_Price;
        private System.Windows.Forms.Label lb_nameOder;
        private System.Windows.Forms.Label label2;
    }
}
