using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILHETERIA
{

   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bilheteria bilheteria = new Bilheteria();

        private void Form1_Load(object sender, EventArgs e)
        {

            listBoxCartaz.Items.AddRange(bilheteria.Filmes);
            listBoxSessoes.Items.AddRange(bilheteria.Sessoes);
            
        }

        private void numericUpDownInteira_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxCartaz.SelectedIndex >= 0 && listBoxSessoes.SelectedIndex >= 0)
            {
                bilheteria.QtdIngressosInteira = Convert.ToInt32(numericUpDownInteira.Value);
                labelSubtotal.Text = bilheteria.Calcula.ToString("C");
            }
            else
            {
                if (numericUpDownInteira.Value != 0)
                {
                    MessageBox.Show("ESCOLHA PELO MENOS UM FILME E UMA SESSÃO!");
                    numericUpDownInteira.Value = 0;
                }
            }
        }

        private void numericUpDownMeia_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxCartaz.SelectedIndex >= 0 && listBoxSessoes.SelectedIndex >= 0)
            {
                bilheteria.QtdIngressosMeia = Convert.ToInt32(numericUpDownMeia.Value);
                labelSubtotal.Text = bilheteria.Calcula.ToString("C");
            }
            else
            {
                if (numericUpDownMeia.Value != 0)
                {
                    MessageBox.Show("ESCOLHA PELO MENOS UM FILME E UMA SESSÃO!");
                    numericUpDownMeia.Value = 0;
                }
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (listBoxCartaz.SelectedIndex >= 0 && listBoxSessoes.SelectedIndex >= 0)
            {
                
                    if (bilheteria.QtdIngressosMeia > 0 || bilheteria.QtdIngressosInteira > 0)
                    {
                        MessageBox.Show("VOCÊ IRÁ ASSISTIR: " + bilheteria.Filme + " ÀS " + bilheteria.Sessao + " | " + bilheteria.Calcula.ToString("C"));
                    }
                    else
                    {
                        MessageBox.Show("ESCOLHA PELO MENOS UMA ENTRADA MEIA OU INTEIRA");
                    }
               
            }
            else
            {
                MessageBox.Show("ESCOLHA PELO MENOS UM FILME E UMA SESSÃO!");
            }
        }

        private void listBoxCartaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            bilheteria.Filme = listBoxCartaz.Text;
        }

        private void listBoxSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bilheteria.Sessao = listBoxSessoes.Text;
        }
    }
}
