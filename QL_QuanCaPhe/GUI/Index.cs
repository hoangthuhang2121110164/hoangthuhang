using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCaPhe.GUI
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            CategoryManagement categoryManagement = new CategoryManagement();
            categoryManagement.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Close();
            ThongTinNguoiDung thongTinNguoiDung = new ThongTinNguoiDung();
            thongTinNguoiDung.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
        }

        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
