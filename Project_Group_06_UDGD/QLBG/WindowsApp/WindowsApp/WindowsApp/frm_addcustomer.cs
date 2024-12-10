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
    public partial class frm_addcustomer : Form
    {
        public frm_addcustomer()
        {
            InitializeComponent();
        }

        LopDungChung lopChung = new LopDungChung();

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO [USER] (USER_ID, NAME, PHONE, ROLE_ID, STA_ID ) VALUES ( "
            + "'" + txt_makhachhang.Text + "', "
            + "'" + txt_tenkhachhang.Text + "',"
            + "'" + txt_sdtkhachhang.Text + "', "
            + "'" + cb_vaitro.SelectedValue + "', "
            + "'" + cb_trangthai.SelectedValue +"' )";
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

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void frm_addcustomer_Load(object sender, EventArgs e)
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
            grid_customerdata.DataSource = lopChung.loadDL(sql);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [USER]";
            grid_customerdata.DataSource = lopChung.loadDL(sql);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE [USER] SET "
            + "NAME = '" + txt_tenkhachhang.Text + "', "
            + "PHONE = '" + txt_sdtkhachhang.Text + "', "
            + "ROLE_ID = '" + cb_vaitro.SelectedValue + "', "
            + "STA_ID = '" + cb_trangthai.SelectedValue + "'"
            + "WHERE USER_ID = '" + txt_makhachhang.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhập thành viên thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhập thành viên thất bại");
            }
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM [USER]";
            DataTable dt = lopChung.loadDL(sql);
            grid_customerdata.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE [USER] WHERE USER_ID = '" + txt_makhachhang.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa thành viên thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thành viên thất bại");
            }
        }

        private void cb_vaitro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
