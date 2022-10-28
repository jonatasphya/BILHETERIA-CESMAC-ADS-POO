using System;
using System.Collections.Generic;
using System.Text;

namespace BILHETERIA
{
    class Bilheteria
    {

        private int qtdIngressosInteira;
        private int qtdIngressosMeia;
        private string filme;
        private string sessao;
        private string[] filmes = { "Adão Negro", "Aterrorizante 2", "Halloween Ends", "A Queda", "Sorria" };
        private string[] sessoes = { "16:20", "17:00", "20:00", "21:30" };
        private float valorInteira = 32;
        private float valorMeia = 16;

        public float ValorInteira
        {
            get { return valorInteira; }
        }

        public float ValorMeia
        {
            get { return valorMeia; }
        }

        public string Filme
        {
            get { return filme; }
            set { filme = value; }
        }

        public string Sessao
        {
            get { return sessao; }
            set { sessao = value; }
        }

        public string[] Filmes
        {
            get { return filmes; }
        }

        public string[] Sessoes
        {
            get { return sessoes; }
        }

        public int QtdIngressosMeia
        {
            get { return qtdIngressosMeia; }
            set { qtdIngressosMeia = value; }
        }

        public int QtdIngressosInteira
        {
            get { return qtdIngressosInteira; }
            set { qtdIngressosInteira = value; }
        }

        public float CalculaTotal
        {
            get { return calculaTotal(); }
            
        }

        public float CalculaMeias
        {
            get { return calculaMeias(); }
        }

        public float CalculaInteiras
        {
            get { return calculaInteiras(); }
        }

        private float calculaTotal()
        {
            float total;
            return total = (qtdIngressosMeia * valorMeia) + (qtdIngressosInteira * valorInteira);
           
        }

        private float calculaMeias()
        {
            float total;
            return total = qtdIngressosMeia * valorMeia;
        }

        private float calculaInteiras()
        {
            float total;
            return total = qtdIngressosInteira * valorInteira;
        }

    }
}
