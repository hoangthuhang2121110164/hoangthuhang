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
    public partial class ProductManagement : Form
    {
        public string url = "";
        public ProductManagement()
        {
            InitializeComponent();
        }

        public void reload()
        {
            dgvThongTin.DataSource = ProductDAL.layDanhSach();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            float a;
            if (txtTen.Text == null || nudSoLuong.Value == 0 || txtGia.Text == null || float.TryParse(txtGia.Text, out a) == false
                || txtMoTa.Text == null || cboLoaiSP.Text == null)
            {
                MessageBox.Show("Bạn nhập thiếu hoặc sai dữ liệu!");
            }
            else
            {
                Image img = pbImg.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                Product product = new Product();
                product.name = txtTen.Text;
                product.description = txtMoTa.Text;
                product.quantity = Convert.ToInt32(nudSoLuong.Value);
                product.price = float.Parse(txtGia.Text);
                product.categoryId = CategoryBAL.findIDByName(cboLoaiSP.Text);
                product.img = arr;
                ProductBAL.addProduct(product);
                reload();
            }
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            foreach (var item in CategoryBAL.layDanhSachTen())
            {
                cboLoaiSP.Items.Add(item);
            }
            reload();
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
        static int id;
        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                id = int.Parse(dgvThongTin.Rows[index].Cells[0].Value.ToString());
                txtTen.Text = dgvThongTin.Rows[index].Cells[1].Value.ToString();
                nudSoLuong.Text = dgvThongTin.Rows[index].Cells[2].Value.ToString();
                txtGia.Text = dgvThongTin.Rows[index].Cells[3].Value.ToString();
                txtMoTa.Text = dgvThongTin.Rows[index].Cells[4].Value.ToString();
                int categoryId = int.Parse(dgvThongTin.Rows[index].Cells[5].Value.ToString());
                cboLoaiSP.Text = CategoryBAL.findNameByID(categoryId);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            float a;
            if (txtTen.Text == null || nudSoLuong.Value == 0 || txtGia.Text == null || float.TryParse(txtGia.Text, out a) == false
                || txtMoTa.Text == null || cboLoaiSP.Text == null)
            {
                MessageBox.Show("Bạn nhập thiếu hoặc sai dữ liệu!");
            }
            else
            {
                Image img = pbImg.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                Product product = new Product();
                product.id = id;
                product.name = txtTen.Text;
                product.description = txtMoTa.Text;
                product.quantity = Convert.ToInt32(nudSoLuong.Value);
                product.price = float.Parse(txtGia.Text);
                product.categoryId = CategoryBAL.findIDByName(cboLoaiSP.Text);
                product.img = arr;
                ProductBAL.updateProduct(product);
                reload();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                ProductBAL.deleteProduct(id);
                reload();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).Text = "";
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
            }
        }

     
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            ProductBAL.xuatBaoCao();
        }

        private void ProductManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.Show();
        }
    }
}
