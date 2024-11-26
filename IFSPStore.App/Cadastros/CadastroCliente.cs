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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroCliente : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Cidade> _cidadeService;
        private List<Cliente>? clientes;
        #endregion

        #region Construtor
        public CadastroCliente(IBaseService<Cliente> clienteService, IBaseService<Cidade> cidadeService)
        {
            _clienteService = clienteService;
            _cidadeService = cidadeService;
            InitializeComponent();
            CarregarCombo();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = tbNome.Text;
            cliente.Endereco = tbEndereco.Text;
            cliente.Bairro = tbBairro.Text;

            if (int.TryParse(cbCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                cliente.Cidade = cidade;
            }
        }

        private void CarregarCombo()
        {
            cbCidade.ValueMember = "Id";
            cbCidade.DisplayMember = "NomeEstado";
            cbCidade.DataSource = _cidadeService.Get<CidadeModel>().ToList();
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
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
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
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<Cliente>().ToList();
            dgvConsulta.DataSource = clientes;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
            tbEndereco.Text = linha?.Cells["Endereço"].Value.ToString();
            tbBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            cbCidade.Text = linha?.Cells["Cidade"].Value.ToString();
        }

        #endregion
    }
}
