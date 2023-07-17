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
    }
}
