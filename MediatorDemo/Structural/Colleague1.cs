using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo.Structural
{
    class Colleague1 : Colleague
    {
        // original implementation
        // public Colleague1(Mediator mediator) : base(mediator)
        // {
        // }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 receives notification message: {message}");
        }
    }
}
