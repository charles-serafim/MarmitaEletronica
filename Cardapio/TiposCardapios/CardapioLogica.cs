using System;
using System.Collections.Generic;
using System.Linq; // Added for OrderBy and ThenBy
using Cardapio.TiposItems;

namespace Cardapio.TiposCardapios
{
    public class CardapioLogica : JsonParser
    {
        public List<Item> ItemsDoCardapio = JsonParser.ReceberJson(@"C:\Users\luanar\source\repos\MarmitaEletronica\Cardapio\Itens.json");

        public List<Item> OrdenarItensPorNomeEID()
        {
            return ItemsDoCardapio.OrderBy(item => item.Nome).ThenBy(item => item.Id).ToList();
        }

        public List<Item> OrdenarItensPorNome()
        {
            return ItemsDoCardapio.OrderBy(item => item.Nome).ToList();
        }

        public List<Item> OrdenarItensPorTipo()
        {
            return ItemsDoCardapio.OrderBy(item => item.Tipo.ToString()).ToList(); // Converted to string for ordering
        }

        public List<Item> OrdenarItensPorPreco()
        {
            return ItemsDoCardapio.OrderBy(item => item.Preco).ToList();
        }

        public List<Item> OrdenarItensPorVegetariano()
        {
            return ItemsDoCardapio.OrderBy(item => item.Vegetariano).ThenBy(item => item.Nome).ToList();
        }

        public void AdicionarItem(Item novoItem) => ItemsDoCardapio.Add(novoItem);
        public void RemoverItem(Item removerItem) => ItemsDoCardapio.Remove(removerItem);

        public void MostrarCardapioOrdenadoPorNome() // Print de todo cardapio
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome ---");

            var itensOrdenados = OrdenarItensPorNome();
            foreach (var item in itensOrdenados)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco:C2} - Descrição: {item.Descricao} - Calorias: {item.Calorias}");
            }
        }

        public void MostrarCardapioOrdenado(List<Item> items)   // Print de parte específica do cardapio
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome ---");

            foreach (var item in items)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco:C2} - Descrição: {item.Descricao} - Calorias: {item.Calorias}");
            }
        }
    }
}
