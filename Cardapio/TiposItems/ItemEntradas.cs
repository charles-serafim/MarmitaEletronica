using System;

namespace Cardapio.TiposItems
{
    public class ItemEntradas : Item
    {
        public ItemEntradas(string nome, decimal preco, string? descricao, double calorias) : base(nome, preco, descricao, calorias)
        {
        }
    }
}
