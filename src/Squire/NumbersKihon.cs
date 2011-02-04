using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squire.Framework;

namespace Squire
{
    [TestClass]
    public class NumbersKihon : NumbersKihonStructure
    {
        protected override int Return_The_Maximum_Value_Of_Int32()
        {
            return Int32.MaxValue;
        }

        protected override int Return_The_Minimum_Value_Of_Int32()
        {
            return Int32.MinValue;
        }

        protected override int Return_The_Remainder_Of_a_Divided_By_b(int a, int b)
        {
            return a % b;
        }

        protected override double Return_The_Maximum_Value_Of_Double()
        {
            return double.MaxValue;
        }

        protected override double Return_The_Minimum_Value_Of_Double()
        {
            return double.MinValue;
        }

        protected override bool Return_True_If_a_Is_Not_A_Number(double a)
        {
            return Double.IsNaN(a);
        }

        protected override bool Return_True_If_a_Is_An_Infinity(double a)
        {
            bool IsValid = (Double.IsPositiveInfinity(a) || Double.IsNegativeInfinity(a));
            return IsValid;
        }
    }
}
