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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void MenuCalculadoraImc_Click(object sender, EventArgs e)
        {
            var form = new FrmCalculadoraIMC();
            form.MdiParent = this;
            form.Show();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            var loading = new SplashScreen();
            loading.ShowDialog();
        }

        private void calculadoraDeAposentadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CalculadoraAposentadoria();
            form.MdiParent = this;
            form.Show();
        }

        private void geradorDeCarteirinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Carteirinha();
            form.MdiParent = this;
            form.Show();
        }
    }
}
