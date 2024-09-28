namespace Design_Patterns.Command_Pattern.Receiver
{
    public class AcController
    {
        public bool isOn;
        public int temperature;

        public AcController(){}

        public void turnOnAC()
        {
            this.isOn = true;
            Console.WriteLine("Turned on AC");
        }

        public void turnOffAC()
        {
            this.isOn= false;
            Console.WriteLine("Turned off AC");
        }

        public void setTemperature(int temp)
        {
            this.temperature = temp;
        }
    }
}
