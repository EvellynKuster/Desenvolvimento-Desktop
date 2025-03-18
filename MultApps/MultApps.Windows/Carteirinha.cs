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

            if (idade <= 12)
            {
                panelCor.BackColor = Color.LightBlue;
            }
            else if (idade <= 29)
            {
                panelCor.BackColor = Color.Gold;
            }
            else if (idade <= 59)
            {
                panelCor.BackColor = Color.MediumPurple;
            }
            else if (idade >= 60)
            {
                panelCor.BackColor = Color.LightGreen;
            }


        }
    }
}
