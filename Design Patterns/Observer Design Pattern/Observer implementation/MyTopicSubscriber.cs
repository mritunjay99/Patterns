using Design_Patterns.Observer_Design_Pattern.Subject_Interface;

namespace Design_Patterns.Observer_Design_Pattern.Observer_Interface
{
    public class MyTopicSubscriber: Observer
    {
        private string ?name;
        private Subject ?topic;

        public MyTopicSubscriber(string name)
        {
            this.name = name;   
        }

        public void update()
        {
            string msg =(String) topic.getUpdate(this);
            if (msg == null)
            {
                Console.WriteLine(name + ":: No new message");
            }
            else
            {
                Console.WriteLine($"{name}:: Consuming message::{msg}");
            }
        }

        public void setSubject(Subject sub)
        {
            topic = sub;
        }
    }
}
