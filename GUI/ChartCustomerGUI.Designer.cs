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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.chartCustomer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panelChildForm.BorderColor = System.Drawing.Color.White;
            this.panelChildForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.panelChildForm.BorderThickness = 1;
            this.panelChildForm.Controls.Add(this.chartCustomer);
            this.panelChildForm.Controls.Add(this.iconButton4);
            this.panelChildForm.Location = new System.Drawing.Point(2, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(800, 395);
            this.panelChildForm.TabIndex = 14;
            // 
            // chartCustomer
            // 
            this.chartCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.chartCustomer.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chartCustomer.BackImageTransparentColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartCustomer.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartCustomer.Legends.Add(legend1);
            this.chartCustomer.Location = new System.Drawing.Point(7, 61);
            this.chartCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.chartCustomer.Name = "chartCustomer";
            this.chartCustomer.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.chartCustomer.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chartCustomer.Series.Add(series1);
            this.chartCustomer.Size = new System.Drawing.Size(657, 324);
            this.chartCustomer.TabIndex = 10;
            this.chartCustomer.Text = "chart1";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(7, 9);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(82, 28);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Lấy dữ liệu";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // ChartCustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChartCustomerGUI";
            this.Text = "ChartCustomerGUI";
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
    }
}