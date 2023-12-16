using Cardapio.TiposCardapios;
using Cardapio.TiposItems;
using System;

namespace Cardapio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cardapioBebidas = new CardapioBebidas("Bebidas");
            var cardapioEntradas = new CardapioEntradas("Entradas");
            var cardapioPratos = new CardapioPratos("Pratos Principais");
            var cardapioSaladas = new CardapioSaladas("Saladas");

            var agua = new ItemBebidas("Água", 1.20m, "Água mineral", 0, false, true);
            var suco = new ItemBebidas("Suco de Laranja", 2.50m, "Suco natural de laranja de 500ml", 120, false, true);
            var saladaFolhas = new ItemSaladas("Salada de Folhas", 7.50m, "Mix de folhas verdes", 50, false, true);
            var saladaVegetal = new ItemSaladas("Salada de Vegetais", 8.00m, "Mix de vegetais frescos", 60, true, false);
            var entrada = new ItemEntradas("Entrada", 5.00m, "Entrada saborosa", 80);
            var pratoPrincipal = new ItemPratosPrincipais("Prato Principal", 12.00m, "Prato saboroso principal", 200);

            cardapioBebidas.AdicionarItem(agua);
            cardapioBebidas.AdicionarItem(suco);
            cardapioSaladas.AdicionarItem(saladaFolhas);
            cardapioSaladas.AdicionarItem(saladaVegetal);
            cardapioEntradas.AdicionarItem(entrada);
            cardapioPratos.AdicionarItem(pratoPrincipal);

            cardapioBebidas.MostrarCardapio();
            cardapioSaladas.MostrarCardapio();
            cardapioEntradas.MostrarCardapio();
            cardapioPratos.MostrarCardapio();

            Console.ReadLine();
        }
    }
}