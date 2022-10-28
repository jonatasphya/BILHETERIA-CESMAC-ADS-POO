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
            foreach(var f in bilheteria.Filmes)
            {
                listBoxCartaz.Items.Add(f);
            }

            foreach (var f in bilheteria.Sessoes)
            {
                listBoxSessoes.Items.Add(f);
            }
            
        }

        private void numericUpDownInteira_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxCartaz.SelectedIndex >= 0 && listBoxSessoes.SelectedIndex >= 0)
            {
                bilheteria.QtdIngressosInteira = Convert.ToInt32(numericUpDownInteira.Value);
                labelSubtotal.Text = bilheteria.CalculaTotal.ToString("C");
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
                labelSubtotal.Text = bilheteria.CalculaTotal.ToString("C");
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
                        tabControl1.SelectedIndex = 1;
                        textBoxRecibo.Text = "---RECIBO---" + Environment.NewLine + Environment.NewLine +
                        $"FILME: {bilheteria.Filme}" + Environment.NewLine + Environment.NewLine;
                        textBoxRecibo.Text += "----------------------------" + Environment.NewLine;

                    if (bilheteria.QtdIngressosMeia > 0)
                        {
                            textBoxRecibo.Text += $"MEIA ENTRADA - {bilheteria.QtdIngressosMeia} x {bilheteria.ValorMeia.ToString("C")} = " +
                            $"{bilheteria.CalculaMeias.ToString("C")}" + Environment.NewLine;
                        }

                        if (bilheteria.QtdIngressosInteira > 0)
                        {

                            textBoxRecibo.Text += $"INTEIRA - {bilheteria.QtdIngressosInteira} x {bilheteria.ValorInteira.ToString("C")} = " +
                            $"{bilheteria.CalculaInteiras.ToString("C")}" + Environment.NewLine;

                        }

                        textBoxRecibo.Text += "----------------------------";
                        textBoxRecibo.Text += Environment.NewLine + Environment.NewLine + $"TOTAL: {bilheteria.CalculaTotal.ToString("C")}"; 


                    //MessageBox.Show("VOCÊ IRÁ ASSISTIR: " + bilheteria.Filme + " ÀS " + bilheteria.Sessao + " | TOTAL: " + bilheteria.Calcula.ToString("C"));
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
