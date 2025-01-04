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
    public partial class frm_khuyenmai : Form
    {
        public frm_khuyenmai()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung();
        private void date_ngaytao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DISSCOUNTS";
            grid_datadiscount.DataSource = lopChung.loadDL(sql);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO DISSCOUNTS (DC_ID, DC_NAME, DC_VALUE, STA_ID, [START], [END]) VALUES ( "
            + "'" + txt_makm.Text + "', "
            + "'" + txt_tenkm.Text + "',"
            + "'" + txt_discount.Text + "',"
            + "'" + cb_trangthai.SelectedValue + "',"
            + "'" + date_ngaybatdau.Value.ToString("yyyy-MM-dd") + "',"
            + "'" + date_ngayketthuc.Value.ToString("yyyy-MM-dd") + "')";
            int kq = lopChung.ThemSuaXoa(sql, null);
            if (kq >= 0)
            {
                MessageBox.Show("Thêm mới khuyến mãi thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm mới khuyến mãi thất bại");
            }
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM DISSCOUNTS";
            DataTable dt = lopChung.loadDL(sql);
            grid_datadiscount.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE DISSCOUNTS SET "
            + "DC_NAME = '" + txt_tenkm.Text + "', "
            + "DC_VALUE = '" + txt_discount.Text + "', "
            + "STA_ID = '" + cb_trangthai.SelectedValue + "',"
            + "[START] = '" + date_ngaybatdau.Value.ToString("yyyy-MM-dd") + "',"
            + "[END] = '" + date_ngayketthuc.Value.ToString("yyyy-MM-dd") + "'"
            + "WHERE DC_ID = '" + txt_makm.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql, null);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhập khuyến mãi thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhập khuyến mãi thất bại");
            }
        }

        private void frm_khuyenmai_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM STATUS";
            cb_trangthai.DataSource = lopChung.loadDL(sql1);
            cb_trangthai.DisplayMember = "STA_DESC";
            cb_trangthai.ValueMember = "STA_ID";

            string sql = "SELECT * FROM DISSCOUNTS";
            grid_datadiscount.DataSource = lopChung.loadDL(sql);
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
        private void btn_clear_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DISSCOUNTS WHERE DC_ID = .." +
               " '" + txt_timkiem.Text + "'";
            grid_datadiscount.DataSource = lopChung.loadDL(sql);
        }
    }
}
