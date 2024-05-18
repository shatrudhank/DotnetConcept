using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericTestClass genericTestClass = new GenericTestClass();
            genericTestClass.Name = "test";
            genericTestClass.Age = 10;
        }
    }
}
