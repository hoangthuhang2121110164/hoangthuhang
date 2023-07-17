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
    public partial class Form4 : Form
       
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            btMul.Click += new EventHandler(btMul_Click);
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            btEquals.Click += new EventHandler(btEquals_Click);
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            bt0.Click += new EventHandler(bt0_Click);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            bt1.Click += new EventHandler(bt1_Click);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            bt2.Click += new EventHandler(bt2_Click);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            bt3.Click += new EventHandler(bt3_Click);
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            btPlus.Click += new EventHandler(btPlus_Click);
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            btBang.Click += new EventHandler(btBang_Click);
        }
    }
}
