using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using GestaoDePedidos.Mesas;

namespace Funcionarios.TiposFuncionarios
{
    public class Recepcionista : Funcionario
    {
        public Recepcionista(string nome, int id)
            : base(nome, id)
        {

        }
        //Lógica para trazer a verificação de mesas do menuRecepcao para a classe Recepcionista
        //public List<Mesas> Mesas { get; set; }       
        //Mesas = LeitorDeJson();   

        //public Mesas? SelecionarMesaR(int resposta)
        //{
        //    if (Mesas.Find(x => x.Lugares == resposta && x.status == StatusMesa.Livre) != null)
        //    {
        //        return Mesas.Find(x => x.Lugares == resposta && x.status == StatusMesa.Livre);
        //    }
        //    else if (Mesas.Find(x => x.Lugares > resposta && x.status == StatusMesa.Livre) != null)
        //    {
        //        return Mesas.Find(x => x.Lugares > resposta && x.status == StatusMesa.Livre);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Não há mesas disponíveis que atendam a quantidade de clientes, por favor aguarde um momento.");
        //        return null;
        //    }
        //}
    }
}
