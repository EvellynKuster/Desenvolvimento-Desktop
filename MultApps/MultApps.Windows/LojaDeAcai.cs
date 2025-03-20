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
    public partial class LojaDeAcai : Form
    {
        public LojaDeAcai()
        {
            InitializeComponent();
        }

        //Adiciona o tamanho do açaí

        private void btnSelecionarPequeno_Click(object sender, EventArgs e)
        {
            listTamanho.Items.Add ("Açaí pequeno (300ml) - R$15.00");
        }

        private void btnSelecionarMedio_Click(object sender, EventArgs e)
        {
            listTamanho.Items.Add("Açaí médio (500ml) - R$20.00");
        }

        private void btnSelecionarGrande_Click(object sender, EventArgs e)
        {
            listTamanho.Items.Add("Açaí grande (700ml) - R$25.00");
        }

        private void btnSelecionarFamilia_Click(object sender, EventArgs e)
        {
            listTamanho.Items.Add("Açaí família (300ml) - R$35.00");
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            lblNome.Text = nome;

            string senha = GerarSenhaCurta(); // Chama a função que gera a senha
            lblSenha.Text = senha; // Atribui a senha gerada ao texto do Label

        }

        private string GerarSenhaCurta()
        {
            // Obtém a data e hora atuais
            DateTime agora = DateTime.Now;

            // Formata a senha para usar apenas mês, dia, hora e minuto
            string senhaComSegundos = $"{agora:MMddHHmmss}";
            return senhaComSegundos;
        }

        //Mostra os complementos

        private void numericGranola_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Granola");
        }

        private void numericLeitePo_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Leite em pó");
        }

        private void numericConfete_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Confete");
        }

        private void numericChocobol_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Chocobol");
        }

        private void numericAmendoim_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Amendoim");
        }

        private void numericCoco_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Coco Ralado");
        }

        private void numericBanana_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Banana");
        }

        private void numericUva_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Uva");
        }

        private void numericKiwi_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Kiwi");
        }

        private void numericMorango_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Morango");
        }

        private void numericAbacaxi_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Abacaxi");
        }

        private void numericManga_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Manga");
        }

        private void numericCobMorango_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Calda de Morango");
        }

        private void numericMel_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Mel");
        }

        private void numericLeiteConden_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Leite condensado");
        }

        private void numericChocolate_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Calda de chocolate");
        }

        private void numericCaramelo_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Caramelo");
        }

        private void numericLimao_ValueChanged(object sender, EventArgs e)
        {
            listComplementos.Items.Add("Calda de limão");
        }
    }
}
