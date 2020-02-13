using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entidades
{
    class Estado
    {
        public string Nome { get; set; }
        public int Ddd { get; set; }
        public Cidade Capital { get; set; }
        public int Qtd_Cidade { get; set; }
        public Pais Localizacao_Pais { get; set; }
        public List<Cidade> Nome_Cidades { get; set; } = new List<Cidade>();

        public Estado(string nome, int ddd, Cidade capital, int qtd_Cidade, Pais localizacao_Pais)
        {
            Nome = nome;
            Ddd = ddd;
            Capital = capital;
            Qtd_Cidade = qtd_Cidade;
            Localizacao_Pais = localizacao_Pais;
        }

        public void Add_Cidade(Cidade cidade)
        {
            Nome_Cidades.Add(cidade);
        }

        public void Remove_Cidade(Cidade cidade)
        {
            Nome_Cidades.Remove(cidade);
        }
    }
}
