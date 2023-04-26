using Cloudculator.Core.Interfaces;

namespace Cloudculator.Core
{
    public class CalculatorEngine : ICalculatorEngine
    {
        public double Add(double left, double right)
        {
            var result = left + right;
            if(double.IsInfinity(result))
            {
                throw new OverflowException();
            };

            return result;
        }

        public double Divide(double divergent, double divisor)
        {
            throw new NotImplementedException();
        }

        public double Multiply(double left, double right)
        {
            throw new NotImplementedException();
        }

        public double Subtract(double left, double right)
        {
            throw new NotImplementedException();
        }
    }
}
