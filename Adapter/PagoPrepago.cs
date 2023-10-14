namespace Adapter
{
    public class PagoPrepago : IPago
    {
        private string _numeroTarjetaP;
        public PagoPrepago(string numeroTarjetaP)
        {
            _numeroTarjetaP = numeroTarjetaP;
        }
        public void Cobrar()
        {
            Console.WriteLine($"Se pago con tarjeta prepago de Amazon{_numeroTarjetaP}");
        }
    }
}
