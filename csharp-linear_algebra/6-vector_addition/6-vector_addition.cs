using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double sumOne = vector1[0] + vector2[0];
            double sumTwo = vector1[1] + vector2[1];

            double[] sum = {sumOne, sumTwo};

            return sum;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double sumOne = vector1[0] + vector2[0];
            double sumTwo = vector1[1] + vector2[1];
            double sumThree = vector1[2] + vector2[2];

            double[] sum = {sumOne, sumTwo, sumThree};

            return sum;
        }
        else
        {
            double[] vector = {-1};
            return vector;
        }
    }
}