using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    internal class SimpleSubscriber
    {
        public void Add(int x, int y) => Console.WriteLine(x + y);
        public void Sub(int x, int y) => Console.WriteLine(x - y);
    }
}
