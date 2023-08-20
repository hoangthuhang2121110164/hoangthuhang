using QL_QuanCaPhe.BAL;
using QL_QuanCaPhe.DAL;
using QL_QuanCaPhe.DTO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //public void moForm()
        //{
        //    Application.Run(new ThongTinNguoiDung());
        //}

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == null || txtMatKhau.Text == null)
            {
                MessageBox.Show("Ban chua nhap tai khoan hoac mat khau!");
            }
            else
            {
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                Users users = new Users();
                users.username = taiKhoan;
                users.password = matKhau;

                if (LoginBAL.dangNhapBAL(users) == true)
                {
                    this.Hide();
                    Index index = new Index();
                    index.Show();
                }
                else
                {
                    MessageBox.Show("Ban da nhap sai tai khoan hoac mat khau!");
                }

            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
