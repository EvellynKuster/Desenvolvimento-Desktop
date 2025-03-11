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
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.Goldenrod;
            chkAdulto.ForeColor = Color.DarkGray;
            chkAdulto.Checked = false;
            lblMaiorIdade.Text = "Abaixo de 19 anos";
            lblIMC.Text = "Z IMC para criança";

            lblIdade.Visible = true;
            cmbIdade.Visible = true;
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkGray;
            chkAdulto.ForeColor = Color.Goldenrod;
            chkCrianca.Checked = false;
            lblMaiorIdade.Text = "Acima de 19 anos";
            lblIMC.Text = "IMC para adulto";

            lblIdade.Visible = false;
            cmbIdade.Visible = false;
        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.Goldenrod;
            chkFeminino.ForeColor = Color.DarkGray;
            chkFeminino.Checked = false;
        }

        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.Goldenrod;
            chkMasculino.ForeColor = Color.DarkGray;
            chkMasculino.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //primeiro passo: obter os dados
            var peso = double.Parse(txtPeso.Text);
            var altura = double.Parse(txtAltura.Text);

            //segundo passo: calcular com os dados
            var imc = peso / (altura * altura);
            var TextoBase = $@"Seu IMC : {imc:N2}";

            if (imc <= 18.5)
            {
                lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
            }
            else if (imc <= 24.9)
            {
                lblResultadoImc.Text = $@" {TextoBase} é normal";
            }
            else if (imc <= 29.9)
            {
                lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
            }
            else if (imc <= 34.9)
            {
                lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 1";
            }
            else if (imc <= 39.9)
            {
                lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 2";
            }
            else if (imc >= 40.0)
            {
                lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 3";
            }

            //exibir o resultado
            lblResultadoImc.Text = imc.ToString("N2");

           
        }
    }
}
