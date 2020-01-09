using System;
using System.Collections.Generic;
using System.Text;

namespace OverTheHillsAndFarAway
{
    class Teletubby : ITelephoneObserver
    {
        private readonly string _name;
        private readonly TubbyPhone _tubbyPhone;

        public Teletubby(string name, TubbyPhone tubbyPhone)
        {
            _name = name;
            _tubbyPhone = tubbyPhone;
            tubbyPhone.Attach(this);
        }

        public void Update()
        {
            TubbyPhone.WhatToDoEnum whatToDo = _tubbyPhone.WhatToDo;
            switch (whatToDo)
            {
                case TubbyPhone.WhatToDoEnum.Play:
                {
                    Console.WriteLine("{0} play!!", _name);
                }
                    break;
                case TubbyPhone.WhatToDoEnum.SayHello:
                {
                    Console.WriteLine("{0} smiles and says HI!", _name);
                }
                    break;
                case TubbyPhone.WhatToDoEnum.SayByeBye:
                {
                    Console.WriteLine("{0}: Bye bye!!!!", _name);
                }
                    break;
                case TubbyPhone.WhatToDoEnum.TimeForTubbyCustard:
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
