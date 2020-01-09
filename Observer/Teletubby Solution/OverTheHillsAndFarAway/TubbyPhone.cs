using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace OverTheHillsAndFarAway
{
    class TubbyPhone : TelephoneSubject
    {
        public enum WhatToDoEnum
        {
            Play,
            SayHello,
            SayByeBye,
            TimeForTubbyCustard
        }

        private WhatToDoEnum whatToDo = WhatToDoEnum.Play;

        public WhatToDoEnum WhatToDo => whatToDo;

        public void Play()
        {
            whatToDo = WhatToDoEnum.Play;
            Notify();
        }

        public void SayHello()
        {
            whatToDo = WhatToDoEnum.SayHello;
            Notify();
        }

        public void SayByeBye()
        {
            whatToDo = WhatToDoEnum.SayByeBye;
            Notify();
        }

        public void TimeForTubbyCustard()
        {
            whatToDo = WhatToDoEnum.TimeForTubbyCustard;
            Notify();
        }
    }
}
