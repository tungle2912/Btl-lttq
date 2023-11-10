namespace HotelManager.components
{
    partial class ReservationForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.AddButton = new System.Windows.Forms.Button();
			this.guestLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.roomNumberCBBox = new Bunifu.Framework.UI.BunifuDropdown();
			this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.ageTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.addressTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.nameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.arriveTimeDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
			this.label2 = new System.Windows.Forms.Label();
			this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.PriceTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.guestIDTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.employeeIDTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.BillIDLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.ServiceDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.ServiceCBBox = new Bunifu.Framework.UI.BunifuDropdown();
			this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.PriceServiceTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnAddService = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.LeaveTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
			this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.Totallabel = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.PhoneNumberTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.ExportDataBtn = new FontAwesome.Sharp.IconButton();
			this.closeReservationFormBtn = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.AddButton.FlatAppearance.BorderSize = 0;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.AddButton.ForeColor = System.Drawing.Color.White;
			this.AddButton.Location = new System.Drawing.Point(455, 607);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(165, 41);
			this.AddButton.TabIndex = 64;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.guestFormButton_Click);
			// 
			// guestLabel
			// 
			this.guestLabel.AutoSize = true;
			this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.guestLabel.ForeColor = System.Drawing.Color.White;
			this.guestLabel.Location = new System.Drawing.Point(585, 45);
			this.guestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.guestLabel.Name = "guestLabel";
			this.guestLabel.Size = new System.Drawing.Size(34, 24);
			this.guestLabel.TabIndex = 63;
			this.guestLabel.Text = "Bill";
			this.guestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(636, 607);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(165, 41);
			this.cancelButton.TabIndex = 59;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.deleteButton.FlatAppearance.BorderSize = 0;
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.deleteButton.ForeColor = System.Drawing.Color.White;
			this.deleteButton.Location = new System.Drawing.Point(455, 661);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(346, 41);
			this.deleteButton.TabIndex = 73;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// roomNumberCBBox
			// 
			this.roomNumberCBBox.BackColor = System.Drawing.Color.Transparent;
			this.roomNumberCBBox.BorderRadius = 3;
			this.roomNumberCBBox.ForeColor = System.Drawing.Color.White;
			this.roomNumberCBBox.Items = new string[0];
			this.roomNumberCBBox.Location = new System.Drawing.Point(574, 109);
			this.roomNumberCBBox.Name = "roomNumberCBBox";
			this.roomNumberCBBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.roomNumberCBBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.roomNumberCBBox.selectedIndex = -1;
			this.roomNumberCBBox.Size = new System.Drawing.Size(234, 35);
			this.roomNumberCBBox.TabIndex = 74;
			this.roomNumberCBBox.onItemSelected += new System.EventHandler(this.roomNumberTextBox_onItemSelected);
			// 
			// bunifuCustomLabel7
			// 
			this.bunifuCustomLabel7.AutoSize = true;
			this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel7.Location = new System.Drawing.Point(453, 115);
			this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
			this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 19);
			this.bunifuCustomLabel7.TabIndex = 115;
			this.bunifuCustomLabel7.Text = "Room Number";
			// 
			// ageTextBox
			// 
			this.ageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ageTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ageTextBox.ForeColor = System.Drawing.Color.White;
			this.ageTextBox.HintForeColor = System.Drawing.Color.White;
			this.ageTextBox.HintText = "";
			this.ageTextBox.isPassword = false;
			this.ageTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.ageTextBox.LineIdleColor = System.Drawing.Color.Gray;
			this.ageTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.ageTextBox.LineThickness = 4;
			this.ageTextBox.Location = new System.Drawing.Point(163, 243);
			this.ageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(204, 52);
			this.ageTextBox.TabIndex = 121;
			this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.ageTextBox.OnValueChanged += new System.EventHandler(this.ValidateNumber);
			// 
			// addressTextBox
			// 
			this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressTextBox.ForeColor = System.Drawing.Color.White;
			this.addressTextBox.HintForeColor = System.Drawing.SystemColors.Window;
			this.addressTextBox.HintText = "";
			this.addressTextBox.isPassword = false;
			this.addressTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.addressTextBox.LineIdleColor = System.Drawing.Color.Gray;
			this.addressTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.addressTextBox.LineThickness = 4;
			this.addressTextBox.Location = new System.Drawing.Point(163, 327);
			this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(204, 52);
			this.addressTextBox.TabIndex = 120;
			this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameTextBox.ForeColor = System.Drawing.Color.White;
			this.nameTextBox.HintForeColor = System.Drawing.Color.White;
			this.nameTextBox.HintText = "";
			this.nameTextBox.isPassword = false;
			this.nameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.nameTextBox.LineIdleColor = System.Drawing.Color.Gray;
			this.nameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.nameTextBox.LineThickness = 4;
			this.nameTextBox.Location = new System.Drawing.Point(163, 163);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(204, 52);
			this.nameTextBox.TabIndex = 122;
			this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// arriveTimeDatepicker
			// 
			this.arriveTimeDatepicker.BackColor = System.Drawing.Color.SeaGreen;
			this.arriveTimeDatepicker.BorderRadius = 0;
			this.arriveTimeDatepicker.ForeColor = System.Drawing.Color.White;
			this.arriveTimeDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.arriveTimeDatepicker.FormatCustom = null;
			this.arriveTimeDatepicker.Location = new System.Drawing.Point(574, 265);
			this.arriveTimeDatepicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.arriveTimeDatepicker.Name = "arriveTimeDatepicker";
			this.arriveTimeDatepicker.Size = new System.Drawing.Size(234, 41);
			this.arriveTimeDatepicker.TabIndex = 124;
			this.arriveTimeDatepicker.Value = new System.DateTime(2023, 11, 3, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(453, 272);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 19);
			this.label2.TabIndex = 125;
			this.label2.Text = "Arrive Time";
			// 
			// bunifuCustomLabel8
			// 
			this.bunifuCustomLabel8.AutoSize = true;
			this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel8.Location = new System.Drawing.Point(45, 505);
			this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
			this.bunifuCustomLabel8.Size = new System.Drawing.Size(78, 19);
			this.bunifuCustomLabel8.TabIndex = 139;
			this.bunifuCustomLabel8.Text = "Employee";
			// 
			// bunifuCustomLabel10
			// 
			this.bunifuCustomLabel10.AutoSize = true;
			this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel10.Location = new System.Drawing.Point(45, 104);
			this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
			this.bunifuCustomLabel10.Size = new System.Drawing.Size(62, 19);
			this.bunifuCustomLabel10.TabIndex = 127;
			this.bunifuCustomLabel10.Text = "GuestID";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 185);
			this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(51, 19);
			this.bunifuCustomLabel2.TabIndex = 128;
			this.bunifuCustomLabel2.Text = "Name";
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(45, 266);
			this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(36, 19);
			this.bunifuCustomLabel3.TabIndex = 129;
			this.bunifuCustomLabel3.Text = "Age";
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(45, 347);
			this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(61, 19);
			this.bunifuCustomLabel4.TabIndex = 130;
			this.bunifuCustomLabel4.Text = "Address";
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(45, 423);
			this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(112, 19);
			this.bunifuCustomLabel5.TabIndex = 131;
			this.bunifuCustomLabel5.Text = "Phone Number";
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PriceTextBox.Enabled = false;
			this.PriceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceTextBox.ForeColor = System.Drawing.Color.White;
			this.PriceTextBox.HintForeColor = System.Drawing.Color.White;
			this.PriceTextBox.HintText = "";
			this.PriceTextBox.isPassword = false;
			this.PriceTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PriceTextBox.LineIdleColor = System.Drawing.Color.Gray;
			this.PriceTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PriceTextBox.LineThickness = 4;
			this.PriceTextBox.Location = new System.Drawing.Point(985, 92);
			this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.Size = new System.Drawing.Size(222, 52);
			this.PriceTextBox.TabIndex = 132;
			this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// guestIDTxt
			// 
			this.guestIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guestIDTxt.Enabled = false;
			this.guestIDTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guestIDTxt.ForeColor = System.Drawing.Color.White;
			this.guestIDTxt.HintForeColor = System.Drawing.Color.White;
			this.guestIDTxt.HintText = "";
			this.guestIDTxt.isPassword = false;
			this.guestIDTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.guestIDTxt.LineIdleColor = System.Drawing.Color.Gray;
			this.guestIDTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.guestIDTxt.LineThickness = 4;
			this.guestIDTxt.Location = new System.Drawing.Point(163, 81);
			this.guestIDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guestIDTxt.Name = "guestIDTxt";
			this.guestIDTxt.Size = new System.Drawing.Size(204, 52);
			this.guestIDTxt.TabIndex = 126;
			this.guestIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuCustomLabel6
			// 
			this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomLabel6.AutoSize = true;
			this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel6.Location = new System.Drawing.Point(878, 117);
			this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
			this.bunifuCustomLabel6.Size = new System.Drawing.Size(86, 19);
			this.bunifuCustomLabel6.TabIndex = 135;
			this.bunifuCustomLabel6.Text = "Price Room";
			// 
			// employeeIDTextBox
			// 
			this.employeeIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.employeeIDTextBox.Enabled = false;
			this.employeeIDTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeIDTextBox.ForeColor = System.Drawing.Color.White;
			this.employeeIDTextBox.HintForeColor = System.Drawing.Color.White;
			this.employeeIDTextBox.HintText = "";
			this.employeeIDTextBox.isPassword = false;
			this.employeeIDTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.employeeIDTextBox.LineIdleColor = System.Drawing.Color.Gray;
			this.employeeIDTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.employeeIDTextBox.LineThickness = 4;
			this.employeeIDTextBox.Location = new System.Drawing.Point(163, 485);
			this.employeeIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.employeeIDTextBox.Name = "employeeIDTextBox";
			this.employeeIDTextBox.Size = new System.Drawing.Size(204, 52);
			this.employeeIDTextBox.TabIndex = 136;
			this.employeeIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// BillIDLabel
			// 
			this.BillIDLabel.AutoSize = true;
			this.BillIDLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillIDLabel.ForeColor = System.Drawing.Color.White;
			this.BillIDLabel.Location = new System.Drawing.Point(45, 36);
			this.BillIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BillIDLabel.Name = "BillIDLabel";
			this.BillIDLabel.Size = new System.Drawing.Size(0, 19);
			this.BillIDLabel.TabIndex = 140;
			// 
			// ServiceDataGrid
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ServiceDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.ServiceDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ServiceDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.ServiceDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ServiceDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ServiceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ServiceDataGrid.DoubleBuffered = true;
			this.ServiceDataGrid.EnableHeadersVisualStyles = false;
			this.ServiceDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
			this.ServiceDataGrid.HeaderForeColor = System.Drawing.Color.White;
			this.ServiceDataGrid.Location = new System.Drawing.Point(574, 347);
			this.ServiceDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ServiceDataGrid.Name = "ServiceDataGrid";
			this.ServiceDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ServiceDataGrid.RowHeadersWidth = 62;
			this.ServiceDataGrid.RowTemplate.Height = 28;
			this.ServiceDataGrid.Size = new System.Drawing.Size(632, 120);
			this.ServiceDataGrid.TabIndex = 142;
			this.ServiceDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceDataGrid_CellClick);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(453, 347);
			this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 19);
			this.bunifuCustomLabel1.TabIndex = 143;
			this.bunifuCustomLabel1.Text = "Services";
			// 
			// ServiceCBBox
			// 
			this.ServiceCBBox.BackColor = System.Drawing.Color.Transparent;
			this.ServiceCBBox.BorderRadius = 3;
			this.ServiceCBBox.ForeColor = System.Drawing.Color.White;
			this.ServiceCBBox.Items = new string[0];
			this.ServiceCBBox.Location = new System.Drawing.Point(574, 191);
			this.ServiceCBBox.Name = "ServiceCBBox";
			this.ServiceCBBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.ServiceCBBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.ServiceCBBox.selectedIndex = -1;
			this.ServiceCBBox.Size = new System.Drawing.Size(234, 35);
			this.ServiceCBBox.TabIndex = 144;
			this.ServiceCBBox.onItemSelected += new System.EventHandler(this.ServiceCBBox_onItemSelected);
			// 
			// bunifuCustomLabel9
			// 
			this.bunifuCustomLabel9.AutoSize = true;
			this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel9.Location = new System.Drawing.Point(453, 188);
			this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
			this.bunifuCustomLabel9.Size = new System.Drawing.Size(58, 19);
			this.bunifuCustomLabel9.TabIndex = 145;
			this.bunifuCustomLabel9.Text = "Service";
			// 
			// bunifuCustomLabel11
			// 
			this.bunifuCustomLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomLabel11.AutoSize = true;
			this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel11.Location = new System.Drawing.Point(878, 190);
			this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
			this.bunifuCustomLabel11.Size = new System.Drawing.Size(95, 19);
			this.bunifuCustomLabel11.TabIndex = 147;
			this.bunifuCustomLabel11.Text = "Price Service";
			// 
			// PriceServiceTextbox
			// 
			this.PriceServiceTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PriceServiceTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PriceServiceTextbox.Enabled = false;
			this.PriceServiceTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceServiceTextbox.ForeColor = System.Drawing.Color.White;
			this.PriceServiceTextbox.HintForeColor = System.Drawing.Color.White;
			this.PriceServiceTextbox.HintText = "";
			this.PriceServiceTextbox.isPassword = false;
			this.PriceServiceTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PriceServiceTextbox.LineIdleColor = System.Drawing.Color.Gray;
			this.PriceServiceTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PriceServiceTextbox.LineThickness = 4;
			this.PriceServiceTextbox.Location = new System.Drawing.Point(985, 174);
			this.PriceServiceTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PriceServiceTextbox.Name = "PriceServiceTextbox";
			this.PriceServiceTextbox.Size = new System.Drawing.Size(222, 52);
			this.PriceServiceTextbox.TabIndex = 146;
			this.PriceServiceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btnAddService
			// 
			this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.btnAddService.FlatAppearance.BorderSize = 0;
			this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnAddService.ForeColor = System.Drawing.Color.White;
			this.btnAddService.Location = new System.Drawing.Point(456, 434);
			this.btnAddService.Name = "btnAddService";
			this.btnAddService.Size = new System.Drawing.Size(103, 33);
			this.btnAddService.TabIndex = 148;
			this.btnAddService.Text = "Add Service";
			this.btnAddService.UseVisualStyleBackColor = false;
			this.btnAddService.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(878, 275);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 19);
			this.label1.TabIndex = 150;
			this.label1.Text = "Leave Time";
			// 
			// LeaveTimePicker
			// 
			this.LeaveTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LeaveTimePicker.BackColor = System.Drawing.Color.SeaGreen;
			this.LeaveTimePicker.BorderRadius = 0;
			this.LeaveTimePicker.ForeColor = System.Drawing.Color.White;
			this.LeaveTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.LeaveTimePicker.FormatCustom = null;
			this.LeaveTimePicker.Location = new System.Drawing.Point(985, 265);
			this.LeaveTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LeaveTimePicker.Name = "LeaveTimePicker";
			this.LeaveTimePicker.Size = new System.Drawing.Size(222, 41);
			this.LeaveTimePicker.TabIndex = 149;
			this.LeaveTimePicker.Value = new System.DateTime(2023, 11, 3, 0, 0, 0, 0);
			this.LeaveTimePicker.onValueChanged += new System.EventHandler(this.LeaveTimePicker_onValueChanged);
			// 
			// bunifuCustomLabel12
			// 
			this.bunifuCustomLabel12.AutoSize = true;
			this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel12.Location = new System.Drawing.Point(452, 520);
			this.bunifuCustomLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
			this.bunifuCustomLabel12.Size = new System.Drawing.Size(101, 19);
			this.bunifuCustomLabel12.TabIndex = 151;
			this.bunifuCustomLabel12.Text = "Total Money :";
			// 
			// Totallabel
			// 
			this.Totallabel.AutoSize = true;
			this.Totallabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Totallabel.ForeColor = System.Drawing.Color.White;
			this.Totallabel.Location = new System.Drawing.Point(572, 520);
			this.Totallabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Totallabel.Name = "Totallabel";
			this.Totallabel.Size = new System.Drawing.Size(0, 19);
			this.Totallabel.TabIndex = 152;
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PhoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PhoneNumberTextBox.ForeColor = System.Drawing.Color.White;
			this.PhoneNumberTextBox.HintForeColor = System.Drawing.Color.White;
			this.PhoneNumberTextBox.HintText = "";
			this.PhoneNumberTextBox.isPassword = false;
			this.PhoneNumberTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PhoneNumberTextBox.LineIdleColor = System.Drawing.Color.Gray;
			this.PhoneNumberTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.PhoneNumberTextBox.LineThickness = 4;
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(163, 405);
			this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(204, 52);
			this.PhoneNumberTextBox.TabIndex = 155;
			this.PhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// ExportDataBtn
			// 
			this.ExportDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ExportDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(116)))), ((int)(((byte)(74)))));
			this.ExportDataBtn.Enabled = false;
			this.ExportDataBtn.FlatAppearance.BorderSize = 0;
			this.ExportDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExportDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ExportDataBtn.ForeColor = System.Drawing.Color.White;
			this.ExportDataBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
			this.ExportDataBtn.IconColor = System.Drawing.Color.White;
			this.ExportDataBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.ExportDataBtn.IconSize = 28;
			this.ExportDataBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportDataBtn.Location = new System.Drawing.Point(1042, 520);
			this.ExportDataBtn.Name = "ExportDataBtn";
			this.ExportDataBtn.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.ExportDataBtn.Size = new System.Drawing.Size(165, 39);
			this.ExportDataBtn.TabIndex = 154;
			this.ExportDataBtn.Text = "Export";
			this.ExportDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportDataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ExportDataBtn.UseVisualStyleBackColor = false;
			this.ExportDataBtn.Click += new System.EventHandler(this.ExportDataBtn_Click);
			// 
			// closeReservationFormBtn
			// 
			this.closeReservationFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeReservationFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.closeReservationFormBtn.FlatAppearance.BorderSize = 0;
			this.closeReservationFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeReservationFormBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
			this.closeReservationFormBtn.IconColor = System.Drawing.Color.White;
			this.closeReservationFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.closeReservationFormBtn.IconSize = 32;
			this.closeReservationFormBtn.Location = new System.Drawing.Point(1217, 2);
			this.closeReservationFormBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.closeReservationFormBtn.Name = "closeReservationFormBtn";
			this.closeReservationFormBtn.Size = new System.Drawing.Size(42, 37);
			this.closeReservationFormBtn.TabIndex = 58;
			this.closeReservationFormBtn.UseVisualStyleBackColor = false;
			this.closeReservationFormBtn.Click += new System.EventHandler(this.closeReservationFormBtn_Click);
			// 
			// ReservationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			this.ClientSize = new System.Drawing.Size(1258, 749);
			this.Controls.Add(this.PhoneNumberTextBox);
			this.Controls.Add(this.ExportDataBtn);
			this.Controls.Add(this.Totallabel);
			this.Controls.Add(this.bunifuCustomLabel12);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LeaveTimePicker);
			this.Controls.Add(this.btnAddService);
			this.Controls.Add(this.bunifuCustomLabel11);
			this.Controls.Add(this.PriceServiceTextbox);
			this.Controls.Add(this.bunifuCustomLabel9);
			this.Controls.Add(this.ServiceCBBox);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.ServiceDataGrid);
			this.Controls.Add(this.BillIDLabel);
			this.Controls.Add(this.bunifuCustomLabel8);
			this.Controls.Add(this.employeeIDTextBox);
			this.Controls.Add(this.bunifuCustomLabel6);
			this.Controls.Add(this.PriceTextBox);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.bunifuCustomLabel4);
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuCustomLabel10);
			this.Controls.Add(this.guestIDTxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.arriveTimeDatepicker);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.ageTextBox);
			this.Controls.Add(this.bunifuCustomLabel7);
			this.Controls.Add(this.roomNumberCBBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.guestLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.closeReservationFormBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ReservationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ReservationForm";
			this.Load += new System.EventHandler(this.ReservationForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label guestLabel;
        private System.Windows.Forms.Button cancelButton;
        private FontAwesome.Sharp.IconButton closeReservationFormBtn;
        private System.Windows.Forms.Button deleteButton;
        private Bunifu.Framework.UI.BunifuDropdown roomNumberCBBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ageTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextBox;
        private Bunifu.Framework.UI.BunifuDatepicker arriveTimeDatepicker;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox guestIDTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox employeeIDTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel BillIDLabel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ServiceDataGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown ServiceCBBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceServiceTextbox;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker LeaveTimePicker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel Totallabel;
        private FontAwesome.Sharp.IconButton ExportDataBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneNumberTextBox;
    }
}