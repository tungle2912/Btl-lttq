using FontAwesome.Sharp;
using HotelManager.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.pages
{
    public partial class Setting : Form
    {
        Form currentForm = null;

        public Setting()
        {   
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox c = new CustomMessageBox("Xác nhận", "Bạn có chắc chắn muốn đăng xuất không?", "Yes", "No");

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

     


        private void DirectPage(Form page, object sender)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            
            currentForm = page;
            page.TopLevel = false; // i
            page.Dock = DockStyle.Fill;
            page.FormBorderStyle = FormBorderStyle.None;
            tabsPanel.Controls.Add(page); // i
            tabsPanel.Tag = page;
            page.BringToFront(); // i
            page.Show();
        }



        private void accountTab_Click(object sender, EventArgs e)
        {
            SettingUpdateAccount s = new SettingUpdateAccount();
            DirectPage(s, sender);
        }

        private void voucherTab_Click(object sender, EventArgs e)
        {
            SettingEventVoucher s = new SettingEventVoucher();
            DirectPage(s, sender);
        }


    }
    
}
