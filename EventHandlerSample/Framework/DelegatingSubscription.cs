namespace EventHandlerSample.Framework;

public class DelegatingSubscription : ISubscription
{
    private readonly Action _unSubscripAction;
    public DelegatingSubscription(Action unSubscripAction)
    {
        _unSubscripAction = unSubscripAction;
    }

    public void Unsubscrip()
    {             
        _unSubscripAction.Invoke();
    }
    
    public void Dispose()
    {
        this.Unsubscrip();
    }
}