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
    public partial class frm_payments : Form
    {
        public frm_payments()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {


            frm_printbills pb = new frm_printbills();
            pb.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frm_payments_Load(object sender, EventArgs e)
        {
            string sql = "SELECT PAY_METHOD FROM PAYMENTS";
            cb_phuongthuctt.DataSource = lopChung.loadDL(sql);
            cb_phuongthuctt.DisplayMember = "PAY_METHOD";
            cb_phuongthuctt.ValueMember = "PAY_METHOD";

            string sql1 = "SELECT DC_NAME FROM DISSCOUNTS";
            cb_magiamgia.DataSource = lopChung.loadDL(sql1);
            cb_magiamgia.DisplayMember = "DC_NAME";
            cb_magiamgia.ValueMember = "DC_NAME";


        }
    }
}
