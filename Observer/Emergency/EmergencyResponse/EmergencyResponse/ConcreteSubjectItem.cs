namespace EmergencyResponse
{
    public class ConcreteSubjectItem:Subject
    {
        public enum Emergencies
        {
            ResponseWait,
            Fire,
            Robbery,
            Injury,
            Unknown
        }

        private Emergencies currentEmergencies = Emergencies.ResponseWait;

        public Emergencies HandleEmergency => currentEmergencies;
        public string SubjectState { get; set; }

        public void Fire()
        {
            currentEmergencies = Emergencies.Fire;
            Notify();
        }

        public void Robbery()
        {
            currentEmergencies = Emergencies.Robbery;
            Notify();
        }

        public void CitizenInjury()
        {
            currentEmergencies = Emergencies.Injury;
            Notify();
        }

        public void Unknown()
        {
            currentEmergencies = Emergencies.Unknown;
            Notify();
        }
    }
}