using System;

namespace SingletonDemoV2
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object InstanceLock = new object();

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter Value {counter}");
        }

        private static Singleton instance = null;
       
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (instance == null)
                            instance = new Singleton();

                    }
                }
                return instance;
            }
        }
        
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
