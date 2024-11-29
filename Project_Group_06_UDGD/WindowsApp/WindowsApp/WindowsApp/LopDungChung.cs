using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp
{
    internal class LopDungChung
    {
        SqlConnection conn;
        public LopDungChung()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Duy Tân\Năm 4\Đồ án chuyên ngành_CS445\Gruop-06\Project_Group_06_UDGD\WindowsApp\WindowsApp\WindowsApp\QuanLyBanGiay.mdf;Integrated Security=True";
            conn = new SqlConnection(chuoikn);
        }

        public object LayGiaTri(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }

        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }

        public DataTable loadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        internal int ThemSuaXoa(object sql)
        {
            throw new NotImplementedException();
        }
    }
}
