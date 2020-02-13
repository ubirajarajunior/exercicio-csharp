using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entidades
{
    class Pais
    {
        public string Nome { get; set; }
        public int Qtd_Pais { get; set; }
        public int Ddi { get; set; }
        public Estado Capital { get; set; }
        public Continente Localizacao_Continente { get; set; }
        public List<Estado> Estados { get; set; } = new List<Estado>();

        public Pais(string nome, int qtd_Pais, int ddi, Continente localizacao_Continete, Estado capital)
        {
            Nome = nome;
            Qtd_Pais = qtd_Pais;
            Ddi = ddi;
            Capital = capital;
            Localizacao_Continente = localizacao_Continete;
            
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
