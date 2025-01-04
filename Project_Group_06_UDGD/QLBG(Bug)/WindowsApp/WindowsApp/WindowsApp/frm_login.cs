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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung();

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT (*) FROM [USER] WHERE USER_ID = '" + txt_username.Text + "'AND PASSWORD = '" + txt_password.Text + "'";
            int kq = (int)lopChung.LayGiaTri(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_Menu main = new frm_Menu();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
