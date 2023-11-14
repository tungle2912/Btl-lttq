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
            // hiển thị hóa đơn trong tháng này
            System.Data.DataTable dt = pro.GetData("SELECT " +
				"MAHD AS N'Bill ID', " +
				"MAKH AS N'Guest ID', " +
				"NGAYDEN AS 'Arrive Time', " +
				"NGAYDI AS 'Leave Time', " +
				"THOIGIANTHUE AS N'Rental period'," +
				"TONGHD AS N'Total '" +
				"FROM HOADON where YEAR(NGAYDI)=YEAR(getdate()) AND MONTH(NGAYDI)=MONTH(getdate())");
            datahoadon.DataSource= dt;

            dt = pro.GetData("select * from totalcounter");
            lbTotalRoom.Text = dt.Rows[0]["sophong"].ToString();
            lbTotalAvaliable.Text = dt.Rows[0]["sophong_available"].ToString();
            lbTotalBooked.Text = dt.Rows[0]["sophong_booked"].ToString();
            lbTotalstaff.Text = dt.Rows[0]["NhanVien"].ToString();
            //hiển thị top5 khach hang
            dt = pro.GetData("select * from top5khachhang");
            chart2.Series["Series1"].Points.DataBind(dt.AsEnumerable(), "HOTEN", "SoLanDen", "");

            //hiển thị luong nhan vien
            labelemployeesalary.Text = pro.RenderID("select dbo.LUONGF(year(getdate()),month(getdate()))");
            lbTotalReven.Text= pro.RenderID("select dbo.DOANHTHUF(year(getdate()),month(getdate()))");
            lbNBO.Text = pro.RenderID("select dbo.NUMBERORDER(year(getdate()),month(getdate()))");
            labeltotalprofit.Text = (double.Parse(lbTotalReven.Text) - double.Parse(labelemployeesalary.Text)).ToString();

			dt = pro.GetData("select * from LOINHUANNAM(year(getdate()))");
			chart1.DataSource = dt;
			chart1.Series["Series1"].XValueMember = "THANG";
			chart1.Series["Series1"].YValueMembers = "LOINHUAN_USD";
			chart1.DataBind();
		}
		private void dtpNgay_onValueChanged(object sender, EventArgs e)
		{
            System.Data.DataTable dt = pro.GetData("SELECT " +
             "MAHD AS N'Bill ID', " +
             "MAKH AS N'Guest ID', " +
             "NGAYDEN AS 'Arrive Time', " +
             "NGAYDI AS 'Leave Time', " +
             "THOIGIANTHUE AS N'Rental period'," +
             "TONGHD AS N'Total '" +
             $"FROM HOADON where YEAR(NGAYDI)={dtpNgay.Value.Year} AND MONTH(NGAYDI) ={dtpNgay.Value.Month}");
            datahoadon.DataSource = dt;


            //hiển thị luong nhan vien
            labelemployeesalary.Text = pro.RenderID($"select dbo.LUONGF({dtpNgay.Value.Year},{dtpNgay.Value.Month})");
			lbTotalReven.Text = pro.RenderID($"select dbo.DOANHTHUF({dtpNgay.Value.Year},{dtpNgay.Value.Month})");
			lbNBO.Text = pro.RenderID($"select dbo.NUMBERORDER({dtpNgay.Value.Year},{dtpNgay.Value.Month})");
			labeltotalprofit.Text = (double.Parse(lbTotalReven.Text) - double.Parse(labelemployeesalary.Text)).ToString();

			dt = pro.GetData($"select * from LOINHUANNAM({dtpNgay.Value.Year})");
			chart1.DataSource = dt;
			chart1.Series["Series1"].XValueMember = "THANG";
			chart1.Series["Series1"].YValueMembers = "LOINHUAN_USD";
			chart1.DataBind();
		}


        private void btnEX_Click(object sender, EventArgs e)
        {
           /* ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
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


	
	}
}
