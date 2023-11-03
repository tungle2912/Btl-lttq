using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.components
{
    public partial class ReservationCheckOut : Form
    {
        private string billID,guestID, name, address, phoneNumber;
        private int roomNumber;

        public ReservationCheckOut(string billID,string guestID, string name, int age, string address, string phoneNumber, int roomNumber, DateTime arriveTime)
        {
            this.billID=billID;
            this.guestID = guestID;
            this.name = name;
            this.age = age;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.roomNumber = roomNumber;
            this.arriveTime = arriveTime;           
            InitializeComponent();
        }

        DBQuery db =new DBQuery();
        private void closeReservationFormBtn_Click(object sender, EventArgs e)
        {
            CustomMessageBox c = new CustomMessageBox("Xác nhận", "Bạn có chắc chắn muốn thoát chương trình", "Yes", "No");
            c.YesClicked += (s, args) =>
            {
                this.Close();
            };

            c.YesClicked += (s, args) =>
            {
                return;
            };
            c.ShowDialog();
        }

        private void ageTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }
    

        private void leaveTimeDatepicker_onValueChanged(object sender, EventArgs e)
        {
            string d =  leaveTimeDatepicker.Value.ToString("yyyy-MM-dd");
            db.MutateData("update HOADON set NGAYDI='" + d + "' where MAHD=N'"+ billID+"'");
            TotalMoneyTextBox.Text = db.RenderID("select TONGHD from HOADON where MAHD=N'" + billID + "'");
        }

        private int age;
        DateTime arriveTime;

        public ReservationCheckOut()
        {       
            InitializeComponent();
        }
        private void ReservationCheckOut_Load(object sender, EventArgs e)
        {
           
            guestIDTxt.Text = guestID;
            nameTextBox.Text = name;
            ageTextBox.Text = age.ToString();
            addressTextBox.Text = address;
            phoneNumberTextBox.Text = phoneNumber;
            RoomNumberTxt.Text = roomNumber.ToString();
            arriveTimeTextBox.Text = arriveTime.ToString();
            employeeIDTextBox.Text = Login.MaNV;
        }
    }
}
