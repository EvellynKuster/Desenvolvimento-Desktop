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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            CarregarTodasCategorias();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cmbStatus.SelectedIndex;

            var categoriaRepository = new CategoriaRepository();

            if (string.IsNullOrEmpty(txtId.Text))
            {
                var resultado = categoriaRepository.CadastrarCategoria(categoria);
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
                categoria.Id = int.Parse(txtId.Text);
                var resultado = categoriaRepository.AtualizarCategoria(categoria);

                if (resultado)
                {
                    MessageBox.Show("Categoria atualizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar categoria");
                }
            }

            

            CarregarTodasCategorias();
        }

        private void CarregarTodasCategorias()
        {
            var categoriaRepository = new CategoriaRepository();
            var listaDeCategorias = categoriaRepository.ListarTodasCategorias();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",  
            }
            );

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome da categoria",
            }
            );

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HeaderText = "Data de cadastro",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200
            }
            );

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200
            }
            );

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            }
            );

            dataGridView1.DataSource = listaDeCategorias;
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
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var categoriaId = int.Parse(txtId.Text);
            var categoriaRepository = new CategoriaRepository();
            var sucesso = categoriaRepository.DeletarCategoria(categoriaId);

            if(sucesso)
            {
                MessageBox.Show("Categoria removida com sucesso");
                CarregarTodasCategorias();
            }
            else
            {
                MessageBox.Show($"Não foi possível deletar a categoria: {txtNome.Text}");
            }

            btnDeletar.Enabled = false;
            btnLimpar_Click(sender, e);
        }
    }
}

