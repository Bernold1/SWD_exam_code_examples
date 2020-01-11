using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.ConcreteStates
{
    //Concrete state class 
    class MediumRare : DonenessState
    {
        public MediumRare(DonenessState state) : this(state.CurrentTemp, state.Steak)
        {

        }
        public MediumRare(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 139.99;
            upperTemp = 150;
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
                steak.State = new Rare(this);
            }
            else if (currentTemp > upperTemp)
            {
                steak.State = new WellDone(this);
            }
        }

        public override void RemoveTemp(double temp)
        {
            currentTemp -= temp;
            DonenessCheck();
        }
    }
}
