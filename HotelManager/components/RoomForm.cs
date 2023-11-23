using HotelManager.pages;
using HotelManager.utils;
using System;
using System.Data;
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
                roomNumberTextBox.Enabled = false;
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
                CustomMessageBox c = new CustomMessageBox("Xác nhận", $"Xoá phòng {Rooms.rNum} thành công");
                c.ShowDialog();
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


			if (int.TryParse(roomNumberTextBox.Text, out int roomNumber) && int.TryParse(roomPriceTextBox.Text, out int roomPrice))
			{
				int status = roomStatusDropDown.selectedIndex == 0 ? 0 : 1;
				DataTable dt = new DataTable();
				dt = db.GetData("SELECT * FROM PHONG WHERE SOPHONG = " + roomNumber + "");

				try
				{
					if (currentState == "ADD")
					{

						if (dt.Rows.Count == 0)
						{
							db.MutateData("INSERT INTO PHONG VALUES("
						   + roomNumber + ", '"
						   + roomTypeDropdown.selectedValue + "', '"
						   + status + "',"
						   + roomPrice + ", '" + roomFloorDropDown.selectedValue + "')");
							(new CustomMessageBox("Xác nhận", "Thêm phòng thành công")).ShowDialog();
						}
						else
						{
							(new CustomMessageBox("Xác nhận", "Phòng đã tồn tại")).ShowDialog();
						}
					}
					else
					{

						if (dt.Rows.Count <= 1)
						{
							db.MutateData("UPDATE PHONG SET " +
							"TANG = '" + roomFloorDropDown.selectedValue + "'," +
							"LOAIPHONG = '" + roomTypeDropdown.selectedValue + "'," +
							"TINHTRANG = '" + status + "'," +
							"GIAPHONG = '" + roomPriceTextBox.Text + "'" +
							$"WHERE SOPHONG = {Rooms.rNum}");
							(new CustomMessageBox("Xác nhận", "Cập nhật phòng thành công")).ShowDialog();
							this.Close();
						}
						else
						{
							(new CustomMessageBox("Xác nhận", "Phòng đã tồn tại")).ShowDialog();
						}
					}
				}
				catch (Exception ex)
				{
					(new CustomMessageBox("Xác nhận", "Có lỗi xảy ra. Hãy thử lại!")).ShowDialog();
					throw ex;
				}
			}
			else
			{
				(new CustomMessageBox("Xác nhận", "Số phòng và giá phòng phải là số!")).ShowDialog();
			}
		}


        // CLEAR FORM 

        public void ClearFormInput()
        {

        }
    }
}
