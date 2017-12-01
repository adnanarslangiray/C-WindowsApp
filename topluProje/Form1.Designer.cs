namespace topluProje
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dizüstü");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Masaüstü");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Bilgisayar", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Android");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Ios");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Cep Telefonu", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cbKategoriGoster = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rbKokDugum = new System.Windows.Forms.RadioButton();
            this.rbAltDugum = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.cbSeciliKategori = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AccessibleName = "";
            this.treeView1.Location = new System.Drawing.Point(12, 25);
            this.treeView1.Name = "treeView1";
            treeNode7.Checked = true;
            treeNode7.Name = "altOgeDizustu";
            treeNode7.Text = "Dizüstü";
            treeNode8.Checked = true;
            treeNode8.Name = "altOgeMasaustu";
            treeNode8.Text = "Masaüstü";
            treeNode9.Checked = true;
            treeNode9.Name = "tnBilgisayar";
            treeNode9.Tag = "";
            treeNode9.Text = "Bilgisayar";
            treeNode10.Checked = true;
            treeNode10.Name = "altOgeAndroid";
            treeNode10.Text = "Android";
            treeNode11.Checked = true;
            treeNode11.Name = "altOgeIos";
            treeNode11.Text = "Ios";
            treeNode12.Checked = true;
            treeNode12.Name = "tnTelefon";
            treeNode12.Text = "Cep Telefonu";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(153, 232);
            this.treeView1.TabIndex = 0;
            // 
            // cbKategoriGoster
            // 
            this.cbKategoriGoster.AutoSize = true;
            this.cbKategoriGoster.Location = new System.Drawing.Point(194, 118);
            this.cbKategoriGoster.Name = "cbKategoriGoster";
            this.cbKategoriGoster.Size = new System.Drawing.Size(136, 17);
            this.cbKategoriGoster.TabIndex = 1;
            this.cbKategoriGoster.Text = "Tüm Kategorileri Göster";
            this.cbKategoriGoster.UseVisualStyleBackColor = true;
            this.cbKategoriGoster.CheckedChanged += new System.EventHandler(this.cbKategoriGoster_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.rbKokDugum);
            this.groupBox1.Controls.Add(this.rbAltDugum);
            this.groupBox1.Location = new System.Drawing.Point(194, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kategori Girişi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(106, 56);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 38);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Kategori Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rbKokDugum
            // 
            this.rbKokDugum.AutoSize = true;
            this.rbKokDugum.Location = new System.Drawing.Point(6, 44);
            this.rbKokDugum.Name = "rbKokDugum";
            this.rbKokDugum.Size = new System.Drawing.Size(81, 17);
            this.rbKokDugum.TabIndex = 2;
            this.rbKokDugum.TabStop = true;
            this.rbKokDugum.Text = "Kök Düğüm";
            this.rbKokDugum.UseVisualStyleBackColor = true;
            // 
            // rbAltDugum
            // 
            this.rbAltDugum.AutoSize = true;
            this.rbAltDugum.Location = new System.Drawing.Point(6, 67);
            this.rbAltDugum.Name = "rbAltDugum";
            this.rbAltDugum.Size = new System.Drawing.Size(74, 17);
            this.rbAltDugum.TabIndex = 3;
            this.rbAltDugum.TabStop = true;
            this.rbAltDugum.Text = "Alt Düğüm";
            this.rbAltDugum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tüm Kategoriler";
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(194, 150);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(109, 44);
            this.btnKategoriSil.TabIndex = 6;
            this.btnKategoriSil.Text = "Seçili Kategoriyi Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // cbSeciliKategori
            // 
            this.cbSeciliKategori.AutoSize = true;
            this.cbSeciliKategori.Location = new System.Drawing.Point(309, 165);
            this.cbSeciliKategori.Name = "cbSeciliKategori";
            this.cbSeciliKategori.Size = new System.Drawing.Size(134, 17);
            this.cbSeciliKategori.TabIndex = 7;
            this.cbSeciliKategori.Text = "Seçili Kategoriyi Göster";
            this.cbSeciliKategori.UseVisualStyleBackColor = true;
            this.cbSeciliKategori.CheckedChanged += new System.EventHandler(this.cbSeciliKategori_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 336);
            this.Controls.Add(this.cbSeciliKategori);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbKategoriGoster);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox cbKategoriGoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rbKokDugum;
        private System.Windows.Forms.RadioButton rbAltDugum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.CheckBox cbSeciliKategori;
    }
}

