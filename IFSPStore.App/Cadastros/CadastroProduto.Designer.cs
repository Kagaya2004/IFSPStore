namespace IFSPStore.App.Cadastros
{
    partial class CadastroProduto
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
            tbPreco = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cbGrupo = new ReaLTaiizor.Controls.MaterialComboBox();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbUnidadeVenda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbDataCompra = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbDataCompra);
            tabPageCadastro.Controls.Add(tbUnidadeVenda);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Controls.Add(cbGrupo);
            tabPageCadastro.Controls.Add(tbPreco);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(tbPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(cbGrupo, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbNome, 0);
            tabPageCadastro.Controls.SetChildIndex(tbUnidadeVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataCompra, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(625, 320);
            // 
            // tbPreco
            // 
            tbPreco.AllowPromptAsInput = true;
            tbPreco.AnimateReadOnly = false;
            tbPreco.AsciiOnly = false;
            tbPreco.BackgroundImageLayout = ImageLayout.None;
            tbPreco.BeepOnError = false;
            tbPreco.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbPreco.Depth = 0;
            tbPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPreco.HidePromptOnLeave = false;
            tbPreco.HideSelection = true;
            tbPreco.Hint = "Preço";
            tbPreco.InsertKeyMode = InsertKeyMode.Default;
            tbPreco.LeadingIcon = null;
            tbPreco.Location = new Point(37, 98);
            tbPreco.Mask = "";
            tbPreco.MaxLength = 32767;
            tbPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPreco.Name = "tbPreco";
            tbPreco.PasswordChar = '\0';
            tbPreco.PrefixSuffixText = null;
            tbPreco.PromptChar = '_';
            tbPreco.ReadOnly = false;
            tbPreco.RejectInputOnFirstFailure = false;
            tbPreco.ResetOnPrompt = true;
            tbPreco.ResetOnSpace = true;
            tbPreco.RightToLeft = RightToLeft.No;
            tbPreco.SelectedText = "";
            tbPreco.SelectionLength = 0;
            tbPreco.SelectionStart = 0;
            tbPreco.ShortcutsEnabled = true;
            tbPreco.Size = new Size(174, 48);
            tbPreco.SkipLiterals = true;
            tbPreco.TabIndex = 4;
            tbPreco.TabStop = false;
            tbPreco.TextAlign = HorizontalAlignment.Center;
            tbPreco.TextMaskFormat = MaskFormat.IncludePrompt;
            tbPreco.TrailingIcon = null;
            tbPreco.UseSystemPasswordChar = false;
            tbPreco.ValidatingType = null;
            // 
            // cbGrupo
            // 
            cbGrupo.AutoResize = false;
            cbGrupo.BackColor = Color.FromArgb(255, 255, 255);
            cbGrupo.Depth = 0;
            cbGrupo.DrawMode = DrawMode.OwnerDrawVariable;
            cbGrupo.DropDownHeight = 174;
            cbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupo.DropDownWidth = 121;
            cbGrupo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbGrupo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Hint = "Grupo";
            cbGrupo.IntegralHeight = false;
            cbGrupo.ItemHeight = 43;
            cbGrupo.Location = new Point(37, 168);
            cbGrupo.MaxDropDownItems = 4;
            cbGrupo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(716, 49);
            cbGrupo.StartIndex = 0;
            cbGrupo.TabIndex = 5;
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
            tbId.Location = new Point(37, 28);
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
            tbId.Size = new Size(92, 48);
            tbId.TabIndex = 6;
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
            tbNome.Location = new Point(160, 28);
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
            tbNome.Size = new Size(593, 48);
            tbNome.TabIndex = 7;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // tbUnidadeVenda
            // 
            tbUnidadeVenda.AnimateReadOnly = false;
            tbUnidadeVenda.AutoCompleteMode = AutoCompleteMode.None;
            tbUnidadeVenda.AutoCompleteSource = AutoCompleteSource.None;
            tbUnidadeVenda.BackgroundImageLayout = ImageLayout.None;
            tbUnidadeVenda.CharacterCasing = CharacterCasing.Normal;
            tbUnidadeVenda.Depth = 0;
            tbUnidadeVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUnidadeVenda.HideSelection = true;
            tbUnidadeVenda.Hint = "Unidade Venda";
            tbUnidadeVenda.LeadingIcon = null;
            tbUnidadeVenda.Location = new Point(235, 98);
            tbUnidadeVenda.MaxLength = 32767;
            tbUnidadeVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbUnidadeVenda.Name = "tbUnidadeVenda";
            tbUnidadeVenda.PasswordChar = '\0';
            tbUnidadeVenda.PrefixSuffixText = null;
            tbUnidadeVenda.ReadOnly = false;
            tbUnidadeVenda.RightToLeft = RightToLeft.No;
            tbUnidadeVenda.SelectedText = "";
            tbUnidadeVenda.SelectionLength = 0;
            tbUnidadeVenda.SelectionStart = 0;
            tbUnidadeVenda.ShortcutsEnabled = true;
            tbUnidadeVenda.Size = new Size(279, 48);
            tbUnidadeVenda.TabIndex = 8;
            tbUnidadeVenda.TabStop = false;
            tbUnidadeVenda.TextAlign = HorizontalAlignment.Left;
            tbUnidadeVenda.TrailingIcon = null;
            tbUnidadeVenda.UseSystemPasswordChar = false;
            // 
            // tbDataCompra
            // 
            tbDataCompra.AllowPromptAsInput = true;
            tbDataCompra.AnimateReadOnly = false;
            tbDataCompra.AsciiOnly = false;
            tbDataCompra.BackgroundImageLayout = ImageLayout.None;
            tbDataCompra.BeepOnError = false;
            tbDataCompra.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataCompra.Depth = 0;
            tbDataCompra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataCompra.HidePromptOnLeave = false;
            tbDataCompra.HideSelection = true;
            tbDataCompra.Hint = "Data Compra";
            tbDataCompra.InsertKeyMode = InsertKeyMode.Default;
            tbDataCompra.LeadingIcon = null;
            tbDataCompra.Location = new Point(540, 98);
            tbDataCompra.Mask = "99/99/9999";
            tbDataCompra.MaxLength = 32767;
            tbDataCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataCompra.Name = "tbDataCompra";
            tbDataCompra.PasswordChar = '\0';
            tbDataCompra.PrefixSuffixText = null;
            tbDataCompra.PromptChar = '_';
            tbDataCompra.ReadOnly = false;
            tbDataCompra.RejectInputOnFirstFailure = false;
            tbDataCompra.ResetOnPrompt = true;
            tbDataCompra.ResetOnSpace = true;
            tbDataCompra.RightToLeft = RightToLeft.No;
            tbDataCompra.SelectedText = "";
            tbDataCompra.SelectionLength = 0;
            tbDataCompra.SelectionStart = 0;
            tbDataCompra.ShortcutsEnabled = true;
            tbDataCompra.Size = new Size(213, 48);
            tbDataCompra.SkipLiterals = true;
            tbDataCompra.TabIndex = 9;
            tbDataCompra.TabStop = false;
            tbDataCompra.Text = "  /  /";
            tbDataCompra.TextAlign = HorizontalAlignment.Center;
            tbDataCompra.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataCompra.TrailingIcon = null;
            tbDataCompra.UseSystemPasswordChar = false;
            tbDataCompra.ValidatingType = null;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialComboBox cbGrupo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbPreco;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataCompra;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbUnidadeVenda;
    }
}