using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsApp
{
    public partial class frm_bills : Form
    {
        public frm_bills()
        {
            InitializeComponent();
        }

        LopDungChung_2 lopChung2 = new LopDungChung_2();

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DATHHANG";
            grid_dataorders.DataSource = lopChung2.loadDL_2(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DATHANG WHERE DH_ID = " +
                " '" + txt_timkiem.Text + "'";
            grid_dataorders.DataSource = lopChung2.loadDL_2(sql);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM DATHANG";
            DataTable dt = lopChung2.loadDL_2(sql);
            grid_dataorders.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void frm_bills_Load(object sender, EventArgs e)
        {
            //string sql2 = "SELECT * FROM STATUS WHERE STA_DESC IN ('Đã Thanh Toán', 'Chưa Thanh Toán')";
            string sql2 = "SELECT * FROM STATUS";
            cb_trangthai.DataSource = lopChung2.loadDL_2(sql2);
            cb_trangthai.DisplayMember = "STA_DESC";
            cb_trangthai.ValueMember = "STA_ID";

            string sql = "SELECT DH_ID, PROD_NAME, SIZE, COLOR_ID, CUSTOMER_NAME,CUSTOMER_SDT, CUSTOMER_ADDRESS, STOCK, PTTT, TOTAL_PRICE FROM DATHANG";
            grid_dataorders.DataSource = lopChung2.loadDL_2(sql);
        }

        private void btn_chitiethd_Click(object sender, EventArgs e)
        {
            
                frm_E_Bills eb = new frm_E_Bills();
                eb.ShowDialog();
            
        }

        private void btn_cndonhang_Click(object sender, EventArgs e)
        {
            int tratruoc;
            float price;

            // Kiểm tra dữ liệu đầu vào
            if (!int.TryParse(txt_tratruoc.Text, out tratruoc) || tratruoc <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }

            if (!float.TryParse(txt_thanhtien.Text, out price) || price <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm hợp lệ.");
                return;
            }

            if (cb_trangthai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.");
                return;
            }

            float total_price = price - tratruoc;

            try
            {
                // Câu lệnh SQL sử dụng tham số
                string sql = @"
                    INSERT INTO ORDERS (
                        ORD_ID, NHANVIEN, PROD_ID,  CUSTOMER_NAME, CUSTOMER_PHONE, ORD_DATE, STA_ID, TOTAL_PRICE, PAID_AMOUNT, CONLAI
                    ) VALUES (
                        @ORD_ID, @NHANVIEN, @PROD_ID, @CUSTOMER_NAME, @CUSTOMER_PHONE, @ORD_DATE, 
                        @STA_ID, @TOTAL_PRICE, @PAID_AMOUNT, @CONLAI)";

                // Tạo danh sách tham số
                var parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@ORD_ID", txt_mahoadon.Text.Trim()),
                        new SqlParameter("@NHANVIEN", txt_manhanvien.Text.Trim()),
                        new SqlParameter("@PROD_ID", txt_masanpham.Text.Trim()),
                        new SqlParameter("@CUSTOMER_NAME", txt_khachhang.Text.Trim()),
                        new SqlParameter("@CUSTOMER_PHONE", txt_sdtkhach.Text.Trim()),
                        new SqlParameter("@ORD_DATE", DateTime.Now),
                        new SqlParameter("@STA_ID", cb_trangthai.SelectedValue),
                        new SqlParameter("@TOTAL_PRICE", txt_thanhtien.Text.Trim()),
                        new SqlParameter("@PAID_AMOUNT", txt_tratruoc.Text.Trim()),
                        new SqlParameter("@CONLAI", total_price)
                    };

                // Gọi phương thức thực thi SQL
                int kq = lopChung2.ThemSuaXoa_2(sql, parameters);
                if (kq > 0)
                {
                    MessageBox.Show("Xác nhận thành công");
                    LoadData(); // Tải lại dữ liệu giỏ hàng
                }
                else
                {
                    MessageBox.Show("Xác nhận thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void grid_dataorders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_dataorders.CellClick += grid_dataorders_CellClick;
        }

        private void grid_dataorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = grid_dataorders.Rows[e.RowIndex];

                    txt_khachhang.Text = row.Cells["CUSTOMER_NAME"].Value.ToString();
                    txt_sdtkhach.Text = row.Cells["CUSTOMER_SDT"].Value.ToString();
                    txt_thanhtien.Text = row.Cells["TOTAL_PRICE"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Có lỗi khi chọn sản phẩm: {ex.Message}");
            }
        }
    }
}
