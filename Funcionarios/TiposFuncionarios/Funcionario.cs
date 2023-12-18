using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.TiposFuncionarios
{
    public abstract class Funcionario
    {
        protected string nome { get; set; }      
        protected int id { get; set; }      

        public Funcionario(string nome,int id)
        {
            this.nome = nome;           
            this.id = id;          
        }      

    }
}
