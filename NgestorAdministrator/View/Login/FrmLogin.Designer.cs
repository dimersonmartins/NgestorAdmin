namespace NgestorAdministrator.View.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.selectServer = new Bunifu.UI.WinForms.BunifuDropdown();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnLogar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUser = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.selectServer);
            this.bunifuCards1.Controls.Add(this.logo);
            this.bunifuCards1.Controls.Add(this.btnLogar);
            this.bunifuCards1.Controls.Add(this.label20);
            this.bunifuCards1.Controls.Add(this.txtUser);
            this.bunifuCards1.Controls.Add(this.label26);
            this.bunifuCards1.Controls.Add(this.txtPassword);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(397, 398);
            this.bunifuCards1.TabIndex = 1;
            // 
            // selectServer
            // 
            this.selectServer.BackColor = System.Drawing.Color.White;
            this.selectServer.BorderRadius = 1;
            this.selectServer.Color = System.Drawing.Color.SteelBlue;
            this.selectServer.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.selectServer.DisabledColor = System.Drawing.Color.Gray;
            this.selectServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectServer.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.selectServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectServer.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectServer.FillDropDown = false;
            this.selectServer.FillIndicator = false;
            this.selectServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectServer.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectServer.FormattingEnabled = true;
            this.selectServer.Icon = null;
            this.selectServer.IndicatorColor = System.Drawing.Color.SteelBlue;
            this.selectServer.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectServer.ItemBackColor = System.Drawing.Color.White;
            this.selectServer.ItemBorderColor = System.Drawing.Color.White;
            this.selectServer.ItemForeColor = System.Drawing.Color.SteelBlue;
            this.selectServer.ItemHeight = 26;
            this.selectServer.ItemHighLightColor = System.Drawing.Color.Gainsboro;
            this.selectServer.Location = new System.Drawing.Point(55, 144);
            this.selectServer.Name = "selectServer";
            this.selectServer.Size = new System.Drawing.Size(280, 32);
            this.selectServer.TabIndex = 50;
            this.selectServer.Text = null;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(151, 30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 97);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 49;
            this.logo.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogar.BackgroundImage")));
            this.btnLogar.ButtonText = "Logar";
            this.btnLogar.ButtonTextMarginLeft = 0;
            this.btnLogar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnLogar.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnLogar.DisabledForecolor = System.Drawing.Color.White;
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogar.IconPadding = 10;
            this.btnLogar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLogar.IdleBorderRadius = 1;
            this.btnLogar.IdleBorderThickness = 0;
            this.btnLogar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLogar.IdleIconLeftImage = null;
            this.btnLogar.IdleIconRightImage = null;
            this.btnLogar.Location = new System.Drawing.Point(55, 315);
            this.btnLogar.Name = "btnLogar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnLogar.onHoverState = stateProperties1;
            this.btnLogar.Size = new System.Drawing.Size(280, 45);
            this.btnLogar.TabIndex = 24;
            this.btnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 16);
            this.label20.TabIndex = 23;
            this.label20.Text = "Usuário:";
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = false;
            this.txtUser.AcceptsTab = false;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUser.BackgroundImage")));
            this.txtUser.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUser.BorderColorHover = System.Drawing.Color.Silver;
            this.txtUser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtUser.BorderRadius = 1;
            this.txtUser.BorderThickness = 2;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txtUser.DefaultText = "jpaulolxm@gmail.com";
            this.txtUser.FillColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = true;
            this.txtUser.IconLeft = null;
            this.txtUser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtUser.IconPadding = 10;
            this.txtUser.IconRight = null;
            this.txtUser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtUser.Location = new System.Drawing.Point(55, 199);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MinimumSize = new System.Drawing.Size(117, 35);
            this.txtUser.Modified = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ReadOnly = false;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(282, 35);
            this.txtUser.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtUser.TabIndex = 22;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMarginLeft = 5;
            this.txtUser.TextPlaceholder = "";
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(51, 249);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 16);
            this.label26.TabIndex = 21;
            this.label26.Text = "Senha:";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.Silver;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txtPassword.DefaultText = "123456";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Location = new System.Drawing.Point(55, 273);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(117, 35);
            this.txtPassword.Modified = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(280, 35);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 20;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextPlaceholder = "";
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 398);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogar;
        private System.Windows.Forms.Label label20;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtUser;
        private System.Windows.Forms.Label label26;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuDropdown selectServer;
    }
}