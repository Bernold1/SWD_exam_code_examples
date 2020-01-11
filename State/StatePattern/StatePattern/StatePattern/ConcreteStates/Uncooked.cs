using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.ConcreteStates
{
    //Concrete state class 
    class Uncooked : DonenessState
    {
        public Uncooked(DonenessState state)
        {
            currentTemp = state.CurrentTemp;
            steak = state.Steak;
            Initialize();
        }
        private void Initialize()
        {
            lowerTemp = 0;
            upperTemp = 130;
            canEat = false;
        }
        public override void AddTemp(double temp)
        {
            currentTemp += temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp>upperTemp)
            {
                steak.State = new Rare(this);
            }
        }

        public override void RemoveTemp(double temp)
        {
            currentTemp -= temp;
            DonenessCheck();
        }
    }
}
