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
    public partial class frmcidadania : Form
    {
        public frmcidadania()
        {
            InitializeComponent();
        }
        string lingua, mostrarCidadania;

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void txtcidadania_TextChanged(object sender, EventArgs e)
        {
            txtMostrarCidadania.Clear();
            txtlingua.Clear();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int cidadania;

            cidadania = Convert.ToInt32(txtcidadania.Text);

            if (cidadania == 1)
            {
                mostrarCidadania = "Brasileiro";

                lingua = "Português";
            }
            else if (cidadania == 2)
            {
                mostrarCidadania = "Alemão";

                lingua = "Alemão";
            }
            else if (cidadania == 3)
            {
                mostrarCidadania = "Inglês";

                lingua = "Inglês";
            }
            else if (cidadania == 4)
            {
                mostrarCidadania = "Italiano";

                lingua = "Italiano";
            }
            else if (cidadania == 5)
            {
                mostrarCidadania = "Espanhol";

                lingua = "Espanhol";
            }
            else if (cidadania == 6)
            {
                mostrarCidadania = "Francês";

                lingua = "Francês";
            }
            else if (cidadania == 6)
            {
                mostrarCidadania = "Francês";

                lingua = "Francês";
            }
            else if (cidadania != 1 || cidadania != 2 || cidadania != 3 || cidadania != 4 || cidadania != 5 || cidadania != 6)
            {
                mostrarCidadania = "Não identificado";

                lingua = "Não identificada";
            }

            txtMostrarCidadania.Text = mostrarCidadania;
            txtlingua.Text = lingua;


        }
    }
}
