using Cardapio.TiposCardapios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDePedidos.Mesas
{
    public class Mesas
    {
        public int Id { get; set; }
        public int Lugares { get; set; }
        public StatusMesa status { get; set; }
        public Comanda? comanda { get; set; }

        public void AbrirMesa()
        {
            if (this.status != StatusMesa.Livre)
            {
                throw new Exception("Mesa não livre");
            }

            this.status = StatusMesa.Ocupada;
            AbrirComanda();
        }

        public void AbrirComanda()
        {
            if (this.comanda != null)
            {
                throw new Exception("Comanda já aberta");
            }

            var comanda = new Comanda();
            comanda.EstadoComanda = StatusComanda.Aberta;

            this.comanda = comanda;
        }

        public void FecharMesa()
        {
            if (this.status != StatusMesa.Ocupada)
            {
                throw new Exception("Mesa não foi aberta");
            }
            if (this.comanda?.EstadoComanda != StatusComanda.Fechada)
            {
                throw new Exception("A comanda não está fechada");
            }
            this.status = StatusMesa.Livre;
            FecharComanda();
        }
        public void FecharComanda()
        {
            if (this.comanda == null)
            {
                throw new Exception("Comanda não aberta");
            }

            this.comanda.EstadoComanda = StatusComanda.Fechada;
        }
        public void ExibirComanda()
        {
            if (this.comanda == null)
            {
                throw new Exception("Comanda não aberta");
            }

            Console.WriteLine($"O total da sua comanda é R$ {this.comanda.ItensDaComanda.ObterValorTotal():C2}");
            Console.WriteLine("Itens na comanda:");
            foreach (var item in this.comanda.ItensDaComanda.Itens)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco:C2} - Descrição: {item.Descricao} - Calorias: {item.Calorias}");
            }
        }

        public void ChamarGarcom()
        {
            if (this.status != StatusMesa.Ocupada)
            {
                throw new Exception("Mesa não foi aberta");
            }
            if (this.comanda?.EstadoComanda != StatusComanda.Aberta)
            {
                throw new Exception("A comanda não está aberta");
            }
            this.comanda.EstadoComanda = StatusComanda.ChamandoGarcom;
            Console.WriteLine("Comanda aberta.");
            //FazPedido(cardapio, idItem);
        }

        public int FazPedido(CardapioLogica cardapio, int idItem)
        {
            //if (this.comanda?.ItensDaComanda.AdicionarItem(cardapio, idItem) == 0)
            //{
            //    this.comanda.EstadoComanda = StatusComanda.Aberta;
            //}
            if (this.comanda != null && this.comanda.EstadoComanda == StatusComanda.Aberta)
            {
                this.comanda.EstadoComanda = StatusComanda.Aberta;
            }

            int adicionouItem = comanda.ItensDaComanda.AdicionarItem(cardapio, idItem);
            return adicionouItem;
        }


        public void Reservar()
        {
            if (this.status != StatusMesa.Livre)
            {
                throw new Exception("Mesa não livre");
            }

            this.status = StatusMesa.Reservada;
        }

        public void Desativar()
        {
            if (this.status != StatusMesa.Livre)
            {
                throw new Exception("Mesa não livre");
            }

            this.status = StatusMesa.Desativada;
        }

        public void LiberarReserva()
        {
            if (this.status != StatusMesa.Reservada)
            {
                throw new Exception("Mesa não reservada");
            }

            this.status = StatusMesa.Livre;
        }

        public void LiberarDesativacao()
        {
            if (this.status != StatusMesa.Desativada)
            {
                throw new Exception("Mesa não desativada");
            }

            this.status = StatusMesa.Livre;
        }

    }
}
