namespace SifreUretimiYapanProgram
{
    partial class Form1
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
            this.lstSifreler = new System.Windows.Forms.ListBox();
            this.chckKucukHarf = new System.Windows.Forms.CheckBox();
            this.chckRakam = new System.Windows.Forms.CheckBox();
            this.chckBuyuk = new System.Windows.Forms.CheckBox();
            this.chckOzelKarakter = new System.Windows.Forms.CheckBox();
            this.lblSifreSayisi = new System.Windows.Forms.Label();
            this.lblSifreUzunluk = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.numericUpDownSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.groupParametreler = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSifreUzunlugu)).BeginInit();
            this.groupParametreler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSifreler
            // 
            this.lstSifreler.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstSifreler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSifreler.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstSifreler.FormattingEnabled = true;
            this.lstSifreler.ItemHeight = 18;
            this.lstSifreler.Location = new System.Drawing.Point(401, 30);
            this.lstSifreler.Name = "lstSifreler";
            this.lstSifreler.ScrollAlwaysVisible = true;
            this.lstSifreler.Size = new System.Drawing.Size(387, 400);
            this.lstSifreler.TabIndex = 6;
            // 
            // chckKucukHarf
            // 
            this.chckKucukHarf.AutoSize = true;
            this.chckKucukHarf.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckKucukHarf.Location = new System.Drawing.Point(147, 86);
            this.chckKucukHarf.Name = "chckKucukHarf";
            this.chckKucukHarf.Size = new System.Drawing.Size(109, 25);
            this.chckKucukHarf.TabIndex = 1;
            this.chckKucukHarf.Text = "Küçük Harf";
            this.chckKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chckRakam
            // 
            this.chckRakam.AutoSize = true;
            this.chckRakam.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckRakam.Location = new System.Drawing.Point(147, 165);
            this.chckRakam.Name = "chckRakam";
            this.chckRakam.Size = new System.Drawing.Size(82, 25);
            this.chckRakam.TabIndex = 3;
            this.chckRakam.Text = "Rakam";
            this.chckRakam.UseVisualStyleBackColor = true;
            // 
            // chckBuyuk
            // 
            this.chckBuyuk.AutoSize = true;
            this.chckBuyuk.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBuyuk.Location = new System.Drawing.Point(147, 125);
            this.chckBuyuk.Name = "chckBuyuk";
            this.chckBuyuk.Size = new System.Drawing.Size(111, 25);
            this.chckBuyuk.TabIndex = 2;
            this.chckBuyuk.Text = "Büyük Harf";
            this.chckBuyuk.UseVisualStyleBackColor = true;
            // 
            // chckOzelKarakter
            // 
            this.chckOzelKarakter.AutoSize = true;
            this.chckOzelKarakter.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckOzelKarakter.Location = new System.Drawing.Point(147, 203);
            this.chckOzelKarakter.Name = "chckOzelKarakter";
            this.chckOzelKarakter.Size = new System.Drawing.Size(127, 25);
            this.chckOzelKarakter.TabIndex = 4;
            this.chckOzelKarakter.Text = "Özel Karakter";
            this.chckOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // lblSifreSayisi
            // 
            this.lblSifreSayisi.AutoSize = true;
            this.lblSifreSayisi.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreSayisi.Location = new System.Drawing.Point(60, 261);
            this.lblSifreSayisi.Name = "lblSifreSayisi";
            this.lblSifreSayisi.Size = new System.Drawing.Size(94, 21);
            this.lblSifreSayisi.TabIndex = 1;
            this.lblSifreSayisi.Text = "Şifre Sayısı :";
            // 
            // lblSifreUzunluk
            // 
            this.lblSifreUzunluk.AutoSize = true;
            this.lblSifreUzunluk.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUzunluk.Location = new System.Drawing.Point(33, 304);
            this.lblSifreUzunluk.Name = "lblSifreUzunluk";
            this.lblSifreUzunluk.Size = new System.Drawing.Size(121, 21);
            this.lblSifreUzunluk.TabIndex = 1;
            this.lblSifreUzunluk.Text = "Şifre Uzunluğu :";
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUret.Location = new System.Drawing.Point(194, 358);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(153, 53);
            this.btnUret.TabIndex = 5;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // numericUpDownSifreSayisi
            // 
            this.numericUpDownSifreSayisi.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownSifreSayisi.Location = new System.Drawing.Point(169, 261);
            this.numericUpDownSifreSayisi.Name = "numericUpDownSifreSayisi";
            this.numericUpDownSifreSayisi.Size = new System.Drawing.Size(153, 26);
            this.numericUpDownSifreSayisi.TabIndex = 2;
            // 
            // numericUpDownSifreUzunlugu
            // 
            this.numericUpDownSifreUzunlugu.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownSifreUzunlugu.Location = new System.Drawing.Point(169, 302);
            this.numericUpDownSifreUzunlugu.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSifreUzunlugu.Name = "numericUpDownSifreUzunlugu";
            this.numericUpDownSifreUzunlugu.Size = new System.Drawing.Size(153, 26);
            this.numericUpDownSifreUzunlugu.TabIndex = 3;
            // 
            // groupParametreler
            // 
            this.groupParametreler.BackColor = System.Drawing.Color.DimGray;
            this.groupParametreler.Controls.Add(this.numericUpDownSifreUzunlugu);
            this.groupParametreler.Controls.Add(this.numericUpDownSifreSayisi);
            this.groupParametreler.Controls.Add(this.lblSifreSayisi);
            this.groupParametreler.Controls.Add(this.lblSifreUzunluk);
            this.groupParametreler.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupParametreler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupParametreler.Location = new System.Drawing.Point(25, 12);
            this.groupParametreler.Name = "groupParametreler";
            this.groupParametreler.Size = new System.Drawing.Size(370, 420);
            this.groupParametreler.TabIndex = 0;
            this.groupParametreler.TabStop = false;
            this.groupParametreler.Text = "Parametreler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(812, 451);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.chckOzelKarakter);
            this.Controls.Add(this.chckBuyuk);
            this.Controls.Add(this.chckRakam);
            this.Controls.Add(this.chckKucukHarf);
            this.Controls.Add(this.lstSifreler);
            this.Controls.Add(this.groupParametreler);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSifreUzunlugu)).EndInit();
            this.groupParametreler.ResumeLayout(false);
            this.groupParametreler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSifreler;
        private System.Windows.Forms.CheckBox chckKucukHarf;
        private System.Windows.Forms.CheckBox chckRakam;
        private System.Windows.Forms.CheckBox chckBuyuk;
        private System.Windows.Forms.CheckBox chckOzelKarakter;
        private System.Windows.Forms.Label lblSifreSayisi;
        private System.Windows.Forms.Label lblSifreUzunluk;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.NumericUpDown numericUpDownSifreSayisi;
        private System.Windows.Forms.NumericUpDown numericUpDownSifreUzunlugu;
        private System.Windows.Forms.GroupBox groupParametreler;
    }
}

