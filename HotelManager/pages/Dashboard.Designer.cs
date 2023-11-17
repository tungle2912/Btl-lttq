﻿namespace HotelManager.pages
{
    partial class Dashboard
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
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dtpNgay = new Bunifu.Framework.UI.BunifuDatepicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbPTNB = new System.Windows.Forms.Label();
			this.lbNBO = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labeltotalprofit = new System.Windows.Forms.Label();
			this.lbPTTP = new System.Windows.Forms.Label();
			this.lbTotaP = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbPTTR = new System.Windows.Forms.Label();
			this.lbTotalReven = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lbPTEM = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lbTotalAvaliable = new System.Windows.Forms.Label();
			this.lbTotalBooked = new System.Windows.Forms.Label();
			this.lbTotalRoom = new System.Windows.Forms.Label();
			this.lbTotalstaff = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.datahoadon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.iconButton4 = new FontAwesome.Sharp.IconButton();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.ExportDataBtn = new FontAwesome.Sharp.IconButton();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datahoadon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// elementHost1
			// 
			this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elementHost1.Location = new System.Drawing.Point(0, 0);
			this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(465, 235);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.cartesianChart1;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.dtpNgay);
			this.panel4.Controls.Add(this.ExportDataBtn);
			this.panel4.Location = new System.Drawing.Point(0, 2);
			this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1725, 82);
			this.panel4.TabIndex = 16;
			// 
			// dtpNgay
			// 
			this.dtpNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			this.dtpNgay.BorderRadius = 0;
			this.dtpNgay.ForeColor = System.Drawing.Color.White;
			this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpNgay.FormatCustom = null;
			this.dtpNgay.Location = new System.Drawing.Point(30, 14);
			this.dtpNgay.Margin = new System.Windows.Forms.Padding(6);
			this.dtpNgay.Name = "dtpNgay";
			this.dtpNgay.Size = new System.Drawing.Size(420, 60);
			this.dtpNgay.TabIndex = 156;
			this.dtpNgay.Value = new System.DateTime(2023, 11, 8, 14, 52, 17, 840);
			this.dtpNgay.onValueChanged += new System.EventHandler(this.dtpNgay_onValueChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lbPTNB);
			this.panel1.Controls.Add(this.lbNBO);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(24, 88);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(420, 98);
			this.panel1.TabIndex = 17;
			// 
			// lbPTNB
			// 
			this.lbPTNB.AutoSize = true;
			this.lbPTNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPTNB.ForeColor = System.Drawing.Color.LightGreen;
			this.lbPTNB.Location = new System.Drawing.Point(318, 29);
			this.lbPTNB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPTNB.Name = "lbPTNB";
			this.lbPTNB.Size = new System.Drawing.Size(75, 29);
			this.lbPTNB.TabIndex = 6;
			this.lbPTNB.Text = "+15%";
			// 
			// lbNBO
			// 
			this.lbNBO.AutoSize = true;
			this.lbNBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNBO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbNBO.Location = new System.Drawing.Point(98, 48);
			this.lbNBO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNBO.Name = "lbNBO";
			this.lbNBO.Size = new System.Drawing.Size(65, 29);
			this.lbNBO.TabIndex = 5;
			this.lbNBO.Text = "1000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(99, 14);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Number of Order";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel3.Controls.Add(this.labeltotalprofit);
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Controls.Add(this.lbPTTP);
			this.panel3.Controls.Add(this.lbTotaP);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Location = new System.Drawing.Point(1336, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 49, 4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(360, 94);
			this.panel3.TabIndex = 18;
			// 
			// labeltotalprofit
			// 
			this.labeltotalprofit.AutoSize = true;
			this.labeltotalprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltotalprofit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labeltotalprofit.Location = new System.Drawing.Point(114, 42);
			this.labeltotalprofit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labeltotalprofit.Name = "labeltotalprofit";
			this.labeltotalprofit.Size = new System.Drawing.Size(65, 29);
			this.labeltotalprofit.TabIndex = 13;
			this.labeltotalprofit.Text = "1000";
			// 
			// lbPTTP
			// 
			this.lbPTTP.AutoSize = true;
			this.lbPTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPTTP.ForeColor = System.Drawing.Color.LimeGreen;
			this.lbPTTP.Location = new System.Drawing.Point(280, 29);
			this.lbPTTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPTTP.Name = "lbPTTP";
			this.lbPTTP.Size = new System.Drawing.Size(75, 29);
			this.lbPTTP.TabIndex = 9;
			this.lbPTTP.Text = "+15%";
			this.lbPTTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTotaP
			// 
			this.lbTotaP.AutoSize = true;
			this.lbTotaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotaP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbTotaP.Location = new System.Drawing.Point(96, 48);
			this.lbTotaP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotaP.Name = "lbTotaP";
			this.lbTotaP.Size = new System.Drawing.Size(0, 29);
			this.lbTotaP.TabIndex = 7;
			this.lbTotaP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Gray;
			this.label8.Location = new System.Drawing.Point(104, 11);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 25);
			this.label8.TabIndex = 8;
			this.label8.Text = "Total Profit";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.lbPTTR);
			this.panel2.Controls.Add(this.lbTotalReven);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Location = new System.Drawing.Point(467, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(444, 98);
			this.panel2.TabIndex = 19;
			// 
			// lbPTTR
			// 
			this.lbPTTR.AutoSize = true;
			this.lbPTTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPTTR.ForeColor = System.Drawing.Color.LimeGreen;
			this.lbPTTR.Location = new System.Drawing.Point(341, 29);
			this.lbPTTR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPTTR.Name = "lbPTTR";
			this.lbPTTR.Size = new System.Drawing.Size(75, 29);
			this.lbPTTR.TabIndex = 9;
			this.lbPTTR.Text = "+25%";
			this.lbPTTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTotalReven
			// 
			this.lbTotalReven.AutoSize = true;
			this.lbTotalReven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalReven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbTotalReven.Location = new System.Drawing.Point(141, 48);
			this.lbTotalReven.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalReven.Name = "lbTotalReven";
			this.lbTotalReven.Size = new System.Drawing.Size(65, 29);
			this.lbTotalReven.TabIndex = 7;
			this.lbTotalReven.Text = "1000";
			this.lbTotalReven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Gray;
			this.label5.Location = new System.Drawing.Point(141, 12);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Total Revenue";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Controls.Add(this.panel3);
			this.panel5.Location = new System.Drawing.Point(0, 89);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1725, 100);
			this.panel5.TabIndex = 20;
			// 
			// panel7
			// 
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel7.Controls.Add(this.pictureBox4);
			this.panel7.Controls.Add(this.label1);
			this.panel7.Controls.Add(this.lbPTEM);
			this.panel7.Controls.Add(this.label4);
			this.panel7.Location = new System.Drawing.Point(932, -1);
			this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(381, 98);
			this.panel7.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightGreen;
			this.label1.Location = new System.Drawing.Point(284, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 29);
			this.label1.TabIndex = 6;
			this.label1.Text = "+15%";
			// 
			// lbPTEM
			// 
			this.lbPTEM.AutoSize = true;
			this.lbPTEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPTEM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbPTEM.Location = new System.Drawing.Point(104, 48);
			this.lbPTEM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPTEM.Name = "lbPTEM";
			this.lbPTEM.Size = new System.Drawing.Size(65, 29);
			this.lbPTEM.TabIndex = 5;
			this.lbPTEM.Text = "1000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Gray;
			this.label4.Location = new System.Drawing.Point(104, 14);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Employee salary";
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			chartArea1.AxisX.IsMarginVisible = false;
			chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
			chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
			chartArea1.AxisX.MajorGrid.LineWidth = 0;
			chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
			chartArea1.AxisY.LabelStyle.Format = "${0}";
			chartArea1.AxisY.LineColor = System.Drawing.Color.White;
			chartArea1.AxisY.LineWidth = 0;
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
			legend1.ForeColor = System.Drawing.Color.White;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(24, 206);
			this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chart1.Name = "chart1";
			series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			series1.BackSecondaryColor = System.Drawing.Color.DodgerBlue;
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
			series1.Color = System.Drawing.Color.Lime;
			series1.LabelForeColor = System.Drawing.Color.GreenYellow;
			series1.Legend = "Legend1";
			series1.MarkerSize = 10;
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(1287, 402);
			this.chart1.TabIndex = 21;
			this.chart1.Text = "chart1";
			title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			title1.ForeColor = System.Drawing.Color.White;
			title1.Name = "Title1";
			title1.Text = "Gross Revenue";
			this.chart1.Titles.Add(title1);
			// 
			// chart2
			// 
			this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart2.BackColor = System.Drawing.Color.Black;
			this.chart2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
			chartArea2.BackColor = System.Drawing.Color.Transparent;
			chartArea2.BorderColor = System.Drawing.Color.Transparent;
			chartArea2.BorderWidth = 10;
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.Transparent;
			legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
			legend2.BorderColor = System.Drawing.Color.Transparent;
			legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend2.ForeColor = System.Drawing.Color.White;
			legend2.Name = "Legend1";
			legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(1336, 206);
			this.chart2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chart2.Name = "chart2";
			series2.BorderColor = System.Drawing.Color.Black;
			series2.BorderWidth = 5;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series2.IsValueShownAsLabel = true;
			series2.LabelBackColor = System.Drawing.Color.Transparent;
			series2.LabelForeColor = System.Drawing.Color.WhiteSmoke;
			series2.Legend = "Legend1";
			series2.MarkerColor = System.Drawing.Color.Transparent;
			series2.Name = "Series1";
			series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(360, 402);
			this.chart2.TabIndex = 22;
			this.chart2.Text = "chart2";
			title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title2.ForeColor = System.Drawing.Color.White;
			title2.Name = "Title1";
			title2.Text = "Top 5 customer";
			this.chart2.Titles.Add(title2);
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel6.Controls.Add(this.lbTotalAvaliable);
			this.panel6.Controls.Add(this.lbTotalBooked);
			this.panel6.Controls.Add(this.lbTotalRoom);
			this.panel6.Controls.Add(this.lbTotalstaff);
			this.panel6.Controls.Add(this.iconButton4);
			this.panel6.Controls.Add(this.iconButton3);
			this.panel6.Controls.Add(this.iconButton2);
			this.panel6.Controls.Add(this.iconButton1);
			this.panel6.Controls.Add(this.label9);
			this.panel6.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.panel6.Location = new System.Drawing.Point(24, 632);
			this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(328, 298);
			this.panel6.TabIndex = 23;
			// 
			// lbTotalAvaliable
			// 
			this.lbTotalAvaliable.AutoSize = true;
			this.lbTotalAvaliable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalAvaliable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalAvaliable.ForeColor = System.Drawing.Color.White;
			this.lbTotalAvaliable.Location = new System.Drawing.Point(208, 231);
			this.lbTotalAvaliable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalAvaliable.Name = "lbTotalAvaliable";
			this.lbTotalAvaliable.Size = new System.Drawing.Size(19, 29);
			this.lbTotalAvaliable.TabIndex = 19;
			this.lbTotalAvaliable.Text = ":";
			// 
			// lbTotalBooked
			// 
			this.lbTotalBooked.AutoSize = true;
			this.lbTotalBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalBooked.ForeColor = System.Drawing.Color.White;
			this.lbTotalBooked.Location = new System.Drawing.Point(210, 172);
			this.lbTotalBooked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalBooked.Name = "lbTotalBooked";
			this.lbTotalBooked.Size = new System.Drawing.Size(19, 29);
			this.lbTotalBooked.TabIndex = 18;
			this.lbTotalBooked.Text = ":";
			// 
			// lbTotalRoom
			// 
			this.lbTotalRoom.AutoSize = true;
			this.lbTotalRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalRoom.ForeColor = System.Drawing.Color.White;
			this.lbTotalRoom.Location = new System.Drawing.Point(210, 118);
			this.lbTotalRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalRoom.Name = "lbTotalRoom";
			this.lbTotalRoom.Size = new System.Drawing.Size(19, 29);
			this.lbTotalRoom.TabIndex = 17;
			this.lbTotalRoom.Text = ":";
			// 
			// lbTotalstaff
			// 
			this.lbTotalstaff.AutoSize = true;
			this.lbTotalstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalstaff.ForeColor = System.Drawing.Color.White;
			this.lbTotalstaff.Location = new System.Drawing.Point(210, 62);
			this.lbTotalstaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalstaff.Name = "lbTotalstaff";
			this.lbTotalstaff.Size = new System.Drawing.Size(19, 29);
			this.lbTotalstaff.TabIndex = 13;
			this.lbTotalstaff.Text = ":";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Location = new System.Drawing.Point(33, 20);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(159, 29);
			this.label9.TabIndex = 6;
			this.label9.Text = "Total Counter";
			// 
			// datahoadon
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.datahoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datahoadon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.datahoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datahoadon.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.datahoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.datahoadon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datahoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.datahoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datahoadon.DoubleBuffered = true;
			this.datahoadon.EnableHeadersVisualStyles = false;
			this.datahoadon.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.datahoadon.HeaderForeColor = System.Drawing.Color.White;
			this.datahoadon.Location = new System.Drawing.Point(378, 632);
			this.datahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.datahoadon.Name = "datahoadon";
			this.datahoadon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.datahoadon.RowHeadersWidth = 62;
			this.datahoadon.RowTemplate.Height = 28;
			this.datahoadon.Size = new System.Drawing.Size(1318, 298);
			this.datahoadon.TabIndex = 24;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::HotelManager.Properties.Resources.customer;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(84, 71);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// iconButton4
			// 
			this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.iconButton4.FlatAppearance.BorderSize = 0;
			this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton4.ForeColor = System.Drawing.Color.White;
			this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck;
			this.iconButton4.IconColor = System.Drawing.Color.White;
			this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconButton4.IconSize = 32;
			this.iconButton4.Location = new System.Drawing.Point(0, 100);
			this.iconButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.Rotation = 1D;
			this.iconButton4.Size = new System.Drawing.Size(208, 66);
			this.iconButton4.TabIndex = 16;
			this.iconButton4.Text = "Total Room";
			this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton4.UseVisualStyleBackColor = false;
			// 
			// iconButton3
			// 
			this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton3.ForeColor = System.Drawing.Color.White;
			this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.HouseCircleXmark;
			this.iconButton3.IconColor = System.Drawing.Color.White;
			this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconButton3.IconSize = 32;
			this.iconButton3.Location = new System.Drawing.Point(1, 214);
			this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Rotation = 1D;
			this.iconButton3.Size = new System.Drawing.Size(207, 66);
			this.iconButton3.TabIndex = 15;
			this.iconButton3.Text = "Avaliable";
			this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton3.UseVisualStyleBackColor = false;
			// 
			// iconButton2
			// 
			this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.ForeColor = System.Drawing.Color.White;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck;
			this.iconButton2.IconColor = System.Drawing.Color.White;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconButton2.IconSize = 32;
			this.iconButton2.Location = new System.Drawing.Point(-4, 158);
			this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Rotation = 1D;
			this.iconButton2.Size = new System.Drawing.Size(213, 66);
			this.iconButton2.TabIndex = 14;
			this.iconButton2.Text = "Booked";
			this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton2.UseVisualStyleBackColor = false;
			// 
			// iconButton1
			// 
			this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.ForeColor = System.Drawing.Color.White;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
			this.iconButton1.IconColor = System.Drawing.Color.White;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconButton1.IconSize = 32;
			this.iconButton1.Location = new System.Drawing.Point(-3, 48);
			this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Rotation = 1D;
			this.iconButton1.Size = new System.Drawing.Size(210, 66);
			this.iconButton1.TabIndex = 13;
			this.iconButton1.Text = "Total Staff";
			this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton1.UseVisualStyleBackColor = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::HotelManager.Properties.Resources._9135010;
			this.pictureBox4.Location = new System.Drawing.Point(12, 12);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(82, 71);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 10;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::HotelManager.Properties.Resources.margin;
			this.pictureBox2.Location = new System.Drawing.Point(9, 11);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(82, 71);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::HotelManager.Properties.Resources.increase;
			this.pictureBox3.Location = new System.Drawing.Point(10, 12);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(93, 66);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			// 
			// ExportDataBtn
			// 
			this.ExportDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ExportDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(116)))), ((int)(((byte)(74)))));
			this.ExportDataBtn.Enabled = false;
			this.ExportDataBtn.FlatAppearance.BorderSize = 0;
			this.ExportDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExportDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ExportDataBtn.ForeColor = System.Drawing.Color.White;
			this.ExportDataBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
			this.ExportDataBtn.IconColor = System.Drawing.Color.White;
			this.ExportDataBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.ExportDataBtn.IconSize = 28;
			this.ExportDataBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportDataBtn.Location = new System.Drawing.Point(1498, 11);
			this.ExportDataBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ExportDataBtn.Name = "ExportDataBtn";
			this.ExportDataBtn.Padding = new System.Windows.Forms.Padding(9, 2, 9, 2);
			this.ExportDataBtn.Size = new System.Drawing.Size(195, 58);
			this.ExportDataBtn.TabIndex = 155;
			this.ExportDataBtn.Text = "Export Data";
			this.ExportDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportDataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ExportDataBtn.UseVisualStyleBackColor = false;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1725, 958);
			this.Controls.Add(this.datahoadon);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datahoadon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbPTTR;
		private System.Windows.Forms.Label lbTotalReven;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbPTNB;
		private System.Windows.Forms.Label lbNBO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbPTTP;
		private System.Windows.Forms.Label lbTotaP;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lbTotalAvaliable;
		private System.Windows.Forms.Label lbTotalBooked;
		private System.Windows.Forms.Label lbTotalRoom;
		private System.Windows.Forms.Label lbTotalstaff;
		private FontAwesome.Sharp.IconButton iconButton4;
		private FontAwesome.Sharp.IconButton iconButton3;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.Label label9;
		private Bunifu.Framework.UI.BunifuCustomDataGrid datahoadon;
		private FontAwesome.Sharp.IconButton ExportDataBtn;
		private Bunifu.Framework.UI.BunifuDatepicker dtpNgay;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbPTEM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labeltotalprofit;
	}
}