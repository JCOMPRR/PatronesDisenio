namespace PuntoDeVenta
{
    public class PagoEfectivoAdapter : IPagoPV
    {
        public void Cobrar()
        {
            Console.WriteLine("El cliente pago en Efectivo");
        }
    }
}
