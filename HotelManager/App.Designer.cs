namespace HotelManager
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pageTitle = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.homeLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userAuth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayRealTime = new System.Windows.Forms.Label();
            this.displayRealDate = new System.Windows.Forms.Label();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.SettingButton = new FontAwesome.Sharp.IconButton();
            this.ReservationButton = new FontAwesome.Sharp.IconButton();
            this.EmployeesButton = new FontAwesome.Sharp.IconButton();
            this.ClientsButton = new FontAwesome.Sharp.IconButton();
            this.RoomsButton = new FontAwesome.Sharp.IconButton();
            this.DashboardButton = new FontAwesome.Sharp.IconButton();
            this.panelDestopApp = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDestopApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelTitleBar.Controls.Add(this.pageTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(864, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.pageTitle.Location = new System.Drawing.Point(451, 22);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(56, 23);
            this.pageTitle.TabIndex = 1;
            this.pageTitle.Text = "Home";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.homeLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 149);
            this.panelLogo.TabIndex = 0;
            // 
            // homeLogo
            // 
            this.homeLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeLogo.Image = global::HotelManager.Properties.Resources.hotel_logo;
            this.homeLogo.Location = new System.Drawing.Point(0, 0);
            this.homeLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeLogo.Name = "homeLogo";
            this.homeLogo.Size = new System.Drawing.Size(200, 147);
            this.homeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeLogo.TabIndex = 0;
            this.homeLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.LogoutButton);
            this.panelMenu.Controls.Add(this.SettingButton);
            this.panelMenu.Controls.Add(this.ReservationButton);
            this.panelMenu.Controls.Add(this.EmployeesButton);
            this.panelMenu.Controls.Add(this.ClientsButton);
            this.panelMenu.Controls.Add(this.RoomsButton);
            this.panelMenu.Controls.Add(this.DashboardButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 625);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.userAuth);
            this.panel2.Font = new System.Drawing.Font("Impact", 10F);
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 43);
            this.panel2.TabIndex = 31;
            // 
            // userAuth
            // 
            this.userAuth.AutoSize = true;
            this.userAuth.Font = new System.Drawing.Font("Impact", 10F);
            this.userAuth.ForeColor = System.Drawing.Color.White;
            this.userAuth.Location = new System.Drawing.Point(23, 13);
            this.userAuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userAuth.Name = "userAuth";
            this.userAuth.Size = new System.Drawing.Size(116, 18);
            this.userAuth.TabIndex = 0;
            this.userAuth.Text = "Login as lequangvu";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.displayRealTime);
            this.panel1.Controls.Add(this.displayRealDate);
            this.panel1.Location = new System.Drawing.Point(0, 518);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 106);
            this.panel1.TabIndex = 30;
            // 
            // displayRealTime
            // 
            this.displayRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayRealTime.AutoSize = true;
            this.displayRealTime.Font = new System.Drawing.Font("Impact", 10F);
            this.displayRealTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.displayRealTime.Location = new System.Drawing.Point(53, 54);
            this.displayRealTime.Name = "displayRealTime";
            this.displayRealTime.Size = new System.Drawing.Size(0, 18);
            this.displayRealTime.TabIndex = 2;
            this.displayRealTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayRealDate
            // 
            this.displayRealDate.AutoSize = true;
            this.displayRealDate.Font = new System.Drawing.Font("Impact", 10F);
            this.displayRealDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.displayRealDate.Location = new System.Drawing.Point(23, 14);
            this.displayRealDate.Name = "displayRealDate";
            this.displayRealDate.Size = new System.Drawing.Size(0, 18);
            this.displayRealDate.TabIndex = 3;
            this.displayRealDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.LogoutButton.IconColor = System.Drawing.Color.Gainsboro;
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.IconSize = 32;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(0, 425);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LogoutButton.Size = new System.Drawing.Size(200, 46);
            this.LogoutButton.TabIndex = 29;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.SettingButton.IconColor = System.Drawing.Color.Gainsboro;
            this.SettingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingButton.IconSize = 32;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(0, 379);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingButton.Size = new System.Drawing.Size(200, 46);
            this.SettingButton.TabIndex = 26;
            this.SettingButton.Text = "Setting";
            this.SettingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReservationButton.FlatAppearance.BorderSize = 0;
            this.ReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ReservationButton.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.ReservationButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ReservationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReservationButton.IconSize = 32;
            this.ReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationButton.Location = new System.Drawing.Point(0, 333);
            this.ReservationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ReservationButton.Size = new System.Drawing.Size(200, 46);
            this.ReservationButton.TabIndex = 25;
            this.ReservationButton.Text = "Reservation";
            this.ReservationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.EmployeesButton.IconChar = FontAwesome.Sharp.IconChar.Servicestack;
            this.EmployeesButton.IconColor = System.Drawing.Color.Gainsboro;
            this.EmployeesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeesButton.IconSize = 32;
            this.EmployeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeesButton.Location = new System.Drawing.Point(0, 287);
            this.EmployeesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EmployeesButton.Size = new System.Drawing.Size(200, 46);
            this.EmployeesButton.TabIndex = 24;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.AutoSize = true;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ClientsButton.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.ClientsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ClientsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientsButton.IconSize = 32;
            this.ClientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsButton.Location = new System.Drawing.Point(0, 241);
            this.ClientsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ClientsButton.Size = new System.Drawing.Size(200, 46);
            this.ClientsButton.TabIndex = 23;
            this.ClientsButton.Text = "Guest";
            this.ClientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // RoomsButton
            // 
            this.RoomsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomsButton.FlatAppearance.BorderSize = 0;
            this.RoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RoomsButton.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.RoomsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.RoomsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RoomsButton.IconSize = 32;
            this.RoomsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomsButton.Location = new System.Drawing.Point(0, 195);
            this.RoomsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomsButton.Name = "RoomsButton";
            this.RoomsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RoomsButton.Size = new System.Drawing.Size(200, 46);
            this.RoomsButton.TabIndex = 20;
            this.RoomsButton.Text = "Rooms";
            this.RoomsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RoomsButton.UseVisualStyleBackColor = true;
            this.RoomsButton.Click += new System.EventHandler(this.RoomsButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardButton.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.DashboardButton.IconColor = System.Drawing.Color.Gainsboro;
            this.DashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardButton.IconSize = 32;
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(0, 149);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DashboardButton.Size = new System.Drawing.Size(200, 46);
            this.DashboardButton.TabIndex = 10;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // panelDestopApp
            // 
            this.panelDestopApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.panelDestopApp.Controls.Add(this.pictureBox1);
            this.panelDestopApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDestopApp.Location = new System.Drawing.Point(200, 75);
            this.panelDestopApp.Name = "panelDestopApp";
            this.panelDestopApp.Size = new System.Drawing.Size(864, 550);
            this.panelDestopApp.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HotelManager.Properties.Resources.hotel_logo;
            this.pictureBox1.Location = new System.Drawing.Point(178, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 625);
            this.Controls.Add(this.panelDestopApp);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROYAL HOTEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.App_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDestopApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox homeLogo;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton DashboardButton;
        private FontAwesome.Sharp.IconButton SettingButton;
        private FontAwesome.Sharp.IconButton ReservationButton;
        private FontAwesome.Sharp.IconButton EmployeesButton;
        private FontAwesome.Sharp.IconButton ClientsButton;
        private FontAwesome.Sharp.IconButton RoomsButton;
        private System.Windows.Forms.Panel panelDestopApp;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displayRealTime;
        private System.Windows.Forms.Label displayRealDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userAuth;
    }
}

