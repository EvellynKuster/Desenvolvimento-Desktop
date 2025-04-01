using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

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


            if (chkAdulto.Checked && chkMasculino.Checked)
            {
                //ADULTO MASCULINO: calcular com os dados
                #region adulto masculino

                var imc = peso / (altura * altura);
                var TextoBase = $@"Seu IMC : {imc:N2}";

                //exibir o resultado
                lblResultadoImc.Text = imc.ToString("N2");

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                    picboxImc.Load(ImcImagem.MasculinoAbaixoDoPesoNormal);
                }
                else if (imc <= 24.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é normal";
                    picboxImc.Load(ImcImagem.MasculinoNormal);
                }
                else if (imc <= 29.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                    picboxImc.Load(ImcImagem.MasculinoSobrepeso);
                }
                else if (imc <= 34.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 1";
                    picboxImc.Load(ImcImagem.MasculinoObesidadeGrau1);
                }
                else if (imc <= 39.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 2";
                    picboxImc.Load(ImcImagem.MasculinoObesidadeGrau2);
                }
                else if (imc >= 40.0)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 3";
                    picboxImc.Load(ImcImagem.MasculinoObesidadeGrau3);
                }

                #endregion

            }

            else if (chkAdulto.Checked && chkFeminino.Checked)
            {
                //ADULTO FEMININO: calcular com os dados

                #region adulto feminino

                var imc = peso / (altura * altura);
                var TextoBase = $@"Seu IMC : {imc:N2}";

                //exibir o resultado
                lblResultadoImc.Text = imc.ToString("N2");

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                    picboxImc.Load(ImcImagem.FemininoAbaixoDoPesoNormal);
                }
                else if (imc <= 24.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é normal";
                    picboxImc.Load(ImcImagem.FemininoNormal);
                }
                else if (imc <= 29.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                    picboxImc.Load(ImcImagem.FemininoSobrepeso);
                }
                else if (imc <= 34.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 1";
                    picboxImc.Load(ImcImagem.FemininoObesidadeGrau1);
                }
                else if (imc <= 39.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 2";
                    picboxImc.Load(ImcImagem.FemininoObesidadeGrau2);
                }
                else if (imc >= 40.0)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 3";
                    picboxImc.Load(ImcImagem.FemininoObesidadeGrau3);
                }
                #endregion 
  
            }

            else if (chkCrianca.Checked)
            {
                //CRIANCA: calcular com os dados

                var imc = peso / (altura * altura);
                var TextoBase = $@"Seu IMC : {imc:N2}";

                var coisa = cmbIdade.SelectedIndex;

                if (cmbIdade.SelectedIndex == 0)
                {
                    if (imc <= 14.0)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                        picboxImc.Load(ImcImagem.CriancaAbaixoDoPesoNormal);
                    }
                    else if (imc <= 17.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é normal";
                        picboxImc.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc <= 18.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                        picboxImc.Load(ImcImagem.CriancaSobrepeso);
                    }
                    else if (imc > 18.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é obesidade";
                        picboxImc.Load(ImcImagem.CriancaObesidade);
                    }
                }

                else if (cmbIdade.SelectedIndex == 1)
                {
                    if (imc <= 15.0)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                        picboxImc.Load(ImcImagem.CriancaAbaixoDoPesoNormal);
                    }
                    else if (imc <= 18.0)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é normal";
                        picboxImc.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc <= 19.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                        picboxImc.Load(ImcImagem.CriancaSobrepeso);
                    }
                    else if (imc > 19.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é obesidade";
                        picboxImc.Load(ImcImagem.CriancaObesidade);
                    }
                }

                else if (cmbIdade.SelectedIndex == 2)
                {
                    if (imc <= 16.0)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                        picboxImc.Load(ImcImagem.CriancaAbaixoDoPesoNormal);
                    }
                    else if (imc <= 19.0)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é normal";
                        picboxImc.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc <= 20.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                        picboxImc.Load(ImcImagem.CriancaSobrepeso);
                    }
                    else if (imc > 20.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é obesidade";
                        picboxImc.Load(ImcImagem.CriancaObesidade);
                    }

                }

                else if (cmbIdade.SelectedIndex == 3)
                {
                    if (imc <= 17.0)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                        picboxImc.Load(ImcImagem.CriancaAbaixoDoPesoNormal);
                    }
                    else if (imc <= 20.0)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é normal";
                        picboxImc.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc <= 21.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                        picboxImc.Load(ImcImagem.CriancaSobrepeso);
                    }
                    else if (imc <= 21.5)
                    {
                        lblResultadoImc.Text = $@" {TextoBase} é obesidade";
                        picboxImc.Load(ImcImagem.CriancaObesidade);
                    }

                }
               
            }
        }

    }
}
