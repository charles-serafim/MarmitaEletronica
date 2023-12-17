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

        public List <Mesas> listaDeMesasAtendidas { get; set; } = new List<Mesas>();
        public Garcom(string nome, string contato, int idade, string turno, string endereco, int id, double salario, int mesasAtendendo)
            : base(nome, contato, idade, turno, endereco, id, salario)
        {
            MesasAtendendo = mesasAtendendo;
        }

        public void AbrirMesaG(Mesas m)
        {         
            m.AbrirMesa();
            MesasAtendendo += 1;
            listaDeMesasAtendidas.Add(m);
        }

        public void FecharMesaG(Mesas m)
        {
            m.FecharMesa();
            MesasAtendendo -= 1;
            listaDeMesasAtendidas.Remove(m);
        }

        public void FazPedidoG(Mesas m, int idItem)
        {
            m.FazPedido(idItem);
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
