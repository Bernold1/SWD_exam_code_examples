using System;

namespace BasicState
{
    class Program
    {
        static void Main(string[] args)
        {
            Context Smarthouse = new Context();

            Smarthouse.TurnOn(true);
            Smarthouse.TurnOff(true);
            Smarthouse.TurnOn(false);
            Smarthouse.TurnOff(false);
            Console.ReadKey();
        }
    }
}
