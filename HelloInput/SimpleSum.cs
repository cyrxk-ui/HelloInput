using System.Activities;
using System.ComponentModel;

namespace HelloInput
{
    public class SimpleSum : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<double> FirstNumber { get; set; }

        [Category("Input")]
        public InArgument<double> SecondNumber { get; set; }

        [Category("Output")]
        public OutArgument<double> ResultNumber { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstNumber = FirstNumber.Get(context);
            var secondNumber = SecondNumber.Get(context);
            var helper = new SimpleSumHelper(firstNumber, secondNumber);
            var result = helper.Execute();
            ResultNumber.Set(context, result);
        }


    }
}
