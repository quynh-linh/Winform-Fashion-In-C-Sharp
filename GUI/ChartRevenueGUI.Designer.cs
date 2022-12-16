namespace GUI
{
    partial class ChartRevenueGUI
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel9 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.chartCustomer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.statistic = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridViewRevenue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.doanhThu = new Guna.UI2.WinForms.Guna2TextBox();
            this.doanhThu2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.iconButton3);
            this.panel9.Controls.Add(this.iconButton2);
            this.panel9.Controls.Add(this.iconButton1);
            this.panel9.Location = new System.Drawing.Point(8, 9);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(254, 30);
            this.panel9.TabIndex = 7;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(148, 2);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(104, 28);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Nhập vào";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(64, 2);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(80, 28);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Bán ra";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 2);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(57, 28);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Tổng";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // chartCustomer
            // 
            this.chartCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.chartCustomer.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chartCustomer.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartCustomer.BackSecondaryColor = System.Drawing.Color.DimGray;
            this.chartCustomer.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartCustomer.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chartCustomer.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartCustomer.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartCustomer.Legends.Add(legend1);
            this.chartCustomer.Location = new System.Drawing.Point(2, 59);
            this.chartCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartCustomer.Name = "chartCustomer";
            this.chartCustomer.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.Legend = "Legend1";
            series1.Name = "Nhập vào";
            series1.ShadowColor = System.Drawing.Color.DimGray;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Bán ra";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chartCustomer.Series.Add(series1);
            this.chartCustomer.Series.Add(series2);
            this.chartCustomer.Size = new System.Drawing.Size(557, 384);
            this.chartCustomer.TabIndex = 9;
            this.chartCustomer.Text = "chart1";
            title1.ForeColor = System.Drawing.Color.IndianRed;
            title1.Name = "Lợi nhuận";
            this.chartCustomer.Titles.Add(title1);
            this.chartCustomer.Click += new System.EventHandler(this.chartCustomer_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(267, 11);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(91, 27);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Load data";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // statistic
            // 
            this.statistic.BackColor = System.Drawing.Color.Transparent;
            this.statistic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statistic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statistic.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statistic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statistic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statistic.ItemHeight = 30;
            this.statistic.ItemsAppearance.BackColor = System.Drawing.Color.Gainsboro;
            this.statistic.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistic.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.statistic.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White;
            this.statistic.ItemsAppearance.SelectedFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistic.ItemsAppearance.SelectedForeColor = System.Drawing.Color.DimGray;
            this.statistic.Location = new System.Drawing.Point(610, 9);
            this.statistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(156, 36);
            this.statistic.TabIndex = 10;
            this.statistic.SelectedIndexChanged += new System.EventHandler(this.statistic_SelectedIndexChanged);
            // 
            // dataGridViewRevenue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRevenue.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewRevenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRevenue.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRevenue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRevenue.GridColor = System.Drawing.Color.White;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(565, 59);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.RowHeadersVisible = false;
            this.dataGridViewRevenue.RowHeadersWidth = 51;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(238, 358);
            this.dataGridViewRevenue.TabIndex = 16;
            this.dataGridViewRevenue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRevenue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewRevenue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRevenue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewRevenue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRevenue.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRevenue.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridViewRevenue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewRevenue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewRevenue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRevenue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRevenue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRevenue.ThemeStyle.HeaderStyle.Height = 60;
            this.dataGridViewRevenue.ThemeStyle.ReadOnly = false;
            this.dataGridViewRevenue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRevenue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRevenue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRevenue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewRevenue.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewRevenue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRevenue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // doanhThu
            // 
            this.doanhThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.doanhThu.DefaultText = "Doanh Thu : 0";
            this.doanhThu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.doanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.doanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.doanhThu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.doanhThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.doanhThu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doanhThu.Location = new System.Drawing.Point(913, 552);
            this.doanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doanhThu.Name = "doanhThu";
            this.doanhThu.PasswordChar = '\0';
            this.doanhThu.PlaceholderText = "";
            this.doanhThu.SelectedText = "";
            this.doanhThu.Size = new System.Drawing.Size(244, 46);
            this.doanhThu.TabIndex = 17;
            // 
            // doanhThu2
            // 
            this.doanhThu2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.doanhThu2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.doanhThu2.DefaultText = "Doanh thu : 0 vnđ";
            this.doanhThu2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.doanhThu2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.doanhThu2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.doanhThu2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.doanhThu2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.doanhThu2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doanhThu2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.doanhThu2.ForeColor = System.Drawing.Color.White;
            this.doanhThu2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doanhThu2.Location = new System.Drawing.Point(565, 386);
            this.doanhThu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doanhThu2.Name = "doanhThu2";
            this.doanhThu2.PasswordChar = '\0';
            this.doanhThu2.PlaceholderText = "";
            this.doanhThu2.SelectedText = "";
            this.doanhThu2.Size = new System.Drawing.Size(238, 55);
            this.doanhThu2.TabIndex = 18;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panelChildForm.BorderColor = System.Drawing.Color.Black;
            this.panelChildForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.panelChildForm.BorderThickness = 1;
            this.panelChildForm.Controls.Add(this.iconButton5);
            this.panelChildForm.Controls.Add(this.doanhThu2);
            this.panelChildForm.Controls.Add(this.doanhThu);
            this.panelChildForm.Controls.Add(this.dataGridViewRevenue);
            this.panelChildForm.Controls.Add(this.statistic);
            this.panelChildForm.Controls.Add(this.iconButton4);
            this.panelChildForm.Controls.Add(this.chartCustomer);
            this.panelChildForm.Controls.Add(this.panel9);
            this.panelChildForm.Location = new System.Drawing.Point(1, 1);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(802, 452);
            this.panelChildForm.TabIndex = 15;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(508, 11);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(98, 28);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.Text = "Export";
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // ChartRevenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChartRevenueGUI";
            this.Text = "ChartStaffGUI";
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Guna.UI2.WinForms.Guna2ComboBox statistic;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRevenue;
        private Guna.UI2.WinForms.Guna2TextBox doanhThu;
        private Guna.UI2.WinForms.Guna2TextBox doanhThu2;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}