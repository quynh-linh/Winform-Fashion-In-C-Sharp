namespace GUI
{
    partial class ChartProductGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.formChildProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.formChildProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // formChildProduct
            // 
            this.formChildProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formChildProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.formChildProduct.BorderColor = System.Drawing.Color.White;
            this.formChildProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.formChildProduct.BorderThickness = 1;
            this.formChildProduct.Controls.Add(this.btnLoad);
            this.formChildProduct.Controls.Add(this.chartProduct);
            this.formChildProduct.Location = new System.Drawing.Point(0, 1);
            this.formChildProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formChildProduct.Name = "formChildProduct";
            this.formChildProduct.Size = new System.Drawing.Size(788, 380);
            this.formChildProduct.TabIndex = 13;
            this.formChildProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.formChildProduct_Paint);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(52, 8);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 28);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chartProduct
            // 
            this.chartProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.chartProduct.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chartProduct.BackImageTransparentColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartProduct.Legends.Add(legend1);
            this.chartProduct.Location = new System.Drawing.Point(11, 48);
            this.chartProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartProduct.Name = "chartProduct";
            this.chartProduct.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.chartProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chartProduct.Series.Add(series1);
            this.chartProduct.Size = new System.Drawing.Size(634, 314);
            this.chartProduct.TabIndex = 8;
            this.chartProduct.Text = "chart1";
            // 
            // ChartProductGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(789, 384);
            this.Controls.Add(this.formChildProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChartProductGUI";
            this.Text = "ChartProductGUI";
            this.formChildProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel formChildProduct;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
    }
}