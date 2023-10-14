namespace Adapter
{
    public class PagoBitcoin : IPago
    {
        private readonly string _numBitcoin;
        public PagoBitcoin(string numBitcoin)
        {
            _numBitcoin = numBitcoin;
        }
        public void Cobrar()
        {
            Console.WriteLine($"Se realizo pago con Bitcoin con terminacion {_numBitcoin}");
        }
    }
}
