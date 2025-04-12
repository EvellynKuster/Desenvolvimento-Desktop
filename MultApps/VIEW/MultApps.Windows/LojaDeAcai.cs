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

        ///Adiciona o tamanho do açaí
        private void btnSelecionarPequeno_Click(object sender, EventArgs e)
        {
            listTamanho.Items.Add("Açaí pequeno (300ml) - R$15.00");
            listPreco.Items.Add("R$15.00");
        }

        private void btnSelecionarMedio_Click(object sender, EventArgs e)
        {       
            listTamanho.Items.Add("Açaí médio (500ml) - R$20.00");
            listPreco.Items.Add("R$20.00");
        }

        private void btnSelecionarGrande_Click(object sender, EventArgs e)
        {
            listTamanho.Items.Add("Açaí grande (700ml) - R$25.00");
            listPreco.Items.Add("R$25.00");
        }

        private void btnSelecionarFamilia_Click(object sender, EventArgs e)
        {
            listTamanho.Items.Add("Açaí família (300ml) - R$35.00");
            listPreco.Items.Add("R$35.00");
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

        ///Mostra os complementos
        private void numericGranola_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensComplementos())
            {
                return;
            }

            if (numericGranola.Value > 0)
            {
                listComplementos.Items.Add($"Granola");
            }
            else
            {
                listComplementos.Items.Remove($"Granola");
            }
        }

        private void numericLeitePo_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensComplementos())
            {
                return;
            }

            if (numericLeitePo.Value > 0)
            {
                listComplementos.Items.Add($"Leite em pó");
            }
            else
            {
                listComplementos.Items.Remove($"Leite em pó");
            }
        }

        private void numericConfete_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensComplementos())
            {
                return;
            }

            if (numericConfete.Value > 0)
            {
                listComplementos.Items.Add($"Confete");
            }
            else
            {
                listComplementos.Items.Remove($"Confete");
            }
        }

        private void numericChocobol_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensComplementos())
            {
                return;
            }

            if (numericChocobol.Value > 0)
            {
                listComplementos.Items.Add($"Chocobol");
            }
            else
            {
                listComplementos.Items.Remove($"Chocobol");
            }
        }

        private void numericAmendoim_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensComplementos())
            {
                return;
            }

            if (numericAmendoim.Value > 0)
            {
                listComplementos.Items.Add($"Amendoim");
            }
            else
            {
                listComplementos.Items.Remove($"Amendoim");
            }
        }

        private void numericCoco_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensComplementos())
            {
                return;
            }

            if (numericCoco.Value > 0)
            {
                listComplementos.Items.Add($"Coco ralado");
            }
            else
            {
                listComplementos.Items.Remove($"Coco ralado");
            }
        }

        private void numericBanana_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensFrutas())
            {
                return;
            }

            if (numericBanana.Value > 0)
            {
                listFrutas.Items.Add($"Banana");
            }
            else
            {
                listFrutas.Items.Remove($"Banana");
            }
        }

        private void numericUva_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensFrutas())
            {
                return;
            }

            if (numericUva.Value > 0)
            {
                listFrutas.Items.Add($"Uva");
            }
            else
            {
                listFrutas.Items.Remove($"Uva");
            }
        }

        private void numericKiwi_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensFrutas())
            {
                return;
            }

            if (numericKiwi.Value > 0)
            {
                listFrutas.Items.Add($"Kiwi");
            }
            else
            {
                listFrutas.Items.Remove($"Kiwi");
            }
        }

        private void numericMorango_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensFrutas())
            {
                return;
            }

            if (numericMorango.Value > 0)
            {
                listFrutas.Items.Add($"Morango");
            }
            else
            {
                listFrutas.Items.Remove($"Morango");
            }
        }

        private void numericAbacaxi_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensFrutas())
            {
                return;
            }

            if (numericAbacaxi.Value > 0)
            {
                listFrutas.Items.Add($"Abacaxi");
            }
            else
            {
                listFrutas.Items.Remove($"Abacaxi");
            }          
        }

        private void numericManga_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensFrutas())
            {
                return;
            }

            if (numericManga.Value > 0)
            {
                listFrutas.Items.Add($"Manga");
            }
            else
            {
                listFrutas.Items.Remove($"Manga");
            }
        }

        private void numericCobMorango_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensCoberturas())
            {
                return;
            }

            if (numericCobMorango.Value > 0)
            {
                listCoberturas.Items.Add($"Calda de morango");
            }
            else
            {
                listCoberturas.Items.Remove($"Calda de morango");
            }
        }

        private void numericMel_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensCoberturas())
            {
                return;
            }

            if (numericMel.Value > 0)
            {
                listCoberturas.Items.Add($"Mel");
            }
            else
            {
                listCoberturas.Items.Remove($"Mel");
            }
        }

        private void numericLeiteConden_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensCoberturas())
            {
                return;
            }

            if (numericLeiteConden.Value > 0)
            {
                listCoberturas.Items.Add($"Leite condensado");
            }
            else
            {
                listCoberturas.Items.Remove($"Leite condensado");
            }
        }

        private void numericChocolate_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensCoberturas())
            {
                return;
            }

            if (numericChocolate.Value > 0)
            {
                listCoberturas.Items.Add($"Calda de chocolate");
            }
            else
            {
                listCoberturas.Items.Remove($"Calda de chocolate");
            }
        }

        private void numericCaramelo_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItensCoberturas())
            {
                return;
            }

            if (numericCaramelo.Value > 0)
            {
                listCoberturas.Items.Add($"Caramelo");
            }
            else
            {
                listCoberturas.Items.Remove($"Caramelo");
            }
        }

        private void numericLimao_ValueChanged(object sender, EventArgs e)
        {
            if(LimitarItensCoberturas())
            {
                return;
            }

            if (numericLimao.Value > 0)
            {
                listCoberturas.Items.Add($"Calda de limão");
            }
            else
            {
                listCoberturas.Items.Remove($"Calda de limão");
            }
        }

        private bool LimitarItensComplementos()
        {
            if(listComplementos.Items.Count > 3)
            {
                MessageBox.Show("Limite de itens atingidos");
                return true;
            }
            return false;
        }

        private bool LimitarItensFrutas()
        {
            if (listFrutas.Items.Count > 2)
            {
                MessageBox.Show("Limite de itens atingidos");
                return true;
            }
            return false;
        }

        private bool LimitarItensCoberturas()
        {
            if (listCoberturas.Items.Count > 1)
            {
                MessageBox.Show("Limite de itens atingidos");
                return true;
            }
            return false;
        }
    }
}
