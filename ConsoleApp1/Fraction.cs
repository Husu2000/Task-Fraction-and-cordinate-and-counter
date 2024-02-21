namespace ConsoleApp1;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set
        {
            if (value != 0)
                _denominator = value;
            else
                throw new ArgumentException("Denominator 0 ola bilmez.");
        }
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        Denominator = denominator;
    }

    public double ToDecimal()
    {
        return (double)_numerator / _denominator;
    }

    
    public static Fraction Add(Fraction fraction1, Fraction fraction2)
    {
        int numerator = fraction1._numerator * fraction2._denominator + fraction2._numerator * fraction1._denominator;
        int denominator = fraction1._denominator * fraction2._denominator;
        return new Fraction(numerator, denominator);
    }

    public void Simplify()
    {
        int gcd = FindGCD(_numerator, _denominator);
        _numerator /= gcd;
        _denominator /= gcd;
    }

    private int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public Fraction Multiply(Fraction other)
    {
        int newNumerator = _numerator * other._numerator;
        int newDenominator = _denominator * other._denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Subtract(Fraction other)
    {
        int newNumerator = _numerator * other._denominator - other._numerator * _denominator;
        int newDenominator = _denominator * other._denominator;
        return new Fraction(newNumerator, newDenominator);
    }

public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
}
