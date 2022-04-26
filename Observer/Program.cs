using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");

            Observer user1 = new Observer("Anurag", RedMI);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Pranaya", RedMI);
            //User Priyanka will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Priyanka", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();

            RedMI.setAvailability("Available");

            Console.Read();
        }
    }
}
