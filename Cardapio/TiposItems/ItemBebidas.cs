using System;

namespace Cardapio.TiposItems
{
    public class ItemBebidas : Item
    {
        public bool EhAlcolica { get; set; }
        public bool EhNatural { get; set; }

        public ItemBebidas(string nome, decimal preco, string? descricao, double calorias, bool alcolica, bool natural) : base(nome, preco, descricao, calorias)
        {
            EhAlcolica = alcolica;
            EhNatural = natural;
        }
    }
}
