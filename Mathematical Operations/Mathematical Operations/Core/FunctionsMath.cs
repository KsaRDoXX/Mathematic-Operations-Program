using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operations.Core
{
    public static class FunctionsMath
    {
        public static float CalcDelta(float a,float b,float c)
        {
            return (b * b) - (4 * a * c);
        }

        public static float CalcX1(float a, float b, float c, float delta)
        {
            if (a != 0)
                return (-b - (float)Math.Sqrt(delta)) / 2 * a;
            else
                return -b / c;
        }


        public static float CalcX2(float a, float b, float c, float delta)
        {
            if (a != 0)
                return (-b + (float)Math.Sqrt(delta)) / 2 * a;
            else
                return -b / c;
        }

        public static float CalcP(float b, float a)
        {
            if (a != 0)
            {
                return -b / 2 * a;
            }
            else
                return float.NaN;
        }

        public static float CalcQ(float delta, float a)
        {
            if (a != 0)
            {
                return -delta / 4 * a;
            }
            else return float.NaN;
        }
    }
}
