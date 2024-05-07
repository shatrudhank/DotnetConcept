using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public delegate void UpdateCalculation(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {

            //Events with Add remove
            SimplePublisher publisher = new SimplePublisher();
            SimpleSubscriber subscriber = new SimpleSubscriber();

            publisher.Event += subscriber.Add;
            publisher.Event += subscriber.Sub;

            publisher.Notify(3, 4);


            //Auto Implemented Event
            AutoImplementedEvent autoImplementedEvent = new AutoImplementedEvent();
            autoImplementedEvent.Event += subscriber.Add;
            autoImplementedEvent.Event += subscriber.Sub;

            autoImplementedEvent.Notify(5, 6);

        }
    }
}
