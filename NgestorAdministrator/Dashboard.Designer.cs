namespace NgestorAdministrator
{
    partial class Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.painelCentral = new Bunifu.Framework.UI.BunifuCards();
            this.panelCallLogin = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opServidoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.codigosDeBaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situacaoOperadoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.situacaoOperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicoTipoDeBaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCentral
            // 
            this.painelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelCentral.BackColor = System.Drawing.Color.White;
            this.painelCentral.BorderRadius = 5;
            this.painelCentral.BottomSahddow = true;
            this.painelCentral.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.painelCentral.Controls.Add(this.panelCallLogin);
            this.painelCentral.LeftSahddow = false;
            this.painelCentral.Location = new System.Drawing.Point(20, 84);
            this.painelCentral.Name = "painelCentral";
            this.painelCentral.RightSahddow = true;
            this.painelCentral.ShadowDepth = 20;
            this.painelCentral.Size = new System.Drawing.Size(910, 443);
            this.painelCentral.TabIndex = 0;
            this.painelCentral.Resize += new System.EventHandler(this.painelCentral_Resize);
            // 
            // panelCallLogin
            // 
            this.panelCallLogin.Location = new System.Drawing.Point(259, 57);
            this.panelCallLogin.Name = "panelCallLogin";
            this.panelCallLogin.Size = new System.Drawing.Size(388, 377);
            this.panelCallLogin.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(20, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(46, 43);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.menu.Font = new System.Drawing.Font("Arial", 10F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.hostToolStripMenuItem,
            this.operadoraToolStripMenuItem1,
            this.serviçosToolStripMenuItem1,
            this.estoqueToolStripMenuItem1,
            this.financeiroToolStripMenuItem1,
            this.aCLToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(20, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(910, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "Menu";
            this.menu.Visible = false;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.newToolStripMenuItem.Text = "Empresa";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // hostToolStripMenuItem
            // 
            this.hostToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
            this.hostToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.hostToolStripMenuItem.Text = "Host";
            this.hostToolStripMenuItem.Click += new System.EventHandler(this.hostToolStripMenuItem_Click);
            // 
            // operadoraToolStripMenuItem1
            // 
            this.operadoraToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operadorasToolStripMenuItem,
            this.opServidoresToolStripMenuItem1});
            this.operadoraToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGray;
            this.operadoraToolStripMenuItem1.Name = "operadoraToolStripMenuItem1";
            this.operadoraToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.operadoraToolStripMenuItem1.Text = "Operadora";
            this.operadoraToolStripMenuItem1.Click += new System.EventHandler(this.operadoraToolStripMenuItem1_Click);
            // 
            // operadorasToolStripMenuItem
            // 
            this.operadorasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.operadorasToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.operadorasToolStripMenuItem.Name = "operadorasToolStripMenuItem";
            this.operadorasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.operadorasToolStripMenuItem.Text = "Operadoras";
            this.operadorasToolStripMenuItem.Click += new System.EventHandler(this.operadorasToolStripMenuItem_Click);
            // 
            // opServidoresToolStripMenuItem1
            // 
            this.opServidoresToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.opServidoresToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGray;
            this.opServidoresToolStripMenuItem1.Name = "opServidoresToolStripMenuItem1";
            this.opServidoresToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.opServidoresToolStripMenuItem1.Text = "Op. Servidores";
            this.opServidoresToolStripMenuItem1.Click += new System.EventHandler(this.opServidoresToolStripMenuItem1_Click);
            // 
            // serviçosToolStripMenuItem1
            // 
            this.serviçosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigosDeBaixaToolStripMenuItem,
            this.situacaoOperadoraToolStripMenuItem1,
            this.situacaoOperaToolStripMenuItem,
            this.servicoTipoDeBaixaToolStripMenuItem});
            this.serviçosToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGray;
            this.serviçosToolStripMenuItem1.Name = "serviçosToolStripMenuItem1";
            this.serviçosToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.serviçosToolStripMenuItem1.Text = "Serviços";
            // 
            // codigosDeBaixaToolStripMenuItem
            // 
            this.codigosDeBaixaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.codigosDeBaixaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.codigosDeBaixaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.codigosDeBaixaToolStripMenuItem.Name = "codigosDeBaixaToolStripMenuItem";
            this.codigosDeBaixaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.codigosDeBaixaToolStripMenuItem.Text = "Codigos de baixa";
            this.codigosDeBaixaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.codigosDeBaixaToolStripMenuItem.Click += new System.EventHandler(this.codigosDeBaixaToolStripMenuItem_Click);
            // 
            // situacaoOperadoraToolStripMenuItem1
            // 
            this.situacaoOperadoraToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.situacaoOperadoraToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGray;
            this.situacaoOperadoraToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.situacaoOperadoraToolStripMenuItem1.Name = "situacaoOperadoraToolStripMenuItem1";
            this.situacaoOperadoraToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.situacaoOperadoraToolStripMenuItem1.Text = "Situacao Operadora";
            this.situacaoOperadoraToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.situacaoOperadoraToolStripMenuItem1.Click += new System.EventHandler(this.situacaoOperadoraToolStripMenuItem1_Click);
            // 
            // situacaoOperaToolStripMenuItem
            // 
            this.situacaoOperaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.situacaoOperaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.situacaoOperaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.situacaoOperaToolStripMenuItem.Name = "situacaoOperaToolStripMenuItem";
            this.situacaoOperaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.situacaoOperaToolStripMenuItem.Text = "Servico Situacao";
            this.situacaoOperaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.situacaoOperaToolStripMenuItem.Click += new System.EventHandler(this.situacaoOperaToolStripMenuItem_Click);
            // 
            // servicoTipoDeBaixaToolStripMenuItem
            // 
            this.servicoTipoDeBaixaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.servicoTipoDeBaixaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.servicoTipoDeBaixaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicoTipoDeBaixaToolStripMenuItem.Name = "servicoTipoDeBaixaToolStripMenuItem";
            this.servicoTipoDeBaixaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.servicoTipoDeBaixaToolStripMenuItem.Text = "Servico Tipo de Baixa";
            this.servicoTipoDeBaixaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicoTipoDeBaixaToolStripMenuItem.Click += new System.EventHandler(this.servicoTipoDeBaixaToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGray;
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            // 
            // financeiroToolStripMenuItem1
            // 
            this.financeiroToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGray;
            this.financeiroToolStripMenuItem1.Name = "financeiroToolStripMenuItem1";
            this.financeiroToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.financeiroToolStripMenuItem1.Text = "Financeiro";
            // 
            // aCLToolStripMenuItem
            // 
            this.aCLToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.aCLToolStripMenuItem.Name = "aCLToolStripMenuItem";
            this.aCLToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.aCLToolStripMenuItem.Text = "ACL";
            this.aCLToolStripMenuItem.Click += new System.EventHandler(this.aCLToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.painelCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Dashboard";
            this.Text = "      Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.painelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards painelCentral;
        private System.Windows.Forms.Panel panelCallLogin;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem codigosDeBaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situacaoOperadoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem situacaoOperaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicoTipoDeBaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opServidoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aCLToolStripMenuItem;
    }
}

