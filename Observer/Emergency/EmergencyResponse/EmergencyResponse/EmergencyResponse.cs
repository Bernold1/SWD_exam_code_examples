using System;

namespace EmergencyResponse
{
    public class EmergencyResponse:IObserver
    {
        //PSAP stands for Public safety answering point (Alarmcentral til the bois)
        private readonly string _responseType;
        private readonly ConcreteSubjectItem _PSAP;
        public EmergencyResponse(string responseType, ConcreteSubjectItem PSAP)
        {
            _responseType = responseType;
            _PSAP = PSAP;
            PSAP.Attach(this);
        }
        public void Update()
        {
            ConcreteSubjectItem.Emergencies emergencies = _PSAP.HandleEmergency;
            switch (emergencies)
            {
                case ConcreteSubjectItem.Emergencies.ResponseWait:
                {
                        Console.WriteLine("{0} on hold for response\n", _responseType);
                }
                    break;
                case ConcreteSubjectItem.Emergencies.Fire:
                {
                    Console.WriteLine("{0}: on root to fire\n", _responseType);
                    }
                    break;
                case ConcreteSubjectItem.Emergencies.Injury:
                {
                    Console.WriteLine("{0} on root to Injury\n", _responseType);
                    }
                    break;
                case ConcreteSubjectItem.Emergencies.Robbery:
                {
                    Console.WriteLine("{0} on the way for robbery in progress\n", _responseType);
                    }
                    break;
                case ConcreteSubjectItem.Emergencies.Unknown:
                {
                    Console.WriteLine("{0} All units responding\n", _responseType);
                    }
                    break;

            }
        }
    }
}