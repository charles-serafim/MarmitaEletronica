using Cardapio.TiposCardapios;
using Cardapio.TiposItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDePedidos.Pedidos
{
    public class Pedido
    {
        public Cardapio Cardapio { get; set; }
        public List<Item> Itens { get; set; }
        public decimal ValorTotal { get; set; }
        public int QqtItens { get; set; }

        public Pedido()
        {
            this.Itens = GeraItens();
            ValorTotal = 0;
            QqtItens = 0;
        }

        public List<Item> GeraItens()
        {
            return LeitorJSON();
        }
        
        public void AdicionarItem(Item item)
        {
            if (item == null)
            {
                throw new Exception("Item não adicionado");
            }
            Itens.Add(item);
            QqtItens += 1;
            ValorTotal += item.Preco;
        }
        public void RemoverItem(int idItem)
        {
            Itens.Remove(Itens.Find(x => x.Id == idItem));
        }

    }
}
