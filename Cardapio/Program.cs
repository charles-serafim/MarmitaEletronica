using Cardapio.TiposCardapios;
using Cardapio.TiposItems;
using System;

namespace Cardapio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ParserJson = JsonParser.Parse();
            JsonParser.Printing(ParserJson);
        }
    }
}