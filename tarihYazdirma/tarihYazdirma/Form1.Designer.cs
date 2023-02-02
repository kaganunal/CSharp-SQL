namespace tarihYazdirma
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
            this.btnTarih = new System.Windows.Forms.Button();
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTarih
            // 
            this.btnTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarih.Location = new System.Drawing.Point(129, 104);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(137, 71);
            this.btnTarih.TabIndex = 0;
            this.btnTarih.Text = "Tarih";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // txtTarih1
            // 
            this.txtTarih1.Location = new System.Drawing.Point(299, 104);
            this.txtTarih1.Multiline = true;
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.Size = new System.Drawing.Size(139, 22);
            this.txtTarih1.TabIndex = 1;
            // 
            // txtTarih2
            // 
            this.txtTarih2.Location = new System.Drawing.Point(299, 153);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.Size = new System.Drawing.Size(139, 22);
            this.txtTarih2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(571, 291);
            this.Controls.Add(this.txtTarih2);
            this.Controls.Add(this.txtTarih1);
            this.Controls.Add(this.btnTarih);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.TextBox txtTarih1;
        private System.Windows.Forms.TextBox txtTarih2;
    }
}

