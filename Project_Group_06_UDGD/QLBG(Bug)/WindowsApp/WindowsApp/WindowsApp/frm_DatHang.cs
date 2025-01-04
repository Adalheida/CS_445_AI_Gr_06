using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frm_DatHang : Form
    {
        public frm_DatHang()
        {
            InitializeComponent();
        }
        public frm_DatHang(string tengiay, string brand, int size, string mausac, string price)
        {
            InitializeComponent();

            txt_tensanpham.Text = tengiay;
            cb_brand.SelectedValue = brand;
            cb_size.SelectedValue = size;
            cb_mausac.SelectedValue = mausac;
            txt_price.Text = price;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        LopDungChung_2 lopChung2 = new LopDungChung_2();
        private void button3_Click(object sender, EventArgs e)
        {
            frm_payments pm = new frm_payments();
            pm.ShowDialog();
        }

        private void cb_tensanpham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           this.Close();
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
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadData()
        {
            string sql = "SELECT * FROM DATHANG";
            DataTable dt = lopChung2.loadDL_2(sql);
            grid_shopping.DataSource = dt;       // Đặt DataSource cho GridView
        }

        private void frm_DatHang_Load(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM BRAND";
            cb_brand.DataSource = lopChung2.loadDL_2(sql2);
            cb_brand.DisplayMember = "BRD_NAME";
            cb_brand.ValueMember = "BRD_ID";

            string sql3 = "SELECT COLOR_ID FROM PRODUCT_VARIANT";
            cb_mausac.DataSource = lopChung2.loadDL_2(sql3);
            cb_mausac.DisplayMember = "COLOR_ID";
            cb_mausac.ValueMember = "COLOR_ID";

            string sql4 = "SELECT SIZE FROM PRODUCT_VARIANT";
            cb_size.DataSource = lopChung2.loadDL_2(sql4);
            cb_size.DisplayMember = "SIZE";
            cb_size.ValueMember = "SIZE";

            string sql5 = "SELECT PAY_METHOD FROM PAYMENTS";
            cb_phuongthuctt.DataSource = lopChung2.loadDL_2(sql5);
            cb_phuongthuctt.DisplayMember = "PAY_METHOD";
            cb_phuongthuctt.ValueMember = "PAY_METHOD";

            //string sql6 = "SELECT DC_NAME FROM DISSCOUNTS";
            //cb_magiamgia.DataSource = lopChung2.loadDL_2(sql6);
            //cb_magiamgia.DisplayMember = "DC_NAME";
            //cb_magiamgia.ValueMember = "DC_NAME";

            string sql = "SELECT DH_ID, PROD_NAME, SIZE, COLOR_ID, CUSTOMER_NAME, CUSTOMER_SDT, CUSTOMER_ADDRESS, STOCK, PTTT, TOTAL_PRICE FROM DATHANG";
            grid_shopping.DataSource = lopChung2.loadDL_2(sql);
        }


        private void btn_lammoi_Click_1(object sender, EventArgs e)
        {
            RefreshForm();
        }


        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
            int soluong;
            float price;

            if (!int.TryParse(txt_soluong.Text, out soluong) || soluong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }

            if (!float.TryParse(txt_price.Text, out price) || price <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm hợp lệ.");
                return;
            }

            if (cb_size.SelectedValue == null || cb_mausac.SelectedValue == null || cb_brand.SelectedValue == null || cb_phuongthuctt.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin Size, Màu sắc, Brand, và Phương thức thanh toán.");
                return;
            }

            float total_price = soluong * price;

            //try
            //{
            //    string sql = @"
            //        INSERT INTO DATHANG (
            //            DH_ID, PROD_NAME, SIZE, COLOR_ID, STOCK, BRD_ID, 
            //            CUSTOMER_NAME, CUSTOMER_SDT, CUSTOMER_ADDRESS, PTTT, TOTAL_PRICE
            //        ) VALUES (
            //            @DH_ID, @PROD_NAME, @SIZE, @COLOR_ID, @STOCK, @BRD_ID, 
            //            @CUSTOMER_NAME, @CUSTOMER_SDT, @CUSTOMER_ADDRESS, @PTTT, @TOTAL_PRICE)";

            //    var parameters = new List<SqlParameter>
            //        {
            //            new SqlParameter("@DH_ID", txt_madathang.Text.Trim()),
            //            new SqlParameter("@PROD_NAME", txt_tensanpham.Text.Trim()),
            //            new SqlParameter("@SIZE", cb_size.SelectedValue),
            //            new SqlParameter("@COLOR_ID", cb_mausac.SelectedValue),
            //            new SqlParameter("@STOCK", soluong),
            //            new SqlParameter("@BRD_ID", cb_brand.SelectedValue),
            //            new SqlParameter("@CUSTOMER_NAME", txt_tenkhachhang.Text.Trim()),
            //            new SqlParameter("@CUSTOMER_SDT", txt_sdtkhachhang.Text.Trim()),
            //            new SqlParameter("@CUSTOMER_ADDRESS", txt_diachi.Text.Trim()),
            //            new SqlParameter("@PTTT", cb_phuongthuctt.SelectedValue),
            //            new SqlParameter("@TOTAL_PRICE", total_price)
            //        };

            //    int kq = lopChung2.ThemSuaXoa_2(sql, parameters);
            //    if (kq > 0)
            //    {
            //        MessageBox.Show("Thêm sản phẩm thành công");
            //        LoadData();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm sản phẩm thất bại");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message);
            //}

            try
            {
                // 1. Thêm sản phẩm vào bảng DATHANG
                string sqlInsert = @"
                    INSERT INTO DATHANG (
                        DH_ID, PROD_NAME, SIZE, COLOR_ID, STOCK, BRD_ID, 
                        CUSTOMER_NAME, CUSTOMER_SDT, CUSTOMER_ADDRESS, PTTT, TOTAL_PRICE
                    ) VALUES (
                        @DH_ID, @PROD_NAME, @SIZE, @COLOR_ID, @STOCK, @BRD_ID, 
                        @CUSTOMER_NAME, @CUSTOMER_SDT, @CUSTOMER_ADDRESS, @PTTT, @TOTAL_PRICE)";

                    var parametersInsert = new List<SqlParameter>
                            {
                                new SqlParameter("@DH_ID", txt_madathang.Text.Trim()),
                                new SqlParameter("@PROD_NAME", txt_tensanpham.Text.Trim()),
                                new SqlParameter("@SIZE", cb_size.SelectedValue),
                                new SqlParameter("@COLOR_ID", cb_mausac.SelectedValue),
                                new SqlParameter("@STOCK", soluong),
                                new SqlParameter("@BRD_ID", cb_brand.SelectedValue),
                                new SqlParameter("@CUSTOMER_NAME", txt_tenkhachhang.Text.Trim()),
                                new SqlParameter("@CUSTOMER_SDT", txt_sdtkhachhang.Text.Trim()),
                                new SqlParameter("@CUSTOMER_ADDRESS", txt_diachi.Text.Trim()),
                                new SqlParameter("@PTTT", cb_phuongthuctt.SelectedValue),
                                new SqlParameter("@TOTAL_PRICE", total_price)
                            };

                int kqInsert = lopChung2.ThemSuaXoa_2(sqlInsert, parametersInsert);
                if (kqInsert > 0)
                {
                    // 2. Giảm số lượng sản phẩm trong bảng PRODUCT
                            string sqlUpdate = @"
                        UPDATE PRODUCT
                        SET STOCK = STOCK - @SOLUONG
                        WHERE PROD_NAME = @PROD_NAME
                        AND EXISTS (
                            SELECT 1 FROM PRODUCT_VARIANT 
                            WHERE PRODUCT_VARIANT.PROD_ID = PRODUCT.PROD_ID
                            AND SIZE = @SIZE
                            AND COLOR_ID = @COLOR_ID
                        )";

                    var parametersUpdate = new List<SqlParameter>
            {
                new SqlParameter("@SOLUONG", soluong),
                new SqlParameter("@PROD_NAME", txt_tensanpham.Text.Trim()),
                new SqlParameter("@SIZE", cb_size.SelectedValue),
                new SqlParameter("@COLOR_ID", cb_mausac.SelectedValue)
            };

                    int kqUpdate = lopChung2.ThemSuaXoa_2(sqlUpdate, parametersUpdate);

                    if (kqUpdate > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm và cập nhật số lượng thành công.");
                        LoadData(); // Tải lại dữ liệu giỏ hàng
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thành công, nhưng không thể cập nhật số lượng trong kho.");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            frm_payments pm = new frm_payments();
            pm.ShowDialog();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            frm_search sr = new frm_search();
            sr.ShowDialog();
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            frm_bills bl = new frm_bills();
            bl.ShowDialog();
        }
    }
}
