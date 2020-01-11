using StatePattern.ConcreteStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    //Context class!
    class Steak
    {
        private DonenessState _state;
        private string _beefCut;

        public Steak(string beefCut)
        {
            _beefCut = beefCut;
            _state = new Rare(0.0, this);
        }
        public double CurrentTemp
        {
            get { return _state.CurrentTemp; }
        }
        public DonenessState State
        {
            get { return _state; }
            set { _state = value; }
        }
        public void AddTemp(double temp)
        {
            _state.AddTemp(temp);
            Console.WriteLine("Increased temperature by {0} degrees.", temp);
            Console.WriteLine(" Current temp is {0}", CurrentTemp);
            Console.WriteLine(" Status is {0}", State.GetType().Name);
            Console.WriteLine("");
        }
        public void RemoveTemp(double temp)
        {
            _state.RemoveTemp(temp);
            Console.WriteLine("Decreased temperature by {0} degrees.", temp);
            Console.WriteLine(" Current temp is {0}", CurrentTemp);
            Console.WriteLine(" Status is {0}", State.GetType().Name);
            Console.WriteLine("");
        }
    }
}
