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
            this.cancelGuestButton = new System.Windows.Forms.Button();
            this.deleteGuestButton = new System.Windows.Forms.Button();
            this.closeReservationFormBtn = new FontAwesome.Sharp.IconButton();
            this.roomNumberCBBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ageTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addressTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneNumberTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.RoomNumberTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.AddButton.Location = new System.Drawing.Point(696, 849);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(248, 62);
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
            this.guestLabel.Location = new System.Drawing.Point(844, 48);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(120, 32);
            this.guestLabel.TabIndex = 63;
            this.guestLabel.Text = "ADD Bill";
            this.guestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelGuestButton
            // 
            this.cancelGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.cancelGuestButton.FlatAppearance.BorderSize = 0;
            this.cancelGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelGuestButton.ForeColor = System.Drawing.Color.White;
            this.cancelGuestButton.Location = new System.Drawing.Point(967, 849);
            this.cancelGuestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelGuestButton.Name = "cancelGuestButton";
            this.cancelGuestButton.Size = new System.Drawing.Size(248, 62);
            this.cancelGuestButton.TabIndex = 59;
            this.cancelGuestButton.Text = "Cancel";
            this.cancelGuestButton.UseVisualStyleBackColor = false;
            // 
            // deleteGuestButton
            // 
            this.deleteGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.deleteGuestButton.FlatAppearance.BorderSize = 0;
            this.deleteGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteGuestButton.ForeColor = System.Drawing.Color.White;
            this.deleteGuestButton.Location = new System.Drawing.Point(696, 945);
            this.deleteGuestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteGuestButton.Name = "deleteGuestButton";
            this.deleteGuestButton.Size = new System.Drawing.Size(519, 62);
            this.deleteGuestButton.TabIndex = 73;
            this.deleteGuestButton.Text = "Delete";
            this.deleteGuestButton.UseVisualStyleBackColor = false;
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
            this.closeReservationFormBtn.Location = new System.Drawing.Point(1862, 2);
            this.closeReservationFormBtn.Name = "closeReservationFormBtn";
            this.closeReservationFormBtn.Size = new System.Drawing.Size(63, 57);
            this.closeReservationFormBtn.TabIndex = 58;
            this.closeReservationFormBtn.UseVisualStyleBackColor = false;
            this.closeReservationFormBtn.Click += new System.EventHandler(this.closeReservationFormBtn_Click);
            // 
            // roomNumberCBBox
            // 
            this.roomNumberCBBox.BackColor = System.Drawing.Color.Transparent;
            this.roomNumberCBBox.BorderRadius = 3;
            this.roomNumberCBBox.ForeColor = System.Drawing.Color.White;
            this.roomNumberCBBox.Items = new string[0];
            this.roomNumberCBBox.Location = new System.Drawing.Point(820, 151);
            this.roomNumberCBBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomNumberCBBox.Name = "roomNumberCBBox";
            this.roomNumberCBBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.roomNumberCBBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.roomNumberCBBox.selectedIndex = -1;
            this.roomNumberCBBox.Size = new System.Drawing.Size(328, 54);
            this.roomNumberCBBox.TabIndex = 74;
            this.roomNumberCBBox.onItemSelected += new System.EventHandler(this.roomNumberTextBox_onItemSelected);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(638, 160);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(152, 23);
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
            this.ageTextBox.Location = new System.Drawing.Point(244, 374);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(306, 80);
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
            this.addressTextBox.Location = new System.Drawing.Point(244, 502);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(306, 80);
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
            this.nameTextBox.Location = new System.Drawing.Point(244, 251);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(306, 80);
            this.nameTextBox.TabIndex = 122;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.HintForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.HintText = "";
            this.phoneNumberTextBox.isPassword = false;
            this.phoneNumberTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.phoneNumberTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneNumberTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.phoneNumberTextBox.LineThickness = 4;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(244, 622);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(306, 80);
            this.phoneNumberTextBox.TabIndex = 123;
            this.phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneNumberTextBox.OnValueChanged += new System.EventHandler(this.ValidateNumber);
            // 
            // arriveTimeDatepicker
            // 
            this.arriveTimeDatepicker.BackColor = System.Drawing.Color.SeaGreen;
            this.arriveTimeDatepicker.BorderRadius = 0;
            this.arriveTimeDatepicker.ForeColor = System.Drawing.Color.White;
            this.arriveTimeDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.arriveTimeDatepicker.FormatCustom = null;
            this.arriveTimeDatepicker.Location = new System.Drawing.Point(820, 391);
            this.arriveTimeDatepicker.Margin = new System.Windows.Forms.Padding(6);
            this.arriveTimeDatepicker.Name = "arriveTimeDatepicker";
            this.arriveTimeDatepicker.Size = new System.Drawing.Size(328, 63);
            this.arriveTimeDatepicker.TabIndex = 124;
            this.arriveTimeDatepicker.Value = new System.DateTime(2023, 10, 14, 14, 34, 33, 79);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(638, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 125;
            this.label2.Text = "Arrive Time";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(78, 770);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(109, 23);
            this.bunifuCustomLabel8.TabIndex = 139;
            this.bunifuCustomLabel8.Text = "Employee";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(67, 160);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(87, 23);
            this.bunifuCustomLabel10.TabIndex = 127;
            this.bunifuCustomLabel10.Text = "GuestID";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(67, 272);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 23);
            this.bunifuCustomLabel2.TabIndex = 128;
            this.bunifuCustomLabel2.Text = "Name";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(67, 402);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(51, 23);
            this.bunifuCustomLabel3.TabIndex = 129;
            this.bunifuCustomLabel3.Text = "Age";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(67, 517);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 23);
            this.bunifuCustomLabel4.TabIndex = 130;
            this.bunifuCustomLabel4.Text = "Address";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(67, 650);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(157, 23);
            this.bunifuCustomLabel5.TabIndex = 131;
            this.bunifuCustomLabel5.Text = "Phone Number";
            // 
            // PriceTextBox
            // 
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
            this.PriceTextBox.Location = new System.Drawing.Point(1440, 125);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(328, 80);
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
            this.guestIDTxt.Location = new System.Drawing.Point(244, 125);
            this.guestIDTxt.Margin = new System.Windows.Forms.Padding(6);
            this.guestIDTxt.Name = "guestIDTxt";
            this.guestIDTxt.Size = new System.Drawing.Size(306, 80);
            this.guestIDTxt.TabIndex = 126;
            this.guestIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(1295, 160);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(120, 23);
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
            this.employeeIDTextBox.Location = new System.Drawing.Point(244, 746);
            this.employeeIDTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(306, 80);
            this.employeeIDTextBox.TabIndex = 136;
            this.employeeIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BillIDLabel
            // 
            this.BillIDLabel.AutoSize = true;
            this.BillIDLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIDLabel.ForeColor = System.Drawing.Color.White;
            this.BillIDLabel.Location = new System.Drawing.Point(68, 55);
            this.BillIDLabel.Name = "BillIDLabel";
            this.BillIDLabel.Size = new System.Drawing.Size(0, 23);
            this.BillIDLabel.TabIndex = 140;
            // 
            // ServiceDataGrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ServiceDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.ServiceDataGrid.Location = new System.Drawing.Point(820, 517);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            this.ServiceDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServiceDataGrid.RowHeadersWidth = 62;
            this.ServiceDataGrid.RowTemplate.Height = 28;
            this.ServiceDataGrid.Size = new System.Drawing.Size(948, 185);
            this.ServiceDataGrid.TabIndex = 142;
            this.ServiceDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceDataGrid_CellClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(638, 517);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(145, 23);
            this.bunifuCustomLabel1.TabIndex = 143;
            this.bunifuCustomLabel1.Text = "Service panel";
            // 
            // ServiceCBBox
            // 
            this.ServiceCBBox.BackColor = System.Drawing.Color.Transparent;
            this.ServiceCBBox.BorderRadius = 3;
            this.ServiceCBBox.ForeColor = System.Drawing.Color.White;
            this.ServiceCBBox.Items = new string[0];
            this.ServiceCBBox.Location = new System.Drawing.Point(820, 277);
            this.ServiceCBBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServiceCBBox.Name = "ServiceCBBox";
            this.ServiceCBBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ServiceCBBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ServiceCBBox.selectedIndex = -1;
            this.ServiceCBBox.Size = new System.Drawing.Size(328, 54);
            this.ServiceCBBox.TabIndex = 144;
            this.ServiceCBBox.onItemSelected += new System.EventHandler(this.ServiceCBBox_onItemSelected);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(638, 272);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(81, 23);
            this.bunifuCustomLabel9.TabIndex = 145;
            this.bunifuCustomLabel9.Text = "Service";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(1295, 272);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(134, 23);
            this.bunifuCustomLabel11.TabIndex = 147;
            this.bunifuCustomLabel11.Text = "Price Service";
            // 
            // PriceServiceTextbox
            // 
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
            this.PriceServiceTextbox.Location = new System.Drawing.Point(1440, 251);
            this.PriceServiceTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.PriceServiceTextbox.Name = "PriceServiceTextbox";
            this.PriceServiceTextbox.Size = new System.Drawing.Size(328, 80);
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
            this.btnAddService.Location = new System.Drawing.Point(642, 622);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(154, 51);
            this.btnAddService.TabIndex = 148;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1286, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 150;
            this.label1.Text = "Leave Time";
            // 
            // LeaveTimePicker
            // 
            this.LeaveTimePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.LeaveTimePicker.BorderRadius = 0;
            this.LeaveTimePicker.ForeColor = System.Drawing.Color.White;
            this.LeaveTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.LeaveTimePicker.FormatCustom = null;
            this.LeaveTimePicker.Location = new System.Drawing.Point(1440, 391);
            this.LeaveTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.LeaveTimePicker.Name = "LeaveTimePicker";
            this.LeaveTimePicker.Size = new System.Drawing.Size(328, 63);
            this.LeaveTimePicker.TabIndex = 149;
            this.LeaveTimePicker.Value = new System.DateTime(2023, 10, 14, 14, 34, 33, 79);
            this.LeaveTimePicker.onValueChanged += new System.EventHandler(this.LeaveTimePicker_onValueChanged);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(638, 770);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(140, 23);
            this.bunifuCustomLabel12.TabIndex = 151;
            this.bunifuCustomLabel12.Text = "Total Money :";
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.ForeColor = System.Drawing.Color.White;
            this.Totallabel.Location = new System.Drawing.Point(816, 770);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(0, 23);
            this.Totallabel.TabIndex = 152;
            // 
            // RoomNumberTextbox
            // 
            this.RoomNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNumberTextbox.Enabled = false;
            this.RoomNumberTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberTextbox.ForeColor = System.Drawing.Color.White;
            this.RoomNumberTextbox.HintForeColor = System.Drawing.Color.White;
            this.RoomNumberTextbox.HintText = "";
            this.RoomNumberTextbox.isPassword = false;
            this.RoomNumberTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.RoomNumberTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.RoomNumberTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
            this.RoomNumberTextbox.LineThickness = 4;
            this.RoomNumberTextbox.Location = new System.Drawing.Point(820, 135);
            this.RoomNumberTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.RoomNumberTextbox.Name = "RoomNumberTextbox";
            this.RoomNumberTextbox.Size = new System.Drawing.Size(328, 70);
            this.RoomNumberTextbox.TabIndex = 153;
            this.RoomNumberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RoomNumberTextbox.Visible = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1924, 1073);
            this.Controls.Add(this.RoomNumberTextbox);
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
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.roomNumberCBBox);
            this.Controls.Add(this.deleteGuestButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.cancelGuestButton);
            this.Controls.Add(this.closeReservationFormBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label guestLabel;
        private System.Windows.Forms.Button cancelGuestButton;
        private FontAwesome.Sharp.IconButton closeReservationFormBtn;
        private System.Windows.Forms.Button deleteGuestButton;
        private Bunifu.Framework.UI.BunifuDropdown roomNumberCBBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ageTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneNumberTextBox;
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox RoomNumberTextbox;
    }
}