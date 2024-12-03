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
    public partial class CadastroUsuario : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Usuario> _usuarioService;
        private List<Usuario>? usuarios;
        #endregion

        #region Construtor
        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = tbNome.Text;
            usuario.Login = tbLogin.Text;
            usuario.Senha = tbSenha.Text;
            usuario.Email = tbEmail.Text;
            usuario.DataCadastro = DateTime.Parse(tbDataCadastro.Text);
            usuario.DataLogin = DateTime.Parse(tbDataLogin.Text);
            usuario.Ativo = chAtivo.Checked;
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
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
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
                _usuarioService.Delete(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<Usuario>().ToList();
            dgvConsulta.DataSource = usuarios;
            dgvConsulta.Columns["Senha"]!.Visible = false;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
            tbLogin.Text = linha?.Cells["Login"].Value.ToString();
            tbEmail.Text = linha?.Cells["Email"].Value.ToString();
            tbSenha.Text = linha?.Cells["Senha"].Value.ToString();
            chAtivo.Checked = (bool)(linha?.Cells["Ativo"].Value ?? false);

            tbDataCadastro.Text = DateTime.TryParse(linha?.Cells["DataCasdastro"].Value.ToString(), out var dataC)
                ? dataC.ToString("g") : "";
            tbDataLogin.Text = DateTime.TryParse(linha?.Cells["DataLogin"].Value.ToString(), out var dataL)
                ? dataL.ToString("g") : "";
        }
        #endregion
    }
}
