using System;

namespace Cardapio.TiposCardapios
{
    internal class CardapioEntradas : Cardapio
    {
        public CardapioEntradas(string? sessao) : base(sessao)
        {
            Sessao = "Entradas";
        }
    }
}

