// Kaelan Oxby
// 15/6/2019
// V1.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebraic
{
    public class Algebra
    {
        // Square Root Method using Built in Math Libraries.
        public static double SquareRoot(double x)
        {
            return (Math.Sqrt(x));
        }

        // Cube Root Method using Built in Math Libraries
        public static double CubeRoot(double x)
        {
            return (Math.Pow(x, (1.0 / 3.0)));
        }
        
        // Simple Invert Method (10/1 = 0.1)
        public static double Invert(double x)
        {
            double a = 1;
            x = a / x;
            return x;
        }
    }
}
