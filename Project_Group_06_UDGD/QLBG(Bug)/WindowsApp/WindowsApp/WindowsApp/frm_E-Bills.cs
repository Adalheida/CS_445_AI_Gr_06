using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frm_E_Bills : Form
    {
        public frm_E_Bills()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung();
        private void groupService_Enter(object sender, EventArgs e)
                {

                }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Orderdetails od = new frm_Orderdetails();
            od.ShowDialog();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM ORDERS";
            grid_databills.DataSource = lopChung.loadDL(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ODERS WHERE ORD_ID = .." +
               " '" + txt_timkiem.Text + "'";
            grid_databills.DataSource = lopChung.loadDL(sql);
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM ORDERS";
            DataTable dt = lopChung.loadDL(sql);
            grid_databills.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void frm_E_Bills_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ORDERS";
            grid_databills.DataSource = lopChung.loadDL(sql);
        }

        private void grid_databills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_databills.CellClick += grid_databills_CellClick;
        }

        private void grid_databills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = grid_databills.Rows[e.RowIndex];

                    txt_mahd.Text = row.Cells["ORD_ID"].Value.ToString();
                    txt_tenkhachhang.Text = row.Cells["CUSTOMER_NAME"].Value.ToString();
                    txt_sdtkh.Text = row.Cells["CUSTOMER_PHONE"].Value.ToString();
                    txt_manhanvien.Text = row.Cells["NHANVIEN"].Value.ToString();
                    txt_tratruoc.Text = row.Cells["PAID_AMOUNT"].Value.ToString();
                    txt_conlai.Text = row.Cells["CONLAI"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Có lỗi khi chọn sản phẩm: {ex.Message}");
            }
        }
    }
}
