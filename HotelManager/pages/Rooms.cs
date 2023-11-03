using Bunifu.Framework.UI;
using HotelManager.components;
using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManager.pages
{
    public partial class Rooms : Form
    {
        public static string rNum;

        private string activeFilterTab = "ALL";
        private string selectAllCommand = "SELECT SOPHONG AS 'Room Number', TANG AS Floor, LOAIPHONG AS Type, IIF(TINHTRANG=1,N'Đã Thuê',N'Trống') AS Status, GIAPHONG AS Price FROM PHONG";

        public Rooms()
        {
            InitializeComponent();
        }


        private void Rooms_Load(object sender, EventArgs e)
        {
            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            // Fill data in DataGridView
            dt = db.GetData(selectAllCommand);
            roomDataGridView.DataSource = dt;

            // By default, allRoomButton is active
            allRoomButton.IdleFillColor = Color.SeaGreen;
            allRoomButton.IdleForecolor = Color.White;

            // Count inoccupied rooms
            dt1 = db.GetData($"{selectAllCommand} WHERE TINHTRANG = 0");
            allRoomButton.ButtonText = $"All room({dt.Rows.Count})";
            availableRoomButton.ButtonText = $"Available room({dt1.Rows.Count})";
            bookedRoomButton.ButtonText = $"Booked({dt.Rows.Count - dt1.Rows.Count})";
        }   


        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            (new RoomForm()).ShowDialog();
        }

        // ALL ROOM
        private void allRoomButton_Click(object sender, EventArgs e)
        {
            // CLEAR SEARCH BOX
            roomSearchTextBox.Text = "";

            // SET ACTIVE FILTER TAB
            activeFilterTab = "ALL";

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            // Fill data in DataGridView
            dt = db.GetData(selectAllCommand);
            // Active allRoomButton when click 
            ActiveFilterRoomButton(sender);
            roomDataGridView.DataSource = dt;
        }


        // AVAILABLE ROOM
        private void availableRoomButton_Click(object sender, EventArgs e)
        {
            // CLEAR SEARCH BOX
            roomSearchTextBox.Text = "";

            // SET ACTIVE FILTER TAB
            activeFilterTab = "AVAILABLE";

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            // Fill data in DataGridView
            dt = db.GetData($"{selectAllCommand} WHERE TINHTRANG = 0");
            ActiveFilterRoomButton(sender);
            roomDataGridView.DataSource = dt;
        }

        // BOOKED ROOM
        private void bookedRoomButton_Click(object sender, EventArgs e)
        {
            // CLEAR SEARCH BOX
            roomSearchTextBox.Text = "";

            // SET ACTIVE FILTER TAB
            activeFilterTab = "BOOKED";

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            // Fill data in DataGridView
            dt = db.GetData($"{selectAllCommand} WHERE TINHTRANG = 1");
            ActiveFilterRoomButton(sender);
            roomDataGridView.DataSource = dt;
        }

       
        private void roomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rNum = roomDataGridView.CurrentRow.Cells[0].Value.ToString();
            List<KeyValuePair<int, string>> roomTypeList = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(0, "Single"),
                new KeyValuePair<int, string>(1, "Double"),
                new KeyValuePair<int, string>(2, "Triple"),
                new KeyValuePair<int, string>(3, "VIP"),
            };

            string roomNumber = roomDataGridView.CurrentRow.Cells[0].Value.ToString();
            int roomFloor = int.Parse(roomDataGridView.CurrentRow.Cells[1].Value.ToString());

            int roomType = -1;
            foreach(KeyValuePair<int, string> type in roomTypeList)
            {
                if (type.Value == roomDataGridView.CurrentRow.Cells[2].Value.ToString())
                {
                    roomType = type.Key;
                }
            }
            
            int roomStatus = roomDataGridView.CurrentRow.Cells[3].Value.ToString() == "Trống" ? 0 : 1;
            string roomPrice = roomDataGridView.CurrentRow.Cells[4].Value.ToString();

            (new RoomForm(roomNumber, roomFloor, roomType, roomStatus, roomPrice)).ShowDialog();
        }
        
        private void ActiveFilterRoomButton(object sender)
        {
            List<BunifuThinButton2> buttonList = new List<BunifuThinButton2>()
            {
                allRoomButton,
                availableRoomButton, 
                bookedRoomButton
            };

            BunifuThinButton2 button = sender as BunifuThinButton2;
            foreach(BunifuThinButton2 b in buttonList)
            {
                if(button.Name == b.Name)
                {
                    b.IdleFillColor = Color.SeaGreen;
                    b.IdleForecolor = Color.White;
                }
                else
                {
                    b.IdleFillColor = Color.White;
                    b.IdleForecolor = Color.SeaGreen;
                }
            }
        }

        private void FocusOnClick(object sender, EventArgs e)
        {
            roomSearchTextBox.Focus();
        }

      

        private void roomSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = roomSearchTextBox.Text.Trim();

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            
            if (text != "")
            {
                try
                {
                    if(activeFilterTab == "ALL")
                    {
                        dt = db.GetData($"{selectAllCommand} WHERE SOPHONG = {text}");
                    }else if(activeFilterTab == "AVAILABLE")
                    {
                        dt = db.GetData($"{selectAllCommand} WHERE SOPHONG = {text} AND TINHTRANG = 0");
                    }
                    else if(activeFilterTab == "BOOKED")
                    {
                        dt = db.GetData($"{selectAllCommand} WHERE SOPHONG = {text} AND TINHTRANG = 1");
                    }

                    roomDataGridView.DataSource = dt;
                }catch(Exception ex) {
                    roomDataGridView.DataSource = null;
                    return;
                }
            }
            else
            {
                try
                {
                    if (activeFilterTab == "ALL")
                    {
                        dt = db.GetData(selectAllCommand);
                    }
                    else if (activeFilterTab == "AVAILABLE")
                    {
                        dt = db.GetData($"{selectAllCommand} WHERE TINHTRANG = 0");
                    }
                    else if (activeFilterTab == "BOOKED")
                    {
                        dt = db.GetData($"{selectAllCommand} WHERE AND TINHTRANG = 1");
                    }

                    roomDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    roomDataGridView.DataSource = null;
                    return;
                }
            };
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
