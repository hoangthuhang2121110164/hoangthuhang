namespace example
{
    partial class Form4
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
            this.bt0 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btBang = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(12, 98);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 55);
            this.bt0.TabIndex = 0;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(12, 168);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(75, 55);
            this.btMul.TabIndex = 1;
            this.btMul.Text = "+";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(102, 98);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 55);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(183, 98);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 55);
            this.bt2.TabIndex = 0;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(264, 98);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 55);
            this.bt3.TabIndex = 0;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(102, 168);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(75, 55);
            this.btEquals.TabIndex = 0;
            this.btEquals.Text = "*";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(183, 168);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(75, 55);
            this.btPlus.TabIndex = 0;
            this.btPlus.Text = ".";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btBang
            // 
            this.btBang.Location = new System.Drawing.Point(264, 168);
            this.btBang.Name = "btBang";
            this.btBang.Size = new System.Drawing.Size(75, 55);
            this.btBang.TabIndex = 0;
            this.btBang.Text = "=";
            this.btBang.UseVisualStyleBackColor = true;
            this.btBang.Click += new System.EventHandler(this.btBang_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 49);
            this.progressBar1.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 243);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btBang);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btBang;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}