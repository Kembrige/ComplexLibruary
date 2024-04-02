using System;

public class RationalNumber
{
    public int Numerator { get; }
    public int Denominator { get; }

    public RationalNumber(int numerator, int denominator)
    {
        int gcd = GCD(numerator, denominator);
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;
    }

    private int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

    public static RationalNumber Add(RationalNumber r1, RationalNumber r2)
    {
        int numerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
        int denominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber Multiply(RationalNumber r1, RationalNumber r2)
    {
        int numerator = r1.Numerator * r2.Numerator;
        int denominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber Divide(RationalNumber r1, RationalNumber r2)
    {
        int numerator = r1.Numerator * r2.Denominator;
        int denominator = r1.Denominator * r2.Numerator;
        return new RationalNumber(numerator, denominator);
    }
}

public class ComplexNumber
{
    public int Real { get; }
    public int Imaginary { get; }

    public ComplexNumber(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber MultiplyByRational(ComplexNumber c, RationalNumber r)
    {
        int real = c.Real * r.Numerator;
        int imaginary = c.Imaginary * r.Numerator;
        return new ComplexNumber(real, imaginary);
    }
}
