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
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkGray;
            chkAdulto.ForeColor = Color.Goldenrod;
            chkCrianca.Checked = false;
        }
    }
}
