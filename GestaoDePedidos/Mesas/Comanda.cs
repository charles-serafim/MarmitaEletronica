﻿using GestaoDePedidos.Pedidos;

namespace GestaoDePedidos.Mesas
{
    public class Comanda
    {
        public StatusComanda EstadoComanda { get; set; }
        public int IdComanda { get; set; }

        public static int ComandasAbertas = 0;
        public Pedido ItensDaComanda { get; set; }

        public Comanda()
        {
            EstadoComanda = StatusComanda.Aberta;
            ComandasAbertas += 1;
            IdComanda = ComandasAbertas;
            ItensDaComanda = new Pedido();
        }

        public bool ComandaAberta()
        {
            return EstadoComanda == StatusComanda.Aberta;
        }
    }
}