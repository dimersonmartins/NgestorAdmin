namespace NgestorAdministrator.View.Components.PesquisaCompany
{
    partial class PesquisaCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaCompany));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.companysGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComanyName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            ((System.ComponentModel.ISupportInitialize)(this.companysGrid)).BeginInit();
            this.bunifuCards1.SuspendLayout();
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
            this.Empresa});
            this.companysGrid.DoubleBuffered = true;
            this.companysGrid.EnableHeadersVisualStyles = false;
            this.companysGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.companysGrid.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.companysGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companysGrid.Location = new System.Drawing.Point(19, 83);
            this.companysGrid.MultiSelect = false;
            this.companysGrid.Name = "companysGrid";
            this.companysGrid.ReadOnly = true;
            this.companysGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.companysGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companysGrid.Size = new System.Drawing.Size(566, 210);
            this.companysGrid.TabIndex = 28;
            this.companysGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companysGrid_CellDoubleClick);
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
            this.Empresa.Width = 420;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.ButtonText = "Pesquisa";
            this.btnPesquisa.ButtonTextMarginLeft = 0;
            this.btnPesquisa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPesquisa.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnPesquisa.DisabledForecolor = System.Drawing.Color.White;
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
            this.btnPesquisa.Location = new System.Drawing.Point(481, 41);
            this.btnPesquisa.Name = "btnPesquisa";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnPesquisa.onHoverState = stateProperties1;
            this.btnPesquisa.Size = new System.Drawing.Size(104, 33);
            this.btnPesquisa.TabIndex = 27;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome";
            // 
            // txtComanyName
            // 
            this.txtComanyName.AcceptsReturn = false;
            this.txtComanyName.AcceptsTab = false;
            this.txtComanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtComanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtComanyName.BackColor = System.Drawing.Color.Transparent;
            this.txtComanyName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtComanyName.BackgroundImage")));
            this.txtComanyName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtComanyName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtComanyName.BorderColorHover = System.Drawing.Color.Silver;
            this.txtComanyName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtComanyName.BorderRadius = 1;
            this.txtComanyName.BorderThickness = 2;
            this.txtComanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComanyName.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txtComanyName.DefaultText = "";
            this.txtComanyName.FillColor = System.Drawing.Color.White;
            this.txtComanyName.HideSelection = true;
            this.txtComanyName.IconLeft = null;
            this.txtComanyName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtComanyName.IconPadding = 10;
            this.txtComanyName.IconRight = null;
            this.txtComanyName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtComanyName.Location = new System.Drawing.Point(19, 41);
            this.txtComanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComanyName.MaxLength = 32767;
            this.txtComanyName.MinimumSize = new System.Drawing.Size(117, 35);
            this.txtComanyName.Modified = false;
            this.txtComanyName.Name = "txtComanyName";
            this.txtComanyName.PasswordChar = '\0';
            this.txtComanyName.ReadOnly = false;
            this.txtComanyName.SelectedText = "";
            this.txtComanyName.SelectionLength = 0;
            this.txtComanyName.SelectionStart = 0;
            this.txtComanyName.ShortcutsEnabled = true;
            this.txtComanyName.Size = new System.Drawing.Size(456, 35);
            this.txtComanyName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtComanyName.TabIndex = 0;
            this.txtComanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComanyName.TextMarginLeft = 5;
            this.txtComanyName.TextPlaceholder = "";
            this.txtComanyName.UseSystemPasswordChar = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.btnPesquisa);
            this.bunifuCards1.Controls.Add(this.companysGrid);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.txtComanyName);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(20, 60);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(617, 317);
            this.bunifuCards1.TabIndex = 29;
            // 
            // PesquisaCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 397);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PesquisaCompany";
            this.Resizable = false;
            this.Text = "Pesquisa Company";
            this.Load += new System.EventHandler(this.PesquisaCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companysGrid)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid companysGrid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisa;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtComanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
    }
}