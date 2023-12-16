namespace GestaoDePedidos.Mesas
{
    public class Comanda
    {
        public StatusComanda EstadoComanda { get; set; }
        public static int NumeroComanda { get; set; }
        public List<Pedido> ItensDaComanda { get; set; }

    }
}