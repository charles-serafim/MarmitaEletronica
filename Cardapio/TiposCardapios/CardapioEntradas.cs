using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio.TiposCardapios
{
    internal class CardapioEntradas:Cardapio
    {
        public CardapioEntradas(string? sessao) : base(sessao)
        {
            sessao = "Entradas";
        }
    }
}
