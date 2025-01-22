using System;

public class CalcMethods
{
    public double Addition(double x, double y)
    {
        return x + y;
    }

    public double Subtraction(double x, double y)
    {
        return x - y;
    }

    public double Multiplication(double x, double y)
    {
        return x * y;
    }
    public double Division(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        else
        {
            return x / y;
        }
    }
}