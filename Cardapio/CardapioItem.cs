using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio
{
    internal class CardapioItem
    {
        private string Nome;
        private int Preco;

        public CardapioItem(string nome, int preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
