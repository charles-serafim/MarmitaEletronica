using System;

namespace Cardapio.TiposCardapios
{
    internal class CardapioPratos : Cardapio
    {
        public CardapioPratos(string? sessao) : base(sessao)
        {
            Sessao = "Pratos Principais";
        }
    }
}
