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

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preco, desconto, final;

            string mostrarRegiao;

            int regiao;

            preco = Convert.ToDouble(txtpreco.Text);

            //desconto = Convert.ToDouble(txtdesconto.Text);

            final = Convert.ToDouble(txtfinal.Text);

            mostrarRegiao = Convert.ToString(txtregiaoFinal.Text);

            regiao = Convert.ToInt32(txtregiao.Text);

            if (regiao == 1)
            {
                desconto = (preco / 100) * 12;

                final = preco - desconto;
            }
            else if (regiao == 2)
            {
                desconto = (preco / 100) * 5;
            }
            else if (regiao == 3)
            {
                desconto = (preco / 100) * 7;

                final = preco - desconto;
            }
            else if(regiao == 4)
            {
                desconto = (preco / 100) * 12;

                final = preco - desconto;
            }
            else if (regiao == 5)
            {
                desconto = (preco / 100) * 20;

                final = preco - desconto;
            }

            txtdesconto.Text = desconto.ToString();
            txtfinal.Text = final.ToString();
            //txtregiaoFinal = mostrarRegiao; 
        }
    }
}
