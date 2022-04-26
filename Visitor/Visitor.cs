using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        public void Visit(IElement element);
    }

    public class Doctor : IVisitor
    {
        private string name;

        public Doctor(string name)
        {
            this.name = name;
        }

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Doctor: " + this.name + " did the health checkup of the child: " + kid.kidName);
        }
    }

    class Salesman : IVisitor
    {
        private string name; 
        public Salesman(string name)
        {
            this.name = name;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + this.name + " gave the school bag to the child: "
                            + kid.kidName);
        }
    }

}
