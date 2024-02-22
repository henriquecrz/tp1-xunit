namespace tp1_xunit;

public static class Calculator
{
    public static double Add(double x, double y) => Math.Round(x + y, 2);

    public static double Sub(double x, double y) => Math.Round(x - y, 2);

    public static double Mul(double x, double y) => Math.Round(x * y, 2);

    public static double Div(double x, double y) => y != 0 ?
        Math.Round(x / y, 2) :
        throw new DivideByZeroException();
}
