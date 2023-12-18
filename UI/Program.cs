using UI.Menu;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TesteUI teste = new TesteUI();
            teste.Teste();
            //var recepcao = new MenuRecepcao();
            //var atendimento = new MenuGarcom();
            //var mesa = recepcao.SelecionaMesa();
            //var garcom = atendimento.AtribuiGarcom(mesa);
            //atendimento.MostraCardapio();
            //var usuario = new MenuMesa(mesa);
            //usuario.MenuLoop();
        }
    }
}
