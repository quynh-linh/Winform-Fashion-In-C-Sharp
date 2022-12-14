namespace GUI
{
    partial class UC_Bill_import
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
            this.label2 = new System.Windows.Forms.Label();
            this.lb_priceOder = new System.Windows.Forms.Label();
            this.lbl_Quantity_X_Price = new System.Windows.Forms.Label();
            this.lb_nameOder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 1);
            this.label2.TabIndex = 18;
            // 
            // lb_priceOder
            // 
            this.lb_priceOder.AutoSize = true;
            this.lb_priceOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_priceOder.ForeColor = System.Drawing.Color.Black;
            this.lb_priceOder.Location = new System.Drawing.Point(288, 41);
            this.lb_priceOder.Name = "lb_priceOder";
            this.lb_priceOder.Size = new System.Drawing.Size(62, 15);
            this.lb_priceOder.TabIndex = 15;
            this.lb_priceOder.Text = "100,000 d";
            this.lb_priceOder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Quantity_X_Price
            // 
            this.lbl_Quantity_X_Price.AutoSize = true;
            this.lbl_Quantity_X_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity_X_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quantity_X_Price.Location = new System.Drawing.Point(26, 54);
            this.lbl_Quantity_X_Price.Name = "lbl_Quantity_X_Price";
            this.lbl_Quantity_X_Price.Size = new System.Drawing.Size(27, 15);
            this.lbl_Quantity_X_Price.TabIndex = 14;
            this.lbl_Quantity_X_Price.Text = "x10";
            // 
            // lb_nameOder
            // 
            this.lb_nameOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameOder.ForeColor = System.Drawing.Color.Black;
            this.lb_nameOder.Location = new System.Drawing.Point(26, 5);
            this.lb_nameOder.Name = "lb_nameOder";
            this.lb_nameOder.Size = new System.Drawing.Size(255, 34);
            this.lb_nameOder.TabIndex = 13;
            this.lb_nameOder.Text = "name san pham";
            // 
            // UC_Bill_import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_priceOder);
            this.Controls.Add(this.lbl_Quantity_X_Price);
            this.Controls.Add(this.lb_nameOder);
            this.Name = "UC_Bill_import";
            this.Size = new System.Drawing.Size(395, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_priceOder;
        private System.Windows.Forms.Label lbl_Quantity_X_Price;
        private System.Windows.Forms.Label lb_nameOder;
    }
}
