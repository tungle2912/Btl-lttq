using Bunifu.Framework.UI;
using HotelManager.components;
using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.pages
{
    public partial class Reservation : Form
    {
        private string selectAllCommand = ("SELECT " +
                "MAHD AS N'Bill ID', " +
                "MAKH AS N'Guest ID', " +                        
                "NGAYDEN AS 'Arrive Time', " +
                "NGAYDI AS 'Leave Time', " +
                "THOIGIANTHUE AS N'Rental period'," +
                "TONGHD AS N'Total '"+
                "FROM HOADON");
        private string activeFilterTab = "ALL";
        DBQuery db = new DBQuery();
        public Reservation()
        {
            InitializeComponent();

        }

     

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            ReservationForm a=
                new ReservationForm(db.RenderID("select dbo.CreateMaHD()"), db.RenderID("select dbo.CreateMaKH()"));  
            a.FormClosed += restartDataGridView;
            a.ShowDialog();
        }
    
        private void Reservation_Load(object sender, EventArgs e)
        {
            allFilterButton.IdleFillColor = Color.SeaGreen;
            allFilterButton.IdleForecolor = Color.White;
            DataTable dt = new DataTable();
            dt = db.GetData(selectAllCommand);
            reservationDataGridView.DataSource = dt;
        }
        public void restartDataGridView(Object sender, FormClosedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.GetData(selectAllCommand);
            reservationDataGridView.DataSource = dt;
        }
       
        // CELL CLICK 
        private void reservationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReservationForm a = new ReservationForm(reservationDataGridView.CurrentRow.Cells[0].Value.ToString());
            a.FormClosed += restartDataGridView;
            a.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void checkinFilterButton_Click(object sender, EventArgs e)
        {
            activeFilterTab = "CHECKIN";
            ActiveFilterGuestButton(sender);

        
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData($"{selectAllCommand} WHERE NGAYDI IS NULL");
                reservationDataGridView.DataSource = dt;
            }
            catch (Exception ex) { }
        }
  
        private void checkoutFilterButton_Click_1(object sender, EventArgs e)
        {
            activeFilterTab = "CHECKOUT";
            ActiveFilterGuestButton(sender);

            
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData($"{selectAllCommand}  WHERE NGAYDI IS NOT NULL");
                reservationDataGridView.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void allFilterButton_Click_1(object sender, EventArgs e)
        {
            activeFilterTab = "ALL";
            ActiveFilterGuestButton(sender);
           
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetData(selectAllCommand);
                reservationDataGridView.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void reservationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
