namespace WindowsFormsApp21
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.katagorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mADMAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psILoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynıYıldızınAltındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuSeansıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzayYolcularıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLVEDAŞARKISIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENKLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAVİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tURUNCUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yESİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIRMIZIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIZLIERİŞİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKIMIZDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katagorilerToolStripMenuItem,
            this.rENKLERToolStripMenuItem,
            this.hIZLIERİŞİMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // katagorilerToolStripMenuItem
            // 
            this.katagorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.korkuToolStripMenuItem,
            this.bilimKurguToolStripMenuItem,
            this.eLVEDAŞARKISIToolStripMenuItem});
            this.katagorilerToolStripMenuItem.Name = "katagorilerToolStripMenuItem";
            this.katagorilerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.katagorilerToolStripMenuItem.Text = "katagoriler";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mADMAXToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // mADMAXToolStripMenuItem
            // 
            this.mADMAXToolStripMenuItem.Name = "mADMAXToolStripMenuItem";
            this.mADMAXToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mADMAXToolStripMenuItem.Text = "MAD MAX";
            this.mADMAXToolStripMenuItem.Click += new System.EventHandler(this.mADMAXToolStripMenuItem_Click);
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.psILoveToolStripMenuItem,
            this.aynıYıldızınAltındaToolStripMenuItem});
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.romantikToolStripMenuItem.Text = "Romantik";
            // 
            // psILoveToolStripMenuItem
            // 
            this.psILoveToolStripMenuItem.Name = "psILoveToolStripMenuItem";
            this.psILoveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.psILoveToolStripMenuItem.Text = "ps.I love";
            this.psILoveToolStripMenuItem.Click += new System.EventHandler(this.psILoveToolStripMenuItem_Click);
            // 
            // aynıYıldızınAltındaToolStripMenuItem
            // 
            this.aynıYıldızınAltındaToolStripMenuItem.Name = "aynıYıldızınAltındaToolStripMenuItem";
            this.aynıYıldızınAltındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aynıYıldızınAltındaToolStripMenuItem.Text = "Aynı Yıldızın Altında";
            this.aynıYıldızınAltındaToolStripMenuItem.Click += new System.EventHandler(this.aynıYıldızınAltındaToolStripMenuItem_Click);
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korkuSeansıToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.korkuToolStripMenuItem.Text = "Korku";
            // 
            // korkuSeansıToolStripMenuItem
            // 
            this.korkuSeansıToolStripMenuItem.Name = "korkuSeansıToolStripMenuItem";
            this.korkuSeansıToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.korkuSeansıToolStripMenuItem.Text = "Korku Seansı";
            this.korkuSeansıToolStripMenuItem.Click += new System.EventHandler(this.korkuSeansıToolStripMenuItem_Click);
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uzayYolcularıToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
            // 
            // uzayYolcularıToolStripMenuItem
            // 
            this.uzayYolcularıToolStripMenuItem.Name = "uzayYolcularıToolStripMenuItem";
            this.uzayYolcularıToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.uzayYolcularıToolStripMenuItem.Text = "Uzay yolcuları";
            // 
            // eLVEDAŞARKISIToolStripMenuItem
            // 
            this.eLVEDAŞARKISIToolStripMenuItem.Name = "eLVEDAŞARKISIToolStripMenuItem";
            this.eLVEDAŞARKISIToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eLVEDAŞARKISIToolStripMenuItem.Text = "ELVEDA ŞARKISI";
            this.eLVEDAŞARKISIToolStripMenuItem.Click += new System.EventHandler(this.eLVEDAŞARKISIToolStripMenuItem_Click);
            // 
            // rENKLERToolStripMenuItem
            // 
            this.rENKLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAVİToolStripMenuItem,
            this.tURUNCUToolStripMenuItem,
            this.yESİLToolStripMenuItem,
            this.kIRMIZIToolStripMenuItem,
            this.sARIToolStripMenuItem});
            this.rENKLERToolStripMenuItem.Name = "rENKLERToolStripMenuItem";
            this.rENKLERToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.rENKLERToolStripMenuItem.Text = "RENKLER";
            // 
            // mAVİToolStripMenuItem
            // 
            this.mAVİToolStripMenuItem.Name = "mAVİToolStripMenuItem";
            this.mAVİToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mAVİToolStripMenuItem.Text = "MAVİ";
            this.mAVİToolStripMenuItem.Click += new System.EventHandler(this.mAVİToolStripMenuItem_Click);
            // 
            // tURUNCUToolStripMenuItem
            // 
            this.tURUNCUToolStripMenuItem.Name = "tURUNCUToolStripMenuItem";
            this.tURUNCUToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.tURUNCUToolStripMenuItem.Text = "TURUNCU";
            this.tURUNCUToolStripMenuItem.Click += new System.EventHandler(this.tURUNCUToolStripMenuItem_Click);
            // 
            // yESİLToolStripMenuItem
            // 
            this.yESİLToolStripMenuItem.Name = "yESİLToolStripMenuItem";
            this.yESİLToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.yESİLToolStripMenuItem.Text = "YESİL";
            this.yESİLToolStripMenuItem.Click += new System.EventHandler(this.yESİLToolStripMenuItem_Click);
            // 
            // kIRMIZIToolStripMenuItem
            // 
            this.kIRMIZIToolStripMenuItem.Name = "kIRMIZIToolStripMenuItem";
            this.kIRMIZIToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.kIRMIZIToolStripMenuItem.Text = "KIRMIZI";
            this.kIRMIZIToolStripMenuItem.Click += new System.EventHandler(this.kIRMIZIToolStripMenuItem_Click);
            // 
            // sARIToolStripMenuItem
            // 
            this.sARIToolStripMenuItem.Name = "sARIToolStripMenuItem";
            this.sARIToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sARIToolStripMenuItem.Text = "SARI";
            this.sARIToolStripMenuItem.Click += new System.EventHandler(this.sARIToolStripMenuItem_Click);
            // 
            // hIZLIERİŞİMToolStripMenuItem
            // 
            this.hIZLIERİŞİMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hAKKIMIZDAToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.hIZLIERİŞİMToolStripMenuItem.Name = "hIZLIERİŞİMToolStripMenuItem";
            this.hIZLIERİŞİMToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.hIZLIERİŞİMToolStripMenuItem.Text = "HIZLI ERİŞİM";
            // 
            // hAKKIMIZDAToolStripMenuItem
            // 
            this.hAKKIMIZDAToolStripMenuItem.Name = "hAKKIMIZDAToolStripMenuItem";
            this.hAKKIMIZDAToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hAKKIMIZDAToolStripMenuItem.Text = "HAKKIMIZDA";
            this.hAKKIMIZDAToolStripMenuItem.Click += new System.EventHandler(this.hAKKIMIZDAToolStripMenuItem_Click_1);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(858, 375);
            this.webBrowser1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(201, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "FİLMİN ADI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem katagorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem psILoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynıYıldızınAltındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuSeansıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzayYolcularıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENKLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAVİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tURUNCUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yESİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIRMIZIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIZLIERİŞİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKIMIZDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mADMAXToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem eLVEDAŞARKISIToolStripMenuItem;
    }
}

