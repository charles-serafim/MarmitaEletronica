using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoDePedidos.Mesas;

namespace Funcionarios.TiposFuncionarios
{
    public class Garcom : Funcionario
    {
        public int MesasAtendendo { get; set; }
        public Garcom(string nome, string contato, int idade, string turno, string endereco, int id, double salario, int mesasAtendendo)
            : base(nome, contato, idade, turno, endereco, id, salario)
        {
            MesasAtendendo = mesasAtendendo;
        }

        public void AbrirMesaG(Mesas m)
        {         
            m.AbrirMesa();
        }

        public void FecharMesaG(Mesas m)
        {
            m.FecharMesa();
        }

        public void FazPedidoG(Mesas m)
        {
            m.FazPedido();
        }

        public string getNomeG()
        {
            return nome;
        }

        //public void exibirCardapioG(Cardapio c)
        //{
        //    c.exibirCardapio();
        //}
    }
}
