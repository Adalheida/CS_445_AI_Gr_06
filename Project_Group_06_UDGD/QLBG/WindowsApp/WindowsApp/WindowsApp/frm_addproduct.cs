using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frm_addproduct : Form
    {
        public frm_addproduct()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung(); 
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
            grid_dataproducts.DataSource = lopChung.loadDL(sql);
        }

        private void LoadData()
        {
            string sql = "SELECT PROD_ID, PROD_NAME, CATE_ID, BRD_ID,PRICE,COLOR_ID,SIZE,CREATE_AT FROM PRODUCT";
            DataTable dt = lopChung.loadDL(sql);
            grid_dataproducts.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void grid_dataproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO PRODUCT (PROD_ID, PROD_NAME, PRICE, CATE_ID, BRD_ID, COLOR_ID, SIZE, CREATE_AT ) VALUES ( "
            + "'" + txt_magiay.Text + "', "
            + "'" + txt_tengiay.Text + "',"
            + "'" + txt_giaban.Text + "', "
            + "'" + cb_loaigiay.SelectedValue + "', "
            + "'" + cb_brand.SelectedValue + "', "
            + "'" + cb_mausac.SelectedValue + "', "
            + "'" + cb_size.SelectedValue + "', "
            + "'" + date_ngaytao.Value.ToString("yyyy-MM-dd") + "' )";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 0)
            {
                MessageBox.Show("Thêm mới sản phẩm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm mới sản phẩm thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE PRODUCT SET "
            + "PROD_NAME = '" + txt_tengiay.Text + "', "
            + "PRICE = '" + txt_giaban.Text + "', "
            + "CATE_ID = '" + cb_loaigiay.SelectedValue + "', "
            + "BRD_ID = '" + cb_brand.SelectedValue + "', "
            + "COLOR_ID = '" + cb_mausac.SelectedValue + "', "
            + "SIZE = '" + cb_size.SelectedValue + "', "
            + "CREATE_AT = '" + date_ngaytao.Value.ToString("yyyy-MM-dd") + "', "
            + "WHERE PROD_ID = '" + txt_magiay.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhập sản phẩm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhập sản phẩm thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE PRODUCT WHERE PROD_ID = '" + txt_magiay.Text + "'";
            int kq = lopChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT PROD_ID, PROD_NAME, CATE_ID, BRD_ID,PRICE,COLOR_ID,SIZE,CREATE_AT FROM CATEGORIES";
            grid_dataproducts.DataSource = lopChung.loadDL(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Chọn ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    string imageDirectory = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(imageDirectory))
                    {
                        Directory.CreateDirectory(imageDirectory);
                    }
                    string imageFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);

                    string imagePath = Path.Combine(imageDirectory, imageFileName);

                    File.Copy(selectedImagePath, imagePath);

                    if (File.Exists(imagePath))
                    {
                        MessageBox.Show($"Ảnh đã được lưu thành công tại: {imagePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể lưu ảnh. Vui lòng thử lại.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
