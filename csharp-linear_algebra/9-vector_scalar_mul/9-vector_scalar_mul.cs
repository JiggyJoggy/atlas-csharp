using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double sumOne = vector[0] * scalar;
            double sumTwo = vector[1] * scalar;

            double[] sum = {sumOne, sumTwo};

            return sum;
        }
        else if (vector.Length == 3)
        {
            double sumOne = vector[0] * scalar;
            double sumTwo = vector[1] * scalar;
            double sumThree = vector[2] * scalar;

            double[] sum = {sumOne, sumTwo, sumThree};

            return sum;
        }
        else
        {
            double[] emptyVector = {-1};
            return emptyVector;
        }
    }
}