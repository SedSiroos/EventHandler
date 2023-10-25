namespace EventHandlerSample.Framework;

public interface IEventListner
{
    ISubscription Subscribe<T>(IEventHandler<T> handler) where T : IEvent;
}