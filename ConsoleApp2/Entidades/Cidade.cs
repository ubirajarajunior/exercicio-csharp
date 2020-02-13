using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entidades
{
    class Cidade
    {
        public string Nome { get; set; }
        public double Area { get; set; }
        public Estado Localizacao_Estado { get; set; }

        public Cidade(string nome, double area, Estado localizacao_Estado)
        {
            Nome = nome;
            Area = area;
            Localizacao_Estado = localizacao_Estado;
        }
    }
}
