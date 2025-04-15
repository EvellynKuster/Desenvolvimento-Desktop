using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

            var usuarioRepository = new UsuarioRepository();

            if (string.IsNullOrEmpty(txtId.Text))
            {
                var resultado = usuarioRepository.CadastrarUsuario(usuario);
                if (resultado)
                {
                    MessageBox.Show("Categoria cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar categoria");
                }
            }
            else
            {
                usuario.Id = int.Parse(txtId.Text);
                var resultado = usuarioRepository.AtualizarUsuario(usuario);

                if (resultado)
                {
                    MessageBox.Show("Usuário atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar usuário");
                }
            }

            CarregarTodosUsuarios();
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
            var categoriaId = (int)row.Cells[0].Value;

            // Use o método ObterCategoriaPorId para buscar os dados da categoria no banco de dados
            var categoriaRepository = new CategoriaRepository();
            var categoria = categoriaRepository.MostrarCategoriaPorId(categoriaId);

            if (categoria == null)
            {
                MessageBox.Show($"Categoria: #{categoriaId} não encontrada");
                return;
            }
            // Preencha os campos de edição com os dados obtidos
            txtId.Text = categoria.Id.ToString();
            txtNome.Text = categoria.Nome;
            cmbStatus.SelectedIndex = (int)categoria.Status;
            txtDataCriacao.Text = categoria.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = categoria.DataAlteracao.ToString("dd/MM/yyyy HH:mm");

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

    }
}
