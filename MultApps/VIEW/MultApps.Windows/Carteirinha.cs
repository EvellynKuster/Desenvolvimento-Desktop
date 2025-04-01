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
    public partial class Carteirinha : Form
    {
        public Carteirinha()
        {
            InitializeComponent();
        }

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var cpf = txtCpf.Text;
            var nascimento = DateTime.Parse(dateTimePicker1.Text);
            var hoje = DateTime.Now.Year;

            //calcula a idade
            var idade = hoje - nascimento.Year;

            //mostra os dados na carteirinha
            lblIdade.Text = idade.ToString();
            lblNome.Text = nome;

            //Puxa o cpf ofuscado
            /// Pega o CPF digitado no TextBox
            string cpfDigitado = txtCpf.Text;

            /// Chama o método OfuscarCPF e atribui ao Label
            string cpfOfuscado = OfuscarCPF(cpfDigitado);

            /// Exibe o CPF ofuscado no Label
            lblCpf.Text = cpfOfuscado;

            if (idade <= 12)
            {
                panelCor.BackColor = Color.LightBlue;
                picBoxImagem.BackColor = Color.LightBlue;
                picBoxImagem.Load("https://cdn-icons-png.freepik.com/256/3884/3884934.png");
                lblStatus.Text = "Criança";
            }
            else if (idade <= 29)
            {
                panelCor.BackColor = Color.Gold;
                picBoxImagem.BackColor = Color.Gold;
                picBoxImagem.Load("https://cdn-icons-png.freepik.com/256/437/437544.png");
                lblStatus.Text = "Jovem";
            }
            else if (idade <= 59)
            {
                panelCor.BackColor = Color.MediumPurple;
                picBoxImagem.BackColor = Color.MediumPurple;
                picBoxImagem.Load("https://cdn-icons-png.freepik.com/256/14407/14407045.png");
                lblStatus.Text = "Adulto";
            }
            else if (idade >= 60)
            {
                panelCor.BackColor = Color.LightGreen;
                picBoxImagem.BackColor = Color.LightGreen;
                picBoxImagem.Load("https://cdn-icons-png.freepik.com/256/437/437550.png");
                lblStatus.Text = "Idoso";
            }
        }

        private string OfuscarCPF(string cpf)
        {
            // Garante que o CPF tem 11 caracteres
            if (cpf.Length != 11)
                return "CPF inválido";

            // Pega os números do meio
            string parte1 = cpf.Substring(3, 3);
            string parte2 = cpf.Substring(6, 3);

            // Retorna o CPF ofuscado
            return $"***.{parte1}.{parte2}.***";
        }
    }
}
