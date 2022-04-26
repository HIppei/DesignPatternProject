using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoV4
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter Value {counter}");
        }

        private static readonly Lazy<Singleton> InstanceLock = new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetInstance { get { return InstanceLock.Value; } }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
