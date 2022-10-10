namespace GUI
{
    partial class ChartStaffGUI
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).BeginInit();
            this.panel9.SuspendLayout();
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
            this.panelChildForm.Controls.Add(this.panel9);
            this.panelChildForm.Location = new System.Drawing.Point(1, 1);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1066, 486);
            this.panelChildForm.TabIndex = 15;
            // 
            // chartCustomer
            // 
            this.chartCustomer.BackColor = System.Drawing.Color.Black;
            this.chartCustomer.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartCustomer.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartCustomer.Legends.Add(legend1);
            this.chartCustomer.Location = new System.Drawing.Point(14, 61);
            this.chartCustomer.Name = "chartCustomer";
            this.chartCustomer.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chartCustomer.Series.Add(series1);
            this.chartCustomer.Size = new System.Drawing.Size(524, 387);
            this.chartCustomer.TabIndex = 9;
            this.chartCustomer.Text = "chart1";
            this.chartCustomer.Click += new System.EventHandler(this.chartCustomer_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.iconButton3);
            this.panel9.Controls.Add(this.iconButton2);
            this.panel9.Controls.Add(this.iconButton1);
            this.panel9.Location = new System.Drawing.Point(10, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(258, 41);
            this.panel9.TabIndex = 7;
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(320, 17);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(83, 35);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Load data";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
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
            // ChartStaffGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1069, 488);
            this.Controls.Add(this.panelChildForm);
            this.Name = "ChartStaffGUI";
            this.Text = "ChartStaffGUI";
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}