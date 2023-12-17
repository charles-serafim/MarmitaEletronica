using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Cardapio.TiposItems;
using Cardapio.TiposItems.Cardapio.TiposItems;


namespace Cardapio.TiposCardapios
{
    public class CardapioLogica:JsonParser
    {
        public List<Item> ItemsDoCardapio = JsonParser.ReceberJson();

        public List<Item> OrdenarItensPorNome()
        {
            return ItemsDoCardapio.OrderBy(item => item.Nome).ToList();
        }

        public List<Item> OrdenarItensPorTipo()
        {
            return ItemsDoCardapio.OrderBy(item => item.Tipo).ToList();
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

        public void MostrarCardapioOrdenadoPorNome()
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome ---");

            var itensOrdenados = OrdenarItensPorNome();
            foreach (var item in itensOrdenados)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco:C2} - {item.Descricao} - Calorias: {item.Calorias}");
            }
        } 
    }
}
