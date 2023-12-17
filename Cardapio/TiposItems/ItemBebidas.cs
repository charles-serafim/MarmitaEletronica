using Cardapio.TiposItems.Cardapio.TiposItems;
using System;

namespace Cardapio.TiposItems
{
    public class ItemBebidas(string nome, decimal preco, string? descricao, double calorias, bool alcolica, bool natural) : Item(nome, preco, descricao, calorias)
    {
        public bool EhAlcolica { get; set; } = alcolica;
        public bool EhNatural { get; set; } = natural;
    }
}