using HotelManager.pages;
using HotelManager.utils;
using System;
using System.Windows.Forms;

namespace HotelManager.components
{
    public partial class GuestForm : Form
    {
        private string currentState;
        private string guestID, name, age, address, phoneNumber;

        public GuestForm()
        {
            currentState = "ADD";
            InitializeComponent();
        }

 
        public GuestForm(string guestID, string name, string age, string address, string phoneNumber)
        {
            currentState = "UPDATE";
            this.guestID = guestID;
            this.name = name;
            this.age = age;
            this.address = address;
            this.phoneNumber = phoneNumber;

            InitializeComponent();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            guestLabel.Text = currentState;
            if (currentState == "UPDATE")
            {
                guestFormButton.Text = "Update";

                guestIDTextBox.Text = guestID;
                nameTextBox.Text = name;
                ageTextBox.Text = age;
                addressTextBox.Text = address;
                phoneNumberTextBox.Text = phoneNumber;
            }
            else if(currentState == "ADD")
            {
                guestFormButton.Text = "Add";

            }
        }

        private void guestFormButton_Click(object sender, EventArgs e)
        {
            DBQuery db = new DBQuery();
            try
            {
                if (currentState == "ADD")
                {

                    db.MutateData("INSERT INTO KHACHHANG(MAKH, HOTEN, TUOI, DIACHI, SDT) VALUES('"
                    + guestIDTextBox.Text + "', N'"
                    + nameTextBox.Text + "','"
                    + ageTextBox.Text + "', N'"
                    + addressTextBox.Text + "','"
                    + phoneNumberTextBox.Text + "')");

                        (new CustomMessageBox("Xác nhận", "Thêm khách hàng thành công")).ShowDialog();

                }
                else if (currentState == "UPDATE")
                {
                    db.MutateData("UPDATE KHACHHANG SET " +
                    "MAKH = '" + guestIDTextBox.Text + "', " +
                    "HOTEN = N'" + nameTextBox.Text + "', " +
                    "TUOI = " + ageTextBox.Text + ", " +
                    "DIACHI = N'" + addressTextBox.Text + "', " +
                    "SDT = '" + phoneNumberTextBox.Text + "' " +
                    "WHERE MAKH = '" + Guest.gID + "'");


                    if (guestCheckoutCheckBox.Enabled)
                    {
                        db.MutateData("UPDATE HOADON SET NGAYDI = GETDATE() WHERE MAKH = '" + Guest.gID + "'");
                    }
                   
                    (new CustomMessageBox("Xác nhận", "Cập nhật khách hàng thành công")).ShowDialog();
                    this.Close();

                }
            }
            catch(Exception ex)
            {
                (new CustomMessageBox("Xác nhận", "Có lỗi xảy ra. Hãy thử lại!")).ShowDialog();  
            }
        }

     
        private void closeGuestFormBtn_Click(object sender, EventArgs e)
        {
            CustomMessageBox c = new CustomMessageBox("Xác nhận", "Bạn có chắc chắn muốn thoát không?", "Yes", "No");

            c.YesClicked += (s, args) =>
            {
                this.Close();
            };

            c.NoClicked += (s, args) =>
            {
                return;
            };

            c.ShowDialog();
        }

        private void deleteGuestButton_Click(object sender, EventArgs e)
        {
            DBQuery db = new DBQuery();
            try
            {
                db.MutateData("DELETE FROM KHACHHANG WHERE MAKH = '" + Guest.gID + "'");
                (new CustomMessageBox("Xác nhận", "Xóa khách hàng thành công")).ShowDialog();

            }
            catch (Exception ex)
            {
                (new CustomMessageBox("Xác nhận","Database disconnection!")).ShowDialog();
                throw ex;
            }
        }



    }
}
