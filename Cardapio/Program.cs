using Cardapio.TiposCardapios;
using Cardapio.TiposItems;
using Cardapio;
using System;

namespace Cardapio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CardapioLogica cardapioLogica = new CardapioLogica();
            List<Item> ItensDoCardapio = cardapioLogica.ItemsDoCardapio;
            List<Item> ItensVegetarianos = cardapioLogica.OrdenarItensPorVegetariano();


            cardapioLogica.MostrarCardapioOrdenado(ItensVegetarianos);
        }
    }
}