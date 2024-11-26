using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroProduto : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Produto> _produtoService;
        private List<Produto>? produtos;
        #endregion

        #region Construtor
        public CadastroProduto(IBaseService<Produto> produtoService)
        {
            _produtoService = produtoService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Produto produto)
        {
            produto.Nome = tbNome.Text;
            produto.Preco = float.Parse(tbPreco.Text);
            produto.UnidadeVenda = tbUnidadeVenda.Text;
            produto.DataCompra = DateTime.Parse(tbDataCompra.Text);
            //produto.Grupo.Nome = cbGrupo.Text;
        }
        #endregion

        #region Eventos CRUD
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var produto = _produtoService.GetById<Produto>(id);
                        PreencheObjeto(produto);
                        produto = _produtoService.Update<Produto, Produto, ProdutoValidator>(produto);
                    }
                }
                else
                {
                    var produto = new Produto();
                    PreencheObjeto(produto);
                    _produtoService.Add<Produto, Produto, ProdutoValidator>(produto);
                }
                tabControl.SelectedIndex = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Excluir(int id)
        {
            try
            {
                _produtoService.Delete(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            produtos = _produtoService.Get<Produto>().ToList();
            dgvConsulta.DataSource = produtos;
            dgvConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
            tbPreco.Text = linha?.Cells["Preço"].Value.ToString();
            tbUnidadeVenda.Text = linha?.Cells["Unidade Venda"].Value.ToString();
            tbDataCompra.Text = linha?.Cells["Data Compra"].Value.ToString();
            cbGrupo.Text = linha?.Cells["Grupo"].Value.ToString();
        }
        #endregion
    }
}
