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

namespace HotelManager.components
{
    public partial class ServiceForm : Form
    {   
        DBQuery db=new DBQuery();
        private string madv;
        public ServiceForm()
        {
            InitializeComponent();
        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void roomFormLabel_Click(object sender, EventArgs e)
        {

        }

        private void closeRoomFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            ServiceDatagridview.DataSource = db.GetData("select TENDV,GIA FROM DICHVU");
            ServiceDatagridview.Columns[0].Width = 320;
       
        }

        private void ServiceDatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nametxt.Text= ServiceDatagridview.CurrentRow.Cells[0].Value.ToString();
            Pricetxt.Text= ServiceDatagridview.CurrentRow.Cells[1].Value.ToString();
            madv = db.RenderID("select MADV from dichvu where TENDV=N'"+ ServiceDatagridview.CurrentRow.Cells[0].Value.ToString() + "'");
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Tên Dịch Vụ");
                c.ShowDialog();
                Nametxt.Focus();
                return;
            }
            if (Pricetxt.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập giá dịch vụ");
                c.ShowDialog();
                Pricetxt.Focus();
                return;
            }
            DataTable t = db.GetData("select * from DICHVU where TENDV=N'" + Nametxt.Text + "'");
            if (t.Rows.Count > 0)
            {
                new CustomMessageBox("Error","Dịch vụ này đã có rồi ").ShowDialog();
                Nametxt.Focus();
                return;
            }
            db.MutateData("INSERT INTO DICHVU VALUES(N'" + Nametxt.Text + "'," + Pricetxt.Text + ")");
            ServiceForm_Load(sender, e);

        }



        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (Nametxt.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Tên Dịch Vụ");
                c.ShowDialog();
                Nametxt.Focus();
                return;
            }
            if (Pricetxt.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập giá dịch vụ");
                c.ShowDialog();
                Pricetxt.Focus();
                return;
            }
            db.MutateData("UPDATE DICHVU SET TENDV=N'"+Nametxt.Text+"',GIA="+Pricetxt.Text+" WHERE MADV='"+madv+"'");
            ServiceForm_Load(sender, e);
        }
    }
}
