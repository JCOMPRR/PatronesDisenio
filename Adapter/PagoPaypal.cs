namespace Adapter
{
    public class PagoPaypal : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Se hizo el pago mediante PayPal del correo rodjosecarlos15@gmail.com");
        }
    }
}
