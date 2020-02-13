using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorDemo.Structural
{
    class ConcreteMediator : Mediator
    {
        // original implementation
        // public Colleague1 Colleague1 { get; set; }
        // public Colleague2 Colleague2 { get; set; }

        private readonly List<Colleague> _colleagues = new List<Colleague>();

        // second implementation
        // public void Register(Colleague colleague)
        // {
        //     colleague.SetMediator(this);
        //     _colleagues.Add(colleague);
        // }
        
        public T CreateColleague<T>() where T : Colleague, new ()
        {
            // delegating instantiating of a colleague to this method
            var c = new T();
            // create connection between mediator and colleague
            c.SetMediator(this);
            _colleagues.Add(c);
            return c;
        }

        public override void Send(string message, Colleague colleague)
        {
            // original implementation
            // if (colleague == Colleague1)
            // {
            //     Colleague2.HandleNotification(message);
            // }
            // else
            // {
            //     Colleague1.HandleNotification(message);
            // }
            
            _colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}
