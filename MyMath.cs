using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sMaxemProjekt
{
    internal class MyMath
    {
        public float Add(float a, float b)
        {
            return a + b;
        }
        public float Subtract(float a, float b)
        {
            return a - b;
        }
        public float Multiply(float a, float b)
        {
            return a * b;
        }
        public float Divide(float a, float b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}
