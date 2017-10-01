using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            //arrange
            var customer = new Customer();

            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            // act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            //arrange
            var customer = new Customer();

            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            // act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            //arrange
            var customer = new Customer();

            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 100M;

            // act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //assert 
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsIsNull()
        {
            //arrange
            var customer = new Customer();

            string goalSteps = null;
            string actualSteps = "2000";

            // act
            customer.CalculatePercentOfGoalSteps(null, actualSteps);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsNotNumeric()
        {
            //arrange
            var customer = new Customer();

            string goalSteps = "one";
            string actualSteps = "2000";

            // act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Goal must be numeric", e.Message);
                throw;
            }

        }

    }
}
