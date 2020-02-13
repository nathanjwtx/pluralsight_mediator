using System;
using MediatorDemo.Structural;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            
            // original implementation
            // var c1 = new Colleague1(mediator);
            // var c2 = new Colleague2(mediator);
            //
            // mediator.Colleague1 = c1;
            // mediator.Colleague2 = c2;
            
            // second implementation
            // var c1 = new Colleague1();
            // var c2 = new Colleague2();
            //
            // mediator.Register(c1);
            // mediator.Register(c2);

            var c1 = mediator.CreateColleague<Colleague1>();
            var c2 = mediator.CreateColleague<Colleague2>();
            
            c1.Send("Hello, world! Sent by c1");
            c2.Send("Hello, world! Sent by c2");
        }
    }
}
