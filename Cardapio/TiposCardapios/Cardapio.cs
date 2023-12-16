using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardapio.TiposItems;

namespace Cardapio.TiposCardapios
{
    public class Cardapio
    {
        public string? Sessao;
        public List<Item> ItemsDoCardapio = new List<Item>();

        public Cardapio(string? sessao)
        {
            Sessao = sessao;
        }
        public void AdicionarItem(Item novoItem) => ItemsDoCardapio.Add(novoItem);
        public void RemoverItem(Item removerItem) => ItemsDoCardapio.Remove(removerItem);
    }
}

