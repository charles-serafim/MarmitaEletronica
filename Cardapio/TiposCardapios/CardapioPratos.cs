using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio.TiposCardapios
{
    internal class CardapioPratos : Cardapio
    {
        public CardapioPratos(string? sessao) : base(sessao)
        {
            sessao = "Pratos";
        }

    }
}
