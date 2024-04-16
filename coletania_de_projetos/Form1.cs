using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coletania_de_projetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdesc desc = new frmdesc();
            desc.Show();
        }

        private void cidadaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcidadania cidadania = new frmcidadania();
            cidadania.Show();
        }
    }
}
