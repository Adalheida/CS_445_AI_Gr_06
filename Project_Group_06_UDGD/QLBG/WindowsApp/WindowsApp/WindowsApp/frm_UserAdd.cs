using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsApp
{
    public partial class frm_UserAdd : Form
    {
        public frm_UserAdd()
        {
            InitializeComponent();
        }
        LopDungChung lopChung =new LopDungChung();   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_UserAdd_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM STATUS";
            cb_trangthai.DataSource = lopChung.loadDL(sql1);
            cb_trangthai.DisplayMember = "STA_DESC";
            cb_trangthai.ValueMember = "STA_ID";

            string sql2 = "SELECT * FROM ROLE";
            cb_vaitro.DataSource = lopChung.loadDL(sql2);
            cb_vaitro.DisplayMember = "DESCRIPTION";
            cb_vaitro.ValueMember = "ROLE_ID";

            string sql = "SELECT * FROM [USER]";
            grid_userdata.DataSource = lopChung.loadDL(sql);
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO [USER] (USER_ID,PASSWORD, NAME, PHONE, EMAIL, ROLE_ID, STA_ID ) VALUES ( "
            + "'" + txt_tendangnhap.Text + "', "
            + "'" + txt_matkhau.Text + "',"
            + "'" + txt_tennhanvien.Text + "', "
            + "'" + txt_sodienthoai.Text + "', "
            + "'" + txt_email.Text + "', "
            + "'" + cb_vaitro.SelectedValue + "', "
            + "'" + cb_trangthai.SelectedValue + "' )";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 0)
            {
                MessageBox.Show("Thêm mới nhân viên thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm mới nhân viên thất bại");
            }
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM [USER]";
            DataTable dt = lopChung.loadDL(sql);
            grid_userdata.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE [USER] SET "
            + "PASSWORD = '" + txt_matkhau.Text + "', "
            + "NAME = '" + txt_tennhanvien.Text + "', "
            + "PHONE = '" + txt_sodienthoai.Text + "', "
            + "EMAIL = '" + txt_email.Text + "', "
            + "ROLE_ID = '" + cb_vaitro.SelectedValue + "', "
            + "STA_ID = '" + cb_trangthai.SelectedValue + "', "
            + "WHERE USER_ID = '" + txt_tendangnhap.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhập nhân viên thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhập nhân viên thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE [USER] WHERE USER_ID = '" + txt_tennhanvien.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CATEGORIES";
            grid_userdata.DataSource = lopChung.loadDL(sql);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
