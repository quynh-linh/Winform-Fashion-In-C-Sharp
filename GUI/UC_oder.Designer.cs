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
            this.lb_quantityOder = new System.Windows.Forms.Label();
            this.lb_priceOder = new System.Windows.Forms.Label();
            this.btn_deleteOder = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_sizeOder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nameOder
            // 
            this.lb_nameOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameOder.Location = new System.Drawing.Point(6, 9);
            this.lb_nameOder.Name = "lb_nameOder";
            this.lb_nameOder.Size = new System.Drawing.Size(100, 23);
            this.lb_nameOder.TabIndex = 0;
            this.lb_nameOder.Text = "name san pham";
            // 
            // lb_quantityOder
            // 
            this.lb_quantityOder.AutoSize = true;
            this.lb_quantityOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantityOder.Location = new System.Drawing.Point(62, 43);
            this.lb_quantityOder.Name = "lb_quantityOder";
            this.lb_quantityOder.Size = new System.Drawing.Size(30, 17);
            this.lb_quantityOder.TabIndex = 1;
            this.lb_quantityOder.Text = "x10";
            // 
            // lb_priceOder
            // 
            this.lb_priceOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_priceOder.Location = new System.Drawing.Point(6, 66);
            this.lb_priceOder.Name = "lb_priceOder";
            this.lb_priceOder.Size = new System.Drawing.Size(86, 17);
            this.lb_priceOder.TabIndex = 2;
            this.lb_priceOder.Text = "100,000 d";
            // 
            // btn_deleteOder
            // 
            this.btn_deleteOder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteOder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteOder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteOder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteOder.FillColor = System.Drawing.Color.White;
            this.btn_deleteOder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteOder.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteOder.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.btn_deleteOder.Location = new System.Drawing.Point(242, 29);
            this.btn_deleteOder.Name = "btn_deleteOder";
            this.btn_deleteOder.Size = new System.Drawing.Size(31, 31);
            this.btn_deleteOder.TabIndex = 3;
            this.btn_deleteOder.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size  :";
            // 
            // lb_sizeOder
            // 
            this.lb_sizeOder.AutoSize = true;
            this.lb_sizeOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sizeOder.Location = new System.Drawing.Point(184, 43);
            this.lb_sizeOder.Name = "lb_sizeOder";
            this.lb_sizeOder.Size = new System.Drawing.Size(18, 17);
            this.lb_sizeOder.TabIndex = 5;
            this.lb_sizeOder.Text = "S";
            // 
            // UC_oder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lb_sizeOder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deleteOder);
            this.Controls.Add(this.lb_priceOder);
            this.Controls.Add(this.lb_quantityOder);
            this.Controls.Add(this.lb_nameOder);
            this.Name = "UC_oder";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(287, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nameOder;
        private System.Windows.Forms.Label lb_quantityOder;
        private System.Windows.Forms.Label lb_priceOder;
        private Guna.UI2.WinForms.Guna2Button btn_deleteOder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_sizeOder;
    }
}
