namespace HotelManager.components
{
    partial class RoomForm
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
            this.roomNumberTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cancelAddRoomFormButton = new System.Windows.Forms.Button();
            this.roomFormLabel = new System.Windows.Forms.Label();
            this.roomFormButton = new System.Windows.Forms.Button();
            this.roomTypeDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.roomPriceTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roomStatusDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.roomFloorDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label = new System.Windows.Forms.Label();
            this.closeRoomFormBtn = new FontAwesome.Sharp.IconButton();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.roomNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.roomNumberTextBox.HintForeColor = System.Drawing.Color.White;
            this.roomNumberTextBox.HintText = "Room Number";
            this.roomNumberTextBox.isPassword = false;
            this.roomNumberTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomNumberTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.roomNumberTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomNumberTextBox.LineThickness = 3;
            this.roomNumberTextBox.Location = new System.Drawing.Point(71, 116);
            this.roomNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(457, 64);
            this.roomNumberTextBox.TabIndex = 43;
            this.roomNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cancelAddRoomFormButton
            // 
            this.cancelAddRoomFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.cancelAddRoomFormButton.FlatAppearance.BorderSize = 0;
            this.cancelAddRoomFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddRoomFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelAddRoomFormButton.ForeColor = System.Drawing.Color.White;
            this.cancelAddRoomFormButton.Location = new System.Drawing.Point(308, 630);
            this.cancelAddRoomFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelAddRoomFormButton.Name = "cancelAddRoomFormButton";
            this.cancelAddRoomFormButton.Size = new System.Drawing.Size(220, 49);
            this.cancelAddRoomFormButton.TabIndex = 38;
            this.cancelAddRoomFormButton.Text = "Cancel";
            this.cancelAddRoomFormButton.UseVisualStyleBackColor = false;
            this.cancelAddRoomFormButton.Click += new System.EventHandler(this.closeRoomFormBtn_Click);
            // 
            // roomFormLabel
            // 
            this.roomFormLabel.AutoSize = true;
            this.roomFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.roomFormLabel.ForeColor = System.Drawing.Color.White;
            this.roomFormLabel.Location = new System.Drawing.Point(232, 62);
            this.roomFormLabel.Name = "roomFormLabel";
            this.roomFormLabel.Size = new System.Drawing.Size(85, 29);
            this.roomFormLabel.TabIndex = 44;
            this.roomFormLabel.Text = "TITLE";
            this.roomFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomFormButton
            // 
            this.roomFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomFormButton.FlatAppearance.BorderSize = 0;
            this.roomFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomFormButton.ForeColor = System.Drawing.Color.White;
            this.roomFormButton.Location = new System.Drawing.Point(67, 630);
            this.roomFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomFormButton.Name = "roomFormButton";
            this.roomFormButton.Size = new System.Drawing.Size(220, 49);
            this.roomFormButton.TabIndex = 45;
            this.roomFormButton.Text = "Add";
            this.roomFormButton.UseVisualStyleBackColor = false;
            this.roomFormButton.Click += new System.EventHandler(this.roomFormButton_Click);
            // 
            // roomTypeDropdown
            // 
            this.roomTypeDropdown.BackColor = System.Drawing.Color.Transparent;
            this.roomTypeDropdown.BorderRadius = 3;
            this.roomTypeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomTypeDropdown.ForeColor = System.Drawing.Color.White;
            this.roomTypeDropdown.Items = new string[] {
        "Single",
        "Double ",
        "Triple",
        "VIP"};
            this.roomTypeDropdown.Location = new System.Drawing.Point(189, 245);
            this.roomTypeDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roomTypeDropdown.Name = "roomTypeDropdown";
            this.roomTypeDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomTypeDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomTypeDropdown.selectedIndex = 0;
            this.roomTypeDropdown.Size = new System.Drawing.Size(336, 49);
            this.roomTypeDropdown.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Room Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomPriceTextBox
            // 
            this.roomPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.roomPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.roomPriceTextBox.HintForeColor = System.Drawing.Color.White;
            this.roomPriceTextBox.HintText = "Price";
            this.roomPriceTextBox.isPassword = false;
            this.roomPriceTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomPriceTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.roomPriceTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomPriceTextBox.LineThickness = 3;
            this.roomPriceTextBox.Location = new System.Drawing.Point(71, 505);
            this.roomPriceTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roomPriceTextBox.Name = "roomPriceTextBox";
            this.roomPriceTextBox.Size = new System.Drawing.Size(457, 64);
            this.roomPriceTextBox.TabIndex = 52;
            this.roomPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roomStatusDropDown
            // 
            this.roomStatusDropDown.BackColor = System.Drawing.Color.Transparent;
            this.roomStatusDropDown.BorderRadius = 3;
            this.roomStatusDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomStatusDropDown.ForeColor = System.Drawing.Color.White;
            this.roomStatusDropDown.Items = new string[] {
        "Trống",
        "Đã thuê"};
            this.roomStatusDropDown.Location = new System.Drawing.Point(189, 441);
            this.roomStatusDropDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roomStatusDropDown.Name = "roomStatusDropDown";
            this.roomStatusDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomStatusDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomStatusDropDown.selectedIndex = 0;
            this.roomStatusDropDown.Size = new System.Drawing.Size(336, 49);
            this.roomStatusDropDown.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomFloorDropDown
            // 
            this.roomFloorDropDown.BackColor = System.Drawing.Color.Transparent;
            this.roomFloorDropDown.BorderRadius = 3;
            this.roomFloorDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomFloorDropDown.ForeColor = System.Drawing.Color.White;
            this.roomFloorDropDown.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"};
            this.roomFloorDropDown.Location = new System.Drawing.Point(189, 350);
            this.roomFloorDropDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roomFloorDropDown.Name = "roomFloorDropDown";
            this.roomFloorDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomFloorDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.roomFloorDropDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomFloorDropDown.selectedIndex = 0;
            this.roomFloorDropDown.Size = new System.Drawing.Size(336, 49);
            this.roomFloorDropDown.TabIndex = 46;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(68, 362);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 21);
            this.label.TabIndex = 47;
            this.label.Text = "Floor";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeRoomFormBtn
            // 
            this.closeRoomFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeRoomFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.closeRoomFormBtn.FlatAppearance.BorderSize = 0;
            this.closeRoomFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeRoomFormBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeRoomFormBtn.IconColor = System.Drawing.Color.White;
            this.closeRoomFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeRoomFormBtn.IconSize = 32;
            this.closeRoomFormBtn.Location = new System.Drawing.Point(540, 0);
            this.closeRoomFormBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeRoomFormBtn.Name = "closeRoomFormBtn";
            this.closeRoomFormBtn.Size = new System.Drawing.Size(56, 46);
            this.closeRoomFormBtn.TabIndex = 0;
            this.closeRoomFormBtn.UseVisualStyleBackColor = false;
            this.closeRoomFormBtn.Click += new System.EventHandler(this.closeRoomFormBtn_Click);
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.deleteRoomButton.FlatAppearance.BorderSize = 0;
            this.deleteRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteRoomButton.ForeColor = System.Drawing.Color.White;
            this.deleteRoomButton.Location = new System.Drawing.Point(64, 702);
            this.deleteRoomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(461, 49);
            this.deleteRoomButton.TabIndex = 61;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = false;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(596, 805);
            this.Controls.Add(this.deleteRoomButton);
            this.Controls.Add(this.roomPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomStatusDropDown);
            this.Controls.Add(this.roomFloorDropDown);
            this.Controls.Add(this.roomTypeDropdown);
            this.Controls.Add(this.roomFormButton);
            this.Controls.Add(this.roomFormLabel);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.cancelAddRoomFormButton);
            this.Controls.Add(this.closeRoomFormBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton closeRoomFormBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomNumberTextBox;
        private System.Windows.Forms.Button cancelAddRoomFormButton;
        private System.Windows.Forms.Label roomFormLabel;
        private System.Windows.Forms.Button roomFormButton;
        private Bunifu.Framework.UI.BunifuDropdown roomTypeDropdown;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomPriceTextBox;
        private Bunifu.Framework.UI.BunifuDropdown roomStatusDropDown;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown roomFloorDropDown;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button deleteRoomButton;
    }
}