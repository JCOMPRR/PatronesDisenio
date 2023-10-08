namespace PuntoDeVenta
{
    public class VentaExtraDecorator : ICargoExtraDecorator
    {
        public ICargoExtraDecorator _ventaExtra;
        public VentaExtraDecorator (ICargoExtraDecorator ventaExtra)
        {
            _ventaExtra = ventaExtra;
        }

        public virtual decimal CalcularTotal()
        {
            return _ventaExtra.CalcularTotal();
        }

        public List<string> ObtenerProductos()
        {
            return _ventaExtra.ObtenerProductos();
        }
    }
}
