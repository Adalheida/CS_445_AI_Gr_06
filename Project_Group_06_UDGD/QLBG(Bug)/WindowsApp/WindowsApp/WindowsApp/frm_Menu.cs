using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login loginform = new frm_login();
                loginform.Show();
                this.Hide();
            }
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            frm_addcustomer cus = new frm_addcustomer();
            cus.Show();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            frm_UserAdd uadd = new frm_UserAdd();
            uadd.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
           AdminDashBoard dab = new AdminDashBoard();
            dab.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminDashBoard1_Load(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, MouseEventArgs e)
        {
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            frm_addcategory ct = new frm_addcategory();
            ct.Show();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            frm_addproduct sp = new frm_addproduct();
            sp.Show();
        }

        private void btn_khohang_Click(object sender, EventArgs e)
        {
            frm_khohang kh = new frm_khohang();
            kh.Show();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
           frm_search tk = new frm_search();
            tk.Show();
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            frm_DatHang dh = new frm_DatHang();
            dh.Show();
        }

        private void btn_giaohang_Click(object sender, EventArgs e)
        {
            frm_giaohang gh = new frm_giaohang();
            gh.Show();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            frm_E_Bills tt = new frm_E_Bills();
            tt.Show();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            frm_bills hd = new frm_bills();
            hd.Show();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            frm_thongkebaocao tk = new frm_thongkebaocao();
            tk.Show();
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            frm_khuyenmai km = new frm_khuyenmai();
            km.Show();
        }

        private void btn_quydinh_Click(object sender, EventArgs e)
        {
            frm_quydinh qd = new frm_quydinh();
            qd.Show();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            frm_baocao bc = new frm_baocao();
            bc.Show();
        }
    }
}
