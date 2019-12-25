namespace NgestorAdministrator.View.NetHome
{
    partial class VNetHome
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VNetHome));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.painel_container = new Bunifu.Framework.UI.BunifuCards();
            this.advancedWizard1 = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.stepOne = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.selectBaseOperadora = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.configEmpreiteira = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.selectOperacao = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectLocalizacao = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameEmpreiteira = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnPesquisaEmpreiteira = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.selectTipoFiltro = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.painel_container.SuspendLayout();
            this.advancedWizard1.SuspendLayout();
            this.stepOne.SuspendLayout();
            this.configEmpreiteira.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_container
            // 
            this.painel_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.painel_container.BorderRadius = 5;
            this.painel_container.BottomSahddow = true;
            this.painel_container.color = System.Drawing.Color.SteelBlue;
            this.painel_container.Controls.Add(this.advancedWizard1);
            this.painel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_container.Font = new System.Drawing.Font("Arial", 10F);
            this.painel_container.LeftSahddow = false;
            this.painel_container.Location = new System.Drawing.Point(20, 60);
            this.painel_container.Name = "painel_container";
            this.painel_container.RightSahddow = true;
            this.painel_container.ShadowDepth = 20;
            this.painel_container.Size = new System.Drawing.Size(588, 448);
            this.painel_container.TabIndex = 5;
            // 
            // advancedWizard1
            // 
            this.advancedWizard1.BackButtonEnabled = true;
            this.advancedWizard1.BackButtonText = "< Voltar";
            this.advancedWizard1.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.advancedWizard1.ButtonsVisible = true;
            this.advancedWizard1.CancelButtonText = "&Cancel";
            this.advancedWizard1.Controls.Add(this.configEmpreiteira);
            this.advancedWizard1.Controls.Add(this.stepOne);
            this.advancedWizard1.CurrentPageIsFinishPage = false;
            this.advancedWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizard1.FinishButton = true;
            this.advancedWizard1.FinishButtonEnabled = true;
            this.advancedWizard1.FinishButtonText = "&Salvar";
            this.advancedWizard1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.advancedWizard1.HelpButton = false;
            this.advancedWizard1.HelpButtonText = "";
            this.advancedWizard1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizard1.Name = "advancedWizard1";
            this.advancedWizard1.NextButtonEnabled = false;
            this.advancedWizard1.NextButtonText = "Próximo >";
            this.advancedWizard1.ProcessKeys = false;
            this.advancedWizard1.Size = new System.Drawing.Size(588, 448);
            this.advancedWizard1.TabIndex = 40;
            this.advancedWizard1.TouchScreen = false;
            this.advancedWizard1.WizardPages.Add(this.stepOne);
            this.advancedWizard1.WizardPages.Add(this.configEmpreiteira);
            this.advancedWizard1.Finish += new System.EventHandler(this.advancedWizard1_Finish);
            // 
            // stepOne
            // 
            this.stepOne.Controls.Add(this.selectBaseOperadora);
            this.stepOne.Controls.Add(this.label6);
            this.stepOne.Controls.Add(this.label4);
            this.stepOne.Controls.Add(this.txtUser);
            this.stepOne.Controls.Add(this.txtPassword);
            this.stepOne.Controls.Add(this.label3);
            this.stepOne.Controls.Add(this.btnValidate);
            this.stepOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepOne.Header = true;
            this.stepOne.HeaderBackgroundColor = System.Drawing.Color.White;
            this.stepOne.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.stepOne.HeaderImage = ((System.Drawing.Image)(resources.GetObject("stepOne.HeaderImage")));
            this.stepOne.HeaderImageVisible = true;
            this.stepOne.HeaderTitle = "Net Home validação do login";
            this.stepOne.Location = new System.Drawing.Point(0, 0);
            this.stepOne.Name = "stepOne";
            this.stepOne.PreviousPage = 0;
            this.stepOne.Size = new System.Drawing.Size(588, 408);
            this.stepOne.SubTitle = "";
            this.stepOne.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.stepOne.TabIndex = 1;
            // 
            // selectBaseOperadora
            // 
            this.selectBaseOperadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectBaseOperadora.FormattingEnabled = true;
            this.selectBaseOperadora.ItemHeight = 16;
            this.selectBaseOperadora.Location = new System.Drawing.Point(292, 157);
            this.selectBaseOperadora.Name = "selectBaseOperadora";
            this.selectBaseOperadora.Size = new System.Drawing.Size(214, 146);
            this.selectBaseOperadora.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Base Operadora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Usuário:";
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = false;
            this.txtUser.AcceptsTab = false;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUser.BackgroundImage")));
            this.txtUser.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtUser.BorderColorHover = System.Drawing.Color.Blue;
            this.txtUser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtUser.BorderRadius = 1;
            this.txtUser.BorderThickness = 2;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txtUser.DefaultText = "";
            this.txtUser.FillColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = true;
            this.txtUser.IconLeft = null;
            this.txtUser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtUser.IconPadding = 10;
            this.txtUser.IconRight = null;
            this.txtUser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtUser.Location = new System.Drawing.Point(61, 157);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtUser.Modified = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ReadOnly = false;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(214, 35);
            this.txtUser.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtUser.TabIndex = 33;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMarginLeft = 5;
            this.txtUser.TextPlaceholder = "";
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.Blue;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Location = new System.Drawing.Point(61, 219);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPassword.Modified = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(214, 35);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 35;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextPlaceholder = "";
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Senha:";
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Transparent;
            this.btnValidate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidate.BackgroundImage")));
            this.btnValidate.ButtonText = "Validar";
            this.btnValidate.ButtonTextMarginLeft = 0;
            this.btnValidate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnValidate.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnValidate.DisabledForecolor = System.Drawing.Color.White;
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnValidate.IconPadding = 10;
            this.btnValidate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnValidate.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnValidate.IdleBorderRadius = 1;
            this.btnValidate.IdleBorderThickness = 0;
            this.btnValidate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnValidate.IdleIconLeftImage = null;
            this.btnValidate.IdleIconRightImage = null;
            this.btnValidate.Location = new System.Drawing.Point(61, 268);
            this.btnValidate.Name = "btnValidate";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnValidate.onHoverState = stateProperties4;
            this.btnValidate.Size = new System.Drawing.Size(214, 35);
            this.btnValidate.TabIndex = 37;
            this.btnValidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // configEmpreiteira
            // 
            this.configEmpreiteira.Controls.Add(this.selectOperacao);
            this.configEmpreiteira.Controls.Add(this.label1);
            this.configEmpreiteira.Controls.Add(this.label5);
            this.configEmpreiteira.Controls.Add(this.selectLocalizacao);
            this.configEmpreiteira.Controls.Add(this.label7);
            this.configEmpreiteira.Controls.Add(this.txtNameEmpreiteira);
            this.configEmpreiteira.Controls.Add(this.btnPesquisaEmpreiteira);
            this.configEmpreiteira.Controls.Add(this.selectTipoFiltro);
            this.configEmpreiteira.Controls.Add(this.label2);
            this.configEmpreiteira.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configEmpreiteira.Header = true;
            this.configEmpreiteira.HeaderBackgroundColor = System.Drawing.Color.White;
            this.configEmpreiteira.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.configEmpreiteira.HeaderImage = ((System.Drawing.Image)(resources.GetObject("configEmpreiteira.HeaderImage")));
            this.configEmpreiteira.HeaderImageVisible = true;
            this.configEmpreiteira.HeaderTitle = "Configuração da Empreiteira";
            this.configEmpreiteira.Location = new System.Drawing.Point(0, 0);
            this.configEmpreiteira.Name = "configEmpreiteira";
            this.configEmpreiteira.PreviousPage = 0;
            this.configEmpreiteira.Size = new System.Drawing.Size(588, 408);
            this.configEmpreiteira.SubTitle = "";
            this.configEmpreiteira.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.configEmpreiteira.TabIndex = 2;
            // 
            // selectOperacao
            // 
            this.selectOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectOperacao.FormattingEnabled = true;
            this.selectOperacao.ItemHeight = 16;
            this.selectOperacao.Location = new System.Drawing.Point(61, 176);
            this.selectOperacao.Name = "selectOperacao";
            this.selectOperacao.Size = new System.Drawing.Size(214, 130);
            this.selectOperacao.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Local Operação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Localização:";
            // 
            // selectLocalizacao
            // 
            this.selectLocalizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectLocalizacao.FormattingEnabled = true;
            this.selectLocalizacao.ItemHeight = 16;
            this.selectLocalizacao.Location = new System.Drawing.Point(284, 176);
            this.selectLocalizacao.Name = "selectLocalizacao";
            this.selectLocalizacao.Size = new System.Drawing.Size(222, 130);
            this.selectLocalizacao.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Empreiteira";
            // 
            // txtNameEmpreiteira
            // 
            this.txtNameEmpreiteira.AcceptsReturn = false;
            this.txtNameEmpreiteira.AcceptsTab = false;
            this.txtNameEmpreiteira.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNameEmpreiteira.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNameEmpreiteira.BackColor = System.Drawing.Color.Transparent;
            this.txtNameEmpreiteira.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNameEmpreiteira.BackgroundImage")));
            this.txtNameEmpreiteira.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtNameEmpreiteira.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtNameEmpreiteira.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtNameEmpreiteira.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtNameEmpreiteira.BorderRadius = 1;
            this.txtNameEmpreiteira.BorderThickness = 2;
            this.txtNameEmpreiteira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameEmpreiteira.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txtNameEmpreiteira.DefaultText = "";
            this.txtNameEmpreiteira.FillColor = System.Drawing.Color.White;
            this.txtNameEmpreiteira.HideSelection = true;
            this.txtNameEmpreiteira.IconLeft = null;
            this.txtNameEmpreiteira.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtNameEmpreiteira.IconPadding = 10;
            this.txtNameEmpreiteira.IconRight = null;
            this.txtNameEmpreiteira.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtNameEmpreiteira.Location = new System.Drawing.Point(60, 329);
            this.txtNameEmpreiteira.MaxLength = 32767;
            this.txtNameEmpreiteira.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtNameEmpreiteira.Modified = false;
            this.txtNameEmpreiteira.Name = "txtNameEmpreiteira";
            this.txtNameEmpreiteira.PasswordChar = '\0';
            this.txtNameEmpreiteira.ReadOnly = false;
            this.txtNameEmpreiteira.SelectedText = "";
            this.txtNameEmpreiteira.SelectionLength = 0;
            this.txtNameEmpreiteira.SelectionStart = 0;
            this.txtNameEmpreiteira.ShortcutsEnabled = true;
            this.txtNameEmpreiteira.Size = new System.Drawing.Size(335, 35);
            this.txtNameEmpreiteira.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtNameEmpreiteira.TabIndex = 38;
            this.txtNameEmpreiteira.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNameEmpreiteira.TextMarginLeft = 5;
            this.txtNameEmpreiteira.TextPlaceholder = "";
            this.txtNameEmpreiteira.UseSystemPasswordChar = false;
            // 
            // btnPesquisaEmpreiteira
            // 
            this.btnPesquisaEmpreiteira.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisaEmpreiteira.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaEmpreiteira.BackgroundImage")));
            this.btnPesquisaEmpreiteira.ButtonText = "Localizar";
            this.btnPesquisaEmpreiteira.ButtonTextMarginLeft = 0;
            this.btnPesquisaEmpreiteira.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPesquisaEmpreiteira.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnPesquisaEmpreiteira.DisabledForecolor = System.Drawing.Color.White;
            this.btnPesquisaEmpreiteira.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaEmpreiteira.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisaEmpreiteira.IconPadding = 10;
            this.btnPesquisaEmpreiteira.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisaEmpreiteira.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPesquisaEmpreiteira.IdleBorderRadius = 1;
            this.btnPesquisaEmpreiteira.IdleBorderThickness = 0;
            this.btnPesquisaEmpreiteira.IdleFillColor = System.Drawing.Color.Green;
            this.btnPesquisaEmpreiteira.IdleIconLeftImage = null;
            this.btnPesquisaEmpreiteira.IdleIconRightImage = null;
            this.btnPesquisaEmpreiteira.Location = new System.Drawing.Point(401, 329);
            this.btnPesquisaEmpreiteira.Name = "btnPesquisaEmpreiteira";
            stateProperties3.BorderColor = System.Drawing.Color.Green;
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Green;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnPesquisaEmpreiteira.onHoverState = stateProperties3;
            this.btnPesquisaEmpreiteira.Size = new System.Drawing.Size(105, 35);
            this.btnPesquisaEmpreiteira.TabIndex = 27;
            this.btnPesquisaEmpreiteira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisaEmpreiteira.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // selectTipoFiltro
            // 
            this.selectTipoFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectTipoFiltro.BorderRadius = 1;
            this.selectTipoFiltro.Color = System.Drawing.Color.Teal;
            this.selectTipoFiltro.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.selectTipoFiltro.DisabledColor = System.Drawing.Color.Gray;
            this.selectTipoFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectTipoFiltro.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.selectTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTipoFiltro.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectTipoFiltro.FillDropDown = false;
            this.selectTipoFiltro.FillIndicator = false;
            this.selectTipoFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTipoFiltro.ForeColor = System.Drawing.Color.Teal;
            this.selectTipoFiltro.FormattingEnabled = true;
            this.selectTipoFiltro.Icon = null;
            this.selectTipoFiltro.IndicatorColor = System.Drawing.Color.Teal;
            this.selectTipoFiltro.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectTipoFiltro.ItemBackColor = System.Drawing.Color.White;
            this.selectTipoFiltro.ItemBorderColor = System.Drawing.Color.White;
            this.selectTipoFiltro.ItemForeColor = System.Drawing.Color.Teal;
            this.selectTipoFiltro.ItemHeight = 26;
            this.selectTipoFiltro.ItemHighLightColor = System.Drawing.Color.Gainsboro;
            this.selectTipoFiltro.Location = new System.Drawing.Point(60, 111);
            this.selectTipoFiltro.Name = "selectTipoFiltro";
            this.selectTipoFiltro.Size = new System.Drawing.Size(446, 32);
            this.selectTipoFiltro.TabIndex = 32;
            this.selectTipoFiltro.Text = "Selecione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo de Filtro";
            // 
            // VNetHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 528);
            this.Controls.Add(this.painel_container);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "VNetHome";
            this.Resizable = false;
            this.Text = "VNetHome";
            this.Load += new System.EventHandler(this.VNetHome_Load);
            this.painel_container.ResumeLayout(false);
            this.advancedWizard1.ResumeLayout(false);
            this.stepOne.ResumeLayout(false);
            this.stepOne.PerformLayout();
            this.configEmpreiteira.ResumeLayout(false);
            this.configEmpreiteira.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards painel_container;
        private System.Windows.Forms.ListBox selectLocalizacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox selectBaseOperadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox selectOperacao;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown selectTipoFiltro;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnValidate;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtUser;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtNameEmpreiteira;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisaEmpreiteira;
        private AdvancedWizardControl.Wizard.AdvancedWizard advancedWizard1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage configEmpreiteira;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage stepOne;
    }
}