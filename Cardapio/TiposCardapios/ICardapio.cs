using Cardapio.TiposItems;
using System.Collections.Generic;

namespace Cardapio.TiposCardapios
{
    public interface ICardapio
    {
        List<Item> ItemsDoCardapio { get; }

        List<Item> OrdenarItensPorNomeEID();
        List<Item> OrdenarItensPorNome();
        List<Item> OrdenarItensPorTipo();
        List<Item> OrdenarItensPorPreco();
        List<Item> OrdenarItensPorVegetariano();
        void AdicionarItem(Item novoItem);
        void RemoverItem(Item removerItem);
        void MostrarCardapioOrdenadoPorNomeEID();
    }
}
