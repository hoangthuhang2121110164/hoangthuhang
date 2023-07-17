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
    public partial class taianh : Form
    {
        public taianh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh được chọn
                string imagePath = openFileDialog.FileName;

                // Hiển thị hình ảnh lên PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
