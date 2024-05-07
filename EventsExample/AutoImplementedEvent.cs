using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    internal class AutoImplementedEvent
    {
        public event UpdateCalculation Event;

        public void Notify(int x, int y)
        {
            this.Event(x, y);
        }
    }
}
