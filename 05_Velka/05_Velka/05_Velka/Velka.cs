namespace Velka
{
    internal class Velka
    {
        double _saldo, _korkoProsentti;
        

        public Velka(double saldoAlussa, double korkoProsentti)
        {
            this._saldo = saldoAlussa;
            this._korkoProsentti= korkoProsentti;
        }

        public void TulostaSaldo()
        {
            Console.WriteLine(_saldo);
            Console.WriteLine(_korkoProsentti);
            
        }
        public void OdotaVuosi()
        {
            Console.WriteLine((_saldo = _saldo * (1 + _korkoProsentti)));
        }
    }



}
