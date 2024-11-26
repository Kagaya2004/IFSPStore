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
    public partial class CadastroCidade : CadastroBase
    {
        #region Declaração
        private readonly IBaseService<Cidade> _cidadeService;
        private List<Cidade>? cidades;
        #endregion

        #region Construtor
        public CadastroCidade(IBaseService<Cidade> cidadeService)
        {
            _cidadeService = cidadeService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Cidade cidade)
        {
            cidade.Nome = tbNome.Text;
            cidade.Estado = cbEstado.Text;
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
                        var cidade = _cidadeService.GetById<Cidade>(id);
                        PreencheObjeto(cidade);
                        cidade = _cidadeService.Update<Cidade, Cidade, CidadeValidator>(cidade);
                    }
                }
                else
                {
                    var cidade = new Cidade();
                    PreencheObjeto(cidade);
                    _cidadeService.Add<Cidade, Cidade, CidadeValidator>(cidade);
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
                _cidadeService.Delete(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            cidades = _cidadeService.Get<Cidade>().ToList();
            dgvConsulta.DataSource = cidades;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
            cbEstado.Text = linha?.Cells["Estado"].Value.ToString();
        }
        #endregion
    }
}
