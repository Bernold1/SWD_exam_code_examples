using System;
using System.Collections.Generic;
using System.Text;

namespace BasicState
{
    class Lights : State
    {
        public Lights(State state) : this(state.Context)
        {

        }

        public Lights(Context context)
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
                context.State = new Lights(this);
                Console.WriteLine("Lights turned on");
            }
            else
            {
                Console.WriteLine("Lights off");
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
