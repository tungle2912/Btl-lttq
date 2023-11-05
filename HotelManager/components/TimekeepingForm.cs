using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HotelManager.components
{
    public partial class TimekeepingForm : Form
    {   
        DBQuery db=new DBQuery();
        public TimekeepingForm()
        {
            InitializeComponent();
        }

        private void TimekeepingForm_Load(object sender, EventArgs e)
        {
            DataTable t = db.GetData("select HOTEN FROM NHANVIEN");
            foreach (DataRow row in t.Rows)
            {
                string Service = row["HOTEN"].ToString();
                NameCBB.AddItem(Service);
            }
        }

        private void closeGuestFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeIdTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NameCBB_onItemSelected(object sender, EventArgs e)
        {       
            string manv = db.RenderID("SELECT MANV FROM NHANVIEN WHERE HOTEN =N'"+NameCBB.selectedValue.ToString()+"'");
            EmployeeIdTxt.Text=manv;
          
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (NameCBB.selectedIndex < 0)
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập nhân viên");
                c.ShowDialog();
                NameCBB.Focus();
                return;
            }
            DataTable t = db.GetData("select * from BANGLAMVIEC where MANV=N'" + EmployeeIdTxt.Text + "' AND NGAYLAMVIEC='" + Workdaydatetime.Value.ToString("yyyy-MM-dd") + "'");
            if (t.Rows.Count > 0)
            {
                new CustomMessageBox("Error", "đã điểm danh rồi").ShowDialog();
                return;
            }
            db.MutateData("INSERT INTO BANGLAMVIEC VALUES(N'" + EmployeeIdTxt.Text + "','" + Workdaydatetime.Value.ToString("yyyy-MM-dd") + "')");
        }
    }
}
