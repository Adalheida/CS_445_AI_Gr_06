using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frm_search : Form
    {
        public frm_search()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung();

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tensanpham = txt_tengiay.Text;
            string brand = cb_brand.SelectedItem.ToString();
            int size = Convert.ToInt32(cb_size.SelectedValue);
            string mausac = cb_mausac.SelectedItem.ToString();
            string price = txt_price.Text;

            frm_DatHang dhang = new frm_DatHang(tensanpham, brand,size,mausac, price);
            dhang.Show();
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PRODUCT WHERE PROD_NAME = " +
                " '" + txt_tengiay.Text + "'";
            grid_datasearch.DataSource = lopChung.loadDL(sql);
        }

        private void frm_addproduct_Load(object sender, EventArgs e)
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

            //string sql = "SELECT PROD_ID, PROD_NAME, CATE_ID, BRD_ID,PRICE,COLOR_ID,SIZE,CREATE_AT FROM PRODUCT";
            //grid_datasearch.DataSource = lopChung.loadDL(sql);
            
        }
        //private void LoadData()
        //{
        //    string query = "SELECT * FROM PRODUCT";
        //    grid_datasearch.DataSource = lopChung.loadDL(query);
        //    //string sql = "SELECT * FROM PRODUCT";
        //    //DataTable dt = lopChung.loadDL(sql);
        //    //grid_datasearch.DataSource = dt;       // Đặt DataSource cho GridView
        //}

        private void btn_dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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


        private void LoadDataIntoGridView()
        {
            string sql = @"
            SELECT 
                p.PROD_ID, 
                p.PROD_NAME, 
                c.CATE_NAME, 
                b.BRD_NAME, 
                p.PRICE, 
                pv.COLOR_ID, 
                pv.SIZE, 
                p.CREATE_AT, 
                p.STOCK 
            FROM PRODUCT p
            LEFT JOIN CATEGORIES c ON p.CATE_ID = c.CATE_ID
            LEFT JOIN BRAND b ON p.BRD_ID = b.BRD_ID
            LEFT JOIN PRODUCT_VARIANT pv ON p.PROD_ID = pv.PROD_ID";

            grid_datasearch.DataSource = lopChung.loadDL(sql);
        }

        private void grid_datasearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_datasearch.CellClick += Grid_datasearch_CellClick;
        }

        private void Grid_datasearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = grid_datasearch.Rows[e.RowIndex];

                    txt_tengiay.Text = row.Cells["PROD_NAME"].Value.ToString();
                    txt_price.Text = row.Cells["PRICE"].Value.ToString();
                    cb_brand.SelectedValue = row.Cells["BRD_ID"].Value.ToString();
                    cb_size.SelectedValue = row.Cells["SIZE"].Value.ToString();
                    cb_mausac.SelectedValue = row.Cells["COLOR_ID"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Có lỗi khi chọn sản phẩm: {ex.Message}");
            }
        }

        private void frm_search_Load(object sender, EventArgs e)
        {

            string sql2 = "SELECT * FROM BRAND";
            cb_brand.DataSource = lopChung.loadDL(sql2);
            cb_brand.DisplayMember = "BRD_NAME";
            cb_brand.ValueMember = "BRD_ID";

            string sql3 = "SELECT COLOR_ID FROM PRODUCT_VARIANT";
            cb_mausac.DataSource = lopChung.loadDL(sql3);
            cb_mausac.DisplayMember = "COLOR_ID";
            cb_mausac.ValueMember = "COLOR_ID";

            string sql4 = "SELECT SIZE FROM PRODUCT_VARIANT";
            cb_size.DataSource = lopChung.loadDL(sql4);
            cb_size.DisplayMember = "SIZE";
            cb_size.ValueMember = "SIZE";

            //string sql = "SELECT * FROM PRODUCT";
            //grid_datasearch.DataSource = lopChung.loadDL(sql);
            LoadDataIntoGridView();
        }
    }
}
