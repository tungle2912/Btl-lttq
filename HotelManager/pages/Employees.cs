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
            DataTable dt = new DataTable();
            dt = db.GetData("SELECT MANV AS 'Employee ID', HOTEN AS 'Name',GIOITINH AS 'Gender', TENCHUCVU AS 'Position', SDT AS 'Phone Number' FROM NHANVIEN JOIN LUONG ON NHANVIEN.MACHUCVU=LUONG.MACHUCVU");
            employeeDataGridView.DataSource = dt;
        }
        private void updatedata(Object sender, FormClosedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.GetData("SELECT MANV AS 'Employee ID', HOTEN AS 'Name',GIOITINH AS 'Gender', TENCHUCVU AS 'Position', SDT AS 'Phone Number' FROM NHANVIEN JOIN LUONG ON NHANVIEN.MACHUCVU=LUONG.MACHUCVU");
            employeeDataGridView.DataSource = dt;
        }


        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm a = new EmployeeForm(db.RenderID("select dbo.CreateMaNV()"));
            a.FormClosed += updatedata;
            a.ShowDialog();
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeForm a = new EmployeeForm(employeeDataGridView.CurrentRow.Cells[0].Value.ToString(),"Add");
            a.FormClosed += updatedata;
            a.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            new TimekeepingForm().ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            string text = EmployeeSearch.Text.Trim();

            DBQuery db = new DBQuery();
            DataTable dt = new DataTable();

            if (text != "")
            {
                try
                {
                    dt = db.GetData("SELECT MANV AS 'Employee ID', HOTEN AS 'Name', GIOITINH AS 'Gender', TENCHUCVU AS 'Position', SDT AS 'Phone Number' FROM NHANVIEN JOIN LUONG ON NHANVIEN.MACHUCVU = LUONG.MACHUCVU WHERE HOTEN LIKE N'%" + text + "%'");                
                    employeeDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    employeeDataGridView.DataSource = null;
                    return;
                }
            }
            else
            {
                try
                {
                    dt = db.GetData("SELECT MANV AS 'Employee ID', HOTEN AS 'Name',GIOITINH AS 'Gender', TENCHUCVU AS 'Position', SDT AS 'Phone Number' FROM NHANVIEN JOIN LUONG ON NHANVIEN.MACHUCVU=LUONG.MACHUCVU");
                    employeeDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    employeeDataGridView.DataSource = null;
                    return;
                }
            };
        }

        private void EmployeeSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                search();
            }
        }
    }
}
