using System;
using System.Collections.Generic;
using System.Linq; // Added for OrderBy and ThenBy
using Cardapio.TiposItems;

namespace Cardapio.TiposCardapios
{
    public class CardapioLogica : JsonParser
    {
        public List<Item> ItemsDoCardapio = JsonParser.ReceberJson(@"C:\Users\luanar\source\repos\MarmitaEletronica\Cardapio\Itens.json");

        public List<Item> OrdenarItensPorNomeEID() => ReceberJson().OrderBy(item => item.Nome).ThenBy(item => item.Id).ToList();

        public List<Item> OrdenarItensPorNome() => ReceberJson().OrderBy(item => item.Nome).ToList();

        public List<Item> OrdenarItensPorTipo()
        {
            return ItemsDoCardapio.OrderBy(item => item.Tipo.ToString()).ToList(); // Converted to string for ordering
        }

        public List<Item> OrdenarItensPorVegetariano() => ReceberJson().OrderBy(item => item.Vegetariano).ThenBy(item => item.Nome).ToList();

        public void AdicionarItem(Item novoItem) => throw new NotImplementedException(); // Implementar a lógica p add um novo item, se for usar

        public void RemoverItem(Item removerItem) => throw new NotImplementedException(); // msm coisa aqui

        public void MostrarCardapioOrdenadoPorNome() // Print de todo cardapio
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome e ID ---");

            var itensOrdenados = OrdenarItensPorNomeEID();
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
