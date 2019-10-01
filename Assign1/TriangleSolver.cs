using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public static class TriangleSolver
    {
        public static string TriangleAnalyze(int side1, int side2, int side3)
        {
            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
            {
                return "Invalid";
            }
            else if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isoceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
