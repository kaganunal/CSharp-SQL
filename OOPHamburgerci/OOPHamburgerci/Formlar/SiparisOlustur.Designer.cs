namespace OOPHamburgerci
{
    partial class SiparisOlustur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numericAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listSiparis = new System.Windows.Forms.ListBox();
            this.BtnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblMenuSec = new System.Windows.Forms.Label();
            this.panelSoslar = new System.Windows.Forms.FlowLayoutPanel();
            this.radioBtnKucuk = new System.Windows.Forms.RadioButton();
            this.radioBtnOrta = new System.Windows.Forms.RadioButton();
            this.radioBtnBuyuk = new System.Windows.Forms.RadioButton();
            this.panelBoy = new System.Windows.Forms.GroupBox();
            this.comboBoxMenuSecim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).BeginInit();
            this.panelBoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(330, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ekstra Sos Seçiniz";
            // 
            // numericAdet
            // 
            this.numericAdet.BackColor = System.Drawing.Color.OldLace;
            this.numericAdet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAdet.Location = new System.Drawing.Point(384, 349);
            this.numericAdet.Name = "numericAdet";
            this.numericAdet.Size = new System.Drawing.Size(195, 25);
            this.numericAdet.TabIndex = 4;
            this.numericAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(330, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adet";
            // 
            // listSiparis
            // 
            this.listSiparis.BackColor = System.Drawing.Color.OldLace;
            this.listSiparis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSiparis.FormattingEnabled = true;
            this.listSiparis.HorizontalScrollbar = true;
            this.listSiparis.ItemHeight = 17;
            this.listSiparis.Location = new System.Drawing.Point(585, 16);
            this.listSiparis.Name = "listSiparis";
            this.listSiparis.ScrollAlwaysVisible = true;
            this.listSiparis.Size = new System.Drawing.Size(302, 327);
            this.listSiparis.TabIndex = 6;
            // 
            // BtnSiparisEkle
            // 
            this.BtnSiparisEkle.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnSiparisEkle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSiparisEkle.Location = new System.Drawing.Point(319, 382);
            this.BtnSiparisEkle.Name = "BtnSiparisEkle";
            this.BtnSiparisEkle.Size = new System.Drawing.Size(260, 47);
            this.BtnSiparisEkle.TabIndex = 5;
            this.BtnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.BtnSiparisEkle.UseVisualStyleBackColor = false;
            this.BtnSiparisEkle.Click += new System.EventHandler(this.BtnSiparisEkle_Click);
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTamamla.Location = new System.Drawing.Point(731, 382);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(156, 47);
            this.btnSiparisTamamla.TabIndex = 8;
            this.btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(587, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Tutar: ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblToplamTutar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(727, 349);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(156, 23);
            this.lblToplamTutar.TabIndex = 9;
            this.lblToplamTutar.Text = "₺0,00";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTemizle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(585, 382);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(139, 47);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "SİPARİŞİ TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblMenuSec
            // 
            this.lblMenuSec.AutoSize = true;
            this.lblMenuSec.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuSec.Location = new System.Drawing.Point(329, 22);
            this.lblMenuSec.Name = "lblMenuSec";
            this.lblMenuSec.Size = new System.Drawing.Size(95, 19);
            this.lblMenuSec.TabIndex = 11;
            this.lblMenuSec.Text = "Menü Seçin";
            // 
            // panelSoslar
            // 
            this.panelSoslar.AutoScroll = true;
            this.panelSoslar.BackColor = System.Drawing.Color.OldLace;
            this.panelSoslar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSoslar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSoslar.Location = new System.Drawing.Point(319, 171);
            this.panelSoslar.Name = "panelSoslar";
            this.panelSoslar.Size = new System.Drawing.Size(260, 172);
            this.panelSoslar.TabIndex = 12;
            this.panelSoslar.WrapContents = false;
            // 
            // radioBtnKucuk
            // 
            this.radioBtnKucuk.AutoSize = true;
            this.radioBtnKucuk.Checked = true;
            this.radioBtnKucuk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnKucuk.Location = new System.Drawing.Point(9, 26);
            this.radioBtnKucuk.Name = "radioBtnKucuk";
            this.radioBtnKucuk.Size = new System.Drawing.Size(68, 21);
            this.radioBtnKucuk.TabIndex = 1;
            this.radioBtnKucuk.TabStop = true;
            this.radioBtnKucuk.Text = "Küçük";
            this.radioBtnKucuk.UseVisualStyleBackColor = true;
            // 
            // radioBtnOrta
            // 
            this.radioBtnOrta.AutoSize = true;
            this.radioBtnOrta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOrta.Location = new System.Drawing.Point(93, 26);
            this.radioBtnOrta.Name = "radioBtnOrta";
            this.radioBtnOrta.Size = new System.Drawing.Size(56, 21);
            this.radioBtnOrta.TabIndex = 2;
            this.radioBtnOrta.Text = "Orta";
            this.radioBtnOrta.UseVisualStyleBackColor = true;
            // 
            // radioBtnBuyuk
            // 
            this.radioBtnBuyuk.AutoSize = true;
            this.radioBtnBuyuk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnBuyuk.Location = new System.Drawing.Point(170, 26);
            this.radioBtnBuyuk.Name = "radioBtnBuyuk";
            this.radioBtnBuyuk.Size = new System.Drawing.Size(67, 21);
            this.radioBtnBuyuk.TabIndex = 3;
            this.radioBtnBuyuk.Text = "Büyük";
            this.radioBtnBuyuk.UseVisualStyleBackColor = true;
            // 
            // panelBoy
            // 
            this.panelBoy.BackColor = System.Drawing.Color.Wheat;
            this.panelBoy.Controls.Add(this.radioBtnBuyuk);
            this.panelBoy.Controls.Add(this.radioBtnOrta);
            this.panelBoy.Controls.Add(this.radioBtnKucuk);
            this.panelBoy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.panelBoy.Location = new System.Drawing.Point(319, 75);
            this.panelBoy.Name = "panelBoy";
            this.panelBoy.Size = new System.Drawing.Size(260, 59);
            this.panelBoy.TabIndex = 4;
            this.panelBoy.TabStop = false;
            this.panelBoy.Text = "Boy Seçiniz";
            // 
            // comboBoxMenuSecim
            // 
            this.comboBoxMenuSecim.BackColor = System.Drawing.Color.OldLace;
            this.comboBoxMenuSecim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMenuSecim.FormattingEnabled = true;
            this.comboBoxMenuSecim.Location = new System.Drawing.Point(319, 44);
            this.comboBoxMenuSecim.Name = "comboBoxMenuSecim";
            this.comboBoxMenuSecim.Size = new System.Drawing.Size(260, 25);
            this.comboBoxMenuSecim.TabIndex = 10;
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(899, 461);
            this.Controls.Add(this.panelBoy);
            this.Controls.Add(this.panelSoslar);
            this.Controls.Add(this.comboBoxMenuSecim);
            this.Controls.Add(this.lblMenuSec);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.BtnSiparisEkle);
            this.Controls.Add(this.listSiparis);
            this.Controls.Add(this.numericAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).EndInit();
            this.panelBoy.ResumeLayout(false);
            this.panelBoy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSiparis;
        private System.Windows.Forms.Button BtnSiparisEkle;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblMenuSec;
        public System.Windows.Forms.FlowLayoutPanel panelSoslar;
        private System.Windows.Forms.RadioButton radioBtnKucuk;
        private System.Windows.Forms.RadioButton radioBtnOrta;
        private System.Windows.Forms.RadioButton radioBtnBuyuk;
        public System.Windows.Forms.ComboBox comboBoxMenuSecim;
        public System.Windows.Forms.GroupBox panelBoy;
    }
}