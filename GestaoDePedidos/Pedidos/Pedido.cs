using Cardapio.TiposCardapios;
using Cardapio.TiposItems;
using Cardapio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDePedidos.Pedidos
{
    public class Pedido
    {
        public CardapioLogica Cardapio { get; set; }
        public List<Item> Itens { get; set; }
        public decimal? ValorTotal { get; set; }
        public int QqtItens { get; set; }

        public Pedido()
        {
            ValorTotal = 0;
            QqtItens = 0;
        }

        public int AdicionarItem(CardapioLogica cardapio, int idItem)
        {
            if (Itens == null) QqtItens = 0;

            else if (Itens.Count == QqtItens)
            {
                Item item = SelecionaItem(cardapio, idItem);

                if (!cardapio.ItemsDoCardapio.Contains(item) || !(Itens.Count == QqtItens + 1))
                {
                    throw new Exception("Item não adicionado");
                }

                Itens.Add(item);
                QqtItens++;
                ValorTotal += item.Preco;
            }
            
            return 1;
        }

        public Item SelecionaItem(CardapioLogica cardapio, int idItem)
        {
            Item itemEncontrado = cardapio.ItemsDoCardapio.FirstOrDefault(i => i.Id == idItem);
            return itemEncontrado;
        }

        public bool ContemItem(int idItem)
        {
            return Itens.Exists(item => item.Id == idItem);
        }


        public void RemoverItem(int idItem)
        {
            if (ContemItem(idItem)) ;
            Itens.Remove(Itens.Find(x => x.Id == idItem));
        }

    }
}
