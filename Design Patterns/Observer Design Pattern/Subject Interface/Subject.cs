using Design_Patterns.Observer_Design_Pattern.Observer_Interface;

namespace Design_Patterns.Observer_Design_Pattern.Subject_Interface
{
    public interface Subject
    {
        //methods to register and unregister observers
        public void register(Observer obj);
        public void unregister(Observer obj);

        //method to notify observers of change
        public void notifyObservers();

        //method to get updates from subject
        public Object getUpdate(Observer obj);

        public void postMessage(string msg);
    }
}
