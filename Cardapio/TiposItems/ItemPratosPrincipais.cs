using System;

namespace Cardapio.TiposItems
{
    public class ItemPratosPrincipais : Item
    {
        public ItemPratosPrincipais(string nome, decimal preco, string? descricao, double calorias) : base(nome, preco, descricao, calorias)
        {
        }
    }
}
