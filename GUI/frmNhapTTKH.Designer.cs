namespace QL_CaPhe.GUI
{
    partial class frmNhapTTKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapTTKH));
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.btn_Kiemtra = new System.Windows.Forms.Button();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Chapnhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_sdt2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sdt.Location = new System.Drawing.Point(20, 34);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(138, 25);
            this.lbl_sdt.TabIndex = 0;
            this.lbl_sdt.Text = "Số điện thoại";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Sdt.Location = new System.Drawing.Point(204, 30);
            this.txt_Sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(247, 31);
            this.txt_Sdt.TabIndex = 1;
            // 
            // btn_Kiemtra
            // 
            this.btn_Kiemtra.Location = new System.Drawing.Point(19, 92);
            this.btn_Kiemtra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Kiemtra.Name = "btn_Kiemtra";
            this.btn_Kiemtra.Size = new System.Drawing.Size(92, 50);
            this.btn_Kiemtra.TabIndex = 2;
            this.btn_Kiemtra.Text = "Kiểm tra";
            this.btn_Kiemtra.UseVisualStyleBackColor = true;
            this.btn_Kiemtra.Click += new System.EventHandler(this.btn_Kiemtra_Click);
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Location = new System.Drawing.Point(128, 92);
            this.btn_taomoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(92, 50);
            this.btn_taomoi.TabIndex = 2;
            this.btn_taomoi.Text = "Tạo mới";
            this.btn_taomoi.UseVisualStyleBackColor = true;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // btn_dangky
            // 
            this.btn_dangky.Location = new System.Drawing.Point(324, 151);
            this.btn_dangky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(127, 50);
            this.btn_dangky.TabIndex = 2;
            this.btn_dangky.Text = "Đăng ký";
            this.btn_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Chapnhan);
            this.panel1.Controls.Add(this.btn_taomoi);
            this.panel1.Controls.Add(this.txt_Sdt);
            this.panel1.Controls.Add(this.btn_Kiemtra);
            this.panel1.Controls.Add(this.lbl_sdt);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 160);
            this.panel1.TabIndex = 3;
            // 
            // btn_Chapnhan
            // 
            this.btn_Chapnhan.Location = new System.Drawing.Point(339, 92);
            this.btn_Chapnhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Chapnhan.Name = "btn_Chapnhan";
            this.btn_Chapnhan.Size = new System.Drawing.Size(127, 50);
            this.btn_Chapnhan.TabIndex = 2;
            this.btn_Chapnhan.Text = "Chấp nhận";
            this.btn_Chapnhan.UseVisualStyleBackColor = true;
            this.btn_Chapnhan.Click += new System.EventHandler(this.btn_Chapnhan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_dangky);
            this.panel2.Controls.Add(this.txt_sdt2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_tenKH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 220);
            this.panel2.TabIndex = 4;
            // 
            // txt_sdt2
            // 
            this.txt_sdt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sdt2.Location = new System.Drawing.Point(204, 102);
            this.txt_sdt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt2.Name = "txt_sdt2";
            this.txt_sdt2.Size = new System.Drawing.Size(247, 31);
            this.txt_sdt2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenKH.Location = new System.Drawing.Point(204, 31);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(247, 31);
            this.txt_tenKH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // frmNhapTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(514, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhapTTKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmNhapTTKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Button btn_Kiemtra;
        private System.Windows.Forms.Button btn_taomoi;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_sdt2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Chapnhan;
    }
}