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
        public double ValorTotal { get; set; }
        public int QqtItens { get; set; }

        public Pedido()
        {
            Itens = new List<Item>();
            ValorTotal = 0;
            QqtItens = 0;
        }

        public int AdicionarItem(Cardapio tipoCardapio)
        {
            QqtItens = Itens.Count;
            Itens.Add(tipoCardapio.item);
            if(Itens.Count <= QqtItens)
            {
                throw new Exception("Item não adicionado");
            }
            ValorTotal += tipoCardapio.item.Valor;
            return 1;
        }

        public void RemoverItem(int idItem)
        {
            Itens.Remove(Itens.Find(x => x.Id == idItem));
        }

    }

        


}
