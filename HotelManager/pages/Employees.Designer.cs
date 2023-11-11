namespace HotelManager.pages
{
    partial class Employees
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnTimekeeping = new FontAwesome.Sharp.IconButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.EmployeeSearch = new System.Windows.Forms.TextBox();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.addRoomBtn = new FontAwesome.Sharp.IconButton();
			this.employeeDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.btnTimekeeping);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.addRoomBtn);
			this.panel1.Controls.Add(this.employeeDataGridView);
			this.panel1.Location = new System.Drawing.Point(30, 34);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1491, 865);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnTimekeeping
			// 
			this.btnTimekeeping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTimekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(116)))), ((int)(((byte)(74)))));
			this.btnTimekeeping.FlatAppearance.BorderSize = 0;
			this.btnTimekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimekeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnTimekeeping.ForeColor = System.Drawing.Color.White;
			this.btnTimekeeping.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
			this.btnTimekeeping.IconColor = System.Drawing.Color.White;
			this.btnTimekeeping.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnTimekeeping.IconSize = 28;
			this.btnTimekeeping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimekeeping.Location = new System.Drawing.Point(1252, 29);
			this.btnTimekeeping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnTimekeeping.Name = "btnTimekeeping";
			this.btnTimekeeping.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
			this.btnTimekeeping.Size = new System.Drawing.Size(208, 60);
			this.btnTimekeeping.TabIndex = 15;
			this.btnTimekeeping.Text = "Timekeeping";
			this.btnTimekeeping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimekeeping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTimekeeping.UseVisualStyleBackColor = false;
			this.btnTimekeeping.Click += new System.EventHandler(this.btnTimekeeping_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panel2.Controls.Add(this.EmployeeSearch);
			this.panel2.Controls.Add(this.iconButton2);
			this.panel2.Location = new System.Drawing.Point(30, 29);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(585, 60);
			this.panel2.TabIndex = 14;
			// 
			// EmployeeSearch
			// 
			this.EmployeeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EmployeeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.EmployeeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EmployeeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.EmployeeSearch.ForeColor = System.Drawing.Color.White;
			this.EmployeeSearch.Location = new System.Drawing.Point(63, 15);
			this.EmployeeSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EmployeeSearch.Name = "EmployeeSearch";
			this.EmployeeSearch.Size = new System.Drawing.Size(488, 28);
			this.EmployeeSearch.TabIndex = 1;
			this.EmployeeSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSearch_KeyPress);
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
			this.iconButton2.Size = new System.Drawing.Size(66, 58);
			this.iconButton2.TabIndex = 1;
			this.iconButton2.UseVisualStyleBackColor = true;
			this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
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
			this.addRoomBtn.Location = new System.Drawing.Point(1252, 108);
			this.addRoomBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addRoomBtn.Name = "addRoomBtn";
			this.addRoomBtn.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
			this.addRoomBtn.Size = new System.Drawing.Size(208, 60);
			this.addRoomBtn.TabIndex = 13;
			this.addRoomBtn.Text = "Add Employee";
			this.addRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addRoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addRoomBtn.UseVisualStyleBackColor = false;
			this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
			// 
			// employeeDataGridView
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.employeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.employeeDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.employeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.employeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.employeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.employeeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.employeeDataGridView.DoubleBuffered = true;
			this.employeeDataGridView.EnableHeadersVisualStyles = false;
			this.employeeDataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			this.employeeDataGridView.HeaderForeColor = System.Drawing.Color.White;
			this.employeeDataGridView.Location = new System.Drawing.Point(30, 188);
			this.employeeDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.employeeDataGridView.Name = "employeeDataGridView";
			this.employeeDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.employeeDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.employeeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.employeeDataGridView.RowHeadersWidth = 51;
			this.employeeDataGridView.RowTemplate.Height = 42;
			this.employeeDataGridView.Size = new System.Drawing.Size(1431, 648);
			this.employeeDataGridView.TabIndex = 12;
			this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellClick);
			// 
			// Employees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1550, 934);
			this.Controls.Add(this.panel1);
			this.Name = "Employees";
			this.Text = "Employees";
			this.Load += new System.EventHandler(this.Employees_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid employeeDataGridView;
        private FontAwesome.Sharp.IconButton addRoomBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox EmployeeSearch;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnTimekeeping;
    }
}