using System.Collections.Generic;

namespace PushVersion
{
    abstract class TelephoneSubject
    {
        public enum WhatToDoEnum
        {
            Play,
            SayHello,
            SayByeBye,
            TimeForTubbyCustard
        }

        private List<ITelephoneObserver> observers = new List<ITelephoneObserver>();

        public void Attach(ITelephoneObserver observer)
        {
            observers.Add(observer);
        }

        public void Detatch(ITelephoneObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(WhatToDoEnum whatToDo)
        {
            foreach (ITelephoneObserver telephoneObserver in observers)
            {
                telephoneObserver.Update(whatToDo);
            }
        }
    }
}
