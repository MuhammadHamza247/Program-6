using System;

namespace Prg_6_i_
{
    class Program
    {
        static void Main(string[] args)
        {
            double p=5;
            int q=9;
            int n=(q%2)*p + 6.0*p*(q%3) +(q%4)*p*p*p;
            Console.WriteLine(n);
        }
    }
}
