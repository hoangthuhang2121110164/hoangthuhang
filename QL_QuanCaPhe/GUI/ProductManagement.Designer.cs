namespace QL_QuanCaPhe.GUI
{
    partial class ProductManagement
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
            cboLoaiSP = new ComboBox();
            label12 = new Label();
            btnBrowse = new Button();
            pbImg = new PictureBox();
            label11 = new Label();
            label6 = new Label();
            btnClear = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            dgvThongTin = new DataGridView();
            txtGia = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nudSoLuong = new NumericUpDown();
            label3 = new Label();
            txtMoTa = new RichTextBox();
            label4 = new Label();
            btnXuatBaoCao = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            SuspendLayout();
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Items.AddRange(new object[] { "Admin", "User" });
            cboLoaiSP.Location = new Point(134, 490);
            cboLoaiSP.Margin = new Padding(2);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(129, 23);
            cboLoaiSP.TabIndex = 59;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 496);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 58;
            label12.Text = "Loại sản phẩm:";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(125, 387);
            btnBrowse.Margin = new Padding(2);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(110, 20);
            btnBrowse.TabIndex = 57;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // pbImg
            // 
            pbImg.Location = new Point(42, 300);
            pbImg.Margin = new Padding(2);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(105, 56);
            pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImg.TabIndex = 56;
            pbImg.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 387);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 55;
            label11.Text = "Chọn ảnh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 449);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 44;
            label6.Text = "Số lượng:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(610, 527);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 27);
            btnClear.TabIndex = 40;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(429, 527);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 27);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(275, 527);
            btnCapNhat.Margin = new Padding(2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 27);
            btnCapNhat.TabIndex = 38;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(121, 527);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 27);
            btnThem.TabIndex = 37;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvThongTin
            // 
            dgvThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTin.Location = new Point(11, 78);
            dgvThongTin.Margin = new Padding(2);
            dgvThongTin.Name = "dgvThongTin";
            dgvThongTin.RowHeadersWidth = 62;
            dgvThongTin.RowTemplate.Height = 33;
            dgvThongTin.Size = new Size(855, 199);
            dgvThongTin.TabIndex = 36;
            dgvThongTin.CellClick += dgvThongTin_CellClick;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(400, 384);
            txtGia.Margin = new Padding(2);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(96, 23);
            txtGia.TabIndex = 34;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(134, 440);
            txtTen.Margin = new Padding(2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(168, 23);
            txtTen.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 440);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 32;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(304, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 31;
            label1.Text = "Thông tin sản phẩm";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(400, 447);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(120, 23);
            nudSoLuong.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 387);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 61;
            label3.Text = "Giá sản phẩm:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(656, 367);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(195, 96);
            txtMoTa.TabIndex = 62;
            txtMoTa.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 415);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 63;
            label4.Text = "Mô tả sản phẩm:";
            // 
            // btnXuatBaoCao
            // 
            btnXuatBaoCao.Location = new Point(720, 22);
            btnXuatBaoCao.Margin = new Padding(2);
            btnXuatBaoCao.Name = "btnXuatBaoCao";
            btnXuatBaoCao.Size = new Size(94, 27);
            btnXuatBaoCao.TabIndex = 64;
            btnXuatBaoCao.Text = "Xuất báo cáo";
            btnXuatBaoCao.UseVisualStyleBackColor = true;
            btnXuatBaoCao.Click += btnXuatBaoCao_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(889, 579);
            Controls.Add(btnXuatBaoCao);
            Controls.Add(label4);
            Controls.Add(txtMoTa);
            Controls.Add(label3);
            Controls.Add(nudSoLuong);
            Controls.Add(cboLoaiSP);
            Controls.Add(label12);
            Controls.Add(btnBrowse);
            Controls.Add(pbImg);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(dgvThongTin);
            Controls.Add(txtGia);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductManagement";
            Text = "ProductManagement";
            FormClosed += ProductManagement_FormClosed;
            Load += ProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboLoaiSP;
        private Button btnBrowse;
        private PictureBox pbImg;
        private Label label11;
        private Label label6;
        private Button btnClear;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private DataGridView dgvThongTin;
        private TextBox txtGia;
        private TextBox txtTen;
        private Label label2;
        private Label label1;
        private NumericUpDown nudSoLuong;
        protected internal Label label12;
        private Label label3;
        private RichTextBox txtMoTa;
        private Label label4;
        private Button btnXuatBaoCao;
    }
}