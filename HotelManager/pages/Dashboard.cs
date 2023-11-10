using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;




namespace HotelManager.pages
{
    public partial class Dashboard : Form
    {
        DBQuery pro = new DBQuery();
        public SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DS6Q9BBO\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void showInfoThisMonthButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaDK,ThucThu FROM DoanhThu", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string category = reader["MaDK"].ToString();
                    int value = Convert.ToInt32(reader["ThucThu"]);

                    

                }
               
            }
            catch
            {
                throw new Exception("Error");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
       /*     System.Data.DataTable dt = pro.GetData("select * from LUONG ");
            dgvLuong.DataSource = dt;
            dgvLuong.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvLuong.Columns[1].HeaderText = "Tháng";
            dgvLuong.Columns[2].HeaderText = "Năm";
            dgvLuong.Columns[3].HeaderText = "lượng";

            dt = pro.GetData("select count(*) as sophong from PHONG");
            lbTotalRoom.Text = dt.Rows[0]["sophong"].ToString();
            dt = pro.GetData("select count(*) as sophong from PHONG where TINHTRANG=1");
            lbTotalAvaliable.Text = dt.Rows[0]["sophong"].ToString();
            dt = pro.GetData("select count(*) as sophong from PHONG where TINHTRANG=0");
            lbTotalBooked.Text = dt.Rows[0]["sophong"].ToString();
            dt = pro.GetData("select count(*) as NhanVien from NHANVIEN");
            lbTotalstaff.Text = dt.Rows[0]["NhanVien"].ToString();

            dt = pro.GetData("SELECT top 5  KHACHHANG.HOTEN, COUNT(HOADON.MAKH) AS SoLanDen" +
                "\r\nFROM KHACHHANG\r\nLEFT JOIN HOADON ON KHACHHANG.MAKH = HOADON.MAKH" +
                "\r\nGROUP BY KHACHHANG.MAKH, KHACHHANG.HOTEN\r\nORDER BY SoLanDen DESC");
            chart2.Series["Series1"].Points.DataBind(dt.AsEnumerable(), "HOTEN", "SoLanDen", "");*/
        }

        private void btnKTNgay_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = pro.GetData($"select count(*) as SoOder from HOADON Where NGAYDEN = '{dtpNgay.Value.ToString("yyyy-MM-dd")}'");
            lbNBO.Text = dt.Rows[0]["SoOder"].ToString();
            dt = pro.GetData($"select sum(TONGHD) as TongTien from HOADON Where NGAYDEN = '{dtpNgay.Value.ToString("yyyy-MM-dd")}'");
            lbTotalReven.Text = dt.Rows[0]["TongTien"].ToString();
        }

        private void btnEX_Click(object sender, EventArgs e)
        {
         /*   ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            System.Data.DataTable dt = (System.Data.DataTable)dgvLuong.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {
                using (var package = new ExcelPackage())
                {
                    // Tạo một trang tính mới
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Đặt dữ liệu từ DataTable vào trang tính
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);

                    // Lưu tệp Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tệp Excel|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fileInfo);
                        MessageBox.Show("Dữ liệu đã được lưu thành công vào tệp Excel.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = pro.GetData($"select count(*) as SoOder from HOADON Where YEAR(NGAYDEN) = '{dtpNgay.Value.Year}'");
            lbNBO.Text = dt.Rows[0]["SoOder"].ToString();
            dt = pro.GetData($"select sum(TONGHD) as TongTien from HOADON Where YEAR(NGAYDEN) = '{dtpNgay.Value.Year}'");
            lbTotalReven.Text = dt.Rows[0]["TongTien"].ToString();
            dt = pro.GetData($"SELECT MONTH(NGAYDEN) AS THANG, SUM((GIAPHONG + COALESCE(GIADV, 0)))" +
                $" AS DOANHTHU FROM HOADON H LEFT JOIN CHITIETHOADON C ON H.MAHD = C.MAHD " +
                $"WHERE YEAR(NGAYDEN) ='{dtpNgay.Value.Year}' GROUP BY MONTH(NGAYDEN) ORDER BY MONTH(NGAYDEN);");
            chart1.DataSource = dt;
            chart1.Series["Series1"].XValueMember = "THANG";
            chart1.Series["Series1"].YValueMembers = "DOANHTHU";
            chart1.DataBind();
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = pro.GetData($"select count(*) as SoOder from HOADON Where month(NGAYDEN) = '{dtpNgay.Value.Month}'");
            lbNBO.Text = dt.Rows[0]["SoOder"].ToString();
            dt = pro.GetData($"select sum(TONGHD) as TongTien from HOADON Where month(NGAYDEN) = '{dtpNgay.Value.Month}'");
            lbTotalReven.Text = dt.Rows[0]["TongTien"].ToString();
            dt = pro.GetData($"select sum(TONGHD) as TongTien from HOADON Where month(NGAYDEN) = '{dtpNgay.Value.Month}'");
            lbTotalReven.Text = dt.Rows[0]["TongTien"].ToString();
            dt = pro.GetData($"SELECT\r\n    n.Num AS Ngay,\r\n   " +
                $" COALESCE(SUM(CASE WHEN MONTH(hd.NGAYDI) = '{dtpNgay.Value.Month}' AND YEAR(hd.NGAYDI) = '{dtpNgay.Value.Year}' THEN cthd.GIAPHONG + cthd.GIADV ELSE 0 END), 0) " +
                $"AS DoanhThuNgay\r\nFROM Numbers AS n\r\nLEFT JOIN HOADON AS hd ON n.Num = DAY(hd.NGAYDI)\r\n" +
                $"LEFT JOIN CHITIETHOADON AS cthd ON hd.MAHD = cthd.MAHD\r\nGROUP BY n.Num\r\nORDER BY Ngay;");
            chart1.DataSource = dt;
            chart1.Series["Series1"].XValueMember = "Ngay";
            chart1.Series["Series1"].YValueMembers = "DoanhThuNgay";
            chart1.DataBind();
        }

		private void lbPTTR_Click(object sender, EventArgs e)
		{

		}
	}
}
