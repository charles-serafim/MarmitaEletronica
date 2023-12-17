using System;
using System.Text.Json.Serialization;

namespace Cardapio.TiposItems
{
    namespace Cardapio.TiposItems
    {
        public class Item
        {
            public string Nome { get; set; }
            public TipoPrato Tipo { get; set; }
            public bool Vegetariano{ get; set; }
            public decimal Preco { get; set; }
            public string Descricao { get; set; }
            public double Calorias { get; set; }

            public Item() { }  // Add a parameterless constructor

            public Item(string nome, TipoPrato tipo, bool vegetariano, decimal preco, string descricao, double calorias)
            {
                Nome = nome;
                Vegetariano = vegetariano;
                Tipo = tipo;
                Preco = preco;
                Descricao = descricao;
                Calorias = calorias;
            }

            public Item(string nome, decimal preco, string? descricao, double calorias)
            {
                Nome = nome;
                Preco = preco;
                Descricao = descricao;
                Calorias = calorias;
            }
        }
    }
}
