namespace cdrkontrol
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndosyagetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btndosyacopy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndizinchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndosyagetir
            // 
            this.btndosyagetir.BackColor = System.Drawing.Color.RosyBrown;
            this.btndosyagetir.Location = new System.Drawing.Point(34, 24);
            this.btndosyagetir.Name = "btndosyagetir";
            this.btndosyagetir.Size = new System.Drawing.Size(99, 25);
            this.btndosyagetir.TabIndex = 0;
            this.btndosyagetir.Text = "Dosyaları Getir";
            this.btndosyagetir.UseVisualStyleBackColor = false;
            this.btndosyagetir.Click += new System.EventHandler(this.btndosyagetir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(163, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 225);
            this.listBox1.TabIndex = 1;
            // 
            // btndosyacopy
            // 
            this.btndosyacopy.BackColor = System.Drawing.Color.Cyan;
            this.btndosyacopy.Location = new System.Drawing.Point(505, 136);
            this.btndosyacopy.Name = "btndosyacopy";
            this.btndosyacopy.Size = new System.Drawing.Size(161, 29);
            this.btndosyacopy.TabIndex = 2;
            this.btndosyacopy.Text = "Kopyala";
            this.btndosyacopy.UseVisualStyleBackColor = false;
            this.btndosyacopy.Click += new System.EventHandler(this.btndosyacopy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(505, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "C:\\Dosyalar";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(505, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "C:\\Kopyalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Varsayılan Dizin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(404, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kopyalancak Dizin";
            // 
            // btndizinchange
            // 
            this.btndizinchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndizinchange.Location = new System.Drawing.Point(505, 101);
            this.btndizinchange.Name = "btndizinchange";
            this.btndizinchange.Size = new System.Drawing.Size(161, 29);
            this.btndizinchange.TabIndex = 9;
            this.btndizinchange.Text = "Dizin Değiştir";
            this.btndizinchange.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(837, 266);
            this.Controls.Add(this.btndizinchange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btndosyacopy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndosyagetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndosyagetir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btndosyacopy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndizinchange;
    }
}

