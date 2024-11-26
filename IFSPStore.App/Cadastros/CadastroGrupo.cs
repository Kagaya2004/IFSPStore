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
    public partial class CadastroGrupo : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Grupo> _grupoService;
        private List<Grupo> grupos;
        #endregion

        #region Construtor
        public CadastroGrupo(IBaseService<Grupo> grupoService)
        {
            _grupoService = grupoService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Grupo grupo)
        {
            grupo.Nome = tbNome.Text;
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
                        var grupo = _grupoService.GetById<Grupo>(id);
                        PreencheObjeto(grupo);
                        grupo = _grupoService.Update<Grupo, Grupo, GrupoValidator>(grupo);
                    }
                }
                else
                {
                    var grupo = new Grupo();
                    PreencheObjeto(grupo);
                    grupo = _grupoService.Add<Grupo, Grupo, GrupoValidator>(grupo);
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
                _grupoService.Delete(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            grupos = _grupoService.Get<Grupo>().ToList();
            dgvConsulta.DataSource = grupos;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
        }
        #endregion
    }
}
