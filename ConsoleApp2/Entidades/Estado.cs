using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entidades
{
    class Estado
    {
        public string Nome { get; set; }
        public double Extensao { get; set; }
        public int Ddd { get; set; }
        public string Capital { get; set; }
        public int Qtd_Cidade { get; set; }

        public Estado(string nome, double extensao, int ddd, string capital, int qtd_Cidade)
        {
            Nome = nome;
            Extensao = extensao;
            Ddd = ddd;
            Capital = capital;
            Qtd_Cidade = qtd_Cidade;
        }
    }
}
