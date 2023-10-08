namespace PuntoDeVenta
{
    public class VentasAdapter
    {
        private readonly IPagoPV _pago;
        public VentasAdapter(IPagoPV pago)
        {
            _pago = pago;
        }

        public void ProcesarPago()
        {
            _pago.Cobrar();
        }
    }
}
