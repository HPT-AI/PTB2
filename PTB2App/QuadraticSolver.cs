using System;

namespace PTB2App_New
{
    public class QuadraticSolver
    {
        public static string Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                return "This is not a quadratic equation (a = 0).";
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return "No real roots (Δ < 0).";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"One real root (double root): x = {x:F4}";
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b + sqrtDelta) / (2 * a);
                double x2 = (-b - sqrtDelta) / (2 * a);
                return $"Two distinct real roots: x₁ = {x1:F4}, x₂ = {x2:F4}";
            }
        }

        public static bool TryParseDouble(string input, out double value)
        {
            return double.TryParse(input, out value);
        }
    }
}
