using Design_Patterns.Observer_Design_Pattern2.Interface;

namespace Design_Patterns.Observer_Design_Pattern2.Implementation
{
    public class CurrentConditionsDisplay:Observer,DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject subject)
        {
            weatherData = subject;
            weatherData.registerObserver(this);
        }

        public void update(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine($"Current conditions {temperature}F degrees {humidity}% humidity");
        }
    }
}
