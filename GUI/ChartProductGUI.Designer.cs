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
            this.panel9 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.formChildProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // formChildProduct
            // 
            this.formChildProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(196)))));
            this.formChildProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.formChildProduct.BorderThickness = 1;
            this.formChildProduct.Controls.Add(this.btnLoad);
            this.formChildProduct.Controls.Add(this.chartProduct);
            this.formChildProduct.Controls.Add(this.panel9);
            this.formChildProduct.Location = new System.Drawing.Point(0, 1);
            this.formChildProduct.Name = "formChildProduct";
            this.formChildProduct.Size = new System.Drawing.Size(1051, 468);
            this.formChildProduct.TabIndex = 13;
            this.formChildProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.formChildProduct_Paint);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(329, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 35);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chartProduct
            // 
            this.chartProduct.BackColor = System.Drawing.Color.Black;
            this.chartProduct.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartProduct.Legends.Add(legend1);
            this.chartProduct.Location = new System.Drawing.Point(11, 70);
            this.chartProduct.Name = "chartProduct";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chartProduct.Series.Add(series1);
            this.chartProduct.Size = new System.Drawing.Size(524, 387);
            this.chartProduct.TabIndex = 8;
            this.chartProduct.Text = "chart1";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.iconButton3);
            this.panel9.Controls.Add(this.iconButton2);
            this.panel9.Controls.Add(this.iconButton1);
            this.panel9.Location = new System.Drawing.Point(10, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(293, 41);
            this.panel9.TabIndex = 7;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(170, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(83, 35);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Nhập vào";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(86, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(78, 35);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Bán ra";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(76, 35);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Tổng";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // ChartProductGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1052, 472);
            this.Controls.Add(this.formChildProduct);
            this.Name = "ChartProductGUI";
            this.Text = "ChartProductGUI";
            this.formChildProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel formChildProduct;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}