namespace TelefonUygulamasi
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.telefonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telefonlarToolStripMenuItem
            // 
            this.telefonlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonDüzenleToolStripMenuItem,
            this.telefonlarıListeleToolStripMenuItem});
            this.telefonlarToolStripMenuItem.Name = "telefonlarToolStripMenuItem";
            this.telefonlarToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.telefonlarToolStripMenuItem.Text = "Telefonlar";
            // 
            // telefonDüzenleToolStripMenuItem
            // 
            this.telefonDüzenleToolStripMenuItem.Name = "telefonDüzenleToolStripMenuItem";
            this.telefonDüzenleToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.telefonDüzenleToolStripMenuItem.Text = "Telefon Düzenle";
            this.telefonDüzenleToolStripMenuItem.Click += new System.EventHandler(this.telefonDüzenleToolStripMenuItem_Click);
            // 
            // telefonlarıListeleToolStripMenuItem
            // 
            this.telefonlarıListeleToolStripMenuItem.Name = "telefonlarıListeleToolStripMenuItem";
            this.telefonlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.telefonlarıListeleToolStripMenuItem.Text = "Telefonları Listele";
            this.telefonlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.telefonlarıListeleToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 489);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem telefonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonlarıListeleToolStripMenuItem;
    }
}

