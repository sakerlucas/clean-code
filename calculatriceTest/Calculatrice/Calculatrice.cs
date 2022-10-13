namespace calculatriceTest;

public class Calculatrice
{
    public Calculatrice()
    {
    }

    internal object Add(int a, int b)
    {
        if (a < 0 || b < 0)
            throw new Exception("Il est impossible que les params soient négatifs");
        else
            return a + b;
    }

    internal int Div(int a, int b)
    {
        if (a == 0 || b == 0)
            throw new DivideByZeroException("Il est impossible de diviser par 0");
        else if (a < 0 || b < 0)
            throw new Exception("Il est impossible que les params soient négatifs");
        else
            return a / b;
    }

    internal int Mul(int a, int b)
    {
        if (a < 0 || b < 0)
            throw new Exception("Il est impossible que les params soient négatifs");
        else
            return a * b;
    }

    internal int Sub(int a, int b)
    {
        if (a < 0 || b < 0)
            throw new Exception("Il est impossible que les params soient négatifs");
        else
            return a - b;
    }
}

