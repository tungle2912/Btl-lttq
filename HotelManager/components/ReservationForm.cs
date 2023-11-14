using Bunifu.Framework.UI;
using HotelManager.utils;
using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.ServiceProcess;


namespace HotelManager.components
{
    public partial class ReservationForm : Form
    {
        private string currentState;

        private string billID, guestID, name, address, phoneNumber,employeeid;
        private int age, roomNumber;
        DateTime arriveTime,leaveTime;
        DBQuery db = new DBQuery();
        public event EventHandler DataAdded;
        private double? total=0,priceroom = 0,priceservice=0;
        private Boolean checkngaydi=false,checkservice=false;

        private void OnDataAdded()
        {
            DataAdded?.Invoke(this, EventArgs.Empty);
        }


		private void ReservationForm_Load(object sender, EventArgs e)
		{
			updadedatagrid();
            System.Data.DataTable t = db.GetData("select TENDV FROM DICHVU");
			foreach (DataRow row in t.Rows)
			{
				string Service = row["TENDV"].ToString();
				ServiceCBBox.AddItem(Service);
			}
			if (currentState == "UPDATE")
			{
				string[] a = new string[100];
				int i = 0;
				System.Data.DataTable dt = db.GetData("select SOPHONG FROM PHONG ");
				foreach (DataRow row in dt.Rows)
				{
					string roomNumber = row["SOPHONG"].ToString();
					roomNumberCBBox.AddItem(roomNumber);
					a[i] = roomNumber;
					i++;

				}
				updadedatagrid();
				guestLabel.Text = "UPDATE BILL";
				AddButton.Text = "Update ";
				BillIDLabel.Text = billID;
				guestIDTxt.Text = guestID;
				nameTextBox.Text = name;
				cancelButton.Visible = false;
				ageTextBox.Text = age.ToString();
				addressTextBox.Text = address;
				PhoneNumberTextBox.Text = phoneNumber;
				arriveTimeDatepicker.Value = arriveTime;
				ExportDataBtn.Enabled = true;
				if (checkngaydi)
				{
					LeaveTimePicker.Value = leaveTime;
				}

				for (int j = 0; j < i; j++)
				{
					if (a[j] == roomNumber.ToString())
					{
						roomNumberCBBox.selectedIndex = j;
					}
				}
				AddButton.Text = "UPDATE";

				PriceTextBox.Text = db.RenderID("select dbo.price('" + roomNumber.ToString() + "')");
				Totallabel.Text = db.RenderID("select TONGHD from HOADON WHERE MAHD='" + BillIDLabel.Text + "'");
			}
			else if (currentState == "ADD")
			{
				System.Data.DataTable d = db.GetData("select SOPHONG FROM PHONG WHERE TINHTRANG=0");
				foreach (DataRow row in d.Rows)
				{
					string roomNumber = row["SOPHONG"].ToString();
					roomNumberCBBox.AddItem(roomNumber);
				}
				AddButton.Text = "Add ";
				BillIDLabel.Text = billID;
				guestIDTxt.Text = guestID;
				deleteButton.Visible = false;
				ExportDataBtn.Visible = false;
				btnAddService.Enabled = false;
				employeeid = Login.MaNV;

			}
			//    employeeIDTextBox.Text = db.RenderID("select HOTEN FROM NHANVIEN WHERE MANV='"+employeeid+"'") ;    
		}
		private void roomNumberTextBox_onItemSelected(object sender, EventArgs e)
        {   
            roomNumber = int.Parse(roomNumberCBBox.selectedValue.ToString());
            string price = db.RenderID("SELECT dbo.price('"+roomNumberCBBox.selectedValue.ToString()+"')");
            PriceTextBox.Text= price;
            priceroom =float.Parse(price);
        }

        private void ServiceCBBox_onItemSelected(object sender, EventArgs e)
        {
            string price = db.RenderID("SELECT dbo.priceService(N'" + ServiceCBBox.selectedValue.ToString() + "')");
            PriceServiceTextbox.Text = price;
            checkservice = true;
            total += float.Parse(price);
            Totallabel.Text = total.ToString();
        }

        private void LeaveTimePicker_onValueChanged(object sender, EventArgs e)
        {
            checkngaydi = true;
            if (LeaveTimePicker.Value > arriveTimeDatepicker.Value)
            {
                total = total + (priceroom *((LeaveTimePicker.Value - arriveTimeDatepicker.Value).Days + 1));
            }else if(LeaveTimePicker.Value > arriveTimeDatepicker.Value){
                total = total + priceroom;
            }else {
                CustomMessageBox a = new CustomMessageBox("Error", "Ngày đi phải sau ngày đến");
                a.ShowDialog();
                checkngaydi=false;
                return;
            }
                Totallabel.Text = total.ToString();           

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            guestIDTxt.Text = db.RenderID("select dbo.CreateMaHD()");
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            roomNumberCBBox.selectedIndex= 0;
            ServiceCBBox.selectedIndex= 0;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox a = new CustomMessageBox("Xác nhận", "Bạn có muốn xóa hóa đơn này ?");
            a.ShowDialog();
        }

		private void ExportDataBtn_Click(object sender, EventArgs e)
		{
			//ServiceDataGrid//

			Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWorkbook = ExcelApp.Workbooks.Add();
            Excel.Worksheet ExcelWorksheet = ExcelApp.Worksheets[1];
			
			// Print in excel file here
			ExcelWorksheet.Cells[1, 1] = "HÓA ĐƠN THANH TOÁN";
			ExcelWorksheet.Range[ExcelWorksheet.Cells[1, 1], ExcelWorksheet.Cells[1, 2]].Merge();
			ExcelWorksheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			ExcelWorksheet.Cells[1, 1].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
			ExcelWorksheet.Name = "Hóa đơn";

			ExcelWorksheet.Columns[1].ColumnWidth = 40;
			ExcelWorksheet.Columns[2].ColumnWidth = 40;

            ExcelWorksheet.Rows[1].RowHeight = 50;

			ExcelWorksheet.Cells[2, 1] = "Thông tin khách hàng";
			ExcelWorksheet.Range[ExcelWorksheet.Cells[2, 1], ExcelWorksheet.Cells[2, 2]].Merge();
			ExcelWorksheet.Rows[2].RowHeight = 25;
			ExcelWorksheet.Cells[2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			ExcelWorksheet.Cells[2, 1].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;

			// Get customer information

			string rentDays = db.RenderID("SELECT THOIGIANTHUE FROM HOADON");

			DateTime arriveTime = arriveTimeDatepicker.Value;
			string customerName = nameTextBox.Text;
            ExcelWorksheet.Cells[3, 1] = "Họ và tên";
            ExcelWorksheet.Cells[3, 2] = customerName;

			ExcelWorksheet.Cells[4, 1] = "Tuổi";
			ExcelWorksheet.Cells[4, 2] = ageTextBox.Text;

			ExcelWorksheet.Cells[5, 1] = "Địa chỉ";
			ExcelWorksheet.Cells[5, 2] = addressTextBox.Text;

			ExcelWorksheet.Cells[6, 1] = "Số điện thoại";
			ExcelWorksheet.Cells[6, 2] = PhoneNumberTextBox.Text;

			ExcelWorksheet.Cells[7, 1] = "Phòng";
			ExcelWorksheet.Cells[7, 2] = roomNumberCBBox.selectedValue;

			ExcelWorksheet.Cells[8, 1] = "Số ngày thuê";
			ExcelWorksheet.Cells[8, 2] = rentDays;

			ExcelWorksheet.Cells[9, 1] = "Nhân viên hướng dẫn";
			ExcelWorksheet.Cells[9, 2] = employeeIDTextBox.Text;


			ExcelWorksheet.Cells[10, 1] = "Giá sản phẩm và dịch vụ";
			ExcelWorksheet.Range[ExcelWorksheet.Cells[10, 1], ExcelWorksheet.Cells[10, 2]].Merge();
			ExcelWorksheet.Rows[10].RowHeight = 25;
			ExcelWorksheet.Cells[10, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			ExcelWorksheet.Cells[10, 1].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;

			ExcelWorksheet.Cells[11, 1] = "Danh mục";
			ExcelWorksheet.Cells[11, 2] = "Giá";

            

			ExcelWorksheet.Cells[12, 1] = $"Phòng {roomNumberCBBox.selectedValue}";
			ExcelWorksheet.Cells[12, 2] = PriceTextBox.Text;



			int lineInExcelTable = 13;


			foreach (DataGridViewRow row in ServiceDataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    string serviceName = row.Cells["TENDV"].Value.ToString();
                    string servicePrice = row.Cells["GIA"].Value.ToString();
                    ExcelWorksheet.Cells[lineInExcelTable, 1] = serviceName;
                    ExcelWorksheet.Cells[lineInExcelTable, 2] = servicePrice;
					lineInExcelTable++;
                }
            }

            ExcelWorksheet.Cells[lineInExcelTable, 1] = "Tổng tiền";
			ExcelWorksheet.Cells[lineInExcelTable++, 2] = Totallabel.Text;

            ExcelWorksheet.Cells[lineInExcelTable, 1] = "Ngày lập hóa đơn " + arriveTime;
			ExcelWorksheet.Range[ExcelWorksheet.Cells[lineInExcelTable, 1], ExcelWorksheet.Cells[lineInExcelTable, 2]].Merge();
			ExcelWorksheet.Cells[lineInExcelTable, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			ExcelWorksheet.Cells[lineInExcelTable, 1].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;

			for (int i = 3; i <= lineInExcelTable; i++)
            {
				ExcelWorksheet.Cells[i, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				ExcelWorksheet.Cells[i, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			}
			
            // 1. Open save dialog
		    SaveFileDialog saveFileDialog = new SaveFileDialog();

			// 2. File excel displayed
			saveFileDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";

			// 3. Filter to get all .xls extension
			saveFileDialog.FilterIndex = 1;


			saveFileDialog.FileName = $"{customerName}.xlsx";
            try {
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					// 4. Save Dialog
					ExcelWorkbook.SaveAs(saveFileDialog.FileName);

					(new CustomMessageBox("Xác nhận", "Lưu hóa đơn thành công!")).ShowDialog();
				}
			}
			catch 
            {
				(new CustomMessageBox("Thông báo", $"{customerName}.xlsx đang trong quá trình hoạt động. Đóng file và thử lại")).ShowDialog();
			}
            finally
            {
			    // 5. Close
			    ExcelWorkbook.Close();
			    ExcelApp.Quit();
            }

		}

		public ReservationForm()
        {
            currentState = "ADD";
            InitializeComponent();
        }

        private void ServiceDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* btnAddService.Text = "Remove Service";
            string madv = ServiceDataGrid.CurrentRow.Cells[0].Value.ToString();
            db.MutateData("delete CHITIETHOADON WHERE MADV='" + madv + "'");
            updadedatagrid();*/
        }

        public ReservationForm(string billID,string guestID)
        {
            currentState = "ADD";
            this.guestID = guestID;
            this.billID = billID;
            InitializeComponent();
        }
        public ReservationForm(string billID)
        {
            currentState = "UPDATE";
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = db.GetData("SELECT * FROM ReservationView WHERE BillID = '" + billID + "'");
            this.billID = billID;
            this.guestID = dt.Rows[0].Field<string>("GuestID");
            this.name = dt.Rows[0].Field<string>("Name");
            this.age = dt.Rows[0].Field<int>("Age");
            this.address = dt.Rows[0].Field<string>("Address");
            this.phoneNumber = dt.Rows[0].Field<string>("PhoneNumber");
            this.roomNumber = dt.Rows[0].Field<int>("RoomNumber");
            this.arriveTime= dt.Rows[0].Field<DateTime>("ArriveTime");
            this.employeeid = dt.Rows[0].Field<string>("EmployeeID");
            object leaveTimeValue = dt.Rows[0]["LeaveTime"];
       
            if (leaveTimeValue != DBNull.Value)
            {
                this.leaveTime = dt.Rows[0].Field<DateTime>("LeaveTime");
                checkngaydi = true;
            }
            else
            {
                // Xử lý trường hợp cột "LeaveTime" có giá trị null ở đây.
                // Ví dụ: this.leaveTime = DateTime.MinValue; hoặc làm gì đó tùy vào nhu cầu của bạn.
            }
            object totalMoneyValue = dt.Rows[0]["TOTALMONEY"];
            if (totalMoneyValue != DBNull.Value)
            {
                this.total = Convert.ToDouble(totalMoneyValue);
            }
            else
            {
               
            }
            InitializeComponent();
        }
        private void ValidateNumber(object sender, EventArgs e)
        {
            BunifuMaterialTextbox t = (BunifuMaterialTextbox)sender;
            if (!int.TryParse(t.Text, out int result))
            {
                CustomMessageBox a = new CustomMessageBox("Error", "hãy nhập số nguyên ");
                t.Focus();
            }
        }
        private void updadedatagrid()
        {
            ServiceDataGrid.DataSource = db.GetData("SELECT MADV,TENDV,GIA FROM ServiceView WHERE MAHD = N'" + billID + "'");
         
        }

     

        private void closeReservationFormBtn_Click(object sender, EventArgs e)
        {
            /*   CustomMessageBox c = new CustomMessageBox("Xác nhận","Bạn có chắc chắn muốn thoát chương trình","Yes","No");
               c.YesClicked += (s, args) =>
               {
                   this.Close();
               };

               c.YesClicked += (s, args) =>
               {
                   return;  
               };
               c.ShowDialog();*/
            this.Close();
        }
      /*  private void dataAdded()
        {
            DataAdded?.Invoke(this, EventArgs.Empty);
        }*/
        private void guestFormButton_Click(object sender, EventArgs e)
        {
       
            if (nameTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Tên Khách Hàng");
                c.ShowDialog();
                nameTextBox.Focus();
                return;
            }
            if (ageTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Tuổi Khách Hàng");
                c.ShowDialog();
                ageTextBox.Focus();
                return;
            }
            if (addressTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập Địa chỉ Khách Hàng");
                c.ShowDialog();
                addressTextBox.Focus();
                return;
            }
            if (PhoneNumberTextBox.Text.Trim() == "")
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập SĐT Khách Hàng");
                c.ShowDialog();
                PhoneNumberTextBox.Focus();
                return;
            }
            if (roomNumberCBBox.selectedIndex < 0)
            {
                CustomMessageBox c = new CustomMessageBox("error", "Hãy nhập số phòng");
                c.ShowDialog();
                roomNumberCBBox.Focus();
                return;
            }
            string arriveTime = arriveTimeDatepicker.Value.ToString("yyyy-MM-dd");
            string leavetime=LeaveTimePicker.Value.ToString("yyyy-MM-dd");
            //check sdt da ton tai chua
            System.Data.DataTable x = db.GetData("SELECT * FROM KHACHHANG WHERE SDT='" + PhoneNumberTextBox.Text + "'");
            if(x.Rows.Count == 0)
            {
            db.MutateData("INSERT INTO KHACHHANG VALUES(N'"+guestIDTxt.Text+"', N'"+addressTextBox.Text+"', N'"+ageTextBox.Text+"', N'"+ nameTextBox.Text+ "', '"+ PhoneNumberTextBox.Text + "',1)");
            }
            else
            {
                db.MutateData("UPDATE KHACHANG SET SOLANTHUE+=1 WHERE MAKH=N'" + guestIDTxt.Text + "'");
                guestIDTxt.Text=db.RenderID("SELECT MAKH FROM KHACHHANG  WHERE SDT='" + PhoneNumberTextBox.Text + "'");
            }
            //chia 2 truong hop nhap ngay di hoac k
            if (checkngaydi)
            {
                db.MutateData("INSERT INTO HOADON (MAHD, NGAYDEN,NGAYDI, MANV, MAKH) VALUES(N'" + BillIDLabel.Text + "',N'" + arriveTime + "',N'" + leavetime + "',N'" + Login.MaNV + "',N'" + guestIDTxt.Text + "')");
            }
            else
            {
                db.MutateData("INSERT INTO HOADON (MAHD, NGAYDEN, MANV, MAKH) VALUES(N'" + BillIDLabel.Text+"',N'"+arriveTime+"',N'"+Login.MaNV+"',N'"+guestIDTxt.Text+"')");
            }
            // chia 2 truong hop nhap dich vu hoac k
            if (checkservice)
            {
                db.MutateData("INSERT INTO CHITIETHOADON (MACTHD, MAHD, MADV, SOPHONG,GIAPHONG, GIADV) VALUES( dbo.CreateMaCTHD(),'" + BillIDLabel.Text + "',dbo.RenderMaDV(N'" + ServiceCBBox.selectedValue.ToString() + "'),'"+roomNumberCBBox.selectedValue.ToString()+"','"+PriceTextBox.Text+"','"+PriceServiceTextbox.Text+"')");
            }
            else
            {
                db.MutateData("INSERT INTO CHITIETHOADON (MACTHD, MAHD,SOPHONG,GIAPHONG) VALUES( dbo.CreateMaCTHD(),'" + BillIDLabel.Text + "','" + roomNumberCBBox.selectedValue.ToString() + "','" + PriceTextBox.Text + "')");

            }
            updadedatagrid();
            total += float.Parse(PriceServiceTextbox.Text);
            Totallabel.Text = total.ToString();
            btnAddService.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ServiceCBBox.selectedIndex < 0)
            {
                CustomMessageBox a = new CustomMessageBox("Error", "Hãy nhập thông tin dịch vụ");
                a.ShowDialog();
                return;
            }
             System.Data.DataTable x= db.GetData("SELECT * FROM CHITIETHOADON WHERE MAHD=N'" + BillIDLabel.Text + "' AND MADV=dbo.RenderMaDV(N'"+ServiceCBBox.selectedValue.ToString()+"')");
            if (x.Rows.Count ==0)
            {
                db.MutateData("INSERT INTO CHITIETHOADON (MACTHD, MAHD, MADV, SOPHONG,GIAPHONG, GIADV) VALUES( dbo.CreateMaCTHD(),'" + BillIDLabel.Text + "',dbo.RenderMaDV(N'" + ServiceCBBox.selectedValue.ToString() + "'),'" +roomNumber + "','" + PriceTextBox.Text + "','" + PriceServiceTextbox.Text + "')");
                updadedatagrid();
            }
            else
            {
                CustomMessageBox a = new CustomMessageBox("Error", "Dịch vụ này đã nhập rồi");
                a.ShowDialog();
                return;
            }

        }

    }
}
