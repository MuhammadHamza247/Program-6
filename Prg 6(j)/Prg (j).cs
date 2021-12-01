using System;

namespace Prg_6_j_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =3, a=6, b=2;
            n*=a+b;
            a--;
            n%=a; 
            Console.WriteLine(n);
        }
    }
}
