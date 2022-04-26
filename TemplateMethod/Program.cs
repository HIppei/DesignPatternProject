using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseTemplate houseTemplate = new ConcreteHouse();

            houseTemplate.BuildHouse();

            houseTemplate = new WoodenHouse();
            houseTemplate.BuildHouse();
        }
    }
}
