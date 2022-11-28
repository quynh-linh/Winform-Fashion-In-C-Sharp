namespace GUI
{
    partial class ChartCustomerGUI
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.chartCustomer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelChildForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(196)))));
            this.panelChildForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.panelChildForm.BorderThickness = 1;
            this.panelChildForm.Controls.Add(this.iconButton4);
            this.panelChildForm.Controls.Add(this.chartCustomer);
            this.panelChildForm.Location = new System.Drawing.Point(3, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1067, 486);
            this.panelChildForm.TabIndex = 14;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(320, 17);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(109, 34);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Lấy dữ liệu";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // chartCustomer
            // 
            this.chartCustomer.BackColor = System.Drawing.Color.Black;
            this.chartCustomer.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartCustomer.ChartAreas.Add(chartArea1);
            this.chartCustomer.Location = new System.Drawing.Point(11, 62);
            this.chartCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCustomer.Name = "chartCustomer";
            this.chartCustomer.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsXValueIndexed = true;
            series1.LabelAngle = 12;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series1.Name = "Quantity";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartCustomer.Series.Add(series1);
            this.chartCustomer.Size = new System.Drawing.Size(524, 386);
            this.chartCustomer.TabIndex = 9;
            this.chartCustomer.Text = "chart1";
            this.chartCustomer.Click += new System.EventHandler(this.chartProduct_Click);
            // 
            // ChartCustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 485);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChartCustomerGUI";
            this.Text = "ChartCustomerGUI";
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}