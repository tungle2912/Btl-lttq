namespace HotelManager.pages
{
    partial class Rooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.roomDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.allRoomButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bookedRoomButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.availableRoomButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchIconButton = new FontAwesome.Sharp.IconButton();
            this.addRoomBtn = new FontAwesome.Sharp.IconButton();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.Location = new System.Drawing.Point(315, 139);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(210, 68);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Add Rooms";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel7.Controls.Add(this.roomDataGridView);
            this.panel7.Controls.Add(this.allRoomButton);
            this.panel7.Controls.Add(this.bookedRoomButton);
            this.panel7.Controls.Add(this.availableRoomButton);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.addRoomBtn);
            this.panel7.Location = new System.Drawing.Point(33, 38);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1641, 961);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // roomDataGridView
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.roomDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.roomDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.roomDataGridView.DoubleBuffered = true;
            this.roomDataGridView.EnableHeadersVisualStyles = false;
            this.roomDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.roomDataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.roomDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.roomDataGridView.Location = new System.Drawing.Point(27, 201);
            this.roomDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.roomDataGridView.RowHeadersWidth = 51;
            this.roomDataGridView.RowTemplate.Height = 42;
            this.roomDataGridView.Size = new System.Drawing.Size(1584, 732);
            this.roomDataGridView.TabIndex = 10;
            this.roomDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDataGridView_CellClick);
            // 
            // allRoomButton
            // 
            this.allRoomButton.ActiveBorderThickness = 1;
            this.allRoomButton.ActiveCornerRadius = 40;
            this.allRoomButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.allRoomButton.ActiveForecolor = System.Drawing.Color.White;
            this.allRoomButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.allRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.allRoomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allRoomButton.BackgroundImage")));
            this.allRoomButton.ButtonText = "All room(100)";
            this.allRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allRoomButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.allRoomButton.ForeColor = System.Drawing.Color.White;
            this.allRoomButton.IdleBorderThickness = 1;
            this.allRoomButton.IdleCornerRadius = 40;
            this.allRoomButton.IdleFillColor = System.Drawing.Color.White;
            this.allRoomButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.allRoomButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.allRoomButton.Location = new System.Drawing.Point(27, 112);
            this.allRoomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.allRoomButton.Name = "allRoomButton";
            this.allRoomButton.Size = new System.Drawing.Size(195, 69);
            this.allRoomButton.TabIndex = 6;
            this.allRoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allRoomButton.Click += new System.EventHandler(this.allRoomButton_Click);
            // 
            // bookedRoomButton
            // 
            this.bookedRoomButton.ActiveBorderThickness = 1;
            this.bookedRoomButton.ActiveCornerRadius = 40;
            this.bookedRoomButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bookedRoomButton.ActiveForecolor = System.Drawing.Color.White;
            this.bookedRoomButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bookedRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bookedRoomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookedRoomButton.BackgroundImage")));
            this.bookedRoomButton.ButtonText = "Booked(80)";
            this.bookedRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookedRoomButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bookedRoomButton.ForeColor = System.Drawing.Color.White;
            this.bookedRoomButton.IdleBorderThickness = 1;
            this.bookedRoomButton.IdleCornerRadius = 40;
            this.bookedRoomButton.IdleFillColor = System.Drawing.Color.White;
            this.bookedRoomButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bookedRoomButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bookedRoomButton.Location = new System.Drawing.Point(577, 112);
            this.bookedRoomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bookedRoomButton.Name = "bookedRoomButton";
            this.bookedRoomButton.Size = new System.Drawing.Size(156, 69);
            this.bookedRoomButton.TabIndex = 6;
            this.bookedRoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bookedRoomButton.Click += new System.EventHandler(this.bookedRoomButton_Click);
            // 
            // availableRoomButton
            // 
            this.availableRoomButton.ActiveBorderThickness = 1;
            this.availableRoomButton.ActiveCornerRadius = 40;
            this.availableRoomButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.availableRoomButton.ActiveForecolor = System.Drawing.Color.White;
            this.availableRoomButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.availableRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.availableRoomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("availableRoomButton.BackgroundImage")));
            this.availableRoomButton.ButtonText = "Available room(20)";
            this.availableRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availableRoomButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.availableRoomButton.ForeColor = System.Drawing.Color.White;
            this.availableRoomButton.IdleBorderThickness = 1;
            this.availableRoomButton.IdleCornerRadius = 40;
            this.availableRoomButton.IdleFillColor = System.Drawing.Color.White;
            this.availableRoomButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.availableRoomButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.availableRoomButton.Location = new System.Drawing.Point(238, 112);
            this.availableRoomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.availableRoomButton.Name = "availableRoomButton";
            this.availableRoomButton.Size = new System.Drawing.Size(323, 69);
            this.availableRoomButton.TabIndex = 6;
            this.availableRoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.availableRoomButton.Click += new System.EventHandler(this.availableRoomButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.roomSearchTextBox);
            this.panel2.Controls.Add(this.searchIconButton);
            this.panel2.Location = new System.Drawing.Point(27, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 60);
            this.panel2.TabIndex = 5;
            this.panel2.Click += new System.EventHandler(this.FocusOnClick);
            // 
            // roomSearchTextBox
            // 
            this.roomSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roomSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomSearchTextBox.ForeColor = System.Drawing.Color.White;
            this.roomSearchTextBox.Location = new System.Drawing.Point(76, 15);
            this.roomSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomSearchTextBox.Name = "roomSearchTextBox";
            this.roomSearchTextBox.Size = new System.Drawing.Size(496, 28);
            this.roomSearchTextBox.TabIndex = 11;
            this.roomSearchTextBox.TextChanged += new System.EventHandler(this.roomSearchTextBox_TextChanged);
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
            this.searchIconButton.Click += new System.EventHandler(this.FocusOnClick);
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(116)))), ((int)(((byte)(74)))));
            this.addRoomBtn.FlatAppearance.BorderSize = 0;
            this.addRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addRoomBtn.ForeColor = System.Drawing.Color.White;
            this.addRoomBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addRoomBtn.IconColor = System.Drawing.Color.White;
            this.addRoomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addRoomBtn.IconSize = 28;
            this.addRoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRoomBtn.Location = new System.Drawing.Point(1403, 118);
            this.addRoomBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Padding = new System.Windows.Forms.Padding(9, 2, 9, 2);
            this.addRoomBtn.Size = new System.Drawing.Size(208, 60);
            this.addRoomBtn.TabIndex = 2;
            this.addRoomBtn.Text = "Add room";
            this.addRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addRoomBtn.UseVisualStyleBackColor = false;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1704, 1032);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.iconButton2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton searchIconButton;
        private Bunifu.Framework.UI.BunifuThinButton2 bookedRoomButton;
        private Bunifu.Framework.UI.BunifuThinButton2 allRoomButton;
        private Bunifu.Framework.UI.BunifuThinButton2 availableRoomButton;
        private FontAwesome.Sharp.IconButton addRoomBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid roomDataGridView;
        private System.Windows.Forms.TextBox roomSearchTextBox;
    }
}