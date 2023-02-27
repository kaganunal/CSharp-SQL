namespace OOPHamburgerci
{
    partial class EkstraMalzemeEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkstraKaydet = new System.Windows.Forms.Button();
            this.numericEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnEkstraKaydet);
            this.groupBox1.Controls.Add(this.numericEkstraFiyat);
            this.groupBox1.Controls.Add(this.txtEkstraMalzeme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra Malzeme Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEkstraKaydet
            // 
            this.btnEkstraKaydet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkstraKaydet.Location = new System.Drawing.Point(44, 144);
            this.btnEkstraKaydet.Name = "btnEkstraKaydet";
            this.btnEkstraKaydet.Size = new System.Drawing.Size(322, 53);
            this.btnEkstraKaydet.TabIndex = 3;
            this.btnEkstraKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            this.btnEkstraKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraKaydet.Click += new System.EventHandler(this.btnEkstraKaydet_Click);
            // 
            // numericEkstraFiyat
            // 
            this.numericEkstraFiyat.DecimalPlaces = 2;
            this.numericEkstraFiyat.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericEkstraFiyat.Location = new System.Drawing.Point(205, 91);
            this.numericEkstraFiyat.Name = "numericEkstraFiyat";
            this.numericEkstraFiyat.Size = new System.Drawing.Size(161, 28);
            this.numericEkstraFiyat.TabIndex = 2;
            // 
            // txtEkstraMalzeme
            // 
            this.txtEkstraMalzeme.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkstraMalzeme.Location = new System.Drawing.Point(205, 38);
            this.txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            this.txtEkstraMalzeme.Size = new System.Drawing.Size(161, 28);
            this.txtEkstraMalzeme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(127, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyatı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı: ";
            // 
            // EkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(425, 252);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EkstraMalzemeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekstra Malzeme Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkstraKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEkstraMalzeme;
        public System.Windows.Forms.NumericUpDown numericEkstraFiyat;
    }
}