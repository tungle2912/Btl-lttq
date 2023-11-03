namespace HotelManager
{
    partial class CustomMessageBox
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
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.customMessageBoxTitle = new System.Windows.Forms.Label();
            this.customMessageBoxContent = new System.Windows.Forms.Label();
            this.agreeMessageBoxBtn = new System.Windows.Forms.Button();
            this.disagreeMessageBoxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // customMessageBoxTitle
            // 
            this.customMessageBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customMessageBoxTitle.AutoSize = true;
            this.customMessageBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.customMessageBoxTitle.ForeColor = System.Drawing.Color.White;
            this.customMessageBoxTitle.Location = new System.Drawing.Point(277, 30);
            this.customMessageBoxTitle.Name = "customMessageBoxTitle";
            this.customMessageBoxTitle.Size = new System.Drawing.Size(66, 29);
            this.customMessageBoxTitle.TabIndex = 0;
            this.customMessageBoxTitle.Text = "Title";
            this.customMessageBoxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customMessageBoxContent
            // 
            this.customMessageBoxContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customMessageBoxContent.AutoSize = true;
            this.customMessageBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customMessageBoxContent.ForeColor = System.Drawing.Color.White;
            this.customMessageBoxContent.Location = new System.Drawing.Point(261, 84);
            this.customMessageBoxContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customMessageBoxContent.MaximumSize = new System.Drawing.Size(349, 60);
            this.customMessageBoxContent.Name = "customMessageBoxContent";
            this.customMessageBoxContent.Size = new System.Drawing.Size(93, 25);
            this.customMessageBoxContent.TabIndex = 1;
            this.customMessageBoxContent.Text = "Message";
            this.customMessageBoxContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agreeMessageBoxBtn
            // 
            this.agreeMessageBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.agreeMessageBoxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.agreeMessageBoxBtn.FlatAppearance.BorderSize = 0;
            this.agreeMessageBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agreeMessageBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.agreeMessageBoxBtn.ForeColor = System.Drawing.Color.White;
            this.agreeMessageBoxBtn.Location = new System.Drawing.Point(76, 164);
            this.agreeMessageBoxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agreeMessageBoxBtn.Name = "agreeMessageBoxBtn";
            this.agreeMessageBoxBtn.Size = new System.Drawing.Size(220, 50);
            this.agreeMessageBoxBtn.TabIndex = 2;
            this.agreeMessageBoxBtn.Text = "Yes";
            this.agreeMessageBoxBtn.UseVisualStyleBackColor = false;
            this.agreeMessageBoxBtn.Click += new System.EventHandler(this.agreeMessageBoxBtn_Click);
            // 
            // disagreeMessageBoxBtn
            // 
            this.disagreeMessageBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disagreeMessageBoxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.disagreeMessageBoxBtn.FlatAppearance.BorderSize = 0;
            this.disagreeMessageBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disagreeMessageBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disagreeMessageBoxBtn.ForeColor = System.Drawing.Color.White;
            this.disagreeMessageBoxBtn.Location = new System.Drawing.Point(323, 164);
            this.disagreeMessageBoxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disagreeMessageBoxBtn.Name = "disagreeMessageBoxBtn";
            this.disagreeMessageBoxBtn.Size = new System.Drawing.Size(220, 50);
            this.disagreeMessageBoxBtn.TabIndex = 2;
            this.disagreeMessageBoxBtn.Text = "No";
            this.disagreeMessageBoxBtn.UseVisualStyleBackColor = false;
            
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(615, 251);
            this.Controls.Add(this.disagreeMessageBoxBtn);
            this.Controls.Add(this.agreeMessageBoxBtn);
            this.Controls.Add(this.customMessageBoxContent);
            this.Controls.Add(this.customMessageBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Label customMessageBoxTitle;
        private System.Windows.Forms.Label customMessageBoxContent;
        private System.Windows.Forms.Button agreeMessageBoxBtn;
        private System.Windows.Forms.Button disagreeMessageBoxBtn;
    }
}