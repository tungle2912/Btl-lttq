using Bunifu.Framework.UI;
using HotelManager.components;
using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManager.pages
{
    public partial class Guest : Form
    {
        public static string gID;

        private string selectAllCommand = "SELECT KHACHHANG.MAKH AS 'Guest ID', HOTEN AS 'Name', TUOI AS 'Age', DIACHI AS 'Address', SDT AS 'Phone Number' FROM KHACHHANG";
        private string activeFilterTab = "ALL";

        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            allFilterButton.IdleFillColor = Color.SeaGreen;
            allFilterButton.IdleForecolor = Color.White;

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            dt = db.GetData(selectAllCommand);
            guestDataGridView.DataSource = dt;
        }

        private void FocusOnClick(object sender, EventArgs e)
        {
            guestSearchTextBox.Focus();
        }

       

        private void guestDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                gID = guestDataGridView.CurrentRow.Cells[0].Value.ToString();
                string guestID = guestDataGridView.CurrentRow.Cells[0].Value.ToString();
                string name = guestDataGridView.CurrentRow.Cells[1].Value.ToString();
                string age = guestDataGridView.CurrentRow.Cells[2].Value.ToString();
                string address = guestDataGridView.CurrentRow.Cells[3].Value.ToString();
                string phoneNumber = guestDataGridView.CurrentRow.Cells[4].Value.ToString();
                (new GuestForm(guestID, name, age, address, phoneNumber)).ShowDialog();
            
        }

        private void checkinFilterButton_Click(object sender, EventArgs e)
        {
            activeFilterTab = "CHECKIN";
            ActiveFilterGuestButton(sender);

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData($"{selectAllCommand} JOIN HOADON ON HOADON.MAKH = KHACHHANG.MAKH WHERE NGAYDI >= GETDATE()");
                guestDataGridView.DataSource = dt;
            }
            catch (Exception ex) { }
        }


        private void checkoutFilterButton_Click(object sender, EventArgs e)
        {
            activeFilterTab = "CHECKOUT";
            ActiveFilterGuestButton(sender);

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData($"{selectAllCommand} JOIN HOADON ON HOADON.MAKH = KHACHHANG.MAKH WHERE NGAYDI < GETDATE()");
                guestDataGridView.DataSource = dt;
            }
            catch(Exception ex){ }
        }

        private void allFilterButton_Click(object sender, EventArgs e)
        {
            activeFilterTab = "ALL";
            ActiveFilterGuestButton(sender);
            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData(selectAllCommand);
                guestDataGridView.DataSource = dt;
            }catch (Exception ex){ }
        }

        private void ActiveFilterGuestButton(object sender)
        {
            List<BunifuThinButton2> buttonList = new List<BunifuThinButton2>()
            {
                allFilterButton,
                checkinFilterButton,
                checkoutFilterButton
            };

            BunifuThinButton2 button = sender as BunifuThinButton2;
            foreach (BunifuThinButton2 b in buttonList)
            {
                if (button.Name == b.Name)
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


        private void guestSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = guestSearchTextBox.Text.Trim();

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();

            if (text != "")
            {
                try
                {
                    if (activeFilterTab == "ALL")
                    {
                        dt = db.GetData(selectAllCommand);
                    }
                    else if (activeFilterTab == "CHECKIN")
                    {
                        dt = db.GetData($"{selectAllCommand} JOIN HOADON ON HOADON.MAKH = KHACHHANG.MAKH WHERE HOADON.MAKH = '" + text + "' AND NGAYDI >= GETDATE()");
                    }
                    else if (activeFilterTab == "CHECKOUT")
                    {
                        dt = db.GetData($"{selectAllCommand} JOIN HOADON ON HOADON.MAKH = KHACHHANG.MAKH WHERE HOADON.MAKH = '" + text + "' AND NGAYDI < GETDATE()");
                    }

                    guestDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    guestDataGridView.DataSource = null;
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
                    else if (activeFilterTab == "CHECKIN")
                    {
                        dt = db.GetData($"{selectAllCommand} JOIN HOADON ON HOADON.MAKH = KHACHHANG.MAKH WHERE NGAYDI >= GETDATE()");
                    }
                    else if (activeFilterTab == "CHECKOUT")
                    {
                        dt = db.GetData($"{selectAllCommand} JOIN HOADON ON HOADON.MAKH = KHACHHANG.MAKH WHERE NGAYDI < GETDATE()");
                    }

                    guestDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    guestDataGridView.DataSource = null;
                    return;
                }
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
