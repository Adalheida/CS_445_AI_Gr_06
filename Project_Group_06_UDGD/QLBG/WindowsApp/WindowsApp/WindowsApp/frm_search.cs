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

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_DatHang dhang = new frm_DatHang();
            dhang.Show();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "SELECT PROD_ID, PROD_NAME, CATE_ID, BRD_ID, PRICE, COLOR_ID, STOCK FROM PRODUCT WHERE PROD_NAME = .." +
                " '" + txt_tengiay.Text + "'";
            grid_datasearch.DataSource = lopChung.loadDL(sql);
        }

        private void frm_addproduct_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM CATEGORIES";
            cb_loaigiay.DataSource = lopChung.loadDL(sql1);
            cb_loaigiay.DisplayMember = "CATE_NAME";
            cb_loaigiay.ValueMember = "CATE_ID";

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

            string sql = "SELECT PROD_ID, PROD_NAME, CATE_ID, BRD_ID,PRICE,COLOR_ID,SIZE,CREATE_AT FROM PRODUCT";
            grid_datasearch.DataSource = lopChung.loadDL(sql);
        }
        private void LoadData()
        {
            string sql = "SELECT PROD_ID, PROD_NAME, CATE_ID, BRD_ID, PRICE, COLOR_ID, STOCK FROM PRODUCT";
            DataTable dt = lopChung.loadDL(sql);
            grid_datasearch.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void btn_dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
