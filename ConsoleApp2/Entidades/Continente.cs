using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entidades
{
    class Continente
    {
        public string Nome { get; set; }
        public double Qtd_Pais { get; set; }
        public List<Pais> Paises { get; set; } = new List<Pais>();

        public Continente(string nome, double qtd_pais)
        {
            Nome = nome;
            Qtd_Pais = qtd_pais;
           
        }

        public void AddPais(Pais pais)
        {
            Paises.Add(pais);
        }

        public void RemovePais(Pais pais)
        {
            Paises.Remove(pais);
        }






    }
}
