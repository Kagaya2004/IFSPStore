namespace IFSPStore.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            grupoDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, usuáriosToolStripMenuItem, toolStripSeparator2, grupoDeProdutosToolStripMenuItem, produtoToolStripMenuItem, toolStripSeparator3, cidadeToolStripMenuItem, clienteToolStripMenuItem, toolStripSeparator4, vendaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(71, 20);
            cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(180, 22);
            usuáriosToolStripMenuItem.Text = "Usuário";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // grupoDeProdutosToolStripMenuItem
            // 
            grupoDeProdutosToolStripMenuItem.Name = "grupoDeProdutosToolStripMenuItem";
            grupoDeProdutosToolStripMenuItem.Size = new Size(180, 22);
            grupoDeProdutosToolStripMenuItem.Text = "Grupo de Produto";
            grupoDeProdutosToolStripMenuItem.Click += grupoDeProdutosToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(180, 22);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(180, 22);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(180, 22);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(3, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(794, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 17);
            lblUsuario.Text = "Usuário: ";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema IFSP Store";
            WindowState = FormWindowState.Maximized;
            FormClosing += FecharForm;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem grupoDeProdutosToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
    }
}
