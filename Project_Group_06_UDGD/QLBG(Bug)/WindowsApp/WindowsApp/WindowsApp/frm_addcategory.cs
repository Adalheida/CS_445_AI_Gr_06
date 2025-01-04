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
    public partial class frm_addcategory : Form
    {
        public frm_addcategory()
        {
            InitializeComponent();
        }

        LopDungChung lopChung = new LopDungChung();
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CATEGORIES (CATE_ID, CATE_NAME, DESCRIPTION, CREATE_AT) VALUES ( "
            + "'" + txt_madanhmuc.Text + "', "
            + "'" + txt_tendanhmuc.Text + "',"
            + "'" + txt_mota.Text + "', "
            + "'" + date_ngaytao.Value.ToString("yyyy-MM-dd") + "' )";
            int kq = lopChung.ThemSuaXoa(sql, null);
            if (kq >= 0)
            {
                MessageBox.Show("Thêm mới danh mục thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm mới danh mục thất bại");
            }
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM CATEGORIES";
            DataTable dt = lopChung.loadDL(sql);
            grid_dataproducts.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CATEGORIES SET "
            + "CATE_NAME = '" + txt_tendanhmuc.Text + "', "
            + "DESCRIPTION = '" + txt_mota.Text + "', "
            + "CREATE_AT = '" + date_ngaytao.Value.ToString("yyyy-MM-dd") + "'"
            + "WHERE CATE_ID = '" + txt_madanhmuc.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql,null);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhập danh mục thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhập danh mục thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE CATEGORIES WHERE CATE_ID = '" + txt_madanhmuc.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql, null);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa danh mục thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại");
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CATEGORIES";
            grid_dataproducts.DataSource = lopChung.loadDL(sql);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_addcategory_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CATEGORIES";
            grid_dataproducts.DataSource = lopChung.loadDL(sql);
        }

        private void RefreshForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }

                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }

                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }

                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void txt_mota_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
