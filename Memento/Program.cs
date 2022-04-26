using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.ledTV = new LEDTV("42 inch", "60000Rs", false);

            CareTaker careTaker = new CareTaker();
            careTaker.AddMemento(originator.CreateMemento());

            originator.ledTV = new LEDTV("46 inch", "80000Rs", true);
            careTaker.AddMemento(originator.CreateMemento());
            originator.ledTV = new LEDTV("50 inch", "100000Rs", true);

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.WriteLine("\nOriginator restoring to 42 inch LED TV");

            originator.SetMemento(careTaker.GetMemento(0));

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.ReadKey();
        }
    }
}
