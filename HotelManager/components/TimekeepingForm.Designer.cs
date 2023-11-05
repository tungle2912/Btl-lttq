namespace HotelManager.components
{
    partial class TimekeepingForm
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
            this.NameCBB = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EmployeeIdTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.guestLabel = new System.Windows.Forms.Label();
            this.closeGuestFormBtn = new FontAwesome.Sharp.IconButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Workdaydatetime = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // NameCBB
            // 
            this.NameCBB.BackColor = System.Drawing.Color.Transparent;
            this.NameCBB.BorderRadius = 0;
            this.NameCBB.ForeColor = System.Drawing.Color.White;
            this.NameCBB.Items = new string[0];
            this.NameCBB.Location = new System.Drawing.Point(226, 236);
            this.NameCBB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameCBB.Name = "NameCBB";
            this.NameCBB.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.NameCBB.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.NameCBB.selectedIndex = -1;
            this.NameCBB.Size = new System.Drawing.Size(266, 54);
            this.NameCBB.TabIndex = 158;
            this.NameCBB.onItemSelected += new System.EventHandler(this.NameCBB_onItemSelected);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(55, 146);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(30, 23);
            this.bunifuCustomLabel10.TabIndex = 151;
            this.bunifuCustomLabel10.Text = "ID";
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
            this.EmployeeIdTxt.Location = new System.Drawing.Point(226, 103);
            this.EmployeeIdTxt.Margin = new System.Windows.Forms.Padding(6);
            this.EmployeeIdTxt.Name = "EmployeeIdTxt";
            this.EmployeeIdTxt.Size = new System.Drawing.Size(266, 80);
            this.EmployeeIdTxt.TabIndex = 150;
            this.EmployeeIdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeIdTxt.OnValueChanged += new System.EventHandler(this.EmployeeIdTxt_OnValueChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(182, 482);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(254, 63);
            this.Addbtn.TabIndex = 148;
            this.Addbtn.Text = "Add ";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.guestLabel.ForeColor = System.Drawing.Color.White;
            this.guestLabel.Location = new System.Drawing.Point(176, 18);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(178, 32);
            this.guestLabel.TabIndex = 147;
            this.guestLabel.Text = "Timekeeping";
            this.guestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.closeGuestFormBtn.Location = new System.Drawing.Point(533, -4);
            this.closeGuestFormBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeGuestFormBtn.Name = "closeGuestFormBtn";
            this.closeGuestFormBtn.Size = new System.Drawing.Size(63, 54);
            this.closeGuestFormBtn.TabIndex = 146;
            this.closeGuestFormBtn.UseVisualStyleBackColor = false;
            this.closeGuestFormBtn.Click += new System.EventHandler(this.closeGuestFormBtn_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(55, 251);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(71, 23);
            this.bunifuCustomLabel3.TabIndex = 159;
            this.bunifuCustomLabel3.Text = "Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(55, 354);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 23);
            this.bunifuCustomLabel1.TabIndex = 160;
            this.bunifuCustomLabel1.Text = "Work Day";
            // 
            // Workdaydatetime
            // 
            this.Workdaydatetime.BackColor = System.Drawing.Color.SeaGreen;
            this.Workdaydatetime.BorderRadius = 5;
            this.Workdaydatetime.ForeColor = System.Drawing.Color.White;
            this.Workdaydatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Workdaydatetime.FormatCustom = null;
            this.Workdaydatetime.Location = new System.Drawing.Point(226, 343);
            this.Workdaydatetime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Workdaydatetime.Name = "Workdaydatetime";
            this.Workdaydatetime.Size = new System.Drawing.Size(266, 55);
            this.Workdaydatetime.TabIndex = 161;
            this.Workdaydatetime.Value = new System.DateTime(2023, 11, 4, 23, 1, 59, 877);
            // 
            // TimekeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(597, 623);
            this.Controls.Add(this.Workdaydatetime);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.NameCBB);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.EmployeeIdTxt);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.closeGuestFormBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimekeepingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimekeepingForm";
            this.Load += new System.EventHandler(this.TimekeepingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown NameCBB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmployeeIdTxt;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label guestLabel;
        private FontAwesome.Sharp.IconButton closeGuestFormBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker Workdaydatetime;
    }
}