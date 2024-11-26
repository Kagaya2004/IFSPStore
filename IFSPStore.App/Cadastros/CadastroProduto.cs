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
        private readonly IBaseService<Grupo> _grupoService;
        private List<Produto>? produtos;
        #endregion

        #region Construtor
        public CadastroProduto(IBaseService<Produto> produtoService, IBaseService<Grupo> grupoService)
        {
            _produtoService = produtoService;
            _grupoService = grupoService;
            InitializeComponent();
            CarregarCombo();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Produto produto)
        {
            produto.Nome = tbNome.Text;
            if (float.TryParse(tbPreco.Text, out float preco))
            {
                produto.Preco = preco;
            }
            if (DateTime.TryParse(tbDataCompra.Text, out var dataCompra))
            {
                produto.DataCompra = dataCompra;
            }
            produto.UnidadeVenda = tbUnidadeVenda.Text;
            if (int.TryParse(cbGrupo.SelectedValue.ToString(), out int idGrupo))
            {
                var grupo = _grupoService.GetById<Grupo>(idGrupo);
                produto.Grupo = grupo;
                //_produtoService.AttachObject(grupo);
            }
        }

        private void CarregarCombo()
        {
            cbGrupo.ValueMember = "Id";
            cbGrupo.DisplayMember = "Nome";
            cbGrupo.DataSource = _grupoService.Get<Grupo>().ToList();
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
            tbDataCompra.Text = DateTime.TryParse(linha?.Cells["DataCompra"].Value.ToString(), out var dataC)
                ? dataC.ToString("g") : "";
            cbGrupo.SelectedValue = linha?.Cells["IdGrupo"].Value;
        }
        #endregion
    }
}
