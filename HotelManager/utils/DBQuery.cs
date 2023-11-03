using System.Data.SqlClient;
using System.Data;
using System;

namespace HotelManager.utils
{
    internal class DBQuery
    {
        private string dataSource = "Data Source=LAPTOP-1SOFRQ1F\\TUNGLE;Initial Catalog=QLKS;Integrated Security=True";
        SqlConnection connection = null;

        public void OpenConnection()
        {
            connection = new SqlConnection(dataSource);
            if(connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if(connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // SELECT
        public DataTable GetData(string cmd)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public string RenderID(string cmd)
        {
            OpenConnection() ;
            SqlCommand c=new SqlCommand(cmd, connection);
            c.CommandType = CommandType.Text;
            string result=c.ExecuteScalar().ToString();
            CloseConnection();
            if (result != null ) // Kiểm tra xem kết quả không null và không phải là DBNull
            {
                return result.ToString();
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu trả về
                return "N/A"; // Hoặc bạn có thể trả về giá trị mặc định khác
            }
        }

        // INSERT, UPDATE, DELETE
        public void MutateData(string cmd)
        {
            OpenConnection();
            SqlCommand c = new SqlCommand(cmd, connection);
            c.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
