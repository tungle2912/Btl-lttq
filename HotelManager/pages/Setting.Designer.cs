namespace HotelManager.pages
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.accountTab = new System.Windows.Forms.Button();
            this.eventVoucherTab = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.tabsPanel);
            this.panel1.Controls.Add(this.settingPanel);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 635);
            this.panel1.TabIndex = 3;
            // 
            // settingPanel
            // 
            this.settingPanel.Location = new System.Drawing.Point(16, 77);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(932, 542);
            this.settingPanel.TabIndex = 1;
            // 
            // tabsPanel
            // 
            this.tabsPanel.Controls.Add(this.eventVoucherTab);
            this.tabsPanel.Controls.Add(this.accountTab);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsPanel.Location = new System.Drawing.Point(0, 0);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(966, 59);
            this.tabsPanel.TabIndex = 2;
            // 
            // accountTab
            // 
            this.accountTab.Location = new System.Drawing.Point(16, 14);
            this.accountTab.Name = "accountTab";
            this.accountTab.Size = new System.Drawing.Size(112, 31);
            this.accountTab.TabIndex = 2;
            this.accountTab.Text = "Account";
            this.accountTab.UseVisualStyleBackColor = true;
            this.accountTab.Click += new System.EventHandler(this.accountTab_Click);
            // 
            // eventVoucherTab
            // 
            this.eventVoucherTab.Location = new System.Drawing.Point(138, 14);
            this.eventVoucherTab.Name = "eventVoucherTab";
            this.eventVoucherTab.Size = new System.Drawing.Size(112, 31);
            this.eventVoucherTab.TabIndex = 1;
            this.eventVoucherTab.Text = "Event Voucher";
            this.eventVoucherTab.UseVisualStyleBackColor = true;
            this.eventVoucherTab.Click += new System.EventHandler(this.voucherTab_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1011, 682);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Setting";
            this.panel1.ResumeLayout(false);
            this.tabsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.Button eventVoucherTab;
        private System.Windows.Forms.Button accountTab;
    }
}