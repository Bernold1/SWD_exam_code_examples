namespace PushVersion
{
    class TubbyPhone : TelephoneSubject
    {

        public void Play()
        {
            Notify(WhatToDoEnum.Play);
        }

        public void SayHello()
        {
            Notify(WhatToDoEnum.SayHello);
        }

        public void SayByeBye()
        {
            Notify(WhatToDoEnum.SayByeBye);
        }

        public void TimeForTubbyCustard()
        {
            Notify(WhatToDoEnum.TimeForTubbyCustard);
        }
    }
}
