using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public interface Animal
    {
        string speak();
    }

    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow";
        }
    }

    public class Shark : Animal
    {
        public string speak()
        {
            return "Cannot Speake";
        }
    }


}
