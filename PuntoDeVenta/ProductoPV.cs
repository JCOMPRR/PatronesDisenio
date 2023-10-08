namespace PuntoDeVenta
{
    public class ProductoPV
    {
        private readonly ITicket _ticket;

        public ProductoPV(ITicket ticket)
        {
            _ticket = ticket;
        }

        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get => CobrarEfectivo(); }

        public decimal CobrarEfectivo()
        {
            return _ticket.CobrarEfectivo(Precio);
        }
    }

    
}
