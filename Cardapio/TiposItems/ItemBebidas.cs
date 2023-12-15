using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio.TiposItems
{
    public class ItemBebidas : Item
    {
        public bool EhAlcolica;
        public bool EhNatural;


        public ItemBebidas(string nome, decimal preco, string? descricao, double calorias, bool alcolica, bool natural ) : base(nome, preco, descricao, calorias)
        {

        }
    }
}
