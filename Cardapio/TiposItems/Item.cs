using System;
using System.Text.Json.Serialization;

namespace Cardapio.TiposItems
{
    public class Item
    {
        public int Id { get; set; } // Id adicionado

        public string Nome { get; set; }
        public bool EhBebida{ get; set; }
        public TipoPrato Tipo { get; set; }
        public bool Vegetariano { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public double Calorias { get; set; }

        public Item() { }

        public Item(int id, string nome, bool bebida, TipoPrato tipo, bool vegetariano, decimal preco, string descricao, double calorias) =>
            (Id, Nome, EhBebida, Tipo, Vegetariano, Preco, Descricao, Calorias) = (id, nome, bebida, tipo, vegetariano, preco, descricao, calorias);

    }
}
