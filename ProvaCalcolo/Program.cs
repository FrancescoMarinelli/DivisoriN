using System;
using Gestione;

namespace ProvaCalcolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Divisore.LeggiNum();
            Divisore.StampaDivisori(n);

        }
    }
}
