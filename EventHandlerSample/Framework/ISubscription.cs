namespace EventHandlerSample.Framework;

public interface ISubscription : IDisposable
{
    void Unsubscrip();
}