using System;

namespace Cardapio.TiposCardapios
{
    internal class CardapioSaladas : Cardapio
    {
        public CardapioSaladas(string? sessao) : base(sessao)
        {
            Sessao = "Saladas";
        }
    }
}