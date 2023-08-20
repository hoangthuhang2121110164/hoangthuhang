using QL_QuanCaPhe.BAL;
using QL_QuanCaPhe.DAL;
using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCaPhe.GUI
{
    public partial class ThongTinNguoiDung : Form
    {
        public static SqlConnection connection = GetSQLConnection.getConnection();
        string url = null;
        public ThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = openFileDialog.FileName;
                pbAvatar.Image = Image.FromFile(url);
            }
        }
        public void reload()
        {
            dgvThongTin.DataSource = UserBAL.layDanhSach();
        }
        private void ThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNguoiDung.Text == null || txtHo.Text == null || txtTen.Text == null || txtEmail.Text == null || txtDienThoai.Text == null
                || dtpNgaySinh.Text == null || (rbNam.Checked == false && rbNu.Checked == false) || txtTaiKhoan.Text == null || txtMatKhau.Text == null || cboQuyen.Text == null)
            {
                MessageBox.Show("Bạn nhập thiếu dữ liệu!");
            }
            else
            {
                Image img = pbAvatar.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                Users users = new Users();
                users.userID = txtMaNguoiDung.Text;
                users.firstName = txtHo.Text;
                users.lastName = txtTen.Text;
                users.email = txtEmail.Text;
                users.tel = txtDienThoai.Text;
                users.DOB = dtpNgaySinh.Value;
                if (rbNam.Checked)
                {
                    users.gender = true;
                }
                else if (rbNu.Checked)
                {
                    users.gender = false;
                }
                users.username = txtTaiKhoan.Text;
                users.password = txtMatKhau.Text;
                users.userRole = cboQuyen.Text;
                users.avatar = arr;
                UserBAL.addUser(users);
                reload();
            }
        }

        static int id;
        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    id = int.Parse(dgvThongTin.Rows[index].Cells[0].Value.ToString());
                    txtMaNguoiDung.Text = dgvThongTin.Rows[index].Cells[1].Value.ToString();
                    txtHo.Text = dgvThongTin.Rows[index].Cells[2].Value.ToString();
                    txtTen.Text = dgvThongTin.Rows[index].Cells[3].Value.ToString();
                    txtEmail.Text = dgvThongTin.Rows[index].Cells[4].Value.ToString();
                    txtDienThoai.Text = dgvThongTin.Rows[index].Cells[5].Value.ToString();
                    dtpNgaySinh.Text = dgvThongTin.Rows[index].Cells[6].Value.ToString();
                    if (dgvThongTin.Rows[index].Cells[7].Value.ToString() == "True")
                    {
                        rbNam.Checked = true;
                        rbNu.Checked = false;
                    }
                    else
                    {
                        rbNu.Checked = true;
                        rbNam.Checked = false;
                    }
                    cboQuyen.Text = dgvThongTin.Rows[index].Cells[8].Value.ToString();
                    txtTaiKhoan.Text = dgvThongTin.Rows[index].Cells[9].Value.ToString();
                    txtMatKhau.Text = dgvThongTin.Rows[index].Cells[10].Value.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Image img = pbAvatar.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            Users users = new Users();
            users.userID = txtMaNguoiDung.Text;
            users.firstName = txtHo.Text;
            users.lastName = txtTen.Text;
            users.email = txtEmail.Text;
            users.tel = txtDienThoai.Text;
            users.DOB = dtpNgaySinh.Value;
            if (rbNam.Checked)
            {
                users.gender = true;
            }
            else if (rbNu.Checked)
            {
                users.gender = false;
            }
            users.username = txtTaiKhoan.Text;
            users.password = txtMatKhau.Text;
            users.userRole = cboQuyen.Text;
            users.avatar = arr;
            users.id = id;
            UserBAL.updateUser(users);
            reload();
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
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id >= 1)
            {
                UserBAL.deleteUser(id);
                reload();
            }
            else
            {
                MessageBox.Show("Không thể xóa!");
            }
        }

        private void ThongTinNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.Show();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            UserBAL.xuatBaoCao();
        }
    }
}
