using System;

namespace _3_magnitude
{
    class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                return Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]);
            }
            else if (vector.Length == 3)
            {
                return Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
            }
            else
            {
                return -1;
            }
        }
    }
}
