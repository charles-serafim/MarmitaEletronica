using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDePedidos.Pedidos
{
    internal class Pedido
    {
        private static int codigoPedido = 1;
        public int CodigoPedido { get; set; }
        public int CodigoComanda { get; set; }
        public List<ItemPedido> ItensDoPedido { get; set; }
        public double ValorTotal { get; set; }

        public Pedido(int codigoComanda)
        {
            CodigoPedido = codigoPedido++;
            CodigoComanda = codigoComanda;
            ItensDoPedido = new List<ItemPedido>();
            ValorTotal = 0;
        }

    }

    internal class ItemPedido
    {
        public string NomeItem { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        public void AdicionarItem()
        {
            string input;
            while (true)
            {
                Console.WriteLine("Código do item: ");
                input = Console.ReadLine();

                Console.WriteLine("Quantidade: ");
                Console.WriteLine("Valor: ");
            }
        }
    }


}
