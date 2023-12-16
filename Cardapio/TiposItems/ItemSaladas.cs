using System;

namespace Cardapio.TiposItems
{
    public class ItemSaladas : Item
    {
        public bool TemVegetal { get; set; }
        public bool TemFolhas { get; set; }

        public ItemSaladas(string nome, decimal preco, string? descricao, double calorias, bool temVegetal, bool temFolhas) : base(nome, preco, descricao, calorias)
        {
            TemVegetal = temVegetal;
            TemFolhas = temFolhas;
        }
    }
}