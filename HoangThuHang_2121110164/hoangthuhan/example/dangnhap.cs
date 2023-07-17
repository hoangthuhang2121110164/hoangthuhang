using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txtUser = txtUsername.Text.ToString();
            String txtPass = txtpassword.Text.ToString();
            if (txtUser == "hang" && txtPass == "1412")
            {
                Form1 objForm01 = new Form1();
                objForm01.ShowDialog();
            }
        }
    }
}
