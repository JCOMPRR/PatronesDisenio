namespace Adapter
{
    public class PagoVacas : IPago
    {
        
        public void Cobrar()
        {
            Console.WriteLine("Se pago con 4 vacas");
        }
    }
}
