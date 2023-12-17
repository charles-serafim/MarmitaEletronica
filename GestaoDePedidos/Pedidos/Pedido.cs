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
        public Cardapio.TiposCardapios.Cardapio Cardapio { get; set; }
        public List<Item> Itens { get; set; }
        public decimal? ValorTotal { get; set; }
        public int QqtItens { get; set; }

        public Pedido()
        {
            Itens = new List<Item>();
            ValorTotal = 0;
            QqtItens = 0;
        }

        public int AdicionarItem(Cardapio.TiposCardapios.Cardapio cardapio)
        {
            QqtItens = Itens.Count;
            Item item = SelecionaItem(cardapio);
            Itens.Add(item);
            if(Itens.Count <= QqtItens)
            {
                throw new Exception("Item não adicionado");
            }
            ValorTotal += item.Preco;
            return 1;
        }

        public Item SelecionaItem(Cardapio.TiposCardapios.Cardapio cardapio)
        {
            Console.WriteLine("Digite o código do item: ");
            int idItem = int.Parse(Console.ReadLine());
            Item itemEncontrado = cardapio.ItemsDoCardapio.FirstOrDefault(i => i.Id == idItem);
            return itemEncontrado;
        }

        public void RemoverItem(int idItem)
        {
            Itens.Remove(Itens.Find(x => x.Id == idItem));
        }

    }

        


}
