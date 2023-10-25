namespace EventHandlerSample.Framework;

public class EventAggregator : IEventListner,IEventPublisher
{
    private List<Object> _handlers = new List<object>();
    public ISubscription Subscribe<T>(IEventHandler<T> handler) where T : IEvent
    {
        _handlers.Add(handler);
        return new DelegatingSubscription(()=> _handlers.Remove(handler));
    }

    public void Publish<T>(T eventToPublish) where T : IEvent
    {
        var candidts = _handlers.OfType<IEventHandler<T>>().ToList();
        candidts.ForEach(x=>x.Handle(eventToPublish));
    }
}