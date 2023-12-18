using System;
using System.Collections.Generic;
using System.Linq;
using Cardapio.TiposItems;

namespace Cardapio.TiposCardapios
{
    public class CardapioLogica : JsonParser
    {
        // Encapsulate ItemsDoCardapio with a property
        private List<Item> _itemsDoCardapio;
        public List<Item> ItemsDoCardapio
        {
            get
            {
                if (_itemsDoCardapio == null)
                {
                    _itemsDoCardapio = ReceberJson<Item>(@"C:\Users\luanar\source\repos\MarmitaEletronica\Cardapio\Itens.json");
                }
                return _itemsDoCardapio;
            }
        }

        public List<Item> OrdenarItensPorNomeEID() => ItemsDoCardapio.OrderBy(item => item.Nome).ThenBy(item => item.Id).ToList();

        public List<Item> OrdenarItensPorNome() => ItemsDoCardapio.OrderBy(item => item.Nome).ToList();

        public List<Item> OrdenarItensPorTipo() => ItemsDoCardapio.OrderBy(item => item.Tipo.ToString()).ToList();

        public List<Item> OrdenarItensPorVegetariano() => ItemsDoCardapio.OrderBy(item => item.Vegetariano).ThenBy(item => item.Nome).ToList();


        public void AdicionarItem(Item novoItem)
        {
            if (novoItem != null)
            {
                ItemsDoCardapio.Add(novoItem);
            }
        }

        public void RemoverItem(Item removerItem)
        {
            if (removerItem != null)
            {
                ItemsDoCardapio.Remove(removerItem);
            }
        }

        public void MostrarCardapioOrdenadoPorNomeEID()
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome e ID ---");

            var itensOrdenados = OrdenarItensPorNomeEID();
            foreach (var item in itensOrdenados)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco:C2} - Descrição: {item.Descricao} - Calorias: {item.Calorias}");
            }
        }

        public void MostrarCardapioOrdenadoPorNome()
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome ---");

            var itensOrdenados = OrdenarItensPorNome();
            foreach (var item in itensOrdenados)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco:C2} - Descrição: {item.Descricao} - Calorias: {item.Calorias}");
            }
        }
        public void MostrarCardapioOrdenado(List<Item> items)
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome ---");

            var itensOrdenados = items.OrderBy(item => item.Nome);
            foreach (var item in itensOrdenados)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco:C2} - Descrição: {item.Descricao} - Calorias: {item.Calorias}");
            }
        }
    }
}
