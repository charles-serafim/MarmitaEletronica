using Cardapio.TiposItems;
using Funcionarios.TiposFuncionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal class FuncionariosLogica: JsonParser<Funcionario>
    {
        // Coloque o path do seu PC aqui
        public List<Funcionario> funcionariosItems = JsonParser<Funcionario>.ReceberJson();
        //public List<Funcionario> OrdenarItensPorNome()
        //{
        //    return FuncionariosLogica.OrdenarItensPorNome(funcionariosItems);
        //}
        //public List<Funcionario> OrdenarItensPorId()
        //{
        //    return FuncionariosLogica.OrdenarItensPorId(funcionariosItems);
        //}
        //public List<Funcionario> OrdenarItensPorMesa()
        //{
        //    return funcionariosItems.OrderBy(item => item.Mesa).ToList();
        //}
    }
}
