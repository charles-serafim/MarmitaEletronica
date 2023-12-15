using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal abstract class Funcionario
    {
        protected string nome;
        protected string contato;
        protected int idade;
        protected string turno;
        protected string endereco;
        protected int id;
        protected double salario;

        public Funcionario(string nome, string contato, int idade, string turno, string endereco, int id, double salario)
        {
            this.nome = nome;
            this.contato = contato;
            this.idade = idade;
            this.turno = turno;
            this.endereco = endereco;
            this.id = id;
            this.salario = salario;          
        }

        public void Bonificar(bool meta)
        {
            if (meta)
            {
                salario *= 1.1;
                Console.WriteLine("Bonificado com sucesso!");
            }
            else
            {
                Console.WriteLine("Este funcionário não tem direito a bonificação no momento.");
            }
            
        }
        
    }
}
