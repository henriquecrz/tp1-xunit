using tp1_xunit;

Console.WriteLine("Add:");
Console.WriteLine("5 + 6 = " + Calculator.Add(5, 6));
Console.WriteLine("15.1 + 16.2 = " + Calculator.Add(15.1, 16.2));

Console.WriteLine(Environment.NewLine + "Sub:");
Console.WriteLine("11 - 5 = " + Calculator.Sub(11, 5));
Console.WriteLine("5 - 8 = " + Calculator.Sub(5, 8));
Console.WriteLine("20.1 - 7 = " + Calculator.Sub(20.1, 7));

Console.WriteLine(Environment.NewLine + "Mul:");
Console.WriteLine("3 * 4 = " + Calculator.Mul(3, 4));
Console.WriteLine("3.3 * 2 = " + Calculator.Mul(3.3, 2));

Console.WriteLine(Environment.NewLine + "Div:");
Console.WriteLine("21 / 3 = " + Calculator.Div(21, 3));
Console.WriteLine("5 / 2 = " + Calculator.Div(5, 2));

try
{
    Calculator.Div(5, 0);
}
catch (Exception ex)
{
    Console.WriteLine("5 / 0 = " + ex.Message);
}
