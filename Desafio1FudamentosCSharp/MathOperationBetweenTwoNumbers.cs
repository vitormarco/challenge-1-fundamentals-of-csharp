namespace Desafio1FundamentosCSharp;
static public class MathOperationBetweenTwoNumbers
{
    static public double Sum(double firstValue, double secondValue)
    {
        return firstValue + secondValue;
    }

    static public double Subtract(double firstValue, double secondValue)
    {
        return firstValue - secondValue;
    }

    static public double Multiply(double firstValue, double secondValue)
    {
        return firstValue * secondValue;
    }

    static public double Divide(double firstValue, double secondValue)
    {
        return firstValue / secondValue;
    }

    static public double Avarage(double firstValue, double secondValue)
    {
        return (Sum(firstValue: firstValue, secondValue: secondValue)) / 2;
    }

}
