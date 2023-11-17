using HotelManager.utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using OfficeOpenXml;




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
            lbPTEM.Text = pro.RenderID("select dbo.LUONGF(year(getdate()),month(getdate()))");
            lbTotalReven.Text= pro.RenderID("select dbo.DOANHTHUF(year(getdate()),month(getdate()))");
            lbNBO.Text = pro.RenderID("select dbo.NUMBERORDER(year(getdate()),month(getdate()))");
            labeltotalprofit.Text = (double.Parse(lbTotalReven.Text) - double.Parse(lbPTEM.Text)).ToString();

			dt = pro.GetData("select * from LOINHUANNAM(year(getdate()))");
			chart1.DataSource = dt;
			chart1.Series["Series1"].XValueMember = "THANG";
			chart1.Series["Series1"].YValueMembers = "LOINHUAN_USD";
			chart1.DataBind();
		}
		/*	private void dtpNgay_onValueChanged(object sender, EventArgs e)
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
	*/

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

			int currentYear = dtpNgay.Value.Year;
			int currentMonth = dtpNgay.Value.Month;

			int previousMonth;
			int previousYear;


			// Tính tháng và năm của tháng trước đó
			if (currentMonth == 1) // Nếu tháng hiện tại là tháng 1
			{
				previousMonth = 12; // Tháng trước đó là tháng 12
				previousYear = currentYear - 1; // Năm trước đó
			}
			else
			{
				previousMonth = currentMonth - 1; // Tháng trước đó
				previousYear = currentYear; // Năm hiện tại
			}
			/*int labelemployeesalary_1 = Convert.ToInt32( pro.RenderID($"select dbo.LUONGF({previousYear},{previousMonth})"));*/
			string lbTotalReven_1 = pro.RenderID($"select dbo.DOANHTHUF({previousYear},{previousMonth})");
			lbTotalReven.Text = pro.RenderID($"select dbo.DOANHTHUF({dtpNgay.Value.Year},{dtpNgay.Value.Month})");
			double y = Math.Ceiling((double.Parse(lbTotalReven.Text) - double.Parse(lbTotalReven_1)) / double.Parse(lbTotalReven_1) * 100);
			if (y <= 0)
			{
				lbPTTR.ForeColor = Color.Red;
				lbPTTR.Text = $"{y}%";
			}
			else
			{
				lbPTTR.ForeColor = Color.LimeGreen;
				lbPTTR.Text = $"+{y}%";
			}

			//hiển thị luong nhan vien
			string labelemployeesalary_1 = pro.RenderID($"select dbo.LUONGF({previousYear},{previousMonth})");
			lbPTEM.Text = pro.RenderID($"select dbo.LUONGF({dtpNgay.Value.Year},{dtpNgay.Value.Month})");
			y = Math.Ceiling((double.Parse(lbPTEM.Text) - double.Parse(labelemployeesalary_1)) / double.Parse(labelemployeesalary_1) * 100);
			if (y <= 0)
			{
				lbPTEM.ForeColor = Color.Red;
				lbPTEM.Text = $"{y}%";
			}
			else
			{
				lbPTEM.ForeColor = Color.LimeGreen;
				lbPTEM.Text = $"+{y}%";
			}
			string lbNBO_1 = pro.RenderID($"select dbo.NUMBERORDER({previousYear},{previousMonth})");
			lbNBO.Text = pro.RenderID($"select dbo.NUMBERORDER({dtpNgay.Value.Year},{dtpNgay.Value.Month})");
			y = Math.Ceiling((double.Parse(lbNBO.Text) - double.Parse(lbNBO_1)) / double.Parse(lbNBO_1) * 100);
			if (y <= 0)
			{
				lbPTNB.ForeColor = Color.Red;
				lbPTNB.Text = $"{y}%";
			}
			else
			{
				lbPTNB.ForeColor = Color.LimeGreen;
				lbPTNB.Text = $"+{y}%";
			}
			double labeltotalprofit_1 = (double.Parse(lbTotalReven_1) - double.Parse(labelemployeesalary_1));
			labeltotalprofit.Text = (double.Parse(lbTotalReven.Text) - double.Parse(lbPTEM.Text)).ToString();
			y = Math.Ceiling((double.Parse(labeltotalprofit.Text) - labeltotalprofit_1 / labeltotalprofit_1 * 100));
			if (y <= 0)
			{
				lbPTTP.ForeColor = Color.Red;
				lbPTTP.Text = $"{y}%";
			}
			else
			{
				lbPTTP.ForeColor = Color.LimeGreen;
				lbPTTP.Text = $"+{y}%";
			}
			dt = pro.GetData($"select * from LOINHUANNAM({dtpNgay.Value.Year})");
			chart1.DataSource = dt;
			chart1.Series["Series1"].XValueMember = "THANG";
			chart1.Series["Series1"].YValueMembers = "LOINHUAN_USD";
			chart1.DataBind();
		}

		private void ExportDataBtn_Click(object sender, EventArgs e)
		{
			System.Data.DataTable dt = (System.Data.DataTable)datahoadon.DataSource;
			if (dt != null && dt.Rows.Count > 0)
			{
				using (var package = new ExcelPackage())
				{

					// Tạo một trang tính mới
					ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

					int month = dtpNgay.Value.Month;
					int year = dtpNgay.Value.Year;

					worksheet.Cells["A1:G1"].Merge = true;
					worksheet.Cells["A1:G1"].Value = $"Dashboard {month}-{year}";
					worksheet.Cells["A1:G1"].Style.Font.Size = 18;
					worksheet.Cells["A1:G1"].Style.Font.Bold = true;
					worksheet.Cells["A1:G1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

					worksheet.Cells["A3:B3"].Merge = true;
					worksheet.Cells["A3:B3"].Value = "Number of Order:";
					worksheet.Cells["C3:D3"].Merge = true;
					worksheet.Cells["C3:D3"].Value = lbNBO.Text;

					worksheet.Cells["E3:F3"].Merge = true;
					worksheet.Cells["E3:F3"].Value = "Total Revenue:";
					worksheet.Cells["G3:H3"].Merge = true;
					worksheet.Cells["G3:H3"].Value = lbTotalReven.Text;

					worksheet.Cells["A4:B4"].Merge = true;
					worksheet.Cells["A4:B4"].Value = "Employ salary:";
					worksheet.Cells["C4:D4"].Merge = true;
					worksheet.Cells["C4:D4"].Value = lbPTEM.Text;

					worksheet.Cells["E4:F4"].Merge = true;
					worksheet.Cells["E4:F4"].Value = "Total Profit:";
					worksheet.Cells["G4:H4"].Merge = true;
					worksheet.Cells["G4:H4"].Value = labeltotalprofit.Text;
					// Đặt dữ liệu từ DataTable vào trang tính
					worksheet.Cells["A6"].LoadFromDataTable(dt, true);

					// Lưu tệp Excel
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "Tệp Excel|*.xlsx";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						FileInfo file = new FileInfo(saveFileDialog.FileName);
						package.SaveAs(file);
						MessageBox.Show("Dữ liệu đã được lưu thành công vào tệp Excel.");
					}
				}
			}
			else
			{
				MessageBox.Show("danh sách trống");
			}
		}



	}
}
