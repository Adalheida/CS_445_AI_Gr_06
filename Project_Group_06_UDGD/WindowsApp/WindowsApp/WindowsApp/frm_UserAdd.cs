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

        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO [USER] (USER_ID, NAME, PHONE, ROLE_ID, STA_ID ) VALUES ( "
            + "'" + txt_makhachhang.Text + "', "
            + "'" + txt_tenkhachhang.Text + "',"
            + "'" + txt_sdtkhachhang.Text + "', "
            + "'" + cb_vaitro.SelectedValue + "', "
            + "'" + cb_trangthai.SelectedValue + "' )";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 0)
            {
                MessageBox.Show("Thêm mới khách hàng thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm mới khách hàng thất bại");
            }
        }
    }
}
