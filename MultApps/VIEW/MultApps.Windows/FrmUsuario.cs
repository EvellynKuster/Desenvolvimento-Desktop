using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            CarregarTodosUsuarios();

            var status = new[] { "ativo", "inativo" };
            var filtros = new[] { "ativo", "inativo", "todos" };
            cmbStatus.Items.AddRange(status);
            cmbFiltro.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TemCamposEmBranco())
                { 
                    return;
                }

                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;
                usuario.Cpf = maskedCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;

                var usuarioRepository = new UsuarioRepository();

                var emailJaExiste = usuarioRepository.EmailExistente(usuario.Email);
                if(emailJaExiste)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado.");
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    var sucesso = usuarioRepository.CadastrarUsuario(usuario);
                    if (sucesso)
                    {
                        MessageBox.Show("Usuario cadastrado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar categoria");
                    }
                }

                else
                {
                    usuario.Id = int.Parse(txtId.Text);
                    var sucesso = usuarioRepository.AtualizarUsuario(usuario);

                    if (sucesso)
                    {
                        MessageBox.Show("Usuário atualizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar usuário");
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

            CarregarTodosUsuarios();
        }

        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(maskedCpf.Text))
            {
                MessageBox.Show("O campo CPF é obrigatório");
                maskedCpf.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("O campo Email é obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório");
                txtSenha.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("O campo Status é obrigatório");
                txtNome.Focus();
                return true;
            }
            return false;
        }

        private void CarregarTodosUsuarios()
        {
            var usuarioRepository = new UsuarioRepository();
            var listaDeUsuarios = usuarioRepository.ListarTodosUsuarios();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            //id
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
            }
            );

            //nome
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome do usuario",
            }
            );

            //cpf
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "CPF",
            }
            );

            //email
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
            }
            );

            //senha
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Senha",
                HeaderText = "Senha",
            }
            );

            //data de criação
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCriacao",
                HeaderText = "Data de criação",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200
            }
            );

            //data do ultimo acesso
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAcesso",
                HeaderText = "Data do ultimo acesso",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200
            }
            );

            //status
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            }
            );

            dataGridView1.DataSource = listaDeUsuarios;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            // Obtenha a linha selecionada
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Obtenha o ID da categoria da linha selecionada
            var usuarioId = (int)row.Cells[0].Value;

            // Use o método ObterCategoriaPorId para buscar os dados da categoria no banco de dados
            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.MostrarUsuarioPorId(usuarioId);

            if (usuario == null)
            {
                MessageBox.Show($"Usuario: #{usuarioId} não encontrado");
                return;
            }
            // Preencha os campos de edição com os dados obtidos
            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            cmbStatus.SelectedIndex = (int)usuario.Status;
            txtDataCriacao.Text = usuario.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = usuario.DataAcesso.ToString("dd/MM/yyyy HH:mm");
            txtEmail.Text = usuario.Email.ToString();
            txtSenha.Text = usuario.Senha.ToString();
            maskedCpf.Text = usuario.Cpf.ToString();     

            btnDeletar.Enabled = true;
            btnSalvar.Text = "Salvar alterações";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDataCriacao.Text = string.Empty;
            txtDataAlteracao.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            maskedCpf.Text = string.Empty;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var usuarioId = int.Parse(txtId.Text);
            var usuarioRepository = new UsuarioRepository();
            var sucesso = usuarioRepository.DeletarUsuario(usuarioId);

            if (sucesso)
            {
                MessageBox.Show("Usuario removido com sucesso");
                CarregarTodosUsuarios();
            }
            else
            {
                MessageBox.Show($"Não foi possível deletar o usuario: {txtNome.Text}");
            }

            btnDeletar.Enabled = false;
            btnLimpar_Click(sender, e);
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusEnum filtroSelecionado = (StatusEnum)Enum.Parse(typeof(StatusEnum), cmbFiltro.SelectedItem.ToString());

            if (filtroSelecionado == StatusEnum.Todos)
            {
               
            }

            if (filtroSelecionado == StatusEnum.Ativo)
            {
                
            }

            if (filtroSelecionado == StatusEnum.Inativo)
            {
                
            }
        }

    }
}
