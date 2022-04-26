using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("\n Requested Amount 4600");
            atm.WithDraw(4600);
            Console.WriteLine("\n Requested Amount 1900");
            atm.WithDraw(1900);
            Console.WriteLine("\n Requested Amount 600");
            atm.WithDraw(600);
            Console.Read();
        }
    }
}
