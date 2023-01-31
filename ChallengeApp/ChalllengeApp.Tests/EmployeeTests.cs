using System;
using ChallengeApp;

namespace ChalllengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenAddedPoints_ShouldResult()
        {
            //arange
            var employee = new Employee("Adam");
            employee.AddPoints(5);
            employee.AddPoints(9);
            employee.AddPoints(10);
            employee.AddPoints(-24);
            //act
            int result = employee.Points;

            //assert
            Assert.AreEqual(0, employee.Points);
     
        }
    }
}