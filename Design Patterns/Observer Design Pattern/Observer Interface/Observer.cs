using Design_Patterns.Observer_Design_Pattern.Subject_Interface;

namespace Design_Patterns.Observer_Design_Pattern.Observer_Interface
{
    public interface Observer
    {
        //method to update the observer,used by subject
        public void update();

        //attach with subject to observe
        public void setSubject(Subject sub);
    }
}
