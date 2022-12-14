namespace GUI
{
    partial class UC_oder
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
            this.lb_nameOder = new System.Windows.Forms.Label();
            this.lb_priceOder = new System.Windows.Forms.Label();
            this.btn_deleteOder = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Quantity_X_Price = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nameOder
            // 
            this.lb_nameOder.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameOder.ForeColor = System.Drawing.Color.White;
            this.lb_nameOder.Location = new System.Drawing.Point(6, 9);
            this.lb_nameOder.Name = "lb_nameOder";
            this.lb_nameOder.Size = new System.Drawing.Size(201, 49);
            this.lb_nameOder.TabIndex = 0;
            this.lb_nameOder.Text = "name san pham";
            this.lb_nameOder.Click += new System.EventHandler(this.lb_nameOder_Click);
            // 
            // lb_priceOder
            // 
            this.lb_priceOder.AutoSize = true;
            this.lb_priceOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_priceOder.ForeColor = System.Drawing.Color.White;
            this.lb_priceOder.Location = new System.Drawing.Point(210, 54);
            this.lb_priceOder.Name = "lb_priceOder";
            this.lb_priceOder.Size = new System.Drawing.Size(62, 15);
            this.lb_priceOder.TabIndex = 2;
            this.lb_priceOder.Text = "100,000 d";
            this.lb_priceOder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_priceOder.Click += new System.EventHandler(this.lb_nameOder_Click);
            // 
            // btn_deleteOder
            // 
            this.btn_deleteOder.BorderRadius = 5;
            this.btn_deleteOder.BorderThickness = 1;
            this.btn_deleteOder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteOder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteOder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteOder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteOder.FillColor = System.Drawing.Color.White;
            this.btn_deleteOder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteOder.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteOder.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.btn_deleteOder.Location = new System.Drawing.Point(278, 27);
            this.btn_deleteOder.Name = "btn_deleteOder";
            this.btn_deleteOder.Size = new System.Drawing.Size(31, 31);
            this.btn_deleteOder.TabIndex = 3;
            this.btn_deleteOder.Text = "X";
            this.btn_deleteOder.Click += new System.EventHandler(this.btn_deleteOder_Click);
            // 
            // lbl_Quantity_X_Price
            // 
            this.lbl_Quantity_X_Price.AutoSize = true;
            this.lbl_Quantity_X_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity_X_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Quantity_X_Price.Location = new System.Drawing.Point(6, 54);
            this.lbl_Quantity_X_Price.Name = "lbl_Quantity_X_Price";
            this.lbl_Quantity_X_Price.Size = new System.Drawing.Size(27, 15);
            this.lbl_Quantity_X_Price.TabIndex = 1;
            this.lbl_Quantity_X_Price.Text = "x10";
            this.lbl_Quantity_X_Price.Click += new System.EventHandler(this.lb_nameOder_Click);
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(213, 9);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedDepth = 0;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(59, 27);
            this.guna2CircleButton1.TabIndex = 4;
            this.guna2CircleButton1.Text = "-20%";
            this.guna2CircleButton1.Click += new System.EventHandler(this.lb_nameOder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "100,000 d";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.lb_nameOder_Click);
            // 
            // UC_oder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btn_deleteOder);
            this.Controls.Add(this.lb_priceOder);
            this.Controls.Add(this.lbl_Quantity_X_Price);
            this.Controls.Add(this.lb_nameOder);
            this.Name = "UC_oder";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(323, 89);
            this.Click += new System.EventHandler(this.lb_nameOder_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nameOder;
        public System.Windows.Forms.Label lb_priceOder;
        public Guna.UI2.WinForms.Guna2Button btn_deleteOder;
        private System.Windows.Forms.Label lbl_Quantity_X_Price;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        public System.Windows.Forms.Label label1;
    }
}
