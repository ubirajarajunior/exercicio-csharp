using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entidades
{
    class Pais
    {
        public string Nome { get; set; }
        public double Extensao { get; set; }
        public int Ddi { get; set; }
        public string Capital { get; set; }
        public List<Estado> Estados { get; set; } = new List<Estado>();

        public Pais(string nome, double extensao, int ddi, string capital, int qtd_Estado)
        {
            Nome = nome;
            Extensao = extensao;
            Ddi = ddi;
            Capital = capital;
            
        }

        public void AddEstado(Estado estado)
        {
            Estados.Add(estado);
        }

        public void RemoveEstado(Estado estado)
        {
            Estados.Remove(estado);
        }
    }
}
