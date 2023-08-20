namespace QL_QuanCaPhe.GUI
{
    partial class ThongTinNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaNguoiDung = new TextBox();
            txtHo = new TextBox();
            txtTen = new TextBox();
            dgvThongTin = new DataGridView();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            txtDienThoai = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label8 = new Label();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pbAvatar = new PictureBox();
            btnBrowse = new Button();
            label12 = new Label();
            cboQuyen = new ComboBox();
            btnXuatBaoCao = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(363, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 0;
            label1.Text = "Thông tin người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 343);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã người dùng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 379);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "Họ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 407);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Tên:";
            // 
            // txtMaNguoiDung
            // 
            txtMaNguoiDung.Location = new Point(122, 343);
            txtMaNguoiDung.Margin = new Padding(2);
            txtMaNguoiDung.Name = "txtMaNguoiDung";
            txtMaNguoiDung.Size = new Size(168, 23);
            txtMaNguoiDung.TabIndex = 4;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(68, 377);
            txtHo.Margin = new Padding(2);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(223, 23);
            txtHo.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(68, 407);
            txtTen.Margin = new Padding(2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(223, 23);
            txtTen.TabIndex = 6;
            // 
            // dgvThongTin
            // 
            dgvThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTin.Location = new Point(11, 47);
            dgvThongTin.Margin = new Padding(2);
            dgvThongTin.Name = "dgvThongTin";
            dgvThongTin.RowHeadersWidth = 62;
            dgvThongTin.RowTemplate.Height = 33;
            dgvThongTin.Size = new Size(916, 199);
            dgvThongTin.TabIndex = 7;
            dgvThongTin.CellClick += dgvThongTin_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(29, 446);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 27);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(183, 446);
            btnCapNhat.Margin = new Padding(2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 27);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(337, 446);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 27);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(518, 446);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 27);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(373, 290);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 23);
            txtEmail.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 293);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Email:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(392, 320);
            txtDienThoai.Margin = new Padding(2);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(192, 23);
            txtDienThoai.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 322);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 15;
            label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 362);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 17;
            label7.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "yyyy-MM-dd";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(373, 359);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(211, 23);
            dtpNgaySinh.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(307, 398);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 19;
            label8.Text = "Giới tính:";
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(396, 398);
            rbNam.Margin = new Padding(2);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(51, 19);
            rbNam.TabIndex = 20;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(493, 398);
            rbNu.Margin = new Padding(2);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(41, 19);
            rbNu.TabIndex = 21;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(687, 332);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(223, 23);
            txtMatKhau.TabIndex = 25;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(687, 291);
            txtTaiKhoan.Margin = new Padding(2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(223, 23);
            txtTaiKhoan.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(617, 332);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 23;
            label9.Text = "Mật khẩu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(615, 293);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 22;
            label10.Text = "Tài khoản:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 317);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 26;
            label11.Text = "Chọn ảnh:";
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(5, 250);
            pbAvatar.Margin = new Padding(2);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(105, 56);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 27;
            pbAvatar.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(112, 317);
            btnBrowse.Margin = new Padding(2);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(110, 20);
            btnBrowse.TabIndex = 28;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(629, 397);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 29;
            label12.Text = "Quyền:";
            // 
            // cboQuyen
            // 
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Items.AddRange(new object[] { "Admin", "User" });
            cboQuyen.Location = new Point(699, 395);
            cboQuyen.Margin = new Padding(2);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(129, 23);
            cboQuyen.TabIndex = 30;
            // 
            // btnXuatBaoCao
            // 
            btnXuatBaoCao.Location = new Point(722, 5);
            btnXuatBaoCao.Margin = new Padding(2);
            btnXuatBaoCao.Name = "btnXuatBaoCao";
            btnXuatBaoCao.Size = new Size(94, 27);
            btnXuatBaoCao.TabIndex = 65;
            btnXuatBaoCao.Text = "Xuất báo cáo";
            btnXuatBaoCao.UseVisualStyleBackColor = true;
            btnXuatBaoCao.Click += btnXuatBaoCao_Click;
            // 
            // ThongTinNguoiDung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(935, 475);
            Controls.Add(btnXuatBaoCao);
            Controls.Add(cboQuyen);
            Controls.Add(label12);
            Controls.Add(btnBrowse);
            Controls.Add(pbAvatar);
            Controls.Add(label11);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(label8);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label7);
            Controls.Add(txtDienThoai);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(dgvThongTin);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(txtMaNguoiDung);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ThongTinNguoiDung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongTinNguoiDung";
            FormClosed += ThongTinNguoiDung_FormClosed;
            Load += ThongTinNguoiDung_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaNguoiDung;
        private TextBox txtHo;
        private TextBox txtTen;
        private DataGridView dgvThongTin;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnClear;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtDienThoai;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpNgaySinh;
        private Label label8;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pbAvatar;
        private Button btnBrowse;
        private Label label12;
        private ComboBox cboQuyen;
        private Button btnXuatBaoCao;
    }
}