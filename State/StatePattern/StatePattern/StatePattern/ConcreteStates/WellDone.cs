using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.ConcreteStates
{
    class WellDone : DonenessState
    {
        //Concrete state class 
        public WellDone(DonenessState state) : this(state.CurrentTemp, state.Steak)
        {

        }
        public WellDone(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 150;
            upperTemp = 170;
            canEat = true;
        }

        public override void AddTemp(double temp)
        {
            currentTemp += temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp < 0.0)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemp < lowerTemp)
            {
                steak.State = new MediumRare(this);
            }
  
        }

        public override void RemoveTemp(double temp)
        {
            currentTemp -= temp;
            DonenessCheck();
        }
    }
}
