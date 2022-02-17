namespace AccessBaglantisi1
{
    partial class KitaplikFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.kitapaditxt = new System.Windows.Forms.TextBox();
            this.yayinevitxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yazaraditxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.veriTablodgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.veriTablodgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // kitapaditxt
            // 
            this.kitapaditxt.Location = new System.Drawing.Point(83, 22);
            this.kitapaditxt.Name = "kitapaditxt";
            this.kitapaditxt.Size = new System.Drawing.Size(251, 20);
            this.kitapaditxt.TabIndex = 1;
            // 
            // yayinevitxt
            // 
            this.yayinevitxt.Location = new System.Drawing.Point(83, 48);
            this.yayinevitxt.Name = "yayinevitxt";
            this.yayinevitxt.Size = new System.Drawing.Size(251, 20);
            this.yayinevitxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yayınevi";
            // 
            // yazaraditxt
            // 
            this.yazaraditxt.Location = new System.Drawing.Point(83, 74);
            this.yazaraditxt.Name = "yazaraditxt";
            this.yazaraditxt.Size = new System.Drawing.Size(251, 20);
            this.yazaraditxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar Adı";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(361, 20);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(361, 46);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 23);
            this.listelebtn.TabIndex = 7;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(361, 72);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(75, 23);
            this.silbtn.TabIndex = 8;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(361, 101);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(75, 23);
            this.guncellebtn.TabIndex = 9;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // veriTablodgw
            // 
            this.veriTablodgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veriTablodgw.Location = new System.Drawing.Point(12, 148);
            this.veriTablodgw.Name = "veriTablodgw";
            this.veriTablodgw.Size = new System.Drawing.Size(424, 290);
            this.veriTablodgw.TabIndex = 10;
            // 
            // KitaplikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.veriTablodgw);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.yazaraditxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yayinevitxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitapaditxt);
            this.Controls.Add(this.label1);
            this.Name = "KitaplikFrm";
            this.Text = "Kitaplık V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.veriTablodgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapaditxt;
        private System.Windows.Forms.TextBox yayinevitxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yazaraditxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.DataGridView veriTablodgw;
    }
}

