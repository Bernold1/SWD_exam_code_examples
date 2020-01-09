using System;

namespace EmergencyResponse
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubjectItem PSAP = new ConcreteSubjectItem();
            EmergencyResponse Police = new EmergencyResponse("Police", PSAP);
            EmergencyResponse FireStation = new EmergencyResponse("Fire Marshall", PSAP);
            EmergencyResponse Hospital = new EmergencyResponse("Hospital", PSAP);

            PSAP.CitizenInjury();
            PSAP.Fire();
            PSAP.Robbery();
            PSAP.Unknown();
        }
    }
}
