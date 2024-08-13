using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestPojectTourmalineCoreJunior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPojectTourmalineCoreJunior.Tests
{
    [TestClass()]
    public class ChangeCalculatorTests
    {
        [TestMethod()]
        public void TestExactChangeAvailable()
        {
            int[] nominal = { 100, 50, 10, 5, 2, 1 };
            int[] countNominal = { 1, 1, 2, 0, 5, 10 };
            int change = 72;

            string result = ChangeCalculator.GetChange(nominal, countNominal, change);

            Assert.AreEqual("Для сдачи используйте следующие монеты: 50р x 1 10р x 2 2р x 1", result);
        }
    }
}