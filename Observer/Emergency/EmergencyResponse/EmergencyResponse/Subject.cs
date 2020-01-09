using System.Collections.Generic;

namespace EmergencyResponse
{
    //Abstract classes are classes which cannot be instantiated
    public abstract class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        //Attaches a concrete observer (a "subscriber of a sort") to recieve messages
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        //Called when a concrete observer no longer wishes to recieve updates from the subject. 
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in _observers) o.Update();
        }
    }
}