using System;

namespace PushVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            TubbyPhone tubbyPhone = new TubbyPhone();
            Teletubby Lala = new Teletubby("Lala", tubbyPhone);
            Teletubby Poo = new Teletubby("Poo", tubbyPhone);
            Teletubby Dipsy = new Teletubby("Dipsy", tubbyPhone);
            Teletubby TinkyWinky = new Teletubby("Tinky Winky", tubbyPhone);

            tubbyPhone.SayHello();
            tubbyPhone.Play();
            tubbyPhone.TimeForTubbyCustard();
            tubbyPhone.Play();
            tubbyPhone.SayByeBye();

            Console.ReadKey();
        }
    }
}
