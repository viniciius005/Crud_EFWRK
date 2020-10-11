using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Crud_EFWRK_6_10
{
    public partial class TelaInic : Form
    {
        public TelaInic()
        {
            InitializeComponent();
        }

        private void msCadAgenda_Click(object sender, EventArgs e)
        {
            Form1 CadastroAgenda = new Form1();
            CadastroAgenda.Show();
        }

        private void msCadAula_Click(object sender, EventArgs e)
        {
            SalaAulas CadastroAula = new SalaAulas();
            CadastroAula.Show();
        }

        private void msSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
