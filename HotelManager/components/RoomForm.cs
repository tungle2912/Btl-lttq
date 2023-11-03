using HotelManager.pages;
using HotelManager.utils;
using System;
using System.Windows.Forms;

namespace HotelManager.components
{
    public partial class RoomForm : Form
    {
        private string currentState;

        private string roomNumber, roomPrice;
        private int roomType, roomFloor, roomStatus;
    
        public RoomForm()
        {
            currentState = "ADD";
            InitializeComponent();
        }

        public RoomForm(string roomNumber, int roomFloor, int roomType, int roomStatus, string roomPrice)
        {
            currentState = "UPDATE";
            this.roomNumber = roomNumber;
            this.roomFloor = roomFloor - 1;
            this.roomType = roomType;
            this.roomStatus = roomStatus;
            this.roomPrice = roomPrice;
            
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

            roomFormLabel.Text = currentState;

            if (currentState == "UPDATE")
            {
                roomFormButton.Text = "Update";
                roomNumberTextBox.Text = roomNumber;
                roomTypeDropdown.selectedIndex = roomType;
                roomStatusDropDown.selectedIndex = roomStatus;
                roomPriceTextBox.Text = roomPrice;
                roomFloorDropDown.selectedIndex = roomFloor;
            }
            else
            {
                // ADD ROOM
                roomFormButton.Text = "Add";
            }
            
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            DBQuery db = new DBQuery();
            
            try
            {
                db.MutateData("DELETE PHONG WHERE SOPHONG = '" + Rooms.rNum + "'");
                CustomMessageBox c = new CustomMessageBox("Xác nhận", "Xoá phòng thành công");
            }
            catch (Exception ex) {
                CustomMessageBox c = new CustomMessageBox("Xác nhận", $"Phòng {Rooms.rNum} hiện đang có khách thuê. Không thể xoá");
                c.ShowDialog();
            }
        }

        private void closeRoomFormBtn_Click(object sender, EventArgs e)
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

   

        private void roomFormButton_Click(object sender, EventArgs e)
        {
            DBQuery db = new DBQuery();
            if (true)
            {
                int status = roomStatusDropDown.selectedIndex == 0 ? 0 : 1;
                try
                {
                  if(currentState == "ADD")
                    {
                        db.MutateData("INSERT INTO PHONG VALUES('"
                            + roomNumberTextBox.Text + "', '"
                            + roomTypeDropdown.selectedValue + "', '"
                            + status + "','"
                            + roomPriceTextBox.Text + "', '" + roomFloorDropDown.selectedValue + "')");
                            (new CustomMessageBox("Xác nhận", "Thêm phòng thành công")).ShowDialog();
                    }
                    else
                    {
                        db.MutateData("UPDATE PHONG SET " +
                            "SOPHONG = '" + roomNumberTextBox.Text + "'," +
                            "TANG = '"+ roomFloorDropDown.selectedValue + "'," +
                            "LOAIPHONG = '" + roomTypeDropdown.selectedValue + "'," +
                            "TINHTRANG = '" + status + "'," +
                            "GIAPHONG = '" + roomPriceTextBox.Text + "'" +
                            $"WHERE SOPHONG = {Rooms.rNum}");
                            (new CustomMessageBox("Xác nhận", "Cập nhật phòng thành công")).ShowDialog();
                            this.Close();
                    }
                }
                catch (Exception ex)
                {
                    (new CustomMessageBox("Xác nhận", "Có lỗi xảy ra. Hãy thử lại!")).ShowDialog();
                    throw ex;
                }
                
            }
        }


        // CLEAR FORM 

        public void ClearFormInput()
        {

        }
    }
}
