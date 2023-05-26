using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnMathLib
{
    public class ScientificOperations
    {
        public double x {  get; set; }
        public double y { get; set; }

        public double EPowX()
        {
            return Math.Exp(x);
        }
        public double Square()
        {
            return Math.Pow(x, 2);
        }
        public double xPOWy()
        {
            return Math.Pow(x, y);
        }
        public double SquareRoot()
        {
            return Math.Sqrt(x);
        }
        public double xRooty()
        {
            return Math.Pow(x, 1/y);
        }
        public double NFaculty()
        {
            y = 1;
            for(int i = 2; i < x; i++)
            {
                y *= 1;
            }
            return y;
        }
        public double TenBasex()
        {
            return Math.Pow(10, x);
        }

        public double Log()
        {
            
            return Math.Log(x);
        }

        public double LogBaseY()
        {
            return Math.Log(x, y);
        }


        public double LNx()
        {
            return Math.Log10(x);
        }
    }   
}
