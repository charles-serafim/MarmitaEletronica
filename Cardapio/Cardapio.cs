using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio
{
    internal class Cardapio
    {
        public string? Sessao;
        CardapioItem[]? ItemsDoCardapio;

        public Cardapio(string? sessao, CardapioItem[]? itemsDoCardapio)
        {
            Sessao = sessao;
            ItemsDoCardapio = itemsDoCardapio;
        }
    }
}
