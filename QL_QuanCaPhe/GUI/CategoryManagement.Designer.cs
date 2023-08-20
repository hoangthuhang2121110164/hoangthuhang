namespace QL_QuanCaPhe.GUI
{
    partial class CategoryManagement
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
            dgvThongTin = new DataGridView();
            label1 = new Label();
            btnBrowse = new Button();
            pbImg = new PictureBox();
            label11 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            SuspendLayout();
            // 
            // dgvThongTin
            // 
            dgvThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTin.Location = new Point(12, 74);
            dgvThongTin.Name = "dgvThongTin";
            dgvThongTin.RowTemplate.Height = 25;
            dgvThongTin.Size = new Size(776, 234);
            dgvThongTin.TabIndex = 0;
            dgvThongTin.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 40);
            label1.TabIndex = 1;
            label1.Text = "Loại sản phẩm";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(157, 423);
            btnBrowse.Margin = new Padding(2);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(110, 20);
            btnBrowse.TabIndex = 62;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // pbImg
            // 
            pbImg.Location = new Point(74, 336);
            pbImg.Margin = new Padding(2);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(105, 56);
            pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImg.TabIndex = 61;
            pbImg.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 423);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 60;
            label11.Text = "Chọn ảnh:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(532, 377);
            txtTen.Margin = new Padding(2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(168, 23);
            txtTen.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 377);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 58;
            label2.Text = "Tên loại sản phẩm:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(521, 466);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 27);
            btnClear.TabIndex = 66;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(340, 466);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 27);
            btnXoa.TabIndex = 65;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(186, 466);
            btnCapNhat.Margin = new Padding(2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 27);
            btnCapNhat.TabIndex = 64;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(32, 466);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 27);
            btnThem.TabIndex = 63;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // CategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 519);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(btnBrowse);
            Controls.Add(pbImg);
            Controls.Add(label11);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvThongTin);
            Name = "CategoryManagement";
            Text = "CategoryManagement";
            FormClosed += CategoryManagement_FormClosed;
            Load += CategoryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThongTin;
        private Label label1;
        private Button btnBrowse;
        private PictureBox pbImg;
        private Label label11;
        private TextBox txtTen;
        private Label label2;
        private Button btnClear;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
    }
}