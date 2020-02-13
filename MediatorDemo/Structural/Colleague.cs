namespace MediatorDemo.Structural
{
    internal abstract class Colleague
    {
        private Mediator _mediator;

        // original implementation
        // protected Colleague(Mediator mediator)
        // {
        //     _mediator = mediator;
        // }
        
        internal void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }


        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}