using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            //string sql = "SELECT PROD_ID, PROD_NAME, CATE_ID, BRD_ID,PRICE,COLOR_ID,SIZE,CREATE_AT, STOCK FROM PRODUCT";
            string sqlProducts = @"
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
             grid_dataproducts.DataSource = lopChung.loadDL(sqlProducts);
            //grid_dataproducts.DataSource = lopChung.loadDL(sqlProducts);

        }

        //private void LoadData()
        //{
        //    string sql = "SELECT * FROM PRODUCT";
        //    DataTable dt = lopChung.loadDL(sql);
        //    grid_dataproducts.DataSource = dt;       // Đặt DataSource cho GridView
        //}

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

        private void LoadDataIntoGridView()
        {
            string query = "SELECT * FROM PRODUCT";
            grid_dataproducts.DataSource = lopChung.loadDL(query);
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO PRODUCT (PROD_ID, PROD_NAME, PRICE, CATE_ID, BRD_ID, COLOR_ID, SIZE, CREATE_AT, STOCK ) VALUES ( "
            //+ "'" + txt_magiay.Text + "', "
            //+ "'" + txt_tengiay.Text + "',"
            //+ "'" + txt_giaban.Text + "', "
            //+ "'" + cb_loaigiay.SelectedValue + "', "
            //+ "'" + cb_brand.SelectedValue + "', "
            //+ "'" + cb_mausac.SelectedValue + "', "
            //+ "'" + cb_size.SelectedValue + "', "
            //+ "'" + date_ngaytao.Value.ToString("yyyy-MM-dd") + "',"
            //+ "'" + txt_soluong.Text + "')";
            //int kq = lopChung.ThemSuaXoa(sql);
            //if (kq >= 0)
            //{
            //    MessageBox.Show("Thêm mới sản phẩm thành công");
            //    LoadData();
            //}
            //else
            //{
            //    MessageBox.Show("Thêm mới sản phẩm thất bại");
            //}


            try
            {
                string productId = txt_magiay.Text.Trim();
                string productName = txt_tengiay.Text.Trim();
                double price = Convert.ToDouble(txt_giaban.Text.Trim());
                int stock = Convert.ToInt32(txt_soluong.Text.Trim());
                string categoryId = cb_loaigiay.SelectedValue.ToString();
                string brandId = cb_brand.SelectedValue.ToString();
                int size = Convert.ToInt32(cb_size.SelectedValue.ToString());
                string colorId = cb_mausac.SelectedValue.ToString();

                string insertProduct = $"INSERT INTO PRODUCT (PROD_ID, PROD_NAME, CATE_ID, BRD_ID, PRICE, STOCK, CREATE_AT) " +
                                        $"VALUES ('{productId}', '{productName}', '{categoryId}', '{brandId}', {price}, {stock}, GETDATE())";

                if (lopChung.ThemSuaXoa(insertProduct, null) > 0)
                {
                    string insertProductVariant = $"INSERT INTO PRODUCT_VARIANT (PDV_ID, PROD_ID, SIZE, COLOR_ID, STOCK) " +
                                                    $"VALUES ('{Guid.NewGuid()}', '{productId}', {size}, '{colorId}', {stock})";

                    if (lopChung.ThemSuaXoa(insertProductVariant, null) > 0)
                    {
                        MessageBox.Show("Sản phẩm đã được thêm thành công!");
                        LoadDataIntoGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //string sql = "UPDATE PRODUCT SET "
            //+ "PROD_NAME = '" + txt_tengiay.Text + "', "
            //+ "PRICE = '" + txt_giaban.Text + "', "
            //+ "CATE_ID = '" + cb_loaigiay.SelectedValue + "', "
            //+ "BRD_ID = '" + cb_brand.SelectedValue + "', "
            //+ "COLOR_ID = '" + cb_mausac.SelectedValue + "', "
            //+ "SIZE = '" + cb_size.SelectedValue + "', "
            //+ "CREATE_AT = '" + date_ngaytao.Value.ToString("yyyy-MM-dd") + "', "
            //+ "STOCK = '" + txt_soluong.Text + "'"
            //+ "WHERE PROD_ID = '" + txt_magiay.Text + "'";
            //int kq = lopChung.ThemSuaXoa(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Cập nhập sản phẩm thành công");
            //    LoadData();
            //}
            //else
            //{
            //    MessageBox.Show("Cập nhập sản phẩm thất bại");
            //}

            try
            {
                string productId = txt_magiay.Text.Trim();

                if (string.IsNullOrEmpty(productId))
                {
                    MessageBox.Show("Vui lòng nhập Mã giày.");
                    return;
                }

                string productName = txt_tengiay.Text.Trim();
                double price = Convert.ToDouble(txt_giaban.Text.Trim());
                int stock = Convert.ToInt32(txt_soluong.Text.Trim());
                string categoryId = cb_loaigiay.SelectedValue.ToString();
                string brandId = cb_brand.SelectedValue.ToString();

                if (stock < 0)
                {
                    MessageBox.Show("Số lượng cần thêm phải lớn hơn hoặc bằng 0.");
                    return;
                }

                // Lấy số lượng hiện tại của sản phẩm
                string getStockQuery = $"SELECT STOCK FROM PRODUCT WHERE PROD_ID = '{productId}'";
                DataTable dt = lopChung.loadDL(getStockQuery);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.");
                    return;
                }

                int currentStock = Convert.ToInt32(dt.Rows[0]["STOCK"]);
                int updatedStock = currentStock + stock; // Cộng dồn số lượng

                string updateProduct = $@"
                    UPDATE PRODUCT
                    SET PROD_NAME = '{productName}',
                        CATE_ID = '{categoryId}',
                        BRD_ID = '{brandId}',
                        PRICE = {price},
                        STOCK = {updatedStock}
                    WHERE PROD_ID = '{productId}'";

                if (lopChung.ThemSuaXoa(updateProduct, null) > 0)
                {
                    MessageBox.Show("Sửa sản phẩm thành công.");
                    LoadDataIntoGridView();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi sửa sản phẩm: {ex.Message}");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //string sql = "DELETE PRODUCT WHERE PROD_ID = '" + txt_magiay.Text + "'";
            //int kq = lopChung.ThemSuaXoa(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Xóa sản phẩm thành công");
            //    LoadData();
            //}
            //else
            //{
            //    MessageBox.Show("Xóa sản phẩm thất bại");
            //}
            try
            {
                string productId = txt_magiay.Text.Trim();

                if (string.IsNullOrEmpty(productId))
                {
                    MessageBox.Show("Vui lòng nhập Mã giày.");
                    return;
                }

                string deleteProduct = $"DELETE FROM PRODUCT WHERE PROD_ID = '{productId}'";

                if (lopChung.ThemSuaXoa(deleteProduct, null) > 0)
                {
                    MessageBox.Show("Sản phẩm đã được xóa.");
                    LoadDataIntoGridView();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi xóa sản phẩm: {ex.Message}");
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            string sqlProducts = @"
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
            grid_dataproducts.DataSource = lopChung.loadDL(sqlProducts);
            //string sql = "SELECT * FROM PRODUCT";
            //grid_dataproducts.DataSource = lopChung.loadDL(sql);
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

        private void grid_dataproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_dataproducts.CellClick += grid_dataproducts_CellClick;
        }
        private void Grid_dataproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = grid_dataproducts.Rows[e.RowIndex];

                    txt_magiay.Text = row.Cells["PROD_ID"].Value.ToString();
                    txt_tengiay.Text = row.Cells["PROD_NAME"].Value.ToString();
                    txt_giaban.Text = row.Cells["PRICE"].Value.ToString();
                    txt_soluong.Text = row.Cells["STOCK"].Value.ToString();

                    cb_loaigiay.SelectedValue = row.Cells["CATE_ID"].Value.ToString();
                    cb_brand.SelectedValue = row.Cells["BRD_ID"].Value.ToString();
                    cb_mausac.SelectedValue = row.Cells["COLOR_ID"].Value.ToString();
                    cb_size.SelectedValue = row.Cells["SIZE"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Có lỗi khi chọn sản phẩm: {ex.Message}");
            }
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


    }
}
