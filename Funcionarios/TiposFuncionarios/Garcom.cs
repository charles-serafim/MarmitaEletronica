using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoDePedidos.Mesas;
using Cardapio.TiposCardapios;

namespace Funcionarios.TiposFuncionarios
{
    public class Garcom : Funcionario
    {
        public int MesasAtendendo { get; set; }

        public Limpeza l1 { get; set; } = new Limpeza("Ramon", 10);
        //public List <Mesas> listaDeMesasAtendidas { get; set; } = new List<Mesas>(); inicio de lógica para obtenção de quais mesas cada garçom

        public Cardapio.TiposCardapios.Cardapio cardapio { get; set; } = new Cardapio.TiposCardapios.Cardapio("");
        public Garcom(string nome, int id, int mesasAtendendo)
            : base(nome, id)
        {
            MesasAtendendo = mesasAtendendo;
        }

        public void AbrirMesaG(Mesas m)
        {         
            m.AbrirMesa();       
            //listaDeMesasAtendidas.Add(m);
        }

        public void FecharMesaG(Mesas m)
        {
            m.FecharMesa();
            l1.LimparMesa();
            //listaDeMesasAtendidas.Remove(m);
        }

        public void FazPedidoG(Mesas m, int idItem)
        {
            m.FazPedido(idItem);

        }

        public string getNomeG()
        {
            return nome;
        }

        public void ExibirCardapio()
        {
            cardapio.MostrarCardapioOrdenadoPorNome();
        }       
    }
}
