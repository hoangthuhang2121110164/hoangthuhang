namespace QL_CaPhe.GUI
{
    partial class frm_ThemCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemCV));
            this.grp_Position = new System.Windows.Forms.GroupBox();
            this.btn_AddPosition = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NamePosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CategoryPosition = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Position.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Position
            // 
            this.grp_Position.Controls.Add(this.btn_AddPosition);
            this.grp_Position.Controls.Add(this.pictureBox9);
            this.grp_Position.Controls.Add(this.label6);
            this.grp_Position.Controls.Add(this.txt_NamePosition);
            this.grp_Position.Controls.Add(this.label8);
            this.grp_Position.Controls.Add(this.txt_CategoryPosition);
            this.grp_Position.Controls.Add(this.label17);
            this.grp_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp_Position.Location = new System.Drawing.Point(47, 126);
            this.grp_Position.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_Position.Name = "grp_Position";
            this.grp_Position.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_Position.Size = new System.Drawing.Size(417, 308);
            this.grp_Position.TabIndex = 23;
            this.grp_Position.TabStop = false;
            this.grp_Position.Text = "Chức vụ";
            // 
            // btn_AddPosition
            // 
            this.btn_AddPosition.Location = new System.Drawing.Point(261, 225);
            this.btn_AddPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddPosition.Name = "btn_AddPosition";
            this.btn_AddPosition.Size = new System.Drawing.Size(84, 45);
            this.btn_AddPosition.TabIndex = 3;
            this.btn_AddPosition.Text = "Thêm";
            this.btn_AddPosition.UseVisualStyleBackColor = true;
            this.btn_AddPosition.Click += new System.EventHandler(this.btn_AddPosition_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::QL_CaPhe.Properties.Resources.add;
            this.pictureBox9.Location = new System.Drawing.Point(273, 170);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(56, 48);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 0;
            // 
            // txt_NamePosition
            // 
            this.txt_NamePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NamePosition.Location = new System.Drawing.Point(142, 108);
            this.txt_NamePosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NamePosition.Multiline = true;
            this.txt_NamePosition.Name = "txt_NamePosition";
            this.txt_NamePosition.Size = new System.Drawing.Size(224, 32);
            this.txt_NamePosition.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(15, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên chức vụ:";
            // 
            // txt_CategoryPosition
            // 
            this.txt_CategoryPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_CategoryPosition.Location = new System.Drawing.Point(142, 39);
            this.txt_CategoryPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CategoryPosition.Multiline = true;
            this.txt_CategoryPosition.Name = "txt_CategoryPosition";
            this.txt_CategoryPosition.Size = new System.Drawing.Size(224, 32);
            this.txt_CategoryPosition.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(19, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 22);
            this.label17.TabIndex = 3;
            this.label17.Text = "Mã chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "THÊM CHỨC VỤ";
            // 
            // frm_ThemCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(512, 478);
            this.Controls.Add(this.grp_Position);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ThemCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật chức vụ";
            this.grp_Position.ResumeLayout(false);
            this.grp_Position.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Position;
        private System.Windows.Forms.Button btn_AddPosition;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NamePosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CategoryPosition;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
    }
}