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
        protected string contato { get; set; }
        protected int idade { get; set; }
        protected string turno { get; set; }
        protected string endereco { get; set; }
        protected int id { get; set; }
        protected double salario { get; set; }

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
