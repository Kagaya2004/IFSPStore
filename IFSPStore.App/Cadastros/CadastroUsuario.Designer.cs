namespace IFSPStore.App.Cadastros
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chAtivo = new ReaLTaiizor.Controls.MaterialCheckBox();
            tbDataCadastro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbDataLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbDataLogin);
            tabPageCadastro.Controls.Add(tbDataCadastro);
            tabPageCadastro.Controls.Add(chAtivo);
            tabPageCadastro.Controls.Add(tbEmail);
            tabPageCadastro.Controls.Add(tbSenha);
            tabPageCadastro.Controls.Add(tbLogin);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbNome, 0);
            tabPageCadastro.Controls.SetChildIndex(tbLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(tbSenha, 0);
            tabPageCadastro.Controls.SetChildIndex(tbEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(chAtivo, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataCadastro, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataLogin, 0);
            // 
            // tbId
            // 
            tbId.AnimateReadOnly = false;
            tbId.AutoCompleteMode = AutoCompleteMode.None;
            tbId.AutoCompleteSource = AutoCompleteSource.None;
            tbId.BackgroundImageLayout = ImageLayout.None;
            tbId.CharacterCasing = CharacterCasing.Normal;
            tbId.Depth = 0;
            tbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbId.HideSelection = true;
            tbId.Hint = "ID";
            tbId.LeadingIcon = null;
            tbId.Location = new Point(40, 29);
            tbId.MaxLength = 32767;
            tbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbId.Name = "tbId";
            tbId.PasswordChar = '\0';
            tbId.PrefixSuffixText = null;
            tbId.ReadOnly = false;
            tbId.RightToLeft = RightToLeft.No;
            tbId.SelectedText = "";
            tbId.SelectionLength = 0;
            tbId.SelectionStart = 0;
            tbId.ShortcutsEnabled = true;
            tbId.Size = new Size(82, 48);
            tbId.TabIndex = 0;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // tbNome
            // 
            tbNome.AnimateReadOnly = false;
            tbNome.AutoCompleteMode = AutoCompleteMode.None;
            tbNome.AutoCompleteSource = AutoCompleteSource.None;
            tbNome.BackgroundImageLayout = ImageLayout.None;
            tbNome.CharacterCasing = CharacterCasing.Normal;
            tbNome.Depth = 0;
            tbNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbNome.HideSelection = true;
            tbNome.Hint = "Nome";
            tbNome.LeadingIcon = null;
            tbNome.Location = new Point(148, 29);
            tbNome.MaxLength = 32767;
            tbNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbNome.Name = "tbNome";
            tbNome.PasswordChar = '\0';
            tbNome.PrefixSuffixText = null;
            tbNome.ReadOnly = false;
            tbNome.RightToLeft = RightToLeft.No;
            tbNome.SelectedText = "";
            tbNome.SelectionLength = 0;
            tbNome.SelectionStart = 0;
            tbNome.ShortcutsEnabled = true;
            tbNome.Size = new Size(605, 48);
            tbNome.TabIndex = 1;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // tbLogin
            // 
            tbLogin.AnimateReadOnly = false;
            tbLogin.AutoCompleteMode = AutoCompleteMode.None;
            tbLogin.AutoCompleteSource = AutoCompleteSource.None;
            tbLogin.BackgroundImageLayout = ImageLayout.None;
            tbLogin.CharacterCasing = CharacterCasing.Normal;
            tbLogin.Depth = 0;
            tbLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbLogin.HideSelection = true;
            tbLogin.Hint = "Login";
            tbLogin.LeadingIcon = null;
            tbLogin.Location = new Point(40, 92);
            tbLogin.MaxLength = 32767;
            tbLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbLogin.Name = "tbLogin";
            tbLogin.PasswordChar = '\0';
            tbLogin.PrefixSuffixText = null;
            tbLogin.ReadOnly = false;
            tbLogin.RightToLeft = RightToLeft.No;
            tbLogin.SelectedText = "";
            tbLogin.SelectionLength = 0;
            tbLogin.SelectionStart = 0;
            tbLogin.ShortcutsEnabled = true;
            tbLogin.Size = new Size(425, 48);
            tbLogin.TabIndex = 2;
            tbLogin.TabStop = false;
            tbLogin.TextAlign = HorizontalAlignment.Left;
            tbLogin.TrailingIcon = null;
            tbLogin.UseSystemPasswordChar = false;
            // 
            // tbSenha
            // 
            tbSenha.AnimateReadOnly = false;
            tbSenha.AutoCompleteMode = AutoCompleteMode.None;
            tbSenha.AutoCompleteSource = AutoCompleteSource.None;
            tbSenha.BackgroundImageLayout = ImageLayout.None;
            tbSenha.CharacterCasing = CharacterCasing.Normal;
            tbSenha.Depth = 0;
            tbSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSenha.HideSelection = true;
            tbSenha.Hint = "Senha";
            tbSenha.LeadingIcon = (Image)resources.GetObject("tbSenha.LeadingIcon");
            tbSenha.Location = new Point(40, 221);
            tbSenha.MaxLength = 32767;
            tbSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.PrefixSuffixText = null;
            tbSenha.ReadOnly = false;
            tbSenha.RightToLeft = RightToLeft.No;
            tbSenha.SelectedText = "";
            tbSenha.SelectionLength = 0;
            tbSenha.SelectionStart = 0;
            tbSenha.ShortcutsEnabled = true;
            tbSenha.Size = new Size(542, 48);
            tbSenha.TabIndex = 6;
            tbSenha.TabStop = false;
            tbSenha.TextAlign = HorizontalAlignment.Left;
            tbSenha.TrailingIcon = null;
            tbSenha.UseSystemPasswordChar = false;
            // 
            // tbEmail
            // 
            tbEmail.AnimateReadOnly = false;
            tbEmail.AutoCompleteMode = AutoCompleteMode.None;
            tbEmail.AutoCompleteSource = AutoCompleteSource.None;
            tbEmail.BackgroundImageLayout = ImageLayout.None;
            tbEmail.CharacterCasing = CharacterCasing.Normal;
            tbEmail.Depth = 0;
            tbEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmail.HideSelection = true;
            tbEmail.Hint = "Email";
            tbEmail.LeadingIcon = null;
            tbEmail.Location = new Point(40, 155);
            tbEmail.MaxLength = 32767;
            tbEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEmail.Name = "tbEmail";
            tbEmail.PasswordChar = '\0';
            tbEmail.PrefixSuffixText = null;
            tbEmail.ReadOnly = false;
            tbEmail.RightToLeft = RightToLeft.No;
            tbEmail.SelectedText = "";
            tbEmail.SelectionLength = 0;
            tbEmail.SelectionStart = 0;
            tbEmail.ShortcutsEnabled = true;
            tbEmail.Size = new Size(425, 48);
            tbEmail.TabIndex = 4;
            tbEmail.TabStop = false;
            tbEmail.TextAlign = HorizontalAlignment.Left;
            tbEmail.TrailingIcon = null;
            tbEmail.UseSystemPasswordChar = false;
            // 
            // chAtivo
            // 
            chAtivo.AutoSize = true;
            chAtivo.Depth = 0;
            chAtivo.Font = new Font("Segoe UI", 12F);
            chAtivo.Location = new Point(618, 228);
            chAtivo.Margin = new Padding(0);
            chAtivo.MouseLocation = new Point(-1, -1);
            chAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chAtivo.Name = "chAtivo";
            chAtivo.ReadOnly = false;
            chAtivo.Ripple = true;
            chAtivo.Size = new Size(129, 37);
            chAtivo.TabIndex = 7;
            chAtivo.Text = "Usuário Ativo";
            chAtivo.UseAccentColor = false;
            chAtivo.UseVisualStyleBackColor = true;
            // 
            // tbDataCadastro
            // 
            tbDataCadastro.AnimateReadOnly = false;
            tbDataCadastro.AutoCompleteMode = AutoCompleteMode.None;
            tbDataCadastro.AutoCompleteSource = AutoCompleteSource.None;
            tbDataCadastro.BackgroundImageLayout = ImageLayout.None;
            tbDataCadastro.CharacterCasing = CharacterCasing.Normal;
            tbDataCadastro.Depth = 0;
            tbDataCadastro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataCadastro.HideSelection = true;
            tbDataCadastro.Hint = "Data Cadastro";
            tbDataCadastro.LeadingIcon = null;
            tbDataCadastro.Location = new Point(503, 92);
            tbDataCadastro.MaxLength = 32767;
            tbDataCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataCadastro.Name = "tbDataCadastro";
            tbDataCadastro.PasswordChar = '\0';
            tbDataCadastro.PrefixSuffixText = null;
            tbDataCadastro.ReadOnly = false;
            tbDataCadastro.RightToLeft = RightToLeft.No;
            tbDataCadastro.SelectedText = "";
            tbDataCadastro.SelectionLength = 0;
            tbDataCadastro.SelectionStart = 0;
            tbDataCadastro.ShortcutsEnabled = true;
            tbDataCadastro.Size = new Size(250, 48);
            tbDataCadastro.TabIndex = 3;
            tbDataCadastro.TabStop = false;
            tbDataCadastro.TextAlign = HorizontalAlignment.Left;
            tbDataCadastro.TrailingIcon = null;
            tbDataCadastro.UseSystemPasswordChar = false;
            // 
            // tbDataLogin
            // 
            tbDataLogin.AnimateReadOnly = false;
            tbDataLogin.AutoCompleteMode = AutoCompleteMode.None;
            tbDataLogin.AutoCompleteSource = AutoCompleteSource.None;
            tbDataLogin.BackgroundImageLayout = ImageLayout.None;
            tbDataLogin.CharacterCasing = CharacterCasing.Normal;
            tbDataLogin.Depth = 0;
            tbDataLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataLogin.HideSelection = true;
            tbDataLogin.Hint = "Data de Último Login";
            tbDataLogin.LeadingIcon = null;
            tbDataLogin.Location = new Point(503, 155);
            tbDataLogin.MaxLength = 32767;
            tbDataLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataLogin.Name = "tbDataLogin";
            tbDataLogin.PasswordChar = '\0';
            tbDataLogin.PrefixSuffixText = null;
            tbDataLogin.ReadOnly = false;
            tbDataLogin.RightToLeft = RightToLeft.No;
            tbDataLogin.SelectedText = "";
            tbDataLogin.SelectionLength = 0;
            tbDataLogin.SelectionStart = 0;
            tbDataLogin.ShortcutsEnabled = true;
            tbDataLogin.Size = new Size(250, 48);
            tbDataLogin.TabIndex = 5;
            tbDataLogin.TabStop = false;
            tbDataLogin.TextAlign = HorizontalAlignment.Left;
            tbDataLogin.TrailingIcon = null;
            tbDataLogin.UseSystemPasswordChar = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroUsuario";
            Text = "CadastroUsuario";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCheckBox chAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbDataLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbDataCadastro;
    }
}