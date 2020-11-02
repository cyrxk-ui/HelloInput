namespace HelloInput
{
    public class SquaredSumHelper
    {
        protected double firstNumber, secondNumber;
        public SquaredSumHelper(double x, double y)
        {
            firstNumber = x; secondNumber = y;
        }
        public double Execute()
        {
            return System.Math.Pow(firstNumber + secondNumber, 2);
        }
    }
}
