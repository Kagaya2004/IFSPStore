namespace IFSPStore.App.Outros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btOK = new ReaLTaiizor.Controls.MaterialButton();
            btCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tbSenha = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // btOK
            // 
            btOK.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btOK.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btOK.Depth = 0;
            btOK.HighEmphasis = true;
            btOK.Icon = null;
            btOK.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btOK.Location = new Point(283, 232);
            btOK.Margin = new Padding(4, 6, 4, 6);
            btOK.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btOK.Name = "btOK";
            btOK.NoAccentTextColor = Color.Empty;
            btOK.Size = new Size(64, 36);
            btOK.TabIndex = 0;
            btOK.Text = "OK";
            btOK.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btOK.UseAccentColor = false;
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btCancelar
            // 
            btCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCancelar.Depth = 0;
            btCancelar.HighEmphasis = true;
            btCancelar.Icon = null;
            btCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btCancelar.Location = new Point(170, 232);
            btCancelar.Margin = new Padding(4, 6, 4, 6);
            btCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btCancelar.Name = "btCancelar";
            btCancelar.NoAccentTextColor = Color.Empty;
            btCancelar.Size = new Size(96, 36);
            btCancelar.TabIndex = 1;
            btCancelar.Text = "Cancelar";
            btCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btCancelar.UseAccentColor = false;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // tbSenha
            // 
            tbSenha.AllowPromptAsInput = true;
            tbSenha.AnimateReadOnly = false;
            tbSenha.AsciiOnly = false;
            tbSenha.BackgroundImageLayout = ImageLayout.None;
            tbSenha.BeepOnError = false;
            tbSenha.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbSenha.Depth = 0;
            tbSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSenha.HidePromptOnLeave = false;
            tbSenha.HideSelection = true;
            tbSenha.Hint = "Senha";
            tbSenha.InsertKeyMode = InsertKeyMode.Default;
            tbSenha.LeadingIcon = (Image)resources.GetObject("tbSenha.LeadingIcon");
            tbSenha.Location = new Point(25, 150);
            tbSenha.Mask = "";
            tbSenha.MaxLength = 32767;
            tbSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.PrefixSuffixText = null;
            tbSenha.PromptChar = '_';
            tbSenha.ReadOnly = false;
            tbSenha.RejectInputOnFirstFailure = false;
            tbSenha.ResetOnPrompt = true;
            tbSenha.ResetOnSpace = true;
            tbSenha.RightToLeft = RightToLeft.No;
            tbSenha.SelectedText = "";
            tbSenha.SelectionLength = 0;
            tbSenha.SelectionStart = 0;
            tbSenha.ShortcutsEnabled = true;
            tbSenha.Size = new Size(322, 48);
            tbSenha.SkipLiterals = true;
            tbSenha.TabIndex = 2;
            tbSenha.TabStop = false;
            tbSenha.TextAlign = HorizontalAlignment.Left;
            tbSenha.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbSenha.TrailingIcon = null;
            tbSenha.UseSystemPasswordChar = false;
            tbSenha.ValidatingType = null;
            // 
            // tbUsuario
            // 
            tbUsuario.AnimateReadOnly = false;
            tbUsuario.AutoCompleteMode = AutoCompleteMode.None;
            tbUsuario.AutoCompleteSource = AutoCompleteSource.None;
            tbUsuario.BackgroundImageLayout = ImageLayout.None;
            tbUsuario.CharacterCasing = CharacterCasing.Normal;
            tbUsuario.Depth = 0;
            tbUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsuario.HideSelection = true;
            tbUsuario.Hint = "Usuário";
            tbUsuario.LeadingIcon = null;
            tbUsuario.Location = new Point(25, 85);
            tbUsuario.MaxLength = 32767;
            tbUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PasswordChar = '\0';
            tbUsuario.PrefixSuffixText = null;
            tbUsuario.ReadOnly = false;
            tbUsuario.RightToLeft = RightToLeft.No;
            tbUsuario.SelectedText = "";
            tbUsuario.SelectionLength = 0;
            tbUsuario.SelectionStart = 0;
            tbUsuario.ShortcutsEnabled = true;
            tbUsuario.Size = new Size(322, 48);
            tbUsuario.TabIndex = 3;
            tbUsuario.TabStop = false;
            tbUsuario.TextAlign = HorizontalAlignment.Left;
            tbUsuario.TrailingIcon = null;
            tbUsuario.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 295);
            Controls.Add(tbUsuario);
            Controls.Add(tbSenha);
            Controls.Add(btCancelar);
            Controls.Add(btOK);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btOK;
        private ReaLTaiizor.Controls.MaterialButton btCancelar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbUsuario;
    }
}