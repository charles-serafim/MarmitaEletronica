using System;

namespace Cardapio.TiposItems
{
    public abstract class Item
    {
        public string Nome { get; }
        public decimal? Preco { get; set; }
        public string? Descricao { get; set; }
        public double? Calorias { get; set; }

        public Item(string nome, decimal preco, string? descricao, double calorias)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Calorias = calorias;
        }
    }
}
