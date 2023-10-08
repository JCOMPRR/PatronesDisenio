namespace PuntoDeVenta
{
    public class CargoExtraDecorator : VentaExtraDecorator
    {
        private decimal _extra;
        public CargoExtraDecorator(ICargoExtraDecorator venta, decimal extra) 
            : base(venta)
        {
            _extra = extra;
        }

        public override decimal CalcularTotal()
        {
            decimal total = base.CalcularTotal();
            return total + _extra;
        }

        public override string ToString()
        {
            return $" {CalcularTotal():N2}";
        }
    }
}
