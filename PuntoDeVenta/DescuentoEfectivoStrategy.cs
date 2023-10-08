namespace PuntoDeVenta
{
    public class DescuentoEfectivoStrategy : ITicket
    {
        public void cobrarEfectivo(decimal precio)
        {
            Console.WriteLine($"Se hizo pago con efectivo y se ahorro: {precio}");
        }

        public decimal CobrarEfectivo(decimal precio)
        {
            return precio * 0.9m;
        }
    }
}
