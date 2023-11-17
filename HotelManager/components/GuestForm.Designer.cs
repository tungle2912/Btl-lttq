namespace HotelManager.components
{
    partial class GuestForm
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
            this.guestFormButton = new System.Windows.Forms.Button();
            this.guestLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ageTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guestIDTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cancelGuestButton = new System.Windows.Forms.Button();
            this.closeGuestFormBtn = new FontAwesome.Sharp.IconButton();
            this.nameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneNumberTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guestCheckoutCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteGuestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guestFormButton
            // 
            this.guestFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.guestFormButton.FlatAppearance.BorderSize = 0;
            this.guestFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guestFormButton.ForeColor = System.Drawing.Color.White;
            this.guestFormButton.Location = new System.Drawing.Point(67, 658);
            this.guestFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guestFormButton.Name = "guestFormButton";
            this.guestFormButton.Size = new System.Drawing.Size(220, 49);
            this.guestFormButton.TabIndex = 55;
            this.guestFormButton.Text = "Add";
            this.guestFormButton.UseVisualStyleBackColor = false;
            this.guestFormButton.Click += new System.EventHandler(this.guestFormButton_Click);
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.guestLabel.ForeColor = System.Drawing.Color.White;
            this.guestLabel.Location = new System.Drawing.Point(219, 59);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(151, 29);
            this.guestLabel.TabIndex = 54;
            this.guestLabel.Text = "ADD GUEST";
            this.guestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.addressTextBox.ForeColor = System.Drawing.Color.White;
            this.addressTextBox.HintForeColor = System.Drawing.Color.White;
            this.addressTextBox.HintText = "Address";
            this.addressTextBox.isPassword = false;
            this.addressTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.addressTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.addressTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.addressTextBox.LineThickness = 3;
            this.addressTextBox.Location = new System.Drawing.Point(65, 409);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(461, 64);
            this.addressTextBox.TabIndex = 52;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ageTextBox.ForeColor = System.Drawing.Color.White;
            this.ageTextBox.HintForeColor = System.Drawing.Color.White;
            this.ageTextBox.HintText = "Age";
            this.ageTextBox.isPassword = false;
            this.ageTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.ageTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.ageTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.ageTextBox.LineThickness = 3;
            this.ageTextBox.Location = new System.Drawing.Point(67, 304);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(461, 64);
            this.ageTextBox.TabIndex = 53;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guestIDTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.guestIDTextBox.ForeColor = System.Drawing.Color.White;
            this.guestIDTextBox.HintForeColor = System.Drawing.Color.White;
            this.guestIDTextBox.HintText = "Guest ID";
            this.guestIDTextBox.isPassword = false;
            this.guestIDTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.guestIDTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.guestIDTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.guestIDTextBox.LineThickness = 3;
            this.guestIDTextBox.Location = new System.Drawing.Point(67, 100);
            this.guestIDTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(461, 64);
            this.guestIDTextBox.TabIndex = 50;
            this.guestIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cancelGuestButton
            // 
            this.cancelGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.cancelGuestButton.FlatAppearance.BorderSize = 0;
            this.cancelGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelGuestButton.ForeColor = System.Drawing.Color.White;
            this.cancelGuestButton.Location = new System.Drawing.Point(308, 658);
            this.cancelGuestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelGuestButton.Name = "cancelGuestButton";
            this.cancelGuestButton.Size = new System.Drawing.Size(220, 49);
            this.cancelGuestButton.TabIndex = 49;
            this.cancelGuestButton.Text = "Cancel";
            this.cancelGuestButton.UseVisualStyleBackColor = false;
            this.cancelGuestButton.Click += new System.EventHandler(this.closeGuestFormBtn_Click);
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
            this.closeGuestFormBtn.Location = new System.Drawing.Point(541, 0);
            this.closeGuestFormBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeGuestFormBtn.Name = "closeGuestFormBtn";
            this.closeGuestFormBtn.Size = new System.Drawing.Size(56, 46);
            this.closeGuestFormBtn.TabIndex = 48;
            this.closeGuestFormBtn.UseVisualStyleBackColor = false;
            this.closeGuestFormBtn.Click += new System.EventHandler(this.closeGuestFormBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.HintForeColor = System.Drawing.Color.White;
            this.nameTextBox.HintText = "Name";
            this.nameTextBox.isPassword = false;
            this.nameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.nameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.nameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.nameTextBox.LineThickness = 3;
            this.nameTextBox.Location = new System.Drawing.Point(67, 202);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(461, 64);
            this.nameTextBox.TabIndex = 56;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.HintForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.HintText = "Phone Number";
            this.phoneNumberTextBox.isPassword = false;
            this.phoneNumberTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.phoneNumberTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneNumberTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.phoneNumberTextBox.LineThickness = 3;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(67, 508);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(461, 64);
            this.phoneNumberTextBox.TabIndex = 57;
            this.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guestCheckoutCheckBox
            // 
            this.guestCheckoutCheckBox.AutoSize = true;
            this.guestCheckoutCheckBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.guestCheckoutCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.guestCheckoutCheckBox.Location = new System.Drawing.Point(67, 603);
            this.guestCheckoutCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guestCheckoutCheckBox.Name = "guestCheckoutCheckBox";
            this.guestCheckoutCheckBox.Size = new System.Drawing.Size(118, 23);
            this.guestCheckoutCheckBox.TabIndex = 58;
            this.guestCheckoutCheckBox.Text = "Check-out";
            this.guestCheckoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteGuestButton
            // 
            this.deleteGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.deleteGuestButton.FlatAppearance.BorderSize = 0;
            this.deleteGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteGuestButton.ForeColor = System.Drawing.Color.White;
            this.deleteGuestButton.Location = new System.Drawing.Point(67, 729);
            this.deleteGuestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteGuestButton.Name = "deleteGuestButton";
            this.deleteGuestButton.Size = new System.Drawing.Size(461, 49);
            this.deleteGuestButton.TabIndex = 60;
            this.deleteGuestButton.Text = "Delete";
            this.deleteGuestButton.UseVisualStyleBackColor = false;
            this.deleteGuestButton.Click += new System.EventHandler(this.deleteGuestButton_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(596, 833);
            this.Controls.Add(this.deleteGuestButton);
            this.Controls.Add(this.guestCheckoutCheckBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.guestFormButton);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.cancelGuestButton);
            this.Controls.Add(this.closeGuestFormBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guestFormButton;
        private System.Windows.Forms.Label guestLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ageTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox guestIDTextBox;
        private System.Windows.Forms.Button cancelGuestButton;
        private FontAwesome.Sharp.IconButton closeGuestFormBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneNumberTextBox;
        private System.Windows.Forms.CheckBox guestCheckoutCheckBox;
        private System.Windows.Forms.Button deleteGuestButton;
    }
}