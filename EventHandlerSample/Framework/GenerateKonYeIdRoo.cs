namespace EventHandlerSample.Framework;

public class GenerateKonYeIdRoo : IEvent
{
    public Guid Id { get; private set; }

    public GenerateKonYeIdRoo(Guid id)
    {
        Id = id;
    }
}