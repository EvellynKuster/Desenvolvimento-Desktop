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
    public partial class CalculadoraAposentadoria: Form
    {
        public CalculadoraAposentadoria()
        {
            InitializeComponent();
        }

        private void btnAposentadoria_Click(object sender, EventArgs e)
        {
            var nascimento = DateTime.Parse(dateTimePicker1.Text);
            var hoje = DateTime.Now.Year;

            //coleta variaveis
            var idade = hoje - nascimento.Year;
            var anoscontribuicao = int.Parse(txtContribuicao.Text);

            //calculo
           
            #region Aposentadoria por tempo de contribuição

            if (cbSexo.SelectedIndex == 0)
            {
                if (idade >= 62 && anoscontribuicao >= 15)
                {
                    lblResultado.Text = "Você pode se aposentar";
                }
                else
                {
                    lblResultado.Text = "Você não pode se aposentar";
                }
            }
            else
            {
                if (idade >= 65 && anoscontribuicao >= 20)
                {
                    lblResultado.Text = "Você pode se aposentar";
                }
                else
                {
                    lblResultado.Text = "Você não pode se aposentar";
                }
            }

            #endregion

        }
    }
}
