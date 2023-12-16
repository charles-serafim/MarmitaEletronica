using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Cardapio.TiposItems;

namespace Cardapio.TiposCardapios
{
    public class Cardapio
    {
        public string? Sessao { get; set; }
        public List<Item> ItemsDoCardapio = new List<Item>();

        public Cardapio(string? sessao)
        {
            Sessao = sessao;
        }

        public void AdicionarItem(Item novoItem) => ItemsDoCardapio.Add(novoItem);
        public void RemoverItem(Item removerItem) => ItemsDoCardapio.Remove(removerItem);

        public void MostrarCardapio()
        {
            Console.WriteLine($"--- Cardápio de {Sessao} ---");
            foreach (var item in ItemsDoCardapio)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco:C2} - {item.Descricao} - Calorias: {item.Calorias}");
            }
        }
    }
}
