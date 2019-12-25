namespace NgestorAdministrator.View.Operadora
{
    partial class ListarOperadoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarOperadoras));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovaEmpresa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPesquisa = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnBack = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPesquisa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gridOperadoras = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelTopHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOperadoras)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(852, 32);
            this.panel1.TabIndex = 36;
            // 
            // btnNovaEmpresa
            // 
            this.btnNovaEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnNovaEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovaEmpresa.BackgroundImage")));
            this.btnNovaEmpresa.ButtonText = "Nova Operadora";
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
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnNovaEmpresa.onHoverState = stateProperties1;
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
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnNext.onHoverState = stateProperties2;
            this.btnNext.Size = new System.Drawing.Size(40, 26);
            this.btnNext.TabIndex = 32;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtPesquisa.Location = new System.Drawing.Point(3, 2);
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
            this.txtPesquisa.Size = new System.Drawing.Size(307, 28);
            this.txtPesquisa.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPesquisa.TabIndex = 29;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextMarginLeft = 5;
            this.txtPesquisa.TextPlaceholder = "";
            this.txtPesquisa.UseSystemPasswordChar = false;
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
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnBack.onHoverState = stateProperties3;
            this.btnBack.Size = new System.Drawing.Size(42, 26);
            this.btnBack.TabIndex = 31;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnPesquisa.onHoverState = stateProperties4;
            this.btnPesquisa.Size = new System.Drawing.Size(99, 26);
            this.btnPesquisa.TabIndex = 31;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // gridOperadoras
            // 
            this.gridOperadoras.AllowUserToAddRows = false;
            this.gridOperadoras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridOperadoras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOperadoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOperadoras.BackgroundColor = System.Drawing.Color.White;
            this.gridOperadoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOperadoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOperadoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridOperadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOperadoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.gridOperadoras.DoubleBuffered = true;
            this.gridOperadoras.EnableHeadersVisualStyles = false;
            this.gridOperadoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridOperadoras.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.gridOperadoras.HeaderForeColor = System.Drawing.Color.White;
            this.gridOperadoras.Location = new System.Drawing.Point(0, 66);
            this.gridOperadoras.MultiSelect = false;
            this.gridOperadoras.Name = "gridOperadoras";
            this.gridOperadoras.ReadOnly = true;
            this.gridOperadoras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridOperadoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOperadoras.Size = new System.Drawing.Size(852, 544);
            this.gridOperadoras.TabIndex = 37;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 400;
            // 
            // painelTopHeader
            // 
            this.painelTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTopHeader.Location = new System.Drawing.Point(0, 0);
            this.painelTopHeader.Name = "painelTopHeader";
            this.painelTopHeader.Size = new System.Drawing.Size(852, 31);
            this.painelTopHeader.TabIndex = 44;
            // 
            // ListarOperadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.painelTopHeader);
            this.Controls.Add(this.gridOperadoras);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "ListarOperadoras";
            this.Size = new System.Drawing.Size(852, 610);
            this.Load += new System.EventHandler(this.ListarOperadoras_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOperadoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNovaEmpresa;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNext;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPesquisa;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBack;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridOperadoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Panel painelTopHeader;
    }
}
