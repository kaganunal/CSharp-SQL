namespace KarakterSınırlama
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
            this.lblSinir = new System.Windows.Forms.Label();
            this.rchText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSinir
            // 
            this.lblSinir.BackColor = System.Drawing.SystemColors.Menu;
            this.lblSinir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinir.ForeColor = System.Drawing.Color.Black;
            this.lblSinir.Location = new System.Drawing.Point(0, 357);
            this.lblSinir.Name = "lblSinir";
            this.lblSinir.Size = new System.Drawing.Size(800, 93);
            this.lblSinir.TabIndex = 0;
            this.lblSinir.Text = "Kalan Karakter Sayısı:";
            this.lblSinir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rchText
            // 
            this.rchText.Location = new System.Drawing.Point(12, 12);
            this.rchText.Name = "rchText";
            this.rchText.Size = new System.Drawing.Size(776, 327);
            this.rchText.TabIndex = 1;
            this.rchText.Text = "";
            this.rchText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchText);
            this.Controls.Add(this.lblSinir);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSinir;
        private System.Windows.Forms.RichTextBox rchText;
    }
}

