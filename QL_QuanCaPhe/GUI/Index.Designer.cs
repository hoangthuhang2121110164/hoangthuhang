namespace QL_QuanCaPhe.GUI
{
    partial class Index
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
            btnUser = new Button();
            btnProduct = new Button();
            btnCategory = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.Location = new Point(27, 144);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(187, 42);
            btnUser.TabIndex = 0;
            btnUser.Text = "Users Management";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(299, 144);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(191, 42);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product Management";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(561, 144);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(184, 42);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Category Management";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(324, 20);
            label1.Name = "label1";
            label1.Size = new Size(104, 47);
            label1.TabIndex = 3;
            label1.Text = "Index";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 292);
            Controls.Add(label1);
            Controls.Add(btnCategory);
            Controls.Add(btnProduct);
            Controls.Add(btnUser);
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            FormClosed += Index_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUser;
        private Button btnProduct;
        private Button btnCategory;
        private Label label1;
    }
}