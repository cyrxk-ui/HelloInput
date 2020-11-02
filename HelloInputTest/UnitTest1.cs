using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloInput;

namespace HelloInputTest
{
    [TestClass]
    public class UnitTest1
    {

    private double[] inputs = { Double.MinValue, -0.5, 0, 0.5, Double.MaxValue };

        [TestMethod]
        public void TestSimpleSum()
        {
            //Assert.AreEqual(1, 1);

            SimpleSumHelper simp;
            foreach (double i in inputs)
            {
                foreach (double j in inputs)
                {
                    try
                    {
                        simp = new SimpleSumHelper(i, j);
                        Assert.AreEqual(i + j, simp.Execute());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("i: " + i + ", j: " + j + ", Exception: " + e.Message);
                        throw e;
                    }
                }
            }

        }

        [TestMethod]
        public void TestSquaredSum()
        {
            SquaredSumHelper square;
             foreach (double i in inputs)
             {
                 foreach (double j in inputs)
                 {
                     try
                     {
                         square = new SquaredSumHelper(i, j);
                         Assert.AreEqual(System.Math.Pow(i + j, 2), square.Execute());
                     }
                     catch (Exception e)
                     {
                         Console.WriteLine("i: " + i + ", j: " + j + ", Exception: " + e.Message);
                         throw e;
                     }
                 }
             }
        }

    }

}
