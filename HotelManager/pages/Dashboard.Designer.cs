namespace HotelManager.pages
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ExportDataBtn = new FontAwesome.Sharp.IconButton();
			this.button1 = new System.Windows.Forms.Button();
			this.btnCM = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dtpNgay = new Bunifu.Framework.UI.BunifuDatepicker();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.lbTotalReven = new System.Windows.Forms.Label();
			this.lbPTTR = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lbNBO = new System.Windows.Forms.Label();
			this.lbPTNB = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.lbTotaP = new System.Windows.Forms.Label();
			this.lbPTTP = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton4 = new FontAwesome.Sharp.IconButton();
			this.lbTotalstaff = new System.Windows.Forms.Label();
			this.lbTotalRoom = new System.Windows.Forms.Label();
			this.lbTotalBooked = new System.Windows.Forms.Label();
			this.lbTotalAvaliable = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
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
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.btnCM);
			this.panel4.Location = new System.Drawing.Point(0, 2);
			this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1534, 76);
			this.panel4.TabIndex = 16;
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
			this.ExportDataBtn.Location = new System.Drawing.Point(1347, 15);
			this.ExportDataBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ExportDataBtn.Name = "ExportDataBtn";
			this.ExportDataBtn.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
			this.ExportDataBtn.Size = new System.Drawing.Size(157, 48);
			this.ExportDataBtn.TabIndex = 155;
			this.ExportDataBtn.Text = "Export";
			this.ExportDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportDataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ExportDataBtn.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(1206, 16);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 48);
			this.button1.TabIndex = 14;
			this.button1.Text = "Year";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnCM
			// 
			this.btnCM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCM.Location = new System.Drawing.Point(1062, 16);
			this.btnCM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCM.Name = "btnCM";
			this.btnCM.Size = new System.Drawing.Size(124, 48);
			this.btnCM.TabIndex = 12;
			this.btnCM.Text = "Month";
			this.btnCM.UseVisualStyleBackColor = true;
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			chartArea5.AxisX.IsMarginVisible = false;
			chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
			chartArea5.AxisX.LineColor = System.Drawing.Color.DimGray;
			chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
			chartArea5.AxisX.MajorGrid.LineWidth = 0;
			chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
			chartArea5.AxisY.LabelStyle.Format = "${0}";
			chartArea5.AxisY.LineColor = System.Drawing.Color.White;
			chartArea5.AxisY.LineWidth = 0;
			chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
			chartArea5.BackColor = System.Drawing.Color.Transparent;
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			legend5.BackColor = System.Drawing.Color.Transparent;
			legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
			legend5.ForeColor = System.Drawing.Color.White;
			legend5.Name = "Legend1";
			this.chart1.Legends.Add(legend5);
			this.chart1.Location = new System.Drawing.Point(22, 184);
			this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chart1.Name = "chart1";
			series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			series5.BackSecondaryColor = System.Drawing.Color.DodgerBlue;
			series5.BorderWidth = 3;
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
			series5.Color = System.Drawing.Color.Lime;
			series5.LabelForeColor = System.Drawing.Color.GreenYellow;
			series5.Legend = "Legend1";
			series5.MarkerSize = 10;
			series5.Name = "Series1";
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(1155, 319);
			this.chart1.TabIndex = 21;
			this.chart1.Text = "chart1";
			title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			title5.ForeColor = System.Drawing.Color.White;
			title5.Name = "Title1";
			title5.Text = "Gross Revenue";
			this.chart1.Titles.Add(title5);
			// 
			// chart2
			// 
			this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart2.BackColor = System.Drawing.Color.Black;
			this.chart2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
			chartArea6.BackColor = System.Drawing.Color.Transparent;
			chartArea6.BorderColor = System.Drawing.Color.Transparent;
			chartArea6.BorderWidth = 10;
			chartArea6.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea6);
			legend6.BackColor = System.Drawing.Color.Transparent;
			legend6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
			legend6.BorderColor = System.Drawing.Color.Transparent;
			legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend6.ForeColor = System.Drawing.Color.White;
			legend6.Name = "Legend1";
			legend6.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.chart2.Legends.Add(legend6);
			this.chart2.Location = new System.Drawing.Point(1199, 184);
			this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chart2.Name = "chart2";
			series6.BorderColor = System.Drawing.Color.Black;
			series6.BorderWidth = 5;
			series6.ChartArea = "ChartArea1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series6.IsValueShownAsLabel = true;
			series6.LabelBackColor = System.Drawing.Color.Transparent;
			series6.LabelForeColor = System.Drawing.Color.WhiteSmoke;
			series6.Legend = "Legend1";
			series6.MarkerColor = System.Drawing.Color.Transparent;
			series6.Name = "Series1";
			series6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			this.chart2.Series.Add(series6);
			this.chart2.Size = new System.Drawing.Size(305, 319);
			this.chart2.TabIndex = 22;
			this.chart2.Text = "chart2";
			title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title6.ForeColor = System.Drawing.Color.White;
			title6.Name = "Title1";
			title6.Text = "Top 5 customer";
			this.chart2.Titles.Add(title6);
			// 
			// bunifuCustomDataGrid1
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bunifuCustomDataGrid1.DoubleBuffered = true;
			this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
			this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
			this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(338, 526);
			this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
			this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.bunifuCustomDataGrid1.RowHeadersWidth = 62;
			this.bunifuCustomDataGrid1.RowTemplate.Height = 28;
			this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1166, 248);
			this.bunifuCustomDataGrid1.TabIndex = 24;
			// 
			// dtpNgay
			// 
			this.dtpNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			this.dtpNgay.BorderRadius = 0;
			this.dtpNgay.ForeColor = System.Drawing.Color.White;
			this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpNgay.FormatCustom = null;
			this.dtpNgay.Location = new System.Drawing.Point(27, 18);
			this.dtpNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpNgay.Name = "dtpNgay";
			this.dtpNgay.Size = new System.Drawing.Size(377, 48);
			this.dtpNgay.TabIndex = 156;
			this.dtpNgay.Value = new System.DateTime(2023, 11, 8, 14, 52, 17, 840);
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Controls.Add(this.panel3);
			this.panel5.Location = new System.Drawing.Point(0, 78);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1534, 91);
			this.panel5.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Gray;
			this.label5.Location = new System.Drawing.Point(104, 11);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Total Revenue";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTotalReven
			// 
			this.lbTotalReven.AutoSize = true;
			this.lbTotalReven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalReven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbTotalReven.Location = new System.Drawing.Point(103, 38);
			this.lbTotalReven.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalReven.Name = "lbTotalReven";
			this.lbTotalReven.Size = new System.Drawing.Size(56, 25);
			this.lbTotalReven.TabIndex = 7;
			this.lbTotalReven.Text = "1000";
			this.lbTotalReven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbPTTR
			// 
			this.lbPTTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbPTTR.AutoSize = true;
			this.lbPTTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPTTR.ForeColor = System.Drawing.Color.LimeGreen;
			this.lbPTTR.Location = new System.Drawing.Point(614, 23);
			this.lbPTTR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPTTR.Name = "lbPTTR";
			this.lbPTTR.Size = new System.Drawing.Size(64, 25);
			this.lbPTTR.TabIndex = 9;
			this.lbPTTR.Text = "+25%";
			this.lbPTTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbPTTR.Click += new System.EventHandler(this.lbPTTR_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(9, 6);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(78, 58);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
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
			this.panel2.Location = new System.Drawing.Point(461, 8);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(716, 73);
			this.panel2.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(88, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Number of Order";
			// 
			// lbNBO
			// 
			this.lbNBO.AutoSize = true;
			this.lbNBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNBO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbNBO.Location = new System.Drawing.Point(87, 38);
			this.lbNBO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNBO.Name = "lbNBO";
			this.lbNBO.Size = new System.Drawing.Size(56, 25);
			this.lbNBO.TabIndex = 5;
			this.lbNBO.Text = "1000";
			// 
			// lbPTNB
			// 
			this.lbPTNB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbPTNB.AutoSize = true;
			this.lbPTNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPTNB.ForeColor = System.Drawing.Color.LightGreen;
			this.lbPTNB.Location = new System.Drawing.Point(318, 23);
			this.lbPTNB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPTNB.Name = "lbPTNB";
			this.lbPTNB.Size = new System.Drawing.Size(64, 25);
			this.lbPTNB.TabIndex = 6;
			this.lbPTNB.Text = "+15%";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(78, 59);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lbPTNB);
			this.panel1.Controls.Add(this.lbNBO);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(22, 83);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(414, 74);
			this.panel1.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Gray;
			this.label8.Location = new System.Drawing.Point(92, 9);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 8;
			this.label8.Text = "Total Profit";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTotaP
			// 
			this.lbTotaP.AutoSize = true;
			this.lbTotaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotaP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbTotaP.Location = new System.Drawing.Point(85, 38);
			this.lbTotaP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotaP.Name = "lbTotaP";
			this.lbTotaP.Size = new System.Drawing.Size(0, 25);
			this.lbTotaP.TabIndex = 7;
			this.lbTotaP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbPTTP
			// 
			this.lbPTTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbPTTP.AutoSize = true;
			this.lbPTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPTTP.ForeColor = System.Drawing.Color.LimeGreen;
			this.lbPTTP.Location = new System.Drawing.Point(227, 23);
			this.lbPTTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPTTP.Name = "lbPTTP";
			this.lbPTTP.Size = new System.Drawing.Size(64, 25);
			this.lbPTTP.TabIndex = 9;
			this.lbPTTP.Text = "+15%";
			this.lbPTTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(5, 10);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(82, 53);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Controls.Add(this.lbPTTP);
			this.panel3.Controls.Add(this.lbTotaP);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Location = new System.Drawing.Point(1199, 8);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 40, 4, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(305, 71);
			this.panel3.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Location = new System.Drawing.Point(22, 16);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
			this.label9.Size = new System.Drawing.Size(163, 45);
			this.label9.TabIndex = 6;
			this.label9.Text = "Total Counter";
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
			this.iconButton1.Location = new System.Drawing.Point(8, 58);
			this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Rotation = 1D;
			this.iconButton1.Size = new System.Drawing.Size(187, 53);
			this.iconButton1.TabIndex = 13;
			this.iconButton1.Text = "Total Staff";
			this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton1.UseVisualStyleBackColor = false;
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
			this.iconButton2.Location = new System.Drawing.Point(8, 145);
			this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Rotation = 1D;
			this.iconButton2.Size = new System.Drawing.Size(189, 53);
			this.iconButton2.TabIndex = 14;
			this.iconButton2.Text = "Booked";
			this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton2.UseVisualStyleBackColor = false;
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
			this.iconButton3.Location = new System.Drawing.Point(13, 191);
			this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Rotation = 1D;
			this.iconButton3.Size = new System.Drawing.Size(184, 53);
			this.iconButton3.TabIndex = 15;
			this.iconButton3.Text = "Avaliable";
			this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton3.UseVisualStyleBackColor = false;
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
			this.iconButton4.Location = new System.Drawing.Point(12, 100);
			this.iconButton4.Margin = new System.Windows.Forms.Padding(4);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.Rotation = 1D;
			this.iconButton4.Size = new System.Drawing.Size(185, 53);
			this.iconButton4.TabIndex = 16;
			this.iconButton4.Text = "Total Room";
			this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton4.UseVisualStyleBackColor = false;
			// 
			// lbTotalstaff
			// 
			this.lbTotalstaff.AutoSize = true;
			this.lbTotalstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalstaff.ForeColor = System.Drawing.Color.White;
			this.lbTotalstaff.Location = new System.Drawing.Point(187, 69);
			this.lbTotalstaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalstaff.Name = "lbTotalstaff";
			this.lbTotalstaff.Size = new System.Drawing.Size(18, 25);
			this.lbTotalstaff.TabIndex = 13;
			this.lbTotalstaff.Text = ":";
			// 
			// lbTotalRoom
			// 
			this.lbTotalRoom.AutoSize = true;
			this.lbTotalRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalRoom.ForeColor = System.Drawing.Color.White;
			this.lbTotalRoom.Location = new System.Drawing.Point(187, 111);
			this.lbTotalRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalRoom.Name = "lbTotalRoom";
			this.lbTotalRoom.Size = new System.Drawing.Size(18, 25);
			this.lbTotalRoom.TabIndex = 17;
			this.lbTotalRoom.Text = ":";
			// 
			// lbTotalBooked
			// 
			this.lbTotalBooked.AutoSize = true;
			this.lbTotalBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalBooked.ForeColor = System.Drawing.Color.White;
			this.lbTotalBooked.Location = new System.Drawing.Point(187, 156);
			this.lbTotalBooked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalBooked.Name = "lbTotalBooked";
			this.lbTotalBooked.Size = new System.Drawing.Size(18, 25);
			this.lbTotalBooked.TabIndex = 18;
			this.lbTotalBooked.Text = ":";
			// 
			// lbTotalAvaliable
			// 
			this.lbTotalAvaliable.AutoSize = true;
			this.lbTotalAvaliable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.lbTotalAvaliable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalAvaliable.ForeColor = System.Drawing.Color.White;
			this.lbTotalAvaliable.Location = new System.Drawing.Point(185, 202);
			this.lbTotalAvaliable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalAvaliable.Name = "lbTotalAvaliable";
			this.lbTotalAvaliable.Size = new System.Drawing.Size(18, 25);
			this.lbTotalAvaliable.TabIndex = 19;
			this.lbTotalAvaliable.Text = ":";
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel6.AutoScroll = true;
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
			this.panel6.Location = new System.Drawing.Point(22, 526);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(292, 248);
			this.panel6.TabIndex = 23;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1534, 797);
			this.Controls.Add(this.bunifuCustomDataGrid1);
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
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCM;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
		private FontAwesome.Sharp.IconButton ExportDataBtn;
		private Bunifu.Framework.UI.BunifuDatepicker dtpNgay;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbPTTR;
		private System.Windows.Forms.Label lbTotalReven;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbPTTP;
		private System.Windows.Forms.Label lbTotaP;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbNBO;
		private System.Windows.Forms.Label lbPTNB;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton iconButton1;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton3;
		private FontAwesome.Sharp.IconButton iconButton4;
		private System.Windows.Forms.Label lbTotalstaff;
		private System.Windows.Forms.Label lbTotalRoom;
		private System.Windows.Forms.Label lbTotalBooked;
		private System.Windows.Forms.Label lbTotalAvaliable;
		private System.Windows.Forms.Panel panel6;
	}
}