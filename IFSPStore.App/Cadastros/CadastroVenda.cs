using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IFSPStore.App.Models.VendaModel;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroVenda : CadastroBase
    {
        #region Declarações
        private List<VendaItemModel> _vendaItens;
        private readonly IBaseService<Venda> _vendaService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Produto> _produtoService;

        private List<VendaModel>? vendas;
        #endregion

        #region Construtor
        public CadastroVenda(IBaseService<Venda> vendaService, IBaseService<Usuario> usuarioService,
            IBaseService<Cliente> clienteService, IBaseService<Produto> produtoService)
        {
            _vendaService = vendaService;
            _usuarioService = usuarioService;
            _clienteService = clienteService;
            _produtoService = produtoService;
            _vendaItens = new List<VendaItemModel>();
            InitializeComponent();
            CarregarCombo();
            CarregaGridItensVenda();
        }
        #endregion

        #region Métodos
        private void CarregarCombo()
        {
            cbUsuario.ValueMember = "Id";
            cbUsuario.DisplayMember = "Nome";
            cbUsuario.DataSource = _usuarioService.Get<Usuario>().ToList();

            cbCliente.ValueMember = "Id";
            cbCliente.DisplayMember = "Nome";
            cbCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cbProduto.ValueMember = "Id";
            cbProduto.DisplayMember = "Nome";
            cbProduto.DataSource = _produtoService.Get<Produto>().ToList();
        }

        private void PreencheObjeto(Venda venda)
        {
            if (DateTime.TryParse(tbDataVenda.Text, out var dataVenda))
            {
                venda.Data = dataVenda;
            }

            if (int.TryParse(cbUsuario.SelectedValue.ToString(), out var idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                venda.Usuario = usuario;
            }

            if (int.TryParse(cbCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                venda.Cliente = cliente;
            }

            venda.ValorTotal = _vendaItens.Sum(x => x.ValorTotal);

            foreach (var item in _vendaItens)
            {
                var itemVenda = new VendaItem
                {
                    Venda = venda,
                    Produto = _produtoService.GetById<Produto>(intem.IdProduto),
                    ValorUnitario = item.ValorUnitario,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.ValorTotal
                };

                venda.Itens.Add(itemVenda);
            }
        }
        #endregion

        #region Eventos
        protected override void Novo()
        {
            base.Novo();
            _vendaItens.Clear();
            CarregaGridItensVenda();
            tbDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var venda = _vendaService.GetById<Venda>(id);
                        PreencheObjeto(venda);
                        venda = _vendaService.Update<Venda, Venda, VendaValidator>(venda);
                    }
                }
                else
                {
                    var venda = new Venda();
                    PreencheObjeto(venda);
                    venda = _vendaService.Add<Venda, Venda, VendaValidator>(venda);
                }

                tabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Excluir(int id)
        {
            try
            {
                _vendaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Cliente", "Usuario" };
            vendas = _vendaService.Get<VendaModel>(includes).ToList();
            dgvConsulta.DataSource = vendas;
            dgvConsulta.Columns["IdUsuario"]!.Visible = false;
            dgvConsulta.Columns["IdCliente"]!.Visible = false;
            dgvConsulta.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dgvConsulta.Columns["VendaTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            cbUsuario.SelectedValue = linha?.Cells["IdUsuario"].Value;
            cbCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
            tbDataVenda.Text = DateTime.TryParse(linha?.Cells["Data"].Value.ToString(), out var dataC)
                ? dataC.ToString("g") : "";

            var includes = new List<string>() { "Cliente", "Usuario", "Itens", "Itens.Produto" };
            var venda = _vendaService.GetById<Venda>(id, includes);
            _vendaItens = new List<VendaItemModel>();
            foreach (var item in venda.Itens)
            {
                var vendaItem = new VendaItemModel
                {
                    Id = item.Id,
                    IdProduto = item.Produto!.Id,
                    Produto = item.Produto!.Nome,
                    ValorTotal = item.ValorTotal,
                    Quantidade = item.Quantidade,
                    ValorUnitario = item.ValorUnitario,
                };
                _vendaItens.Add(vendaItem);
            }
            CarregaGridItensVenda();
        }

        private void CarregaGridItensVenda()
        {
            var source = new BindingSource();
            source.DataSource = _vendaItens.ToArray();
            dgvVenda.DataSource = source;
            dgvVenda.Columns["Id"]!.Visible = false;
            dgvVenda.Columns["IdProduto"]!.HeaderText = @"Id.Produto";
            dgvVenda.Columns["ValorUnitario"]!.DefaultCellStyle.Format = "C2";
            dgvVenda.Columns["ValorUnitario"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVenda.Columns["ValorTotal"]!.DefaultCellStyle.Format = "C2";
            dgvVenda.Columns["ValorTotal"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVenda.Columns["Quantidade"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var vendaItem = new VendaItemModel();
                if (int.TryParse(cbProduto.SelectedValue.ToString(), out var idProduto))
                {
                    var produto = _produtoService.GetById<Produto>(idProduto);
                    vendaItem.IdProduto = produto.Id;
                    vendaItem.Produto = produto.Nome;
                }

                if (float.TryParse(tbValorUnitario.Text, System.Globalization.NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var vlUnitario))
                {

                }
            }
        }
        #endregion


    }
}
