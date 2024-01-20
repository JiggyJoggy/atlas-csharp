using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length && vector2.Length == 2)
        {
            double sumOne = vector1[1] + vector2[1];
            double sumTwo = vector1[2] + vector2[2];

            double[] sum = [sumOne, sumTwo];

            return Math.Round(sum, 2);
        }
        else if (vector1.Length && vector2.Length == 3)
        {
            double sumOne = vector1[1] + vector2[1];
            double sumTwo = vector1[2] + vector2[2];
            double sumThree = vector1[3] + vector2[3];

            double[] sum = [sumOne, sumTwo, sumThree];

            return Math.Round(sum, 2);
        }
        else
        {
            return -1;
        }
    }
}