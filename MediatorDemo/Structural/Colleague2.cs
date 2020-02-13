using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo.Structural
{
    class Colleague2 : Colleague
    {
        // original implementation
        // public Colleague2(Mediator mediator) : base(mediator)
        // {

        // }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 receives notification message: {message}");
        }
    }
}
