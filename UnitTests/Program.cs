using System;
using HelloInput;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = { Double.MinValue, -0.5, 0, 0.5, Double.MaxValue };
            HelloInput.SimpleSum simp;
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
                        System.Activities.WorkflowInvoker.Invoke(simp);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("i: " + i + ", j: " + j + ", Exception: " + e.Message);
                    }
                }
            }

            HelloInput.SquaredSum square;
            //test squared sum
            foreach (double i in inputs)
            {
                foreach (double j in inputs)
                {
                    try
                    {
                        square = new SquaredSum
                        {
                            FirstNumber = i,
                            SecondNumber = j
                        };
                        System.Activities.WorkflowInvoker.Invoke(square);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("i: " + i + ", j: " + j + ", Exception: " + e.Message);
                    }
                }
            }

            Console.WriteLine("All tests completed. Press enter to exit.");
            Console.ReadLine();
        }
    }
}
