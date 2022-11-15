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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptc_imageProductItem = new System.Windows.Forms.PictureBox();
            this.lb_nameProductItem = new System.Windows.Forms.Label();
            this.lb_priceProductItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_imageProductItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GUI.Properties.Resources.icon_addcart;
            this.pictureBox2.Location = new System.Drawing.Point(120, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ptc_imageProductItem
            // 
            this.ptc_imageProductItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptc_imageProductItem.Image = global::GUI.Properties.Resources.demo_fashion;
            this.ptc_imageProductItem.Location = new System.Drawing.Point(3, 3);
            this.ptc_imageProductItem.Name = "ptc_imageProductItem";
            this.ptc_imageProductItem.Size = new System.Drawing.Size(67, 85);
            this.ptc_imageProductItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptc_imageProductItem.TabIndex = 0;
            this.ptc_imageProductItem.TabStop = false;
            // 
            // lb_nameProductItem
            // 
            this.lb_nameProductItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nameProductItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameProductItem.Location = new System.Drawing.Point(76, 14);
            this.lb_nameProductItem.Name = "lb_nameProductItem";
            this.lb_nameProductItem.Size = new System.Drawing.Size(59, 13);
            this.lb_nameProductItem.TabIndex = 2;
            this.lb_nameProductItem.Text = "Nakaroth";
            // 
            // lb_priceProductItem
            // 
            this.lb_priceProductItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_priceProductItem.AutoSize = true;
            this.lb_priceProductItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_priceProductItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_priceProductItem.Location = new System.Drawing.Point(68, 61);
            this.lb_priceProductItem.Name = "lb_priceProductItem";
            this.lb_priceProductItem.Size = new System.Drawing.Size(46, 9);
            this.lb_priceProductItem.TabIndex = 3;
            this.lb_priceProductItem.Text = "100.000 đ";
            // 
            // UC_Sell_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_priceProductItem);
            this.Controls.Add(this.lb_nameProductItem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ptc_imageProductItem);
            this.Name = "UC_Sell_Item";
            this.Size = new System.Drawing.Size(149, 91);
            this.Click += new System.EventHandler(this.UC_Sell_Item_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_imageProductItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptc_imageProductItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_nameProductItem;
        private System.Windows.Forms.Label lb_priceProductItem;
    }
}
