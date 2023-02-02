namespace mailYazdirma
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
            this.lblIsim = new System.Windows.Forms.Label();
            this.btnEMail = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblSoyIsim = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(294, 55);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(159, 25);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsminizi giriniz:";
            // 
            // btnEMail
            // 
            this.btnEMail.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEMail.FlatAppearance.BorderSize = 10;
            this.btnEMail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEMail.Location = new System.Drawing.Point(299, 224);
            this.btnEMail.Name = "btnEMail";
            this.btnEMail.Size = new System.Drawing.Size(133, 37);
            this.btnEMail.TabIndex = 1;
            this.btnEMail.Text = "Giriş";
            this.btnEMail.UseVisualStyleBackColor = true;
            this.btnEMail.Click += new System.EventHandler(this.btnEMail_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(268, 92);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(193, 30);
            this.txtIsim.TabIndex = 2;
            this.txtIsim.TextChanged += new System.EventHandler(this.txtIsim_TextChanged);
            // 
            // lblSoyIsim
            // 
            this.lblSoyIsim.AutoSize = true;
            this.lblSoyIsim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyIsim.Location = new System.Drawing.Point(278, 140);
            this.lblSoyIsim.Name = "lblSoyIsim";
            this.lblSoyIsim.Size = new System.Drawing.Size(186, 25);
            this.lblSoyIsim.TabIndex = 3;
            this.lblSoyIsim.Text = "Soyadınızı giriniz:";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMail.Location = new System.Drawing.Point(278, 285);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(177, 25);
            this.lblEMail.TabIndex = 4;
            this.lblEMail.Text = "e-Mail adresiniz:";
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyIsim.Location = new System.Drawing.Point(268, 178);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(193, 30);
            this.txtSoyIsim.TabIndex = 5;
            // 
            // txtEMail
            // 
            this.txtEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEMail.Location = new System.Drawing.Point(268, 313);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(193, 30);
            this.txtEMail.TabIndex = 6;
            this.txtEMail.TextChanged += new System.EventHandler(this.txtEMail_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(312, 360);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(106, 34);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblSoyIsim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnEMail);
            this.Controls.Add(this.lblIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Button btnEMail;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblSoyIsim;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Button btnTemizle;
    }
}

