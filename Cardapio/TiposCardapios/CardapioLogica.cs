using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Cardapio.TiposItems;

namespace Cardapio.TiposCardapios
{
    public class CardapioLogica:JsonParser
    {
        //public List<Item> ItemsDoCardapio = JsonParser.ReceberJson();
        public List<Item> ItemsDoCardapio = new List<Item>
        {
            new Item {Id = 1, Nome = "Marmita de Frango", Tipo = 0, Vegetariano = false, Preco = 18, Descricao = "Marmita de frango muito boa e �pica", Calorias = 500},
            new Item { Id = 2, Nome = "Marmita de Porco", Tipo = 0, Vegetariano = false, Preco = 19, Descricao = "Marmita de porco muito boa e �pica", Calorias = 700 },
            new Item { Id = 3, Nome = "Marmita de Casal", Tipo = 0, Vegetariano = false, Preco = 21, Descricao = "Marmita para casais, serve duas pessoas", Calorias = 1000 }
        };

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
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco:C2} - {item.Descricao} - Calorias: {item.Calorias}");
            }
        }
    }
}