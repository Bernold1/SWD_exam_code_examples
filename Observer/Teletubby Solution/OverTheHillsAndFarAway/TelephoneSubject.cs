using System;
using System.Collections.Generic;
using System.Text;

namespace OverTheHillsAndFarAway
{
    abstract class TelephoneSubject
    {
        private List<ITelephoneObserver> observers = new List<ITelephoneObserver>();

        public void Attach(ITelephoneObserver observer)
        {
            observers.Add(observer);
        }

        public void Detatch(ITelephoneObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (ITelephoneObserver telephoneObserver in observers)
            {
                telephoneObserver.Update();
            }
        }
    }
}
