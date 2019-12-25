namespace NgestorAdministrator.View.OperadoraServidores
{
    partial class Novo
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novo));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.selectOperadora = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_uri = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.txt_name);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.selectOperadora);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.txt_uri);
            this.bunifuCards1.Controls.Add(this.btnSave);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(20, 60);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(508, 162);
            this.bunifuCards1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(4, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Operadora:";
            // 
            // selectOperadora
            // 
            this.selectOperadora.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectOperadora.BorderRadius = 1;
            this.selectOperadora.Color = System.Drawing.Color.Teal;
            this.selectOperadora.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.selectOperadora.DisabledColor = System.Drawing.Color.Gray;
            this.selectOperadora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectOperadora.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.selectOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectOperadora.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectOperadora.FillDropDown = false;
            this.selectOperadora.FillIndicator = false;
            this.selectOperadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectOperadora.ForeColor = System.Drawing.Color.Teal;
            this.selectOperadora.FormattingEnabled = true;
            this.selectOperadora.Icon = null;
            this.selectOperadora.IndicatorColor = System.Drawing.Color.Teal;
            this.selectOperadora.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectOperadora.ItemBackColor = System.Drawing.Color.White;
            this.selectOperadora.ItemBorderColor = System.Drawing.Color.White;
            this.selectOperadora.ItemForeColor = System.Drawing.Color.Teal;
            this.selectOperadora.ItemHeight = 26;
            this.selectOperadora.ItemHighLightColor = System.Drawing.Color.Gainsboro;
            this.selectOperadora.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.selectOperadora.Location = new System.Drawing.Point(116, 108);
            this.selectOperadora.Name = "selectOperadora";
            this.selectOperadora.Size = new System.Drawing.Size(221, 32);
            this.selectOperadora.TabIndex = 35;
            this.selectOperadora.Text = "Selecione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Uri:";
            // 
            // txt_uri
            // 
            this.txt_uri.AcceptsReturn = false;
            this.txt_uri.AcceptsTab = false;
            this.txt_uri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_uri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_uri.BackColor = System.Drawing.Color.Transparent;
            this.txt_uri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_uri.BackgroundImage")));
            this.txt_uri.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_uri.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_uri.BorderColorHover = System.Drawing.Color.Silver;
            this.txt_uri.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txt_uri.BorderRadius = 1;
            this.txt_uri.BorderThickness = 2;
            this.txt_uri.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_uri.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txt_uri.DefaultText = "";
            this.txt_uri.FillColor = System.Drawing.Color.White;
            this.txt_uri.HideSelection = true;
            this.txt_uri.IconLeft = null;
            this.txt_uri.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_uri.IconPadding = 10;
            this.txt_uri.IconRight = null;
            this.txt_uri.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txt_uri.Location = new System.Drawing.Point(116, 65);
            this.txt_uri.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_uri.MaxLength = 32767;
            this.txt_uri.MinimumSize = new System.Drawing.Size(136, 35);
            this.txt_uri.Modified = false;
            this.txt_uri.Name = "txt_uri";
            this.txt_uri.PasswordChar = '\0';
            this.txt_uri.ReadOnly = false;
            this.txt_uri.SelectedText = "";
            this.txt_uri.SelectionLength = 0;
            this.txt_uri.SelectionStart = 0;
            this.txt_uri.ShortcutsEnabled = true;
            this.txt_uri.Size = new System.Drawing.Size(379, 35);
            this.txt_uri.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_uri.TabIndex = 30;
            this.txt_uri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_uri.TextMarginLeft = 5;
            this.txt_uri.TextPlaceholder = "";
            this.txt_uri.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Salvar";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSave.DisabledForecolor = System.Drawing.Color.White;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSave.IdleBorderRadius = 1;
            this.btnSave.IdleBorderThickness = 0;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.Location = new System.Drawing.Point(355, 108);
            this.btnSave.Name = "btnSave";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties1;
            this.btnSave.Size = new System.Drawing.Size(140, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(45, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.AcceptsReturn = false;
            this.txt_name.AcceptsTab = false;
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_name.BackgroundImage")));
            this.txt_name.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_name.BorderColorHover = System.Drawing.Color.Silver;
            this.txt_name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txt_name.BorderRadius = 1;
            this.txt_name.BorderThickness = 2;
            this.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_name.DefaultFont = new System.Drawing.Font("Arial", 10F);
            this.txt_name.DefaultText = "";
            this.txt_name.FillColor = System.Drawing.Color.White;
            this.txt_name.HideSelection = true;
            this.txt_name.IconLeft = null;
            this.txt_name.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_name.IconPadding = 10;
            this.txt_name.IconRight = null;
            this.txt_name.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txt_name.Location = new System.Drawing.Point(116, 20);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_name.MaxLength = 32767;
            this.txt_name.MinimumSize = new System.Drawing.Size(136, 35);
            this.txt_name.Modified = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ReadOnly = false;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(379, 35);
            this.txt_name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_name.TabIndex = 37;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.TextMarginLeft = 5;
            this.txt_name.TextPlaceholder = "";
            this.txt_name.UseSystemPasswordChar = false;
            // 
            // Novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 242);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Novo";
            this.Resizable = false;
            this.Text = "Novo Servidor";
            this.Load += new System.EventHandler(this.Novo_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_uri;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown selectOperadora;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_name;
    }
}