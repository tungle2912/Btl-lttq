using HotelManager.components;
using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.pages
{
    public partial class Employees : Form
    {   
        DBQuery db=new DBQuery();
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            dt = db.GetData("SELECT MANV AS 'Employee ID', HOTEN AS 'Name',GIOITINH AS 'Gender', TENCHUCVU AS 'Position', SDT AS 'Phone Number' FROM NHANVIEN JOIN LUONG ON NHANVIEN.MACHUCVU=LUONG.MACHUCVU");
            employeeDataGridView.DataSource = dt;
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
           new EmployeeForm(db.RenderID("select dbo.CreateMaNV()")).ShowDialog();
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new EmployeeForm(employeeDataGridView.CurrentRow.Cells[0].Value.ToString(),"Add").ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            new TimekeepingForm().ShowDialog();
        }
    }
}
