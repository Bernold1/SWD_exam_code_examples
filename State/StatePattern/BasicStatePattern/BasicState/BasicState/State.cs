using System;
using System.Collections.Generic;
using System.Text;

namespace BasicState
{
    abstract class State
    {
        protected Context context;
        protected bool isOn;

        public Context Context
        {
            get { return context; }
            set { context = value; }
        }
        public bool CurrentState
        {
            get { return isOn; }
            set { isOn = value; }
        }

        public abstract void TurnOn(bool b);
        public abstract void TurnOff(bool b);
        public abstract void GridCheck();
    }
}
