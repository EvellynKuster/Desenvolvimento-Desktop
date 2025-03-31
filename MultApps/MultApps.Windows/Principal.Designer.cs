namespace MultApps.Windows
{
    partial class Principal
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.calculadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalculadoraImc = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraDeAposentadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeCarteirinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaDeAçaíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem,
            this.geradoresToolStripMenuItem,
            this.lojasToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 33);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem
            // 
            this.calculadorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCalculadoraImc,
            this.calculadoraDeAposentadoriaToolStripMenuItem});
            this.calculadorasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadorasToolStripMenuItem.Name = "calculadorasToolStripMenuItem";
            this.calculadorasToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.calculadorasToolStripMenuItem.Text = "Calculadoras";
            // 
            // MenuCalculadoraImc
            // 
            this.MenuCalculadoraImc.Name = "MenuCalculadoraImc";
            this.MenuCalculadoraImc.Size = new System.Drawing.Size(349, 30);
            this.MenuCalculadoraImc.Text = "Calculadora de IMC";
            this.MenuCalculadoraImc.Click += new System.EventHandler(this.MenuCalculadoraImc_Click);
            // 
            // calculadoraDeAposentadoriaToolStripMenuItem
            // 
            this.calculadoraDeAposentadoriaToolStripMenuItem.Name = "calculadoraDeAposentadoriaToolStripMenuItem";
            this.calculadoraDeAposentadoriaToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.calculadoraDeAposentadoriaToolStripMenuItem.Text = "Calculadora de aposentadoria";
            this.calculadoraDeAposentadoriaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraDeAposentadoriaToolStripMenuItem_Click);
            // 
            // geradoresToolStripMenuItem
            // 
            this.geradoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geradorDeCarteirinhaToolStripMenuItem});
            this.geradoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geradoresToolStripMenuItem.Name = "geradoresToolStripMenuItem";
            this.geradoresToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.geradoresToolStripMenuItem.Text = "Geradores";
            // 
            // geradorDeCarteirinhaToolStripMenuItem
            // 
            this.geradorDeCarteirinhaToolStripMenuItem.Name = "geradorDeCarteirinhaToolStripMenuItem";
            this.geradorDeCarteirinhaToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.geradorDeCarteirinhaToolStripMenuItem.Text = "Gerador de carteirinha";
            this.geradorDeCarteirinhaToolStripMenuItem.Click += new System.EventHandler(this.geradorDeCarteirinhaToolStripMenuItem_Click);
            // 
            // lojasToolStripMenuItem
            // 
            this.lojasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojaDeAçaíToolStripMenuItem});
            this.lojasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lojasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.lojasToolStripMenuItem.Name = "lojasToolStripMenuItem";
            this.lojasToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.lojasToolStripMenuItem.Text = "Lojas";
            // 
            // lojaDeAçaíToolStripMenuItem
            // 
            this.lojaDeAçaíToolStripMenuItem.Name = "lojaDeAçaíToolStripMenuItem";
            this.lojaDeAçaíToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.lojaDeAçaíToolStripMenuItem.Text = "Loja de açaí";
            this.lojaDeAçaíToolStripMenuItem.Click += new System.EventHandler(this.lojaDeAçaíToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem calculadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCalculadoraImc;
        private System.Windows.Forms.ToolStripMenuItem calculadoraDeAposentadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geradorDeCarteirinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaDeAçaíToolStripMenuItem;
    }
}