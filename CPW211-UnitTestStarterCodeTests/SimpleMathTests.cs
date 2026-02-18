using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests;

[TestClass()]
public class SimpleMathTests
{
    [TestMethod()]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
    {
        Assert.AreEqual(num1 + num2, SimpleMath.Add(num1, num2));
    }

    [TestMethod()]
    [DataRow(10, 5)]
    [DataRow(100, 200)]
    [DataRow(0, 0)]

    public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
    {
        Assert.AreEqual(num1 - num2, SimpleMath.Subtract(num1, num2));
    }

    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(0, 0)]
    public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
    {
        Assert.AreEqual(num1 * num2, SimpleMath.Multiply(num1, num2));
    }

    [TestMethod]
    [DataRow(10, 5)]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
    {
        Assert.AreEqual(num1 / num2, SimpleMath.Divide(num1, num2));
    }

    [TestMethod]
    public void Divide_DenominatorZero_ThrowsArgumentException()
    {
        Assert.ThrowsExactly<ArgumentException>(() => SimpleMath.Divide(10, 0), "Denominator cannot be zero");
    }

    // TODO: Add a new test to test the Divide method with two valid numbers

    // TODO: Add a new test to test the subtract method with two valid numbers
}