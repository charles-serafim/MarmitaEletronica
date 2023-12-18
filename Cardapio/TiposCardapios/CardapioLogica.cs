using System;
using System.Collections.Generic;
using System.Linq;
using Cardapio.TiposItems;

namespace Cardapio.TiposCardapios
{
    public class CardapioLogica : JsonParser, ICardapio
    {
        public List<Item> ItemsDoCardapio => ReceberJson();

        public List<Item> OrdenarItensPorNomeEID() => ReceberJson().OrderBy(item => item.Nome).ThenBy(item => item.Id).ToList();

        public List<Item> OrdenarItensPorNome() => ReceberJson().OrderBy(item => item.Nome).ToList();

        public List<Item> OrdenarItensPorTipo() => ReceberJson().OrderBy(item => item.Tipo).ToList();

        public List<Item> OrdenarItensPorPreco() => ReceberJson().OrderBy(item => item.Preco).ToList();

        public List<Item> OrdenarItensPorVegetariano() => ReceberJson().OrderBy(item => item.Vegetariano).ThenBy(item => item.Nome).ToList();

        public void AdicionarItem(Item novoItem) => throw new NotImplementedException(); // Implementar a lógica p add um novo item, se for usar

        public void RemoverItem(Item removerItem) => throw new NotImplementedException(); // msm coisa aqui

        public void MostrarCardapioOrdenadoPorNomeEID()
        {
            Console.WriteLine($"--- Cardápio de Refeições Ordenado por Nome e ID ---");

            var itensOrdenados = OrdenarItensPorNomeEID();
            foreach (var item in itensOrdenados)
            {
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco:C2} - {item.Descricao} - Calorias: {item.Calorias}");
            }
        }
    }
}
