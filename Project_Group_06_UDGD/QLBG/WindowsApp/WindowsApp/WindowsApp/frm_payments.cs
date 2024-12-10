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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            frm_printbills pb = new frm_printbills();
            pb.ShowDialog();
        }
    }
}
