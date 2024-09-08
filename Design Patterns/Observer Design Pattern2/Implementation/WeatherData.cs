using Design_Patterns.Observer_Design_Pattern2.Interface;

namespace Design_Patterns.Observer_Design_Pattern2.Implementation
{
    public class WeatherData:Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers= new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        public void notifyObserver()
        {
            observers.ForEach(ob => ob.update(temperature,humidity,pressure));
        }

        public void measurementChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementChanged();
        }
    }
}
