using QL_QuanCaPhe.BAL;
using QL_QuanCaPhe.DAL;
using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCaPhe.GUI
{
    public partial class CategoryManagement : Form
    {
        public string url = "";
        static int id;
        public CategoryManagement()
        {
            InitializeComponent();
        }
        public void reload()
        {
            dgvThongTin.DataSource = CategoryDAL.layDanhSach();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == null)
            {
                MessageBox.Show("Bạn nhập thiếu hoặc sai dữ liệu!");
            }
            else
            {
                Image img = pbImg.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                Category category = new Category();
                category.name = txtTen.Text;
                category.img = arr;
                CategoryBAL.addCategory(category);
                reload();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == null)
            {
                MessageBox.Show("Bạn nhập thiếu hoặc sai dữ liệu!");
            }
            else
            {
                Image img = pbImg.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                Category category = new Category();
                category.id = id;
                category.name = txtTen.Text;
                category.img = arr;
                CategoryBAL.updateCategory(category);
                reload();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CategoryBAL.deleteCategory(id);
            reload();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                id = int.Parse(dgvThongTin.Rows[index].Cells[0].Value.ToString());
                txtTen.Text = dgvThongTin.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = openFileDialog.FileName;
                pbImg.Image = Image.FromFile(url);
            }
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void CategoryManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.Show();
        }
    }
}
