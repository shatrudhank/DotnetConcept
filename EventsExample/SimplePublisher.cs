using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    internal class SimplePublisher
    {
       

        private UpdateCalculation updateCalculation;

        public  event UpdateCalculation Event
        {
            add
            {
                this.updateCalculation += value;
            }
            remove
            {
                this.updateCalculation -= value;
            }
        }

        public void Notify(int x,int y)
        {
            this.updateCalculation(x, y);
        }
    }
}
