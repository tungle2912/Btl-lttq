namespace HotelManager.pages
{
    partial class Guest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guestSearchTextBox = new System.Windows.Forms.TextBox();
            this.guestDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.searchIconButton = new FontAwesome.Sharp.IconButton();
            this.allFilterButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkoutFilterButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkinFilterButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.guestDataGridView);
            this.panel1.Controls.Add(this.allFilterButton);
            this.panel1.Controls.Add(this.checkoutFilterButton);
            this.panel1.Controls.Add(this.checkinFilterButton);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(33, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 885);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Controls.Add(this.guestSearchTextBox);
            this.panel3.Controls.Add(this.searchIconButton);
            this.panel3.Location = new System.Drawing.Point(30, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 60);
            this.panel3.TabIndex = 13;
            this.panel3.AutoSizeChanged += new System.EventHandler(this.FocusOnClick);
            // 
            // guestSearchTextBox
            // 
            this.guestSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guestSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guestSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guestSearchTextBox.ForeColor = System.Drawing.Color.White;
            this.guestSearchTextBox.Location = new System.Drawing.Point(76, 15);
            this.guestSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guestSearchTextBox.Name = "guestSearchTextBox";
            this.guestSearchTextBox.Size = new System.Drawing.Size(496, 28);
            this.guestSearchTextBox.TabIndex = 11;
            this.guestSearchTextBox.TextChanged += new System.EventHandler(this.guestSearchTextBox_TextChanged);
            // 
            // guestDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guestDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guestDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guestDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guestDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.guestDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.guestDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guestDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.guestDataGridView.DoubleBuffered = true;
            this.guestDataGridView.EnableHeadersVisualStyles = false;
            this.guestDataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.guestDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.guestDataGridView.Location = new System.Drawing.Point(30, 205);
            this.guestDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guestDataGridView.Name = "guestDataGridView";
            this.guestDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guestDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guestDataGridView.RowHeadersWidth = 51;
            this.guestDataGridView.RowTemplate.Height = 42;
            this.guestDataGridView.Size = new System.Drawing.Size(1431, 648);
            this.guestDataGridView.TabIndex = 11;
            this.guestDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestDataGridView_CellClick);
            // 
            // searchIconButton
            // 
            this.searchIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchIconButton.FlatAppearance.BorderSize = 0;
            this.searchIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchIconButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchIconButton.IconColor = System.Drawing.Color.White;
            this.searchIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchIconButton.IconSize = 28;
            this.searchIconButton.Location = new System.Drawing.Point(3, 2);
            this.searchIconButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchIconButton.Name = "searchIconButton";
            this.searchIconButton.Size = new System.Drawing.Size(66, 59);
            this.searchIconButton.TabIndex = 1;
            this.searchIconButton.UseVisualStyleBackColor = true;
            this.searchIconButton.AutoSizeChanged += new System.EventHandler(this.FocusOnClick);
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
            this.allFilterButton.Location = new System.Drawing.Point(30, 115);
            this.allFilterButton.Margin = new System.Windows.Forms.Padding(6);
            this.allFilterButton.Name = "allFilterButton";
            this.allFilterButton.Size = new System.Drawing.Size(158, 69);
            this.allFilterButton.TabIndex = 5;
            this.allFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allFilterButton.Click += new System.EventHandler(this.allFilterButton_Click);
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
            this.checkoutFilterButton.Location = new System.Drawing.Point(370, 115);
            this.checkoutFilterButton.Margin = new System.Windows.Forms.Padding(6);
            this.checkoutFilterButton.Name = "checkoutFilterButton";
            this.checkoutFilterButton.Size = new System.Drawing.Size(158, 69);
            this.checkoutFilterButton.TabIndex = 5;
            this.checkoutFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkoutFilterButton.Click += new System.EventHandler(this.checkoutFilterButton_Click);
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
            this.checkinFilterButton.Location = new System.Drawing.Point(199, 115);
            this.checkinFilterButton.Margin = new System.Windows.Forms.Padding(6);
            this.checkinFilterButton.Name = "checkinFilterButton";
            this.checkinFilterButton.Size = new System.Drawing.Size(158, 69);
            this.checkinFilterButton.TabIndex = 5;
            this.checkinFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkinFilterButton.Click += new System.EventHandler(this.checkinFilterButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(116)))), ((int)(((byte)(74)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1252, 31);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(9, 2, 9, 2);
            this.iconButton1.Size = new System.Drawing.Size(208, 60);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Export Data";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1554, 952);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Guest";
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.Guest_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 checkoutFilterButton;
        private Bunifu.Framework.UI.BunifuThinButton2 checkinFilterButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid guestDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox guestSearchTextBox;
        private FontAwesome.Sharp.IconButton searchIconButton;
        private Bunifu.Framework.UI.BunifuThinButton2 allFilterButton;
    }
}