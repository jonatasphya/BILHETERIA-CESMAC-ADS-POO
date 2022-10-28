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
        private float total;
        private string[] filmes = { "Adão Negro", "Aterrorizante 2", "Halloween Ends", "A Queda", "Sorria" };
        private string[] sessoes = { "16:20", "17:00", "20:00", "21:30" };


        public string Filme
        {
            get
            {
                return filme;
            }
            set
            {
                filme = value;
            }
        }

        public string Sessao
        {
            get
            {
                return sessao;
            }
            set
            {
                sessao = value;
            }
        }

        public string[] Filmes
        {
            get
            {
                return filmes;
            }
        }

        public string[] Sessoes
        {
            get
            {
                return sessoes;
            }
        }

        public int QtdIngressosMeia
        {
            get
            {
                return qtdIngressosMeia;
            }

            set
            {
                qtdIngressosMeia = value;
            }
        }

        public int QtdIngressosInteira
        {
            get
            {
                return qtdIngressosInteira;
            }

            set
            {
                qtdIngressosInteira = value;
            }
        }

        public float Calcula
        {
            get
            {
                return calcula();
            }
        }

        private float calcula()
        {
            total = (qtdIngressosMeia * 16) + (qtdIngressosInteira * 32);
            return total;
        }

    }
}
