using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.pages
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();
            dt = db.GetData("SELECT MANV AS 'Employee ID', HOTEN AS 'Name', VITRI AS 'Position', SDT AS 'Phone Number' FROM NHANVIEN");
            employeeDataGridView.DataSource = dt;
        }
    }
}
