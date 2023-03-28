namespace EFCoreMarathon
{
    partial class Record
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
            this.Album = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxControl = new System.Windows.Forms.CheckBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Location = new System.Drawing.Point(15, 56);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(104, 20);
            this.Album.TabIndex = 0;
            this.Album.Text = "Album Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Release Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount :";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(125, 49);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(227, 27);
            this.txtAlbumName.TabIndex = 5;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(125, 82);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(227, 27);
            this.txtArtist.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(125, 148);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 27);
            this.txtPrice.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(125, 181);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(227, 27);
            this.txtDiscount.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(393, 405);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 286);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(125, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(225, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Is On Sale :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Discontinued Albums",
            "Albums On Sale",
            "Recently Added 10 Albums",
            "Amount of Discount",
            "",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(124, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "List";
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(56, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(62, 20);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "User Id :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(125, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 23);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "User";
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(125, 118);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(227, 27);
            this.dateTimePickerReleaseDate.TabIndex = 12;
            // 
            // checkBoxControl
            // 
            this.checkBoxControl.AutoSize = true;
            this.checkBoxControl.Checked = true;
            this.checkBoxControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxControl.Location = new System.Drawing.Point(130, 220);
            this.checkBoxControl.Name = "checkBoxControl";
            this.checkBoxControl.Size = new System.Drawing.Size(52, 24);
            this.checkBoxControl.TabIndex = 13;
            this.checkBoxControl.Text = "Yes";
            this.checkBoxControl.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(124, 372);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(94, 29);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(225, 372);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.checkBoxControl);
            this.Controls.Add(this.dateTimePickerReleaseDate);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Album);
            this.Name = "Record";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Album;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAlbumName;
        private TextBox txtArtist;
        private TextBox txtPrice;
        private TextBox txtDiscount;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label1;
        private ComboBox comboBox1;
        private Label label6;
        private Label txtUser;
        private Label lblUser;
        private DateTimePicker dateTimePickerReleaseDate;
        private CheckBox checkBoxControl;
        private Button btnList;
        private Button btnRefresh;
    }
}