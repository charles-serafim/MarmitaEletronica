using GestaoDePedidos.Mesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionarios.TiposFuncionarios;

namespace UI.Menu
{
    internal class MenuGarcom
    {
        public Mesas Mesa { get; set; }
        public List<Garcom>? Garcons { get; set; }
        public Garcom? Garcom { get; set; }

        public Garcom AtribuiGarcom(Mesas mesa)
        {
            this.Mesa = mesa;
            //Garcons = LeitorJSON();
            Garcons = new List<Garcom>
            {
                new Garcom("Charles", 1, 0),
                new Garcom("Vinicius", 2, 0),
                new Garcom("Luana", 3, 0)
            };
            this.Garcom = SelecionaGarcom();
            this.Garcom.MesasAtendendo++;
            this.Garcom.AbrirMesaG(Mesa);
            return this.Garcom;
        }

        public void MostraCardapio(Garcom garcomSelecionado)
        {
            if (Mesa.Lugares > 1)
            {
                Console.Clear();
                Console.WriteLine($"Sejam bem vindos à Marmita Eletrônica, meu nome é {garcomSelecionado.getNomeG()} e será um prazer atendê-los\n\n" +
                    $"Aqui está o cardápio, fiquem à vontade e me chamem quando estiverem prontos para realizar o pedido.\n");
            }
                

            else Console.WriteLine($"Bem vindo à Marmita Eletrônica, meu nome é {garcomSelecionado.getNomeG()} e será um prazer atendê-lo\n\n" +
                $"Aqui está o cardápio, fiquem à vontade e me chamem quando quiser realizar o pedido.");

            garcomSelecionado.ExibirCardapio();

        }
        public Garcom SelecionaGarcom()
        {
            Garcons?.OrderBy(Garcom => Garcom.MesasAtendendo);
            return Garcons.First();
        }

    }
}
