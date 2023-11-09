namespace HotelManager.pages
{
    partial class Reservation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.allFilterButton = new Bunifu.Framework.UI.BunifuThinButton2();
			this.checkoutFilterButton = new Bunifu.Framework.UI.BunifuThinButton2();
			this.checkinFilterButton = new Bunifu.Framework.UI.BunifuThinButton2();
			this.addGuestButton = new FontAwesome.Sharp.IconButton();
			this.reservationDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.allFilterButton);
			this.panel1.Controls.Add(this.checkoutFilterButton);
			this.panel1.Controls.Add(this.checkinFilterButton);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.addGuestButton);
			this.panel1.Controls.Add(this.reservationDataGridView);
			this.panel1.Location = new System.Drawing.Point(28, 31);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1533, 934);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// allFilterButton
			// 
			this.allFilterButton.ActiveBorderThickness = 1;
			this.allFilterButton.ActiveCornerRadius = 40;
			this.allFilterButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.allFilterButton.ActiveForecolor = System.Drawing.Color.White;
			this.allFilterButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.allFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.allFilterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allFilterButton.BackgroundImage")));
			this.allFilterButton.ButtonText = "All";
			this.allFilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.allFilterButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.allFilterButton.ForeColor = System.Drawing.Color.SeaGreen;
			this.allFilterButton.IdleBorderThickness = 1;
			this.allFilterButton.IdleCornerRadius = 40;
			this.allFilterButton.IdleFillColor = System.Drawing.Color.White;
			this.allFilterButton.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.allFilterButton.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.allFilterButton.Location = new System.Drawing.Point(32, 115);
			this.allFilterButton.Margin = new System.Windows.Forms.Padding(6);
			this.allFilterButton.Name = "allFilterButton";
			this.allFilterButton.Size = new System.Drawing.Size(158, 69);
			this.allFilterButton.TabIndex = 15;
			this.allFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.allFilterButton.Click += new System.EventHandler(this.allFilterButton_Click_1);
			// 
			// checkoutFilterButton
			// 
			this.checkoutFilterButton.ActiveBorderThickness = 1;
			this.checkoutFilterButton.ActiveCornerRadius = 40;
			this.checkoutFilterButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.checkoutFilterButton.ActiveForecolor = System.Drawing.Color.White;
			this.checkoutFilterButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.checkoutFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.checkoutFilterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkoutFilterButton.BackgroundImage")));
			this.checkoutFilterButton.ButtonText = "Check out";
			this.checkoutFilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkoutFilterButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.checkoutFilterButton.ForeColor = System.Drawing.Color.SeaGreen;
			this.checkoutFilterButton.IdleBorderThickness = 1;
			this.checkoutFilterButton.IdleCornerRadius = 40;
			this.checkoutFilterButton.IdleFillColor = System.Drawing.Color.White;
			this.checkoutFilterButton.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.checkoutFilterButton.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.checkoutFilterButton.Location = new System.Drawing.Point(372, 115);
			this.checkoutFilterButton.Margin = new System.Windows.Forms.Padding(6);
			this.checkoutFilterButton.Name = "checkoutFilterButton";
			this.checkoutFilterButton.Size = new System.Drawing.Size(158, 69);
			this.checkoutFilterButton.TabIndex = 16;
			this.checkoutFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkoutFilterButton.Click += new System.EventHandler(this.checkoutFilterButton_Click_1);
			// 
			// checkinFilterButton
			// 
			this.checkinFilterButton.ActiveBorderThickness = 1;
			this.checkinFilterButton.ActiveCornerRadius = 40;
			this.checkinFilterButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.checkinFilterButton.ActiveForecolor = System.Drawing.Color.White;
			this.checkinFilterButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.checkinFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.checkinFilterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkinFilterButton.BackgroundImage")));
			this.checkinFilterButton.ButtonText = "Check in";
			this.checkinFilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkinFilterButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.checkinFilterButton.ForeColor = System.Drawing.Color.SeaGreen;
			this.checkinFilterButton.IdleBorderThickness = 1;
			this.checkinFilterButton.IdleCornerRadius = 40;
			this.checkinFilterButton.IdleFillColor = System.Drawing.Color.White;
			this.checkinFilterButton.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.checkinFilterButton.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.checkinFilterButton.Location = new System.Drawing.Point(201, 115);
			this.checkinFilterButton.Margin = new System.Windows.Forms.Padding(6);
			this.checkinFilterButton.Name = "checkinFilterButton";
			this.checkinFilterButton.Size = new System.Drawing.Size(158, 69);
			this.checkinFilterButton.TabIndex = 17;
			this.checkinFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkinFilterButton.Click += new System.EventHandler(this.checkinFilterButton_Click);
			// 
			// addGuestButton
			// 
			this.addGuestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(116)))), ((int)(((byte)(74)))));
			this.addGuestButton.FlatAppearance.BorderSize = 0;
			this.addGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.addGuestButton.ForeColor = System.Drawing.Color.White;
			this.addGuestButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.addGuestButton.IconColor = System.Drawing.Color.White;
			this.addGuestButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.addGuestButton.IconSize = 28;
			this.addGuestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addGuestButton.Location = new System.Drawing.Point(1271, 115);
			this.addGuestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addGuestButton.Name = "addGuestButton";
			this.addGuestButton.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
			this.addGuestButton.Size = new System.Drawing.Size(231, 60);
			this.addGuestButton.TabIndex = 13;
			this.addGuestButton.Text = "Add Reservation";
			this.addGuestButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addGuestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addGuestButton.UseVisualStyleBackColor = false;
			this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
			// 
			// reservationDataGridView
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.reservationDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.reservationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.reservationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.reservationDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.reservationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.reservationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.reservationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.reservationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.reservationDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.reservationDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
			this.reservationDataGridView.DoubleBuffered = true;
			this.reservationDataGridView.EnableHeadersVisualStyles = false;
			this.reservationDataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
			this.reservationDataGridView.HeaderForeColor = System.Drawing.Color.White;
			this.reservationDataGridView.Location = new System.Drawing.Point(30, 203);
			this.reservationDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.reservationDataGridView.Name = "reservationDataGridView";
			this.reservationDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.reservationDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.reservationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.reservationDataGridView.RowHeadersWidth = 51;
			this.reservationDataGridView.RowTemplate.Height = 42;
			this.reservationDataGridView.Size = new System.Drawing.Size(1473, 700);
			this.reservationDataGridView.TabIndex = 12;
			this.reservationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationDataGridView_CellClick);
			this.reservationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationDataGridView_CellContentClick);
			// 
			// iconButton2
			// 
			this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.iconButton2.IconColor = System.Drawing.Color.White;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.IconSize = 28;
			this.iconButton2.Location = new System.Drawing.Point(3, 3);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Size = new System.Drawing.Size(66, 57);
			this.iconButton2.TabIndex = 1;
			this.iconButton2.UseVisualStyleBackColor = true;
		
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panel2.Controls.Add(this.bunifuDatepicker1);
			this.panel2.Controls.Add(this.iconButton2);
			this.panel2.Location = new System.Drawing.Point(30, 29);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(500, 60);
			this.panel2.TabIndex = 14;
		
			// 
			// bunifuDatepicker1
			// 
			this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			this.bunifuDatepicker1.BorderRadius = 0;
			this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
			this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.bunifuDatepicker1.FormatCustom = null;
			this.bunifuDatepicker1.Location = new System.Drawing.Point(76, 0);
			this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bunifuDatepicker1.Name = "bunifuDatepicker1";
			this.bunifuDatepicker1.Size = new System.Drawing.Size(424, 60);
			this.bunifuDatepicker1.TabIndex = 2;
			this.bunifuDatepicker1.Value = new System.DateTime(2023, 11, 8, 14, 52, 17, 840);
			// 
			// Reservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1588, 1000);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Reservation";
			this.Text = "Reservation";
			this.Load += new System.EventHandler(this.Reservation_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton addGuestButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid reservationDataGridView;
        private Bunifu.Framework.UI.BunifuThinButton2 allFilterButton;
        private Bunifu.Framework.UI.BunifuThinButton2 checkoutFilterButton;
        private Bunifu.Framework.UI.BunifuThinButton2 checkinFilterButton;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
		private FontAwesome.Sharp.IconButton iconButton2;
	}
}