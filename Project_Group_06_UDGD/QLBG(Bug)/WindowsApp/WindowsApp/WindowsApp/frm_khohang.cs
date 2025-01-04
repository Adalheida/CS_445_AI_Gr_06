using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frm_khohang : Form
    {
        public frm_khohang()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung();

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

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM INVENTORY";
            grid_datainventory.DataSource = lopChung.loadDL(sql);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM INVENTORY WHERE INV_ID = " +
               " '" + txt_timkiem.Text + "'";
            grid_datainventory.DataSource = lopChung.loadDL(sql);
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM INVENTORY";
            DataTable dt = lopChung.loadDL(sql);
            grid_datainventory.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void frm_khohang_Load(object sender, EventArgs e)
        {
            //string sql1 = "SELECT * FROM CATEGORIES";
            //cb_loaigiay.DataSource = lopChung.loadDL(sql1);
            //cb_loaigiay.DisplayMember = "CATE_NAME";
            //cb_loaigiay.ValueMember = "CATE_ID";

            //string sql2 = "SELECT * FROM BRAND";
            //cb_brand.DataSource = lopChung.loadDL(sql2);
            //cb_brand.DisplayMember = "BRD_NAME";
            //cb_brand.ValueMember = "BRD_ID";

            //string sql3 = "SELECT COLOR_ID FROM PRODUCT_VARIANT";
            //cb_mausac.DataSource = lopChung.loadDL(sql3);
            //cb_mausac.DisplayMember = "COLOR_ID";
            //cb_mausac.ValueMember = "COLOR_ID";

            //string sql4 = "SELECT SIZE FROM PRODUCT_VARIANT";
            //cb_size.DataSource = lopChung.loadDL(sql4);
            //cb_size.DisplayMember = "SIZE";
            //cb_size.ValueMember = "SIZE";

            string sql = "SELECT * FROM INVENTORY";
            grid_datainventory.DataSource = lopChung.loadDL(sql);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO INVENTORY (INV_ID, IBRAND, ISIZE, ICOLOR, STOCK, CREATE_AT) VALUES ( "
            + "'" + txt_mank.Text + "', "
            + "'" + txt_loaigiay.Text + "',"
            + "'" + txt_size.Text + "', "
            + "'" + txt_mausac.Text + "', "
            + "'" + txt_soluong.Text + "', "
            + "'" + date_ngaynhapkho.Value.ToString("yyyy-MM-dd") + "')";
            int kq = lopChung.ThemSuaXoa(sql, null);
            if (kq >= 0)
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE INVENTORY SET "
            + "IBRAND = '" + txt_loaigiay.Text + "', "
            + "STOCK = '"+ txt_soluong.Text +"', "
            + "ISIZE = '" + txt_size.Text + "', "
            + "ICOLOR = '" + txt_mausac.Text + "', "
            + "CREATE_AT = '" + date_ngaynhapkho.Value.ToString("yyyy-MM-dd") + "'"
            + "WHERE INV_ID = '" + txt_mank.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql,null);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhập thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE INVENTORY WHERE INV_ID = '" + txt_mank.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql, null);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
