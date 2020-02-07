using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entidades
{
    class Cidade
    {
        public string Nome { get; set; }
        public double Area { get; set; }

        public Cidade(string nome, double area)
        {
            Nome = nome;
            Area = area;
        }
    }
}
