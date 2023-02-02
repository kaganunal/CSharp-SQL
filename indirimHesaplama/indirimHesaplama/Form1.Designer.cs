namespace indirimHesaplama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chck10IndirimS = new System.Windows.Forms.CheckBox();
            this.chck10Indirim = new System.Windows.Forms.CheckBox();
            this.chck5Indirim = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIndirimli = new System.Windows.Forms.Label();
            this.txtIndirimli = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chck10IndirimS);
            this.groupBox1.Controls.Add(this.chck10Indirim);
            this.groupBox1.Controls.Add(this.chck5Indirim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(68, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İndirimler";
            // 
            // chck10IndirimS
            // 
            this.chck10IndirimS.AutoSize = true;
            this.chck10IndirimS.Location = new System.Drawing.Point(38, 179);
            this.chck10IndirimS.Name = "chck10IndirimS";
            this.chck10IndirimS.Size = new System.Drawing.Size(182, 29);
            this.chck10IndirimS.TabIndex = 4;
            this.chck10IndirimS.Text = "%10 Özel İndirim";
            this.chck10IndirimS.UseVisualStyleBackColor = true;
            // 
            // chck10Indirim
            // 
            this.chck10Indirim.AutoSize = true;
            this.chck10Indirim.Location = new System.Drawing.Point(38, 134);
            this.chck10Indirim.Name = "chck10Indirim";
            this.chck10Indirim.Size = new System.Drawing.Size(240, 29);
            this.chck10Indirim.TabIndex = 3;
            this.chck10Indirim.Text = "%10 Kampanya İndirimi";
            this.chck10Indirim.UseVisualStyleBackColor = true;
            // 
            // chck5Indirim
            // 
            this.chck5Indirim.AutoSize = true;
            this.chck5Indirim.Location = new System.Drawing.Point(38, 88);
            this.chck5Indirim.Name = "chck5Indirim";
            this.chck5Indirim.Size = new System.Drawing.Size(174, 29);
            this.chck5Indirim.TabIndex = 2;
            this.chck5Indirim.Text = "%5 Nakit İndirim";
            this.chck5Indirim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIndirimli);
            this.groupBox2.Controls.Add(this.txtIndirimli);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.lblTutar);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(419, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 322);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesaplama";
            // 
            // lblIndirimli
            // 
            this.lblIndirimli.AutoSize = true;
            this.lblIndirimli.Location = new System.Drawing.Point(75, 226);
            this.lblIndirimli.Name = "lblIndirimli";
            this.lblIndirimli.Size = new System.Drawing.Size(128, 25);
            this.lblIndirimli.TabIndex = 4;
            this.lblIndirimli.Text = "İndirimli Tutar";
            // 
            // txtIndirimli
            // 
            this.txtIndirimli.Location = new System.Drawing.Point(35, 264);
            this.txtIndirimli.Name = "txtIndirimli";
            this.txtIndirimli.Size = new System.Drawing.Size(218, 30);
            this.txtIndirimli.TabIndex = 3;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(153, 88);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 30);
            this.txtTutar.TabIndex = 2;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(54, 93);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(79, 25);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "TUTAR";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(35, 143);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(218, 65);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.CheckBox chck10IndirimS;
        private System.Windows.Forms.CheckBox chck10Indirim;
        private System.Windows.Forms.CheckBox chck5Indirim;
        private System.Windows.Forms.Label lblIndirimli;
        private System.Windows.Forms.TextBox txtIndirimli;
    }
}

