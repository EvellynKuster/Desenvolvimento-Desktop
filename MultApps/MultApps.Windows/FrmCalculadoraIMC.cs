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
            lblIdade.Text = "Abaixo de 19 anos";
            lblIMC.Text = "Z IMC para criança";

        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkGray;
            chkAdulto.ForeColor = Color.Goldenrod;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            lblIMC.Text = "IMC para adulto";
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

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }
    }
}
