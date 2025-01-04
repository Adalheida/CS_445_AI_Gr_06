using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsApp
{
    internal class LopDungChung_2
    {
        private readonly string connectionString;

        public LopDungChung_2()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Duy Tân\Năm 4\Đồ án chuyên ngành_CS445\Gruop-06\Project_Group_06_UDGD\QLBG(Bug)\WindowsApp\WindowsApp\WindowsApp\QuanLyBanGiay.mdf"";Integrated Security=True";
        }

        // Phương thức lấy giá trị đơn
        public object LayGiaTri_2(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    return comm.ExecuteScalar();
                }
            }
        }

        // Phương thức thêm, sửa, xóa
        public int ThemSuaXoa_2(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        comm.Parameters.AddRange(parameters.ToArray());
                    }
                    return comm.ExecuteNonQuery();
                }
            }
        }

        // Phương thức tải dữ liệu
        public DataTable loadDL_2(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(comm))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
