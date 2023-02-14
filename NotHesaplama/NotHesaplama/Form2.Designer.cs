namespace NotHesaplama
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdSoy = new System.Windows.Forms.Label();
            this.lblBasariDurumu = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(168, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Başarı Durumu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ortalama: ";
            // 
            // lblAdSoy
            // 
            this.lblAdSoy.AutoSize = true;
            this.lblAdSoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoy.Location = new System.Drawing.Point(168, 107);
            this.lblAdSoy.Name = "lblAdSoy";
            this.lblAdSoy.Size = new System.Drawing.Size(87, 16);
            this.lblAdSoy.TabIndex = 8;
            this.lblAdSoy.Text = "Adı Soyadı:";
            // 
            // lblBasariDurumu
            // 
            this.lblBasariDurumu.AutoSize = true;
            this.lblBasariDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasariDurumu.Location = new System.Drawing.Point(300, 196);
            this.lblBasariDurumu.Name = "lblBasariDurumu";
            this.lblBasariDurumu.Size = new System.Drawing.Size(11, 16);
            this.lblBasariDurumu.TabIndex = 15;
            this.lblBasariDurumu.Text = " ";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(300, 149);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(11, 16);
            this.lblOrtalama.TabIndex = 14;
            this.lblOrtalama.Text = " ";
            this.lblOrtalama.Click += new System.EventHandler(this.lblOrtalama_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(300, 107);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 16);
            this.lblAdSoyad.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 362);
            this.Controls.Add(this.lblBasariDurumu);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdSoy);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblAdSoy;
        public System.Windows.Forms.Label lblBasariDurumu;
        public System.Windows.Forms.Label lblOrtalama;
        public System.Windows.Forms.Label lblAdSoyad;
    }
}