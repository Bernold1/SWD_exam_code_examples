using System;

namespace PushVersion
{
    class Teletubby : ITelephoneObserver
    {
        private readonly string _name;

        public Teletubby(string name, TubbyPhone tubbyPhone)
        {
            _name = name;
            tubbyPhone.Attach(this);
        }

        public void Update(TelephoneSubject.WhatToDoEnum whatToDo)
        {
            switch (whatToDo)
            {
                case TelephoneSubject.WhatToDoEnum.Play:
                {
                    Console.WriteLine("{0} play!!", _name);
                }
                    break;
                case TelephoneSubject.WhatToDoEnum.SayHello:
                {
                    Console.WriteLine("{0} smiles and says HI!", _name);
                }
                    break;
                case TelephoneSubject.WhatToDoEnum.SayByeBye:
                {
                    Console.WriteLine("{0}: Bye bye!!!!", _name);
                }
                    break;
                case TelephoneSubject.WhatToDoEnum.TimeForTubbyCustard:
                {
                    Console.WriteLine("{0}: Tubby custard! Tubby custard!!!", _name);
                }
                    break;
                default:
                    break;
            }
        }
    }
}
