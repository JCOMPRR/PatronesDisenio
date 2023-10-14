namespace Adapter
{
    public class PagoTrueque : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Se pago cambiando una gallina por 3 panes");
        }
    }
}
