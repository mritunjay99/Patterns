namespace Design_Patterns.Observer_Design_Pattern2.Interface
{
    public interface Subject
    {
        public void registerObserver(Observer o);
        public void removeObserver(Observer o);
        public void notifyObserver();
    }
}
