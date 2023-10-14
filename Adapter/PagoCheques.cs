namespace Adapter
{
    public class PagoCheques : IPago
    {
        private string _numeroCheque;
        public PagoCheques(string numeroCheque)
        {
            _numeroCheque = numeroCheque;
        }
        public void Cobrar()
        {
            Console.WriteLine($"Se pago con cheque {_numeroCheque}");
        }
    }
}
