namespace Cloudculator.Core.Interfaces
{
    public interface ICalculatorEngine
    {
        double Add(double left, double right);
        double Subtract(double left, double right);
        double Multiply(double left, double right);
        double Divide(double divergent, double divisor);
    }
}
