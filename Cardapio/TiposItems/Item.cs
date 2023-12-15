using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio.TiposItems
{
    public abstract class Item
    {
        public string Nome;
        public decimal? Preco;
        private string? Descricao;
        private double? Calorias;

        private bool EhQuente;
        private bool ContemLactose = false;
        private bool ContemCarne = false;
        private bool ContemGlutem = false;
        private bool ContemFrutosMar = false;

        public Item(string nome, decimal preco, string? descricao, double calorias)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Calorias = calorias;
        }
        public string MudarDesc(string novaDescricao) => Descricao = novaDescricao;
        public decimal? MudarPreço(decimal? novoPreço) => Preco = novoPreço;
        public bool TirarCarne() => ContemCarne = false;
        public bool TirarFrutosMar() => ContemFrutosMar = false;
        public bool TirarGlutem() => ContemGlutem = false;
        public bool TirarLactose() => ContemLactose = false;
    }
}
