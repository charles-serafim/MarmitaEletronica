using System;

namespace Cardapio.TiposCardapios
{
    internal class CardapioBebidas : Cardapio
    {
        public CardapioBebidas(string? sessao) : base(sessao)
        {
            Sessao = "Bebidas";
        }
    }
}
