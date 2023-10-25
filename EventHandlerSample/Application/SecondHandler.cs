using EventHandlerSample.Framework;

namespace EventHandlerSample.Application;

public class SecondHandler : IEventHandler<GenerateKonYeIdRoo>
{
    public void Handle(GenerateKonYeIdRoo @event)
    {
        Console.WriteLine($"----------------{@event.Id}");
    }
}