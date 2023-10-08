namespace PuntoDeVenta
{
    public interface ICargoExtraDecorator
    {
        decimal CalcularTotal();
        List<string> ObtenerProductos();
    }
}
