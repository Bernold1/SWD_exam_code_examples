using System;

namespace TemplateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBaseClass square = new WeirdSquare();
            AbstractBaseClass car = new Car();
            square.TemplateMethod();
            car.TemplateMethod();

            Console.ReadKey();
        }
    }
}
