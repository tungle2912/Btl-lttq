using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace HotelManager.pages
{
    public partial class Dashboard : Form
    {
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

        }
    }
}
