using EventHandlerSample.Framework;

namespace EventHandlerSample.Application;

public class FirstHandler : IEventHandler<GenerateKonYeIdRoo>
{
    public void Handle(GenerateKonYeIdRoo @event)
    {
        Console.WriteLine(value: @event.Id);
    }
}