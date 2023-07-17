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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 objForm01 = new Form1();
            objForm01.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 objForm03 = new Form3();
            objForm03.ShowDialog();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            dangnhap objFormdangnhap = new dangnhap();
            objFormdangnhap.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            taianh objFormtaianh = new taianh();
            objFormtaianh.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form13 objForm13 = new Form13();
            objForm13.ShowDialog();
        }
    }
}
