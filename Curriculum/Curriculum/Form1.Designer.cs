namespace Curriculum
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.listBoxGecen = new System.Windows.Forms.ListBox();
            this.listBoxKalan = new System.Windows.Forms.ListBox();
            this.lblGecen = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.rdBtnGecti = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rdBtnKaldi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(95, 93);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 24);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(67, 142);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(63, 24);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(141, 86);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(191, 31);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(141, 139);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(191, 31);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // listBoxGecen
            // 
            this.listBoxGecen.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxGecen.FormattingEnabled = true;
            this.listBoxGecen.ItemHeight = 24;
            this.listBoxGecen.Location = new System.Drawing.Point(363, 83);
            this.listBoxGecen.Name = "listBoxGecen";
            this.listBoxGecen.Size = new System.Drawing.Size(175, 292);
            this.listBoxGecen.TabIndex = 2;
            // 
            // listBoxKalan
            // 
            this.listBoxKalan.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxKalan.FormattingEnabled = true;
            this.listBoxKalan.ItemHeight = 24;
            this.listBoxKalan.Location = new System.Drawing.Point(562, 83);
            this.listBoxKalan.Name = "listBoxKalan";
            this.listBoxKalan.Size = new System.Drawing.Size(175, 292);
            this.listBoxKalan.TabIndex = 2;
            this.listBoxKalan.SelectedIndexChanged += new System.EventHandler(this.listBoxKalan_SelectedIndexChanged);
            // 
            // lblGecen
            // 
            this.lblGecen.AutoSize = true;
            this.lblGecen.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecen.Location = new System.Drawing.Point(405, 48);
            this.lblGecen.Name = "lblGecen";
            this.lblGecen.Size = new System.Drawing.Size(85, 24);
            this.lblGecen.TabIndex = 0;
            this.lblGecen.Text = "Geçenler";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(606, 48);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(79, 24);
            this.lblKalan.TabIndex = 0;
            this.lblKalan.Text = "Kalanlar";
            // 
            // rdBtnGecti
            // 
            this.rdBtnGecti.AutoSize = true;
            this.rdBtnGecti.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnGecti.Location = new System.Drawing.Point(71, 239);
            this.rdBtnGecti.Name = "rdBtnGecti";
            this.rdBtnGecti.Size = new System.Drawing.Size(75, 28);
            this.rdBtnGecti.TabIndex = 3;
            this.rdBtnGecti.TabStop = true;
            this.rdBtnGecti.Text = "Geçti";
            this.rdBtnGecti.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(53, 300);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(279, 75);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rdBtnKaldi
            // 
            this.rdBtnKaldi.AutoSize = true;
            this.rdBtnKaldi.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnKaldi.Location = new System.Drawing.Point(219, 239);
            this.rdBtnKaldi.Name = "rdBtnKaldi";
            this.rdBtnKaldi.Size = new System.Drawing.Size(74, 28);
            this.rdBtnKaldi.TabIndex = 5;
            this.rdBtnKaldi.TabStop = true;
            this.rdBtnKaldi.Text = "Kaldı";
            this.rdBtnKaldi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdBtnKaldi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rdBtnGecti);
            this.Controls.Add(this.listBoxKalan);
            this.Controls.Add(this.listBoxGecen);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblGecen);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ListBox listBoxGecen;
        private System.Windows.Forms.ListBox listBoxKalan;
        private System.Windows.Forms.Label lblGecen;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.RadioButton rdBtnGecti;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rdBtnKaldi;
    }
}

