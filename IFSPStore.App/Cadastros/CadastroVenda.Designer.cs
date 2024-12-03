namespace IFSPStore.App.Cadastros
{
    partial class CadastroVenda
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
            gbProdutos = new GroupBox();
            lblQuantidade = new Label();
            dgvVenda = new DataGridView();
            lblValorTotal = new Label();
            btAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            tbValorTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbValorUnitario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbProduto = new ReaLTaiizor.Controls.MaterialComboBox();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbDataVenda = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cbUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            cbCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenda).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Size = new Size(794, 632);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cbCliente);
            tabPageCadastro.Controls.Add(cbUsuario);
            tabPageCadastro.Controls.Add(tbDataVenda);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Controls.Add(gbProdutos);
            tabPageCadastro.Size = new Size(786, 597);
            tabPageCadastro.Controls.SetChildIndex(gbProdutos, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(cbUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(cbCliente, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(625, 320);
            // 
            // gbProdutos
            // 
            gbProdutos.Controls.Add(lblQuantidade);
            gbProdutos.Controls.Add(dgvVenda);
            gbProdutos.Controls.Add(lblValorTotal);
            gbProdutos.Controls.Add(btAdicionar);
            gbProdutos.Controls.Add(tbValorTotal);
            gbProdutos.Controls.Add(tbQuantidade);
            gbProdutos.Controls.Add(tbValorUnitario);
            gbProdutos.Controls.Add(cbProduto);
            gbProdutos.Location = new Point(25, 155);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(745, 395);
            gbProdutos.TabIndex = 4;
            gbProdutos.TabStop = false;
            gbProdutos.Text = "Produtos da Venda";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(6, 373);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(93, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Qtd. Produtos: 0";
            // 
            // dgvVenda
            // 
            dgvVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenda.Location = new Point(0, 86);
            dgvVenda.Name = "dgvVenda";
            dgvVenda.Size = new Size(744, 284);
            dgvVenda.TabIndex = 5;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(590, 373);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(104, 15);
            lblValorTotal.TabIndex = 7;
            lblValorTotal.Text = "Valor Total: R$ 0,00";
            // 
            // btAdicionar
            // 
            btAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btAdicionar.Depth = 0;
            btAdicionar.HighEmphasis = true;
            btAdicionar.Icon = null;
            btAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btAdicionar.Location = new Point(656, 40);
            btAdicionar.Margin = new Padding(4, 6, 4, 6);
            btAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btAdicionar.Name = "btAdicionar";
            btAdicionar.NoAccentTextColor = Color.Empty;
            btAdicionar.Size = new Size(64, 36);
            btAdicionar.TabIndex = 4;
            btAdicionar.Text = "+";
            btAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btAdicionar.UseAccentColor = false;
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // tbValorTotal
            // 
            tbValorTotal.AnimateReadOnly = false;
            tbValorTotal.AutoCompleteMode = AutoCompleteMode.None;
            tbValorTotal.AutoCompleteSource = AutoCompleteSource.None;
            tbValorTotal.BackgroundImageLayout = ImageLayout.None;
            tbValorTotal.CharacterCasing = CharacterCasing.Normal;
            tbValorTotal.Depth = 0;
            tbValorTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbValorTotal.HideSelection = true;
            tbValorTotal.Hint = "Vl. Total";
            tbValorTotal.LeadingIcon = null;
            tbValorTotal.Location = new Point(532, 32);
            tbValorTotal.MaxLength = 32767;
            tbValorTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbValorTotal.Name = "tbValorTotal";
            tbValorTotal.PasswordChar = '\0';
            tbValorTotal.PrefixSuffixText = null;
            tbValorTotal.ReadOnly = false;
            tbValorTotal.RightToLeft = RightToLeft.No;
            tbValorTotal.SelectedText = "";
            tbValorTotal.SelectionLength = 0;
            tbValorTotal.SelectionStart = 0;
            tbValorTotal.ShortcutsEnabled = true;
            tbValorTotal.Size = new Size(93, 48);
            tbValorTotal.TabIndex = 3;
            tbValorTotal.TabStop = false;
            tbValorTotal.TextAlign = HorizontalAlignment.Left;
            tbValorTotal.TrailingIcon = null;
            tbValorTotal.UseSystemPasswordChar = false;
            // 
            // tbQuantidade
            // 
            tbQuantidade.AnimateReadOnly = false;
            tbQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            tbQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            tbQuantidade.BackgroundImageLayout = ImageLayout.None;
            tbQuantidade.CharacterCasing = CharacterCasing.Normal;
            tbQuantidade.Depth = 0;
            tbQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbQuantidade.HideSelection = true;
            tbQuantidade.Hint = "Qtd.";
            tbQuantidade.LeadingIcon = null;
            tbQuantidade.Location = new Point(408, 32);
            tbQuantidade.MaxLength = 32767;
            tbQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.PasswordChar = '\0';
            tbQuantidade.PrefixSuffixText = null;
            tbQuantidade.ReadOnly = false;
            tbQuantidade.RightToLeft = RightToLeft.No;
            tbQuantidade.SelectedText = "";
            tbQuantidade.SelectionLength = 0;
            tbQuantidade.SelectionStart = 0;
            tbQuantidade.ShortcutsEnabled = true;
            tbQuantidade.Size = new Size(93, 48);
            tbQuantidade.TabIndex = 2;
            tbQuantidade.TabStop = false;
            tbQuantidade.TextAlign = HorizontalAlignment.Left;
            tbQuantidade.TrailingIcon = null;
            tbQuantidade.UseSystemPasswordChar = false;
            // 
            // tbValorUnitario
            // 
            tbValorUnitario.AnimateReadOnly = false;
            tbValorUnitario.AutoCompleteMode = AutoCompleteMode.None;
            tbValorUnitario.AutoCompleteSource = AutoCompleteSource.None;
            tbValorUnitario.BackgroundImageLayout = ImageLayout.None;
            tbValorUnitario.CharacterCasing = CharacterCasing.Normal;
            tbValorUnitario.Depth = 0;
            tbValorUnitario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbValorUnitario.HideSelection = true;
            tbValorUnitario.Hint = "Vl. Unit.";
            tbValorUnitario.LeadingIcon = null;
            tbValorUnitario.Location = new Point(284, 32);
            tbValorUnitario.MaxLength = 32767;
            tbValorUnitario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbValorUnitario.Name = "tbValorUnitario";
            tbValorUnitario.PasswordChar = '\0';
            tbValorUnitario.PrefixSuffixText = null;
            tbValorUnitario.ReadOnly = false;
            tbValorUnitario.RightToLeft = RightToLeft.No;
            tbValorUnitario.SelectedText = "";
            tbValorUnitario.SelectionLength = 0;
            tbValorUnitario.SelectionStart = 0;
            tbValorUnitario.ShortcutsEnabled = true;
            tbValorUnitario.Size = new Size(93, 48);
            tbValorUnitario.TabIndex = 1;
            tbValorUnitario.TabStop = false;
            tbValorUnitario.TextAlign = HorizontalAlignment.Left;
            tbValorUnitario.TrailingIcon = null;
            tbValorUnitario.UseSystemPasswordChar = false;
            // 
            // cbProduto
            // 
            cbProduto.AutoResize = false;
            cbProduto.BackColor = Color.FromArgb(255, 255, 255);
            cbProduto.Depth = 0;
            cbProduto.DrawMode = DrawMode.OwnerDrawVariable;
            cbProduto.DropDownHeight = 174;
            cbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProduto.DropDownWidth = 121;
            cbProduto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbProduto.FormattingEnabled = true;
            cbProduto.Hint = "Produto";
            cbProduto.IntegralHeight = false;
            cbProduto.ItemHeight = 43;
            cbProduto.Location = new Point(6, 31);
            cbProduto.MaxDropDownItems = 4;
            cbProduto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(247, 49);
            cbProduto.StartIndex = 0;
            cbProduto.TabIndex = 0;
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
            tbId.Location = new Point(679, 20);
            tbId.MaxLength = 32767;
            tbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbId.Name = "tbId";
            tbId.PasswordChar = '\0';
            tbId.PrefixSuffixText = null;
            tbId.ReadOnly = true;
            tbId.RightToLeft = RightToLeft.No;
            tbId.SelectedText = "";
            tbId.SelectionLength = 0;
            tbId.SelectionStart = 0;
            tbId.ShortcutsEnabled = true;
            tbId.Size = new Size(90, 48);
            tbId.TabIndex = 5;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // tbDataVenda
            // 
            tbDataVenda.AllowPromptAsInput = true;
            tbDataVenda.AnimateReadOnly = false;
            tbDataVenda.AsciiOnly = false;
            tbDataVenda.BackgroundImageLayout = ImageLayout.None;
            tbDataVenda.BeepOnError = false;
            tbDataVenda.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataVenda.Depth = 0;
            tbDataVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataVenda.HidePromptOnLeave = false;
            tbDataVenda.HideSelection = true;
            tbDataVenda.Hint = "Data Venda";
            tbDataVenda.InsertKeyMode = InsertKeyMode.Default;
            tbDataVenda.LeadingIcon = null;
            tbDataVenda.Location = new Point(28, 20);
            tbDataVenda.Mask = "99/99/9999";
            tbDataVenda.MaxLength = 32767;
            tbDataVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataVenda.Name = "tbDataVenda";
            tbDataVenda.PasswordChar = '\0';
            tbDataVenda.PrefixSuffixText = null;
            tbDataVenda.PromptChar = '_';
            tbDataVenda.ReadOnly = false;
            tbDataVenda.RejectInputOnFirstFailure = false;
            tbDataVenda.ResetOnPrompt = true;
            tbDataVenda.ResetOnSpace = true;
            tbDataVenda.RightToLeft = RightToLeft.No;
            tbDataVenda.SelectedText = "";
            tbDataVenda.SelectionLength = 0;
            tbDataVenda.SelectionStart = 0;
            tbDataVenda.ShortcutsEnabled = true;
            tbDataVenda.Size = new Size(250, 48);
            tbDataVenda.SkipLiterals = true;
            tbDataVenda.TabIndex = 6;
            tbDataVenda.TabStop = false;
            tbDataVenda.Text = "  /  /";
            tbDataVenda.TextAlign = HorizontalAlignment.Left;
            tbDataVenda.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataVenda.TrailingIcon = null;
            tbDataVenda.UseSystemPasswordChar = false;
            tbDataVenda.ValidatingType = null;
            // 
            // cbUsuario
            // 
            cbUsuario.AutoResize = false;
            cbUsuario.BackColor = Color.FromArgb(255, 255, 255);
            cbUsuario.Depth = 0;
            cbUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            cbUsuario.DropDownHeight = 174;
            cbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsuario.DropDownWidth = 121;
            cbUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Hint = "Usuário/Vendedor";
            cbUsuario.IntegralHeight = false;
            cbUsuario.ItemHeight = 43;
            cbUsuario.Location = new Point(317, 20);
            cbUsuario.MaxDropDownItems = 4;
            cbUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(323, 49);
            cbUsuario.StartIndex = 0;
            cbUsuario.TabIndex = 7;
            // 
            // cbCliente
            // 
            cbCliente.AutoResize = false;
            cbCliente.BackColor = Color.FromArgb(255, 255, 255);
            cbCliente.Depth = 0;
            cbCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cbCliente.DropDownHeight = 174;
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.DropDownWidth = 121;
            cbCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCliente.FormattingEnabled = true;
            cbCliente.Hint = "Cliente";
            cbCliente.IntegralHeight = false;
            cbCliente.ItemHeight = 43;
            cbCliente.Location = new Point(25, 89);
            cbCliente.MaxDropDownItems = 4;
            cbCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(745, 49);
            cbCliente.StartIndex = 0;
            cbCliente.TabIndex = 8;
            // 
            // CadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 699);
            Location = new Point(0, 0);
            Name = "CadastroVenda";
            Text = "Cadastro de Venda";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            gbProdutos.ResumeLayout(false);
            gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private GroupBox gbProdutos;
        private ReaLTaiizor.Controls.MaterialComboBox cbUsuario;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataVenda;
        private ReaLTaiizor.Controls.MaterialComboBox cbCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cbProduto;
        private DataGridView dgvVenda;
        private ReaLTaiizor.Controls.MaterialButton btAdicionar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbValorTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbQuantidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbValorUnitario;
        private Label lblValorTotal;
        private Label lblQuantidade;
    }
}