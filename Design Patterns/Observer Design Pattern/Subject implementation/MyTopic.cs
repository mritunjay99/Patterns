using Design_Patterns.Observer_Design_Pattern.Observer_Interface;
using Design_Patterns.Observer_Design_Pattern.Subject_Interface;

namespace Design_Patterns.Observer_Design_Pattern.Subject_implementation
{
    public class MyTopic:Subject
    {
        private List<Observer>? observers;
        private string? message;
        private Boolean changed;
        private readonly Object lockerObject=new Object();

        public MyTopic()
        {
            observers = new List<Observer>();
        }

        public void register(Observer obj)
        {
            if (obj == null) throw new ArgumentNullException("Null Observer");
            
            lock (lockerObject)
            {
                if (!observers.Contains(obj)) observers.Add(obj);
            }
        }

        public void unregister(Observer obj)
        {
            lock (lockerObject)
            {
                observers.Remove(obj);
            }
        }

        public void notifyObservers()
        {
            List<Observer> observersLocal = null;

            //synchronization is used to make sure any observer registered after message is recieved is not notified
            lock (lockerObject) 
            {
                if (!changed) return;
                observersLocal = new List<Observer>(observers);
                changed = false;
            }
            observersLocal.ForEach(obj => obj.update());
        }

        public Object getUpdate(Observer obj)
        {
            return message;
        }

        //method to post message to the topic
        public void postMessage(string msg)
        {
            Console.WriteLine($"Message posted to Topic: {msg}");
            this.message = msg;
            this.changed = true;
            notifyObservers();
        }
    }
}
