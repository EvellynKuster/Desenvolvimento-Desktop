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

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                    picboxImc.Load(ManipuladorDeImagem("abaixo do normal"));
                }
                else if (imc <= 24.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é normal";
                    picboxImc.Load(ManipuladorDeImagem("normal"));
                }
                else if (imc <= 29.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                    picboxImc.Load(ManipuladorDeImagem("sobrepeso");
                }
                else if (imc <= 34.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 1";
                    picboxImc.Load(ManipuladorDeImagem("obesidade grau 1"));
                }
                else if (imc <= 39.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 2";
                    picboxImc.Load(ManipuladorDeImagem("obesidade grau 2"));
                }
                else if (imc >= 40.0)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 3";
                    picboxImc.Load(ManipuladorDeImagem("obesidade grau 3"));
                }

                #endregion

                //exibir o resultado
                lblResultadoImc.Text = imc.ToString("N2");

            }
            else if (chkAdulto.Checked && chkFeminino.Checked)
            {
                //ADULTO FEMININO: calcular com os dados

                #region adulto feminino

                var imc = peso / (altura * altura);
                var TextoBase = $@"Seu IMC : {imc:N2}";

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é abaixo do normal";
                    picboxImc.Load();
                }
                else if (imc <= 24.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é normal";
                    picboxImc.Load();
                }
                else if (imc <= 29.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é sobrepeso";
                    picboxImc.Load();
                }
                else if (imc <= 34.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 1";
                    picboxImc.Load();
                }
                else if (imc <= 39.9)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 2";
                    picboxImc.Load();
                }
                else if (imc >= 40.0)
                {
                    lblResultadoImc.Text = $@" {TextoBase} é obesidade grau 3";
                    picboxImc.Load();
                }

                #endregion 

                //exibir o resultado
                lblResultadoImc.Text = imc.ToString("N2");

            }
            else if (chkCrianca.Checked == true)
            {
                //CRIANCA: calcular com os dados

                var imc = peso / (altura * altura);
                var TextoBase = $@"Seu IMC : {imc:N2}";

                var idade = int.Parse(cmbIdade.Text);

                if (idade > 1)
                {
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
                        lblResultadoImc.Text = $@" {TextoBase} é obesidade";
                    }
                }

                else if (idade > 2)
                {

                }

                else if (idade > 3)
                {

                }

                else if (idade > 4)
                {

                }

                else if (idade > 5)
                {

                }

                else if (idade > 6)
                {

                }

                else if (idade > 7)
                {

                }

                else if (idade > 8)
                {

                }

                else if (idade > 9)
                {

                }

                else if (idade > 10)
                {

                }

                else if (idade > 11)
                {

                }

                else if (idade > 12)
                {

                }

                else if (idade > 13)
                {

                }

                else if (idade > 14)
                {

                }

                else if (idade > 15)
                {

                }

                else if (idade > 16)
                {

                }

                else if (idade > 17)
                {

                }

                else if (idade > 18)
                {

                }









                //exibir o resultado
                lblResultadoImc.Text = imc.ToString("N2");
            }
        }

        private string ManipuladorDeImagem(string grau)
        {
            switch (grau)
            {
                case "abaixo do normal":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_06.png.webp";

                case "normal":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_05.png.webp";

                case "sobrepeso":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_04.png.webp";

                case "obesidade grau 1":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_03.png.webp";

                case "obesidade grau 2":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_02.png.webp";

                case "obesidade grau 3":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_01.png.webp";

                default "" 
            }
        }
    }
}
