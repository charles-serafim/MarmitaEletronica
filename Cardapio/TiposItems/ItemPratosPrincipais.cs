using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio.TiposItems
{
    public class ItemPratosPrincipais : Item
    {
        public ItemPratosPrincipais(string nome, decimal preco, string? descricao, double calorias) : base(nome, preco, descricao, calorias)
        {
        }
    }
}
