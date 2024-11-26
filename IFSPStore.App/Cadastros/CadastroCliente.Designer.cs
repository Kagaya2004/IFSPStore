namespace IFSPStore.App.Cadastros
{
    partial class CadastroCliente
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
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbCidade = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cbCidade);
            tabPageCadastro.Controls.Add(tbBairro);
            tabPageCadastro.Controls.Add(tbEndereco);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.SetChildIndex(tbNome, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbEndereco, 0);
            tabPageCadastro.Controls.SetChildIndex(tbBairro, 0);
            tabPageCadastro.Controls.SetChildIndex(cbCidade, 0);
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
            tbNome.Location = new Point(202, 26);
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
            tbNome.Size = new Size(553, 48);
            tbNome.TabIndex = 1;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
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
            tbId.Location = new Point(47, 26);
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
            tbId.Size = new Size(138, 48);
            tbId.TabIndex = 0;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // tbEndereco
            // 
            tbEndereco.AnimateReadOnly = false;
            tbEndereco.AutoCompleteMode = AutoCompleteMode.None;
            tbEndereco.AutoCompleteSource = AutoCompleteSource.None;
            tbEndereco.BackgroundImageLayout = ImageLayout.None;
            tbEndereco.CharacterCasing = CharacterCasing.Normal;
            tbEndereco.Depth = 0;
            tbEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEndereco.HideSelection = true;
            tbEndereco.Hint = "Endereço";
            tbEndereco.LeadingIcon = null;
            tbEndereco.Location = new Point(47, 96);
            tbEndereco.MaxLength = 32767;
            tbEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.PasswordChar = '\0';
            tbEndereco.PrefixSuffixText = null;
            tbEndereco.ReadOnly = false;
            tbEndereco.RightToLeft = RightToLeft.No;
            tbEndereco.SelectedText = "";
            tbEndereco.SelectionLength = 0;
            tbEndereco.SelectionStart = 0;
            tbEndereco.ShortcutsEnabled = true;
            tbEndereco.Size = new Size(708, 48);
            tbEndereco.TabIndex = 2;
            tbEndereco.TabStop = false;
            tbEndereco.TextAlign = HorizontalAlignment.Left;
            tbEndereco.TrailingIcon = null;
            tbEndereco.UseSystemPasswordChar = false;
            // 
            // tbBairro
            // 
            tbBairro.AnimateReadOnly = false;
            tbBairro.AutoCompleteMode = AutoCompleteMode.None;
            tbBairro.AutoCompleteSource = AutoCompleteSource.None;
            tbBairro.BackgroundImageLayout = ImageLayout.None;
            tbBairro.CharacterCasing = CharacterCasing.Normal;
            tbBairro.Depth = 0;
            tbBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbBairro.HideSelection = true;
            tbBairro.Hint = "Bairro";
            tbBairro.LeadingIcon = null;
            tbBairro.Location = new Point(47, 161);
            tbBairro.MaxLength = 32767;
            tbBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbBairro.Name = "tbBairro";
            tbBairro.PasswordChar = '\0';
            tbBairro.PrefixSuffixText = null;
            tbBairro.ReadOnly = false;
            tbBairro.RightToLeft = RightToLeft.No;
            tbBairro.SelectedText = "";
            tbBairro.SelectionLength = 0;
            tbBairro.SelectionStart = 0;
            tbBairro.ShortcutsEnabled = true;
            tbBairro.Size = new Size(708, 48);
            tbBairro.TabIndex = 3;
            tbBairro.TabStop = false;
            tbBairro.TextAlign = HorizontalAlignment.Left;
            tbBairro.TrailingIcon = null;
            tbBairro.UseSystemPasswordChar = false;
            // 
            // cbCidade
            // 
            cbCidade.AutoResize = false;
            cbCidade.BackColor = Color.FromArgb(255, 255, 255);
            cbCidade.Depth = 0;
            cbCidade.DrawMode = DrawMode.OwnerDrawVariable;
            cbCidade.DropDownHeight = 174;
            cbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCidade.DropDownWidth = 121;
            cbCidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCidade.FormattingEnabled = true;
            cbCidade.Hint = "Cidade/Estado";
            cbCidade.IntegralHeight = false;
            cbCidade.ItemHeight = 43;
            cbCidade.Location = new Point(47, 232);
            cbCidade.MaxDropDownItems = 4;
            cbCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbCidade.Name = "cbCidade";
            cbCidade.Size = new Size(708, 49);
            cbCidade.StartIndex = 0;
            cbCidade.TabIndex = 4;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cbCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
    }
}