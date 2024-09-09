using Design_Patterns.Observer_Design_Pattern.Observer_Interface;
using Design_Patterns.Observer_Design_Pattern.Subject_implementation;
using Design_Patterns.Observer_Design_Pattern.Subject_Interface;
using Design_Patterns.Strategy_Design_Pattern;
using Design_Patterns.Strategy_Design_Pattern.Behavior;
using Design_Patterns.Strategy_Design_Pattern.DuckCLass;

class Program
{
    static void Main(string[] args)
    {
        //Strategy design pattern

        Duck mallardDuck = new MallardDuck();
        mallardDuck.performQuack();
        mallardDuck.performFly();
        mallardDuck.setFlyBehavior(new FlyNoWay());
        mallardDuck.performFly();

        Duck modelDuck = new ModelDuck();
        modelDuck.performQuack();
        modelDuck.performFly();

        modelDuck.setFlyBehavior(new FlyRocketPowered());
        modelDuck.performFly();

        //Observer design pattern

        Subject topic = new MyTopic();

        Observer obj1 = new MyTopicSubscriber("Obj1");
        Observer obj2 = new MyTopicSubscriber("Obj2");
        Observer obj3 = new MyTopicSubscriber("Obj3");

        topic.register(obj1);
        topic.register(obj2);
        topic.register(obj3);

        obj1.setSubject(topic);
        obj2.setSubject(topic);
        obj3.setSubject(topic);

        obj1.update();

        topic.postMessage("Namma Bengaluru!!");
    }
}