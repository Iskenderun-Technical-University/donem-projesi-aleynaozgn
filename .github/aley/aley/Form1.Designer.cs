namespace aley
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(141, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1083, 284);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "sırano";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ilaçkodu";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ilaçadı";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "sonkullanmatarihi";
            this.columnHeader4.Width = 139;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "barkodno";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "fiyat";
            this.columnHeader6.Width = 101;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "adet";
            this.columnHeader7.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "üretimfirması";
            this.columnHeader8.Width = 135;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "kullanmatalimatı";
            this.columnHeader9.Width = 167;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(480, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InfoText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(764, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "SIRA NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "İLAÇ KODU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "İLAÇ ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "SON KULLANMA TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "BARKOD NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "FİYAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "ADET";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(857, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "ÜRETİM FİRMASI";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(831, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "KULLANMA TALİMATI";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 569);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(193, 618);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(565, 524);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 38);
            this.button6.TabIndex = 16;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(565, 574);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(213, 37);
            this.button7.TabIndex = 17;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(565, 619);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(213, 39);
            this.button8.TabIndex = 18;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(978, 532);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(213, 38);
            this.button9.TabIndex = 19;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(978, 580);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(218, 34);
            this.button10.TabIndex = 20;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(193, 479);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(214, 34);
            this.button11.TabIndex = 21;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 705);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

