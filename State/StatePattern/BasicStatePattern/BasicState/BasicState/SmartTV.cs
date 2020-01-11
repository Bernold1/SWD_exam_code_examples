using System;
using System.Collections.Generic;
using System.Text;

namespace BasicState
{
    class SmartTV : State
    {
        public SmartTV(State state) : this(state.Context)
        {

        }

        public SmartTV(Context context)
        {
            this.context = context;
            Initialize();
        }

        private void Initialize()
        {
            isOn = false;
        }
        public override void GridCheck()
        {
            if (isOn)
            {
                context.State = new SmartTV(this);
                Console.WriteLine("SmartTV turned on");
            }
            else
            {
                Console.WriteLine("SmartTV off");
            }
        }

        public override void TurnOff(bool b)
        {
            if (!b)
            {
                isOn = false;
                GridCheck();
            }

        }

        public override void TurnOn(bool b)
        {
            if (b)
            {
                isOn = true;
                GridCheck();
            }

        }
    }
}
