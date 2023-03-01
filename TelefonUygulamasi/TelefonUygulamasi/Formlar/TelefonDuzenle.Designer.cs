namespace TelefonUygulamasi
{
    partial class TelefonDuzenle
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
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.groupBoxDurum = new System.Windows.Forms.GroupBox();
            this.radioHurda = new System.Windows.Forms.RadioButton();
            this.radioBtnSatista = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listTelefonlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBoxDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(79, 80);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(60, 20);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(80, 127);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model:";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.Location = new System.Drawing.Point(107, 171);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(32, 20);
            this.lblYil.TabIndex = 0;
            this.lblYil.Text = "Yıl:";
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(145, 73);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(177, 27);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(145, 120);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(177, 27);
            this.txtModel.TabIndex = 1;
            // 
            // txtYil
            // 
            this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(145, 164);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(177, 27);
            this.txtYil.TabIndex = 2;
            // 
            // groupBoxDurum
            // 
            this.groupBoxDurum.Controls.Add(this.radioHurda);
            this.groupBoxDurum.Controls.Add(this.radioBtnSatista);
            this.groupBoxDurum.Controls.Add(this.radioButton2);
            this.groupBoxDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxDurum.Location = new System.Drawing.Point(145, 207);
            this.groupBoxDurum.Name = "groupBoxDurum";
            this.groupBoxDurum.Size = new System.Drawing.Size(177, 110);
            this.groupBoxDurum.TabIndex = 3;
            this.groupBoxDurum.TabStop = false;
            this.groupBoxDurum.Text = "Durumu";
            // 
            // radioHurda
            // 
            this.radioHurda.AutoSize = true;
            this.radioHurda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioHurda.Location = new System.Drawing.Point(6, 79);
            this.radioHurda.Name = "radioHurda";
            this.radioHurda.Size = new System.Drawing.Size(69, 22);
            this.radioHurda.TabIndex = 0;
            this.radioHurda.TabStop = true;
            this.radioHurda.Text = "Hurda";
            this.radioHurda.UseVisualStyleBackColor = true;
            // 
            // radioBtnSatista
            // 
            this.radioBtnSatista.AutoSize = true;
            this.radioBtnSatista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnSatista.Location = new System.Drawing.Point(6, 23);
            this.radioBtnSatista.Name = "radioBtnSatista";
            this.radioBtnSatista.Size = new System.Drawing.Size(74, 22);
            this.radioBtnSatista.TabIndex = 1;
            this.radioBtnSatista.TabStop = true;
            this.radioBtnSatista.Text = "Satışta";
            this.radioBtnSatista.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(6, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 22);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kullanımda";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // listTelefonlar
            // 
            this.listTelefonlar.FormattingEnabled = true;
            this.listTelefonlar.ItemHeight = 16;
            this.listTelefonlar.Location = new System.Drawing.Point(530, 73);
            this.listTelefonlar.Name = "listTelefonlar";
            this.listTelefonlar.Size = new System.Drawing.Size(381, 244);
            this.listTelefonlar.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEkle.Location = new System.Drawing.Point(530, 323);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 45);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnGuncelle.Location = new System.Drawing.Point(659, 323);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 45);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Location = new System.Drawing.Point(788, 323);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 45);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // TelefonDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listTelefonlar);
            this.Controls.Add(this.groupBoxDurum);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelefonDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefonDuzenle";
            this.groupBoxDurum.ResumeLayout(false);
            this.groupBoxDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.GroupBox groupBoxDurum;
        private System.Windows.Forms.RadioButton radioHurda;
        private System.Windows.Forms.RadioButton radioBtnSatista;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.ListBox listTelefonlar;
    }
}