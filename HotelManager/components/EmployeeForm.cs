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
    public partial class EmployeeForm : Form
    {
        private string currentState="Add";
        private string manv;
		private OpenFileDialog f = new OpenFileDialog();
        private string fileName;
		DBQuery db= new DBQuery();
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        public EmployeeForm(string manv,string a)
        {
            InitializeComponent();
            currentState = "Update";
            this.manv = manv;
        }


        private void guestLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            string[] a=new string[10];
            int i = 0;
            DataTable dt = db.GetData("select TENCHUCVU FROM LUONG");
            foreach (DataRow row in dt.Rows)
            {
                string tenchucvu = row["TENCHUCVU"].ToString();
                PositionCBB.AddItem(tenchucvu);
                a[i] = tenchucvu;
                i++;

            }
            if (currentState == "Add")
            {
            EmployeeIdTxt.Text= manv;
            }
            else
            {            
                guestLabel.Text = "Update Employee";
                Addbtn.Text = "Update";
                EmployeeIdTxt.Text = manv;
                DataTable t = new DataTable();
                t = db.GetData("SELECT * FROM NHANVIEN WHERE MANV = '" + manv + "'");
                NameEmployeeTxt.Text = t.Rows[0].Field<string>("HOTEN");
                PhoneNumbertxt.Text = t.Rows[0].Field<string>("SDT");
                if (t.Rows[0].Field<string>("GIOITINH") == "Nam")
                {
                    btnMale.Checked = true;
                }
                else
                {
                    btnFemale.Checked = true;
                }

            
                for ( int j = 0; j < i; j++)
                {
                    if (a[j] == db.RenderID("select TENCHUCVU FROM LUONG WHERE MACHUCVU='"+ t.Rows[0].Field<int>("MACHUCVU") + "'"))
                    {
                        PositionCBB.selectedIndex = j;
                    }
                }
                try
                {
				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\image\\" + t.Rows[0].Field<string>("Anh"));
                }catch(Exception ex)
                {
                    new CustomMessageBox("Error", "Nhân viên này chưa có ảnh");
                }


			}
        }

        private void guestFormButton_Click(object sender, EventArgs e)
        {
			
            if (currentState == "Add")
            {

                if (NameEmployeeTxt.Text.Trim() == "")
                {
                    CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Tên nhân viên");
                    c.ShowDialog();
                    NameEmployeeTxt.Focus();
                    return;
                }
                if (PhoneNumbertxt.Text.Trim() == "")
                {
                    CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập số điện thoại");
                    c.ShowDialog();
                    PhoneNumbertxt.Focus();
                    return;
                }
                if (PositionCBB.selectedIndex < 0)
                {
                    CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập chức vụ");
                    c.ShowDialog();
                    return;
                }
                if (btnMale.Checked == false && btnFemale.Checked == false)
                {
                    CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập giới tính");
                    c.ShowDialog();
                    return;
                }
                if (btnMale.Checked == true)
                {
                    db.MutateData("INSERT INTO NHANVIEN VALUES ('" + EmployeeIdTxt.Text + "',N'" + NameEmployeeTxt.Text + "',dbo.RenderMaChucVu(N'" + PositionCBB.selectedValue.ToString() + "'),N'Nam','" + PhoneNumbertxt.Text + "','" + fileName + "')");
					new CustomMessageBox("Notification", "Thêm thông tin thành công").ShowDialog();

				}
				else
                {
                    db.MutateData("INSERT INTO NHANVIEN VALUES ('" + EmployeeIdTxt.Text + "',N'" + NameEmployeeTxt.Text + "',dbo.RenderMaChucVu(N'" + PositionCBB.selectedValue.ToString() + "'),N'Nữ','" + PhoneNumbertxt.Text + "','" + fileName + "')");
					new CustomMessageBox("Notification", "Thêm thông tin thành công").ShowDialog();

				}
			}
            else
            {
				db.MutateData("UPDATE NHANVIEN SET HOTEN= N'" + NameEmployeeTxt.Text + "',MACHUCVU= dbo.RenderMaChucVu(N'" + PositionCBB.selectedValue.ToString() + "'),GIOITINH=N'Nữ',SDT='" + PhoneNumbertxt.Text + "',ANH='" + fileName + "' WHERE MANV='"+EmployeeIdTxt.Text+"'");
                new CustomMessageBox("Notification", "Sửa thông tin thành công").ShowDialog();
			}

		}

        private void closeGuestFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{		
			// Thiết lập bộ lọc file
			f.Filter = "JPEG |*.jpg| PNG |*.png|All file |*.*";

			f.FilterIndex = 1;
			// Hiển thị hộp thoại trọn file
			if (f.ShowDialog() == DialogResult.OK)
			{
				// Tải ảnh về bộ nhớ
				Image image = Image.FromFile(f.FileName);
				// Lưu ảnh vào thư mục image của project
				fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                image.Save(Application.StartupPath + "\\image\\" + fileName);
				pictureBox1.Image = Image.FromFile(f.FileName);
			}
		}
	}
}
