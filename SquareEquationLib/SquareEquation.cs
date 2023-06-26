﻿namespace SquareEquationLib;
public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double eps = 1e-9;
        double[] no_roots = new double[] { };
        
        
        if (-eps < a && a < eps || new[] { a, b, c }.Any(double.IsNaN) || new[] { a, b, c }.Any(double.IsInfinity))
        {
            throw new ArgumentException();
        }

        double D = b * b - 4 * a * c;
        
        if (D <= -eps) 
        {
            return no_roots;
        }
        else
        {
            if (-eps < D && D < eps)
            { 
                double[] root = new double[1];
                root[0] = (-b) / 2 * a;
                return root;
            }
            else
            {
                double[] roots = new double[2];
                roots[0] = -(b + Math.Sign(b) * Math.Sqrt(D)) / 2;
                roots[1] = c / roots[0];
                return roots;
            }
        }
    }
}
