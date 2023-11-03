namespace HotelManager
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeRegisterPageBtn = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterFormControl = new System.Windows.Forms.Panel();
            this.eyeRegisterPassword = new FontAwesome.Sharp.IconButton();
            this.eyeRegisterConfirmPassword = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.registerComfirmPasswordWarningText = new System.Windows.Forms.Label();
            this.registerPasswordWarningText = new System.Windows.Forms.Label();
            this.registerConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.registerPasswordInput = new System.Windows.Forms.TextBox();
            this.registerUsernameWarningText = new System.Windows.Forms.Label();
            this.registerUsernameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.directToLoginPage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.RegisterFormControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.closeRegisterPageBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 50);
            this.panel1.TabIndex = 1;
            // 
            // closeRegisterPageBtn
            // 
            this.closeRegisterPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeRegisterPageBtn.BackColor = System.Drawing.Color.White;
            this.closeRegisterPageBtn.FlatAppearance.BorderSize = 0;
            this.closeRegisterPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeRegisterPageBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeRegisterPageBtn.IconColor = System.Drawing.Color.Black;
            this.closeRegisterPageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeRegisterPageBtn.IconSize = 24;
            this.closeRegisterPageBtn.Location = new System.Drawing.Point(827, 13);
            this.closeRegisterPageBtn.Name = "closeRegisterPageBtn";
            this.closeRegisterPageBtn.Size = new System.Drawing.Size(30, 26);
            this.closeRegisterPageBtn.TabIndex = 0;
            this.closeRegisterPageBtn.UseVisualStyleBackColor = false;
            this.closeRegisterPageBtn.Click += new System.EventHandler(this.closeRegisterPageBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pictureBox1.Image = global::HotelManager.Properties.Resources.hotel_logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(509, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 386);
            this.panel2.TabIndex = 3;
            // 
            // RegisterFormControl
            // 
            this.RegisterFormControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegisterFormControl.Controls.Add(this.eyeRegisterPassword);
            this.RegisterFormControl.Controls.Add(this.eyeRegisterConfirmPassword);
            this.RegisterFormControl.Controls.Add(this.label5);
            this.RegisterFormControl.Controls.Add(this.label4);
            this.RegisterFormControl.Controls.Add(this.label3);
            this.RegisterFormControl.Controls.Add(this.panel3);
            this.RegisterFormControl.Controls.Add(this.panel5);
            this.RegisterFormControl.Controls.Add(this.panel6);
            this.RegisterFormControl.Controls.Add(this.registerComfirmPasswordWarningText);
            this.RegisterFormControl.Controls.Add(this.registerPasswordWarningText);
            this.RegisterFormControl.Controls.Add(this.registerConfirmPasswordInput);
            this.RegisterFormControl.Controls.Add(this.registerPasswordInput);
            this.RegisterFormControl.Controls.Add(this.registerUsernameWarningText);
            this.RegisterFormControl.Controls.Add(this.registerUsernameInput);
            this.RegisterFormControl.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.RegisterFormControl.Location = new System.Drawing.Point(32, 94);
            this.RegisterFormControl.Name = "RegisterFormControl";
            this.RegisterFormControl.Size = new System.Drawing.Size(453, 217);
            this.RegisterFormControl.TabIndex = 4;
            // 
            // eyeRegisterPassword
            // 
            this.eyeRegisterPassword.FlatAppearance.BorderSize = 0;
            this.eyeRegisterPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeRegisterPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.eyeRegisterPassword.IconColor = System.Drawing.Color.White;
            this.eyeRegisterPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.eyeRegisterPassword.IconSize = 28;
            this.eyeRegisterPassword.Location = new System.Drawing.Point(398, 75);
            this.eyeRegisterPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eyeRegisterPassword.Name = "eyeRegisterPassword";
            this.eyeRegisterPassword.Size = new System.Drawing.Size(31, 25);
            this.eyeRegisterPassword.TabIndex = 8;
            this.eyeRegisterPassword.UseVisualStyleBackColor = true;
            this.eyeRegisterPassword.Click += new System.EventHandler(this.handleHideShowPassword);
            // 
            // eyeRegisterConfirmPassword
            // 
            this.eyeRegisterConfirmPassword.FlatAppearance.BorderSize = 0;
            this.eyeRegisterConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeRegisterConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.eyeRegisterConfirmPassword.IconColor = System.Drawing.Color.White;
            this.eyeRegisterConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.eyeRegisterConfirmPassword.IconSize = 28;
            this.eyeRegisterConfirmPassword.Location = new System.Drawing.Point(398, 142);
            this.eyeRegisterConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eyeRegisterConfirmPassword.Name = "eyeRegisterConfirmPassword";
            this.eyeRegisterConfirmPassword.Size = new System.Drawing.Size(31, 25);
            this.eyeRegisterConfirmPassword.TabIndex = 7;
            this.eyeRegisterConfirmPassword.UseVisualStyleBackColor = true;
            this.eyeRegisterConfirmPassword.Click += new System.EventHandler(this.handleHideShowConfirmPassword);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(188, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 1);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(188, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 1);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(188, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 1);
            this.panel6.TabIndex = 1;
            // 
            // registerComfirmPasswordWarningText
            // 
            this.registerComfirmPasswordWarningText.AutoSize = true;
            this.registerComfirmPasswordWarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.registerComfirmPasswordWarningText.ForeColor = System.Drawing.Color.Red;
            this.registerComfirmPasswordWarningText.Location = new System.Drawing.Point(191, 180);
            this.registerComfirmPasswordWarningText.Name = "registerComfirmPasswordWarningText";
            this.registerComfirmPasswordWarningText.Size = new System.Drawing.Size(0, 13);
            this.registerComfirmPasswordWarningText.TabIndex = 5;
            // 
            // registerPasswordWarningText
            // 
            this.registerPasswordWarningText.AutoSize = true;
            this.registerPasswordWarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.registerPasswordWarningText.ForeColor = System.Drawing.Color.Red;
            this.registerPasswordWarningText.Location = new System.Drawing.Point(191, 113);
            this.registerPasswordWarningText.Name = "registerPasswordWarningText";
            this.registerPasswordWarningText.Size = new System.Drawing.Size(0, 13);
            this.registerPasswordWarningText.TabIndex = 5;
            // 
            // registerConfirmPasswordInput
            // 
            this.registerConfirmPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.registerConfirmPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerConfirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerConfirmPasswordInput.ForeColor = System.Drawing.Color.White;
            this.registerConfirmPasswordInput.Location = new System.Drawing.Point(188, 149);
            this.registerConfirmPasswordInput.Name = "registerConfirmPasswordInput";
            this.registerConfirmPasswordInput.Size = new System.Drawing.Size(240, 19);
            this.registerConfirmPasswordInput.TabIndex = 4;
            // 
            // registerPasswordInput
            // 
            this.registerPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.registerPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerPasswordInput.ForeColor = System.Drawing.Color.White;
            this.registerPasswordInput.Location = new System.Drawing.Point(188, 82);
            this.registerPasswordInput.Name = "registerPasswordInput";
            this.registerPasswordInput.Size = new System.Drawing.Size(240, 19);
            this.registerPasswordInput.TabIndex = 4;
            // 
            // registerUsernameWarningText
            // 
            this.registerUsernameWarningText.AutoSize = true;
            this.registerUsernameWarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.registerUsernameWarningText.ForeColor = System.Drawing.Color.Red;
            this.registerUsernameWarningText.Location = new System.Drawing.Point(192, 47);
            this.registerUsernameWarningText.Name = "registerUsernameWarningText";
            this.registerUsernameWarningText.Size = new System.Drawing.Size(0, 13);
            this.registerUsernameWarningText.TabIndex = 2;
            // 
            // registerUsernameInput
            // 
            this.registerUsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.registerUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerUsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerUsernameInput.ForeColor = System.Drawing.Color.White;
            this.registerUsernameInput.Location = new System.Drawing.Point(188, 17);
            this.registerUsernameInput.Name = "registerUsernameInput";
            this.registerUsernameInput.Size = new System.Drawing.Size(240, 19);
            this.registerUsernameInput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(174, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sign Up";
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.Transparent;
            this.signupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.signupBtn.FlatAppearance.BorderSize = 2;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(220, 319);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(240, 38);
            this.signupBtn.TabIndex = 8;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            this.signupBtn.MouseEnter += new System.EventHandler(this.handleMouseEnter);
            this.signupBtn.MouseLeave += new System.EventHandler(this.handleMouseLeave);
            // 
            // directToLoginPage
            // 
            this.directToLoginPage.AutoSize = true;
            this.directToLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.directToLoginPage.ForeColor = System.Drawing.Color.White;
            this.directToLoginPage.Location = new System.Drawing.Point(237, 376);
            this.directToLoginPage.Name = "directToLoginPage";
            this.directToLoginPage.Size = new System.Drawing.Size(210, 15);
            this.directToLoginPage.TabIndex = 10;
            this.directToLoginPage.Text = "Already have an account? Login";
            this.directToLoginPage.Click += new System.EventHandler(this.directToLoginPage_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(871, 436);
            this.Controls.Add(this.directToLoginPage);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegisterFormControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.RegisterFormControl.ResumeLayout(false);
            this.RegisterFormControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton closeRegisterPageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel RegisterFormControl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label registerPasswordWarningText;
        private System.Windows.Forms.TextBox registerPasswordInput;
        private System.Windows.Forms.Label registerUsernameWarningText;
        private System.Windows.Forms.TextBox registerUsernameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label registerComfirmPasswordWarningText;
        private System.Windows.Forms.TextBox registerConfirmPasswordInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label directToLoginPage;
        private FontAwesome.Sharp.IconButton eyeRegisterPassword;
        private FontAwesome.Sharp.IconButton eyeRegisterConfirmPassword;
    }
}