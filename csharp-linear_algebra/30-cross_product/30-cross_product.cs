using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            double[] badVector = {-1};
            return badVector;
        }

        double[] sumOfVectors = new double[3];

        sumOfVectors[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        sumOfVectors[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        sumOfVectors[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return sumOfVectors;
    }
}