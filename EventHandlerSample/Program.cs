using System.Diagnostics;
using EventHandlerSample.Application;
using EventHandlerSample.Framework;

var aggregator = new EventAggregator();
var subscrip1 = aggregator.Subscribe(new FirstHandler());
var subscrip2 = aggregator.Subscribe(new SecondHandler());

var stopWatch = new Stopwatch();
stopWatch.Start();

while (true)
{
    aggregator.Publish(new GenerateKonYeIdRoo(Guid.NewGuid()));
    Thread.Sleep(1000);
    if (stopWatch.Elapsed.Seconds>5)
    {
        subscrip2.Unsubscrip();
        if (stopWatch.Elapsed.Seconds>10)
        {
            subscrip1.Unsubscrip();
        }
    }
}