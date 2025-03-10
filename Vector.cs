using System.Numerics;
using System.Runtime.Intrinsics;

public static class VectorCalculator
{
    public static double VectorModule(Vector2 v1)
    {
        float module = ((v1.X * v1.X) + (v1.Y * v1.Y));
        return Math.Sqrt(module);
    }

    public static bool IsR2Ortogonal(Vector2 v1, Vector2 v2)
    {
        double result = (v1.X * v2.X) + (v1.Y * v2.Y);

        if (result == 0)
        {
            return true;
        }
        return false;
    }
}