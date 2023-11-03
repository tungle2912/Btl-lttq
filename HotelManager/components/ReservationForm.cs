using Bunifu.Framework.UI;
using HotelManager.pages;
using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace HotelManager.components
{
    public partial class ReservationForm : Form
    {
        private string currentState;

        private string billID, guestID, name, address, phoneNumber,employeeid,totalmoney;
        private int age, roomNumber;
        DateTime arriveTime,leaveTime;
        DBQuery db=new DBQuery();
        public event EventHandler DataAdded;
        private float total=0,priceroom=0,priceservice=0;
        private void OnDataAdded()
        {
            DataAdded?.Invoke(this, EventArgs.Empty);
        }

        private void roomNumberTextBox_onItemSelected(object sender, EventArgs e)
        {
            string price = db.RenderID("SELECT dbo.price('"+roomNumberCBBox.selectedValue.ToString()+"')");
            PriceTextBox.Text= price;
            priceroom =float.Parse(price);
        }

        private void ServiceCBBox_onItemSelected(object sender, EventArgs e)
        {
            string price = db.RenderID("SELECT dbo.priceService(N'" + ServiceCBBox.selectedValue.ToString() + "')");
            PriceServiceTextbox.Text = price;
            priceservice += float.Parse(price);
        }

        private void LeaveTimePicker_onValueChanged(object sender, EventArgs e)
        {   
         /*   if(LeaveTimePicker.Value> arriveTimeDatepicker.Value)
            {
                totalmoney = totalmoney+ (priceroom * (float)(LeaveTimePicker.Value - arriveTimeDatepicker.Value).TotalDays);
                Totallabel.Text=totalmoney.ToString();
            }*/
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ServiceCBBox.selectedIndex < 0)
            {
                CustomMessageBox a=new CustomMessageBox("Error", "Hãy nhập thông tin dịch vụ");
                a.ShowDialog();
                return;
            }
            DataTable x= db.GetData("SELECT * FROM CHITIETHOADON WHERE MAHD=N'" + BillIDLabel.Text + "' AND MADV=dbo.RenderMaDV(N'"+ServiceCBBox.selectedValue.ToString()+"')");
            if (x.Rows.Count ==0)
            {
                db.MutateData("INSERT INTO CHITIETHOADON (MACTHD, MAHD, MADV, SOPHONG,GIAPHONG, GIADV) VALUES( dbo.CreateMaCTHD(),'" + BillIDLabel.Text + "',dbo.RenderMaDV(N'" + ServiceCBBox.selectedValue.ToString() + "'),'" + roomNumberCBBox.selectedValue.ToString() + "','" + PriceTextBox.Text + "','" + PriceServiceTextbox.Text + "')");
                updadedatagrid();
            }
            else
            {
                CustomMessageBox a = new CustomMessageBox("Error", "Dịch vụ này đã nhập rồi");
                a.ShowDialog();
                return;
            }

        }
        public ReservationForm()
        {
            currentState = "ADD";
            InitializeComponent();
        }

        private void ServiceDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* btnAddService.Text = "Remove Service";
            string madv = ServiceDataGrid.CurrentRow.Cells[0].Value.ToString();
            db.MutateData("delete CHITIETHOADON WHERE MADV='" + madv + "'");
            updadedatagrid();*/
        }

        public ReservationForm(string billID,string guestID)
        {
            currentState = "ADD";
            this.guestID = guestID;
            this.billID = billID;
            InitializeComponent();
        }
        public ReservationForm(string billID, string guestID, string name, int age, string address, string phoneNumber, int roomNumber, DateTime arriveTime,DateTime leavetime,string employeeid,string totalmoney)
        {
            currentState = "UPDATE";
            this.billID = billID;
            this.guestID = guestID;
            this.name = name;
            this.age = age;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.roomNumber = roomNumber;
            this.arriveTime = arriveTime;
            this.leaveTime = leavetime;
            this.employeeid = employeeid;
            this.totalmoney = totalmoney;
            InitializeComponent();
        }
        private void ValidateNumber(object sender, EventArgs e)
        {
            BunifuMaterialTextbox t = (BunifuMaterialTextbox)sender;
            if (!int.TryParse(t.Text, out int result))
            {
                CustomMessageBox a = new CustomMessageBox("Error", "hãy nhập số nguyên ");
                t.Focus();
            }
        }
        private void updadedatagrid()
        {
            ServiceDataGrid.DataSource = db.GetData("SELECT MADV,TENDV,GIA FROM ServiceView WHERE MAHD = N'" + billID + "'");
            ServiceDataGrid.Columns[0].Width = 200;
            ServiceDataGrid.Columns[1].Width = 480;
            ServiceDataGrid.Columns[2].Width = 200;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
         
            updadedatagrid();
            DataTable dt = db.GetData("select SOPHONG FROM PHONG");
            foreach (DataRow row in dt.Rows)
             {
                    string roomNumber = row["SOPHONG"].ToString();
                    roomNumberCBBox.AddItem(roomNumber);
            }
            DataTable t = db.GetData("select TENDV FROM DICHVU");
            foreach (DataRow row in t.Rows)
            {
                string Service = row["TENDV"].ToString();
                ServiceCBBox.AddItem(Service);
            }
            if (currentState == "UPDATE")
            {
                updadedatagrid();
                guestLabel.Text = "UPDATE BILL";
                BillIDLabel.Text = billID;
                guestIDTxt.Text = guestID;
                nameTextBox.Text = name;
                ageTextBox.Text = age.ToString();
                addressTextBox.Text = address;
                phoneNumberTextBox.Text = phoneNumber; 
                arriveTimeDatepicker.Value = arriveTime;
                if (leaveTime != DateTime.Now)
                {
                LeaveTimePicker.Value = leaveTime;
                } 
                AddButton.Text = "UPDATE";
                roomNumberCBBox.Visible = false;
                RoomNumberTextbox.Visible = true;
                RoomNumberTextbox.Text = roomNumber.ToString();
                PriceTextBox.Text = db.RenderID("select dbo.price('"+ roomNumber.ToString() + "')");
                Totallabel.Text = db.RenderID("select TONGHD from HOADON WHERE MAHD='"+BillIDLabel.Text+"'");
            }
            else if(currentState == "ADD"){
                AddButton.Text = "ADD BILL";
                BillIDLabel.Text = billID;
                guestIDTxt.Text = guestID;
                btnAddService.Enabled = false;
                employeeid = Login.MaNV;
            
            }
          //   employeeIDTextBox.Text = db.RenderID("select HOTEN FROM NHANVIEN WHERE MANV='"+employeeid+"'") ;    
        }

        private void closeReservationFormBtn_Click(object sender, EventArgs e)
        {
            /*   CustomMessageBox c = new CustomMessageBox("Xác nhận","Bạn có chắc chắn muốn thoát chương trình","Yes","No");
               c.YesClicked += (s, args) =>
               {
                   this.Close();
               };

               c.YesClicked += (s, args) =>
               {
                   return;  
               };
               c.ShowDialog();*/
            this.Close();
        }
      /*  private void dataAdded()
        {
            DataAdded?.Invoke(this, EventArgs.Empty);
        }*/
        private void guestFormButton_Click(object sender, EventArgs e)
        {
            string guestID = guestIDTxt.Text;
            string name = nameTextBox.Text;
            string age = ageTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string roomNumber = roomNumberCBBox.Text;
            string employeeID = employeeIDTextBox.Text;
            if (nameTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Tên Khách Hàng");
                c.ShowDialog();
                nameTextBox.Focus();
                return;
            }
            if (ageTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Tuổi Khách Hàng");
                c.ShowDialog();
                ageTextBox.Focus();
                return;
            }
            if (addressTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Địa chỉ Khách Hàng");
                c.ShowDialog();
                addressTextBox.Focus();
                return;
            }
            if (phoneNumberTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập SĐT Khách Hàng");
                c.ShowDialog();
                phoneNumberTextBox.Focus();
                return;
            }
            if (roomNumberCBBox.selectedIndex<0)
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập số phòng");
                c.ShowDialog();
                roomNumberCBBox.Focus();
                return;
            }
            string arriveTime = arriveTimeDatepicker.Value.ToString("yyyy-MM-dd");
            DataTable x = db.GetData("SELECT * FROM KHACHHANG WHERE SDT='" + phoneNumberTextBox.Text + "'");
            if(x.Rows.Count == 0)
            {
            db.MutateData("INSERT INTO KHACHHANG VALUES(N'"+guestIDTxt.Text+"', N'"+addressTextBox.Text+"', N'"+ageTextBox.Text+"', N'"+ nameTextBox.Text+ "', '"+ phoneNumberTextBox.Text + "')");
            }
            else
            {   
                guestIDTxt.Text=db.RenderID("SELECT MAKH FROM KHACHHANG  WHERE SDT='" + phoneNumberTextBox.Text + "'");
            }
            db.MutateData("INSERT INTO HOADON (MAHD, NGAYDEN, MANV, MAKH) VALUES(N'" + BillIDLabel.Text+"',N'"+arriveTime+"',N'"+Login.MaNV+"',N'"+guestIDTxt.Text+"')");
            db.MutateData("INSERT INTO CHITIETHOADON (MACTHD, MAHD, MADV, SOPHONG,GIAPHONG, GIADV) VALUES( dbo.CreateMaCTHD(),'" + BillIDLabel.Text + "',dbo.RenderMaDV(N'" + ServiceCBBox.selectedValue.ToString() + "'),'"+roomNumberCBBox.selectedValue.ToString()+"','"+PriceTextBox.Text+"','"+PriceServiceTextbox.Text+"')");
            updadedatagrid();
            totalmoney += float.Parse(PriceServiceTextbox.Text);
            Totallabel.Text = totalmoney.ToString();

            btnAddService.Enabled = true;
        }


    }
}
