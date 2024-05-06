using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{

    public delegate int Performtask(int x, int y);
    public delegate int SpecialRisk(int riskcategory);

    internal class Program
    {
        static void Main(string[] args)
        {

            //Example simple example
            Math math = new Math();
            Performtask Performtask = math.sum;
            Console.WriteLine(Performtask.Invoke(4,3)); //7

            Performtask = math.sub;
            Console.WriteLine(Performtask.Invoke(4, 3)); //1

            //Example multicast delegate , return  value of last executed method
            Performtask Performtask1 = math.sum;
            Performtask1 += math.sub;
            Console.WriteLine(Performtask1.Invoke(4, 3));



            //Example Passing method as parameter
            RiskCalculator riskCalculator = new RiskCalculator();
            riskCalculator.CalculateRiskScore(1, GetSpecialRiskScore);
        }

        static int GetSpecialRiskScore(int personType)
        {
            if (personType == 1)
            {
                return 11;
            }
            return 10;
        }
    }

    class Math
    {
        public int sum(int x, int y) 
        {
            Console.WriteLine("Sum");
            return x+ y;
        }
        public int sub(int x,int y)
        {
            Console.WriteLine("Subtract");
            return x - y;
        }
    }

    class RiskCalculator
    {

        public int CalculateRiskScore(int personType, SpecialRisk specialRisk) 
        {
            int risk = 0;
            if(personType == 0)
            {
                risk = 100;
            }
            else if(personType == 1) 
            {
                risk = 200;
            }
            risk += specialRisk(personType);
            return risk;

        }

    }

}
