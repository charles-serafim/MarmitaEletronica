using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDePedidos.Mesas
{
    internal class Mesas
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Lugares { get; set; }
        public StatusMesa status { get; set; }
        public Comanda? comanda { get; set; }

        public void Ocupar()
        {
            if (this.status == StatusMesa.Ocupada)
            {
                throw new Exception("Mesa já ocupada");
            }

            this.status = StatusMesa.Ocupada;
        }
        public void AbrirMesa()
        {
            if (this.status != StatusMesa.Livre)
            {
                throw new Exception("Mesa não livre");
            }

            this.status = StatusMesa.Ocupada;
        }

        public void AbrirComanda()
        {
            if (this.status != StatusMesa.Ocupada)
            {
                throw new Exception("Mesa não foi aberta");
            }
            if (this.comanda != null)
            {
                throw new Exception("Comanda já aberta");
            }

            var comanda = new Comanda();
            this.comanda = comanda;            
        }

        public void FecharComanda()
        {
            if (this.status != StatusMesa.Ocupada)
            {
                throw new Exception("Mesa não foi aberta");
            }
            if (this.comanda == null)
            {
                throw new Exception("Comanda não aberta");
            }

            this.comanda = null;
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
