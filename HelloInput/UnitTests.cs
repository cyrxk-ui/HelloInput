using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloInput
{
    class UnitTests
    {
        double[] inputs = {Double.MinValue,-0.5,0,0.5,Double.MaxValue};

        public void run_tests()
        {
            OutArgument<double> result;
            SimpleSum simp;
            //test simple sum
            foreach (double i in inputs)
            {
                foreach (double j in inputs)
                {
                    try
                    {
                        simp = new SimpleSum
                        {
                            FirstNumber = i,
                            SecondNumber = j
                        };
                        Console.WriteLine(WorkflowInvoker.Invoke(simp));
                    } catch (Exception e)
                    {
                        Console.WriteLine("i: " + i + ", j: " + j + ", Exception: " + e.Message);
                    }
                }
            }

            //test squared sum
          /*  foreach (int i in inputs)
            {
                foreach (int j in inputs)
                {

                }
            } */

        }

        public void main()
        {
            run_tests();
        }
    }
}
