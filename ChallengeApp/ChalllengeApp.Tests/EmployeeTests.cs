using ChallengeApp;

namespace ChalllengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void ResoultStatistics_ShouldReturnMinMaxAverage()
        {
            //arange
            var employee = new Employee("Adam", "Kuliczkowski");
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(6);
            //act
            var statistics = employee.GetStatisticsWithForEach();
            //assert
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(6, statistics.Max);
            Assert.AreEqual(4, statistics.Average);
            Assert.AreNotEqual(statistics.Min, statistics.Max);
        }
    }
}