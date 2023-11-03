using FontAwesome.Sharp;
using HotelManager.pages;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManager
{
    public partial class App : Form
    {

        private Button currentBtn;
        private Form currentPage;
        public App()
        {
            InitializeComponent();
            
        }


        private void InactiveButton()
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(IconButton))
                {
                    btn.BackColor = Color.FromArgb(32,32,32);
                }

            }
        }


        private void ActiveButton(object sender)
        {
            // rgb(81, 85, 126)
        
                if (currentBtn != (IconButton)sender)
                {
                    InactiveButton();
                    currentBtn = (IconButton)sender;
                    currentBtn.BackColor = Color.FromArgb(46, 46, 46);

            }
        }

        
        private void DirectPage(Form page, object sender)
        {
            if(currentPage != null)
            {
                currentPage.Close();
            }

            ActiveButton(sender);
            currentPage = page;
            page.TopLevel = false; // i
            page.Dock = DockStyle.Fill;
            page.FormBorderStyle = FormBorderStyle.None;
            panelDestopApp.Controls.Add(page); // i
            panelDestopApp.Tag = page;
            page.BringToFront(); // i
            page.Show();
            pageTitle.Text = page.Text;
        }


        
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            DirectPage(dashboard, sender);
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            DirectPage(rooms, sender);

        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();    
            DirectPage(guest, sender);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            DirectPage(employees, sender);
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            DirectPage(reservation, sender);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            DirectPage(setting, sender);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox c = new CustomMessageBox("Xác nhận", "Bạn có chắc chắn muốn đăng xuất không?", "Yes", "No");

            c.YesClicked += (s, args) =>
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            };

            c.NoClicked += (s, args) =>
            {
                return;
            };

            c.ShowDialog();                
        }

        private void App_Load(object sender, EventArgs e)
        {
            userAuth.Text = $"Login as {Login.username}";
            timer.Start();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           displayRealDate.Text = DateTime.Now.ToLongDateString();
           displayRealTime.Text = DateTime.Now.ToLongTimeString();
        }

     
    }
}
