using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Garçom : Funcionario
    {
        public Garçom(string nome, string contato, int idade, string turno, string endereco, int id, double salario)
            : base(nome, contato, idade, turno, endereco, id, salario)
        {

        }
        
          
        
    }
}
