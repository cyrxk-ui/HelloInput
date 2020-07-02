using System;
using System.Activities;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloInput
{
    public class SquaredSum : CodeActivity
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
            var result = System.Math.Pow(firstNumber + secondNumber, 2);
            string message = "The squared sum is "+ result;
            string caption = "Result:";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            
            MessageBox.Show(message, caption, buttons);
            ResultNumber.Set(context, result);
        }

    }

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
            var result = firstNumber + secondNumber;
            string message = "The sum is " + result;
            string caption = "Result:";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);
            ResultNumber.Set(context, result);
        }

    }
}
