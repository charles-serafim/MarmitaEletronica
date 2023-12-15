using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio.TiposCardapios
{
    internal class CardapioBebidas : Cardapio
    {
        public CardapioBebidas(string? sessao) : base(sessao)
        {
            sessao = "Bebidas";
        }
        
    }
}
