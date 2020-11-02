namespace HelloInput
{
    public class SimpleSumHelper
    {
        protected double firstNumber, secondNumber;
        public SimpleSumHelper(double x, double y)
        {
            firstNumber = x; secondNumber = y;
        }
        public double Execute()
        {
            return firstNumber + secondNumber;
        }
    }
}
