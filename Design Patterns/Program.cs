// See https://aka.ms/new-console-template for more information
using Design_Patterns.Strategy_Design_Pattern;
using Design_Patterns.Strategy_Design_Pattern.Behavior;
using Design_Patterns.Strategy_Design_Pattern.DuckCLass;


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