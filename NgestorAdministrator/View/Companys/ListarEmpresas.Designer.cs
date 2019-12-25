namespace NgestorAdministrator.View.Companys
{
    partial class ListarEmpresas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarEmpresas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.companysGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.json = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enviarEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPesquisa = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovaEmpresa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.painelTopHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.companysGrid)).BeginInit();
            this.options.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companysGrid
            // 
            this.companysGrid.AllowUserToAddRows = false;
            this.companysGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.companysGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.companysGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companysGrid.BackgroundColor = System.Drawing.Color.White;
            this.companysGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companysGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companysGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.companysGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companysGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Empresa,
            this.Endereco,
            this.email,
            this.json});
            this.companysGrid.ContextMenuStrip = this.options;
            this.companysGrid.DoubleBuffered = true;
            this.companysGrid.EnableHeadersVisualStyles = false;
            this.companysGrid.GridColor = System.Drawing.Color.White;
            this.companysGrid.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.companysGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companysGrid.Location = new System.Drawing.Point(3, 67);
            this.companysGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companysGrid.MultiSelect = false;
            this.companysGrid.Name = "companysGrid";
            this.companysGrid.ReadOnly = true;
            this.companysGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.companysGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companysGrid.Size = new System.Drawing.Size(842, 441);
            this.companysGrid.TabIndex = 32;
            this.companysGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.companysGrid_CellMouseDown);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 300;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 300;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 250;
            // 
            // json
            // 
            this.json.HeaderText = "json";
            this.json.Name = "json";
            this.json.ReadOnly = true;
            this.json.Visible = false;
            // 
            // options
            // 
            this.options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarEmailToolStripMenuItem,
            this.detalheToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(139, 48);
            // 
            // enviarEmailToolStripMenuItem
            // 
            this.enviarEmailToolStripMenuItem.Name = "enviarEmailToolStripMenuItem";
            this.enviarEmailToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.enviarEmailToolStripMenuItem.Text = "Enviar email";
            this.enviarEmailToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailToolStripMenuItem_Click);
            // 
            // detalheToolStripMenuItem
            // 
            this.detalheToolStripMenuItem.Name = "detalheToolStripMenuItem";
            this.detalheToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.detalheToolStripMenuItem.Text = "Detalhe";
            this.detalheToolStripMenuItem.Click += new System.EventHandler(this.detalheToolStripMenuItem_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.ButtonText = "Pesquisar";
            this.btnPesquisa.ButtonTextMarginLeft = 0;
            this.btnPesquisa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPesquisa.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnPesquisa.DisabledForecolor = System.Drawing.Color.White;
            this.btnPesquisa.Font = new System.Drawing.Font("Arial", 8F);
            this.btnPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisa.IconPadding = 10;
            this.btnPesquisa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisa.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPesquisa.IdleBorderRadius = 1;
            this.btnPesquisa.IdleBorderThickness = 0;
            this.btnPesquisa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPesquisa.IdleIconLeftImage = null;
            this.btnPesquisa.IdleIconRightImage = null;
            this.btnPesquisa.Location = new System.Drawing.Point(316, 2);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisa.Name = "btnPesquisa";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnPesquisa.onHoverState = stateProperties1;
            this.btnPesquisa.Size = new System.Drawing.Size(99, 26);
            this.btnPesquisa.TabIndex = 31;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AcceptsReturn = false;
            this.txtPesquisa.AcceptsTab = false;
            this.txtPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.BackgroundImage")));
            this.txtPesquisa.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPesquisa.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPesquisa.BorderColorHover = System.Drawing.Color.Silver;
            this.txtPesquisa.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPesquisa.BorderRadius = 1;
            this.txtPesquisa.BorderThickness = 2;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisa.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txtPesquisa.DefaultText = "";
            this.txtPesquisa.FillColor = System.Drawing.Color.White;
            this.txtPesquisa.HideSelection = true;
            this.txtPesquisa.IconLeft = null;
            this.txtPesquisa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPesquisa.IconPadding = 10;
            this.txtPesquisa.IconRight = null;
            this.txtPesquisa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPesquisa.Location = new System.Drawing.Point(3, 0);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.MinimumSize = new System.Drawing.Size(136, 28);
            this.txtPesquisa.Modified = false;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ReadOnly = false;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(307, 31);
            this.txtPesquisa.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPesquisa.TabIndex = 29;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextMarginLeft = 5;
            this.txtPesquisa.TextPlaceholder = "";
            this.txtPesquisa.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnNovaEmpresa);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 31);
            this.panel1.TabIndex = 33;
            // 
            // btnNovaEmpresa
            // 
            this.btnNovaEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnNovaEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovaEmpresa.BackgroundImage")));
            this.btnNovaEmpresa.ButtonText = "Nova Empresa";
            this.btnNovaEmpresa.ButtonTextMarginLeft = 0;
            this.btnNovaEmpresa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNovaEmpresa.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnNovaEmpresa.DisabledForecolor = System.Drawing.Color.White;
            this.btnNovaEmpresa.Font = new System.Drawing.Font("Arial", 8F);
            this.btnNovaEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnNovaEmpresa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNovaEmpresa.IconPadding = 10;
            this.btnNovaEmpresa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNovaEmpresa.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNovaEmpresa.IdleBorderRadius = 1;
            this.btnNovaEmpresa.IdleBorderThickness = 0;
            this.btnNovaEmpresa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNovaEmpresa.IdleIconLeftImage = null;
            this.btnNovaEmpresa.IdleIconRightImage = null;
            this.btnNovaEmpresa.Location = new System.Drawing.Point(421, 2);
            this.btnNovaEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovaEmpresa.Name = "btnNovaEmpresa";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnNovaEmpresa.onHoverState = stateProperties2;
            this.btnNovaEmpresa.Size = new System.Drawing.Size(129, 26);
            this.btnNovaEmpresa.TabIndex = 33;
            this.btnNovaEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovaEmpresa.Click += new System.EventHandler(this.btnNovaEmpresa_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.ButtonText = ">";
            this.btnNext.ButtonTextMarginLeft = 0;
            this.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNext.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnNext.DisabledForecolor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Arial", 8F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IconPadding = 10;
            this.btnNext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNext.IdleBorderRadius = 1;
            this.btnNext.IdleBorderThickness = 0;
            this.btnNext.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNext.IdleIconLeftImage = null;
            this.btnNext.IdleIconRightImage = null;
            this.btnNext.Location = new System.Drawing.Point(604, 2);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnNext.onHoverState = stateProperties3;
            this.btnNext.Size = new System.Drawing.Size(42, 26);
            this.btnNext.TabIndex = 32;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.ButtonText = "<";
            this.btnBack.ButtonTextMarginLeft = 0;
            this.btnBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnBack.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnBack.DisabledForecolor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 8F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.IconPadding = 10;
            this.btnBack.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBack.IdleBorderRadius = 1;
            this.btnBack.IdleBorderThickness = 0;
            this.btnBack.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBack.IdleIconLeftImage = null;
            this.btnBack.IdleIconRightImage = null;
            this.btnBack.Location = new System.Drawing.Point(556, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnBack.onHoverState = stateProperties4;
            this.btnBack.Size = new System.Drawing.Size(42, 26);
            this.btnBack.TabIndex = 31;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelTopHeader
            // 
            this.painelTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTopHeader.Location = new System.Drawing.Point(0, 0);
            this.painelTopHeader.Name = "painelTopHeader";
            this.painelTopHeader.Size = new System.Drawing.Size(848, 31);
            this.painelTopHeader.TabIndex = 42;
            // 
            // ListarEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.painelTopHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.companysGrid);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListarEmpresas";
            this.Size = new System.Drawing.Size(848, 508);
            this.Load += new System.EventHandler(this.ListarEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companysGrid)).EndInit();
            this.options.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid companysGrid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisa;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPesquisa;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNext;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBack;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNovaEmpresa;
        private System.Windows.Forms.ContextMenuStrip options;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalheToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn json;
        private System.Windows.Forms.Panel painelTopHeader;
    }
}
