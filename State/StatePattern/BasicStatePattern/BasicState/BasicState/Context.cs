namespace BasicState
{
    class Context
    {
        private State _state;
        public Context()
        {
            _state = new SmartTV(this);
        }
        

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void TurnOn(bool b)
        {
            _state.TurnOn(b);
        }

        public void TurnOff(bool b)
        {
            _state.TurnOff(b);
        }
    }
}