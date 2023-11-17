namespace HotelManager.components
{
    partial class EmployeeForm
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
			this.Addbtn = new System.Windows.Forms.Button();
			this.guestLabel = new System.Windows.Forms.Label();
			this.closeGuestFormBtn = new FontAwesome.Sharp.IconButton();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.EmployeeIdTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.NameEmployeeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.PhoneNumbertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnFemale = new System.Windows.Forms.RadioButton();
			this.btnMale = new System.Windows.Forms.RadioButton();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.PositionCBB = new Bunifu.Framework.UI.BunifuDropdown();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Addbtn
			// 
			this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.Addbtn.FlatAppearance.BorderSize = 0;
			this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Addbtn.ForeColor = System.Drawing.Color.White;
			this.Addbtn.Location = new System.Drawing.Point(287, 923);
			this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Addbtn.Name = "Addbtn";
			this.Addbtn.Size = new System.Drawing.Size(248, 61);
			this.Addbtn.TabIndex = 65;
			this.Addbtn.Text = "Add ";
			this.Addbtn.UseVisualStyleBackColor = false;
			this.Addbtn.Click += new System.EventHandler(this.guestFormButton_Click);
			// 
			// guestLabel
			// 
			this.guestLabel.AutoSize = true;
			this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.guestLabel.ForeColor = System.Drawing.Color.White;
			this.guestLabel.Location = new System.Drawing.Point(334, 32);
			this.guestLabel.Name = "guestLabel";
			this.guestLabel.Size = new System.Drawing.Size(199, 32);
			this.guestLabel.TabIndex = 64;
			this.guestLabel.Text = "Add Employee";
			this.guestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.guestLabel.Click += new System.EventHandler(this.guestLabel_Click);
			// 
			// closeGuestFormBtn
			// 
			this.closeGuestFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.closeGuestFormBtn.FlatAppearance.BorderSize = 0;
			this.closeGuestFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeGuestFormBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
			this.closeGuestFormBtn.IconColor = System.Drawing.Color.White;
			this.closeGuestFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.closeGuestFormBtn.IconSize = 32;
			this.closeGuestFormBtn.Location = new System.Drawing.Point(773, -1);
			this.closeGuestFormBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.closeGuestFormBtn.Name = "closeGuestFormBtn";
			this.closeGuestFormBtn.Size = new System.Drawing.Size(63, 54);
			this.closeGuestFormBtn.TabIndex = 59;
			this.closeGuestFormBtn.UseVisualStyleBackColor = false;
			this.closeGuestFormBtn.Click += new System.EventHandler(this.closeGuestFormBtn_Click);
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(96, 301);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 23);
			this.bunifuCustomLabel2.TabIndex = 132;
			this.bunifuCustomLabel2.Text = "Name";
			// 
			// bunifuCustomLabel10
			// 
			this.bunifuCustomLabel10.AutoSize = true;
			this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel10.Location = new System.Drawing.Point(96, 181);
			this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
			this.bunifuCustomLabel10.Size = new System.Drawing.Size(129, 23);
			this.bunifuCustomLabel10.TabIndex = 131;
			this.bunifuCustomLabel10.Text = "EmployeeID";
			// 
			// EmployeeIdTxt
			// 
			this.EmployeeIdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.EmployeeIdTxt.Enabled = false;
			this.EmployeeIdTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmployeeIdTxt.ForeColor = System.Drawing.Color.White;
			this.EmployeeIdTxt.HintForeColor = System.Drawing.Color.White;
			this.EmployeeIdTxt.HintText = "";
			this.EmployeeIdTxt.isPassword = false;
			this.EmployeeIdTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.EmployeeIdTxt.LineIdleColor = System.Drawing.Color.Gray;
			this.EmployeeIdTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.EmployeeIdTxt.LineThickness = 4;
			this.EmployeeIdTxt.Location = new System.Drawing.Point(273, 146);
			this.EmployeeIdTxt.Margin = new System.Windows.Forms.Padding(6);
			this.EmployeeIdTxt.Name = "EmployeeIdTxt";
			this.EmployeeIdTxt.Size = new System.Drawing.Size(416, 80);
			this.EmployeeIdTxt.TabIndex = 130;
			this.EmployeeIdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// NameEmployeeTxt
			// 
			this.NameEmployeeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NameEmployeeTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameEmployeeTxt.ForeColor = System.Drawing.Color.White;
			this.NameEmployeeTxt.HintForeColor = System.Drawing.Color.White;
			this.NameEmployeeTxt.HintText = "";
			this.NameEmployeeTxt.isPassword = false;
			this.NameEmployeeTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.NameEmployeeTxt.LineIdleColor = System.Drawing.Color.Gray;
			this.NameEmployeeTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.NameEmployeeTxt.LineThickness = 4;
			this.NameEmployeeTxt.Location = new System.Drawing.Point(273, 272);
			this.NameEmployeeTxt.Margin = new System.Windows.Forms.Padding(6);
			this.NameEmployeeTxt.Name = "NameEmployeeTxt";
			this.NameEmployeeTxt.Size = new System.Drawing.Size(416, 80);
			this.NameEmployeeTxt.TabIndex = 129;
			this.NameEmployeeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(96, 429);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 23);
			this.bunifuCustomLabel1.TabIndex = 134;
			this.bunifuCustomLabel1.Text = " Position";
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(96, 549);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(151, 23);
			this.bunifuCustomLabel3.TabIndex = 136;
			this.bunifuCustomLabel3.Text = "PhoneNumber";
			// 
			// PhoneNumbertxt
			// 
			this.PhoneNumbertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PhoneNumbertxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PhoneNumbertxt.ForeColor = System.Drawing.Color.White;
			this.PhoneNumbertxt.HintForeColor = System.Drawing.Color.White;
			this.PhoneNumbertxt.HintText = "";
			this.PhoneNumbertxt.isPassword = false;
			this.PhoneNumbertxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PhoneNumbertxt.LineIdleColor = System.Drawing.Color.Gray;
			this.PhoneNumbertxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PhoneNumbertxt.LineThickness = 4;
			this.PhoneNumbertxt.Location = new System.Drawing.Point(273, 524);
			this.PhoneNumbertxt.Margin = new System.Windows.Forms.Padding(6);
			this.PhoneNumbertxt.Name = "PhoneNumbertxt";
			this.PhoneNumbertxt.Size = new System.Drawing.Size(416, 80);
			this.PhoneNumbertxt.TabIndex = 135;
			this.PhoneNumbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnFemale);
			this.panel1.Controls.Add(this.btnMale);
			this.panel1.Location = new System.Drawing.Point(273, 656);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 83);
			this.panel1.TabIndex = 137;
			// 
			// btnFemale
			// 
			this.btnFemale.AutoSize = true;
			this.btnFemale.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.btnFemale.ForeColor = System.Drawing.Color.White;
			this.btnFemale.Location = new System.Drawing.Point(235, 24);
			this.btnFemale.Name = "btnFemale";
			this.btnFemale.Size = new System.Drawing.Size(109, 27);
			this.btnFemale.TabIndex = 148;
			this.btnFemale.TabStop = true;
			this.btnFemale.Text = "Female";
			this.btnFemale.UseVisualStyleBackColor = true;
			// 
			// btnMale
			// 
			this.btnMale.AutoSize = true;
			this.btnMale.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.btnMale.ForeColor = System.Drawing.Color.White;
			this.btnMale.Location = new System.Drawing.Point(14, 26);
			this.btnMale.Name = "btnMale";
			this.btnMale.Size = new System.Drawing.Size(84, 27);
			this.btnMale.TabIndex = 146;
			this.btnMale.TabStop = true;
			this.btnMale.Text = "Male";
			this.btnMale.UseVisualStyleBackColor = true;
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(96, 684);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(85, 23);
			this.bunifuCustomLabel4.TabIndex = 138;
			this.bunifuCustomLabel4.Text = "Gender";
			// 
			// PositionCBB
			// 
			this.PositionCBB.BackColor = System.Drawing.Color.Transparent;
			this.PositionCBB.BorderRadius = 3;
			this.PositionCBB.ForeColor = System.Drawing.Color.White;
			this.PositionCBB.Items = new string[0];
			this.PositionCBB.Location = new System.Drawing.Point(273, 443);
			this.PositionCBB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PositionCBB.Name = "PositionCBB";
			this.PositionCBB.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.PositionCBB.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.PositionCBB.selectedIndex = -1;
			this.PositionCBB.Size = new System.Drawing.Size(416, 54);
			this.PositionCBB.TabIndex = 145;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(475, 745);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(214, 137);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 147;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(100, 789);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 56);
			this.button1.TabIndex = 148;
			this.button1.Text = "Avatar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.bunifuThinButton21_Click);
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			this.ClientSize = new System.Drawing.Size(835, 1012);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.PositionCBB);
			this.Controls.Add(this.bunifuCustomLabel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Controls.Add(this.PhoneNumbertxt);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuCustomLabel10);
			this.Controls.Add(this.EmployeeIdTxt);
			this.Controls.Add(this.NameEmployeeTxt);
			this.Controls.Add(this.Addbtn);
			this.Controls.Add(this.guestLabel);
			this.Controls.Add(this.closeGuestFormBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EmployeeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmployeeForm";
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label guestLabel;
        private FontAwesome.Sharp.IconButton closeGuestFormBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmployeeIdTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameEmployeeTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneNumbertxt;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDropdown PositionCBB;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.RadioButton btnFemale;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
	}
}