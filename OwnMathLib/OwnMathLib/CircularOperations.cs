using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///

namespace OwnMathLib
{
    public class CircularOperations
    {
        public double x { get; set; }
        double y;
        public readonly double PI = Math.PI;
        public readonly double E = Math.E;


        public double SinY()
        {
            y = (x * PI) / 180;     /// rechnet x in ´rad um 
            return Math.Sin(y);

        }

        public double CosY()
        {
            y = (x * PI) / 180;     /// rechnet x in ´rad um 
            return Math.Cos(y);

        }
        public double TanY()
        {
            y = (x * PI) / 180;     /// rechnet x in ´rad um 
            return Math.Tan(y);

        }

        
    }
}
