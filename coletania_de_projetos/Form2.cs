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
    public partial class frmdesc : Form
    {
        public frmdesc()
        {
            InitializeComponent();
        }
        double final, desconto;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preco;

            string mostrarRegiao;

            int regiao;

            preco = Convert.ToDouble(txtpreco.Text);

            mostrarRegiao = Convert.ToString(txtregiaoFinal.Text);

            regiao = Convert.ToInt32(txtregiao.Text);

            if (regiao == 1)
            {
                //nordeste

                desconto = (preco / 100) * 12;

                final = preco - desconto;

                mostrarRegiao = "Nordeste";
            }
            else if (regiao == 2)
            {
                //norte

                desconto = (preco / 100) * 5;

                final = preco - desconto;

                mostrarRegiao = "Norte";
            }
            else if (regiao == 3)
            {
                //sudeste

                desconto = (preco / 100) * 7;

                final = preco - desconto;

                mostrarRegiao = "Sudeste";
            }
            else if(regiao == 4)
            {
                //sul

                desconto = (preco / 100) * 15;

                final = preco - desconto;

                mostrarRegiao = "Sul";
            }
            else if (regiao == 5)
            {
                //Centro-oeste

                desconto = (preco / 100) * 20;

                final = preco - desconto;

                mostrarRegiao = "Centro-Oeste";
            }
            else if (regiao == 0)
            {
                //Importado

                desconto = 0;

                final = preco - desconto;

                mostrarRegiao = "Importado";
            }

            txtdesconto.Text = desconto.ToString();
            txtfinal.Text = final.ToString();
            txtregiaoFinal.Text = mostrarRegiao; 
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void txtregiaoFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
