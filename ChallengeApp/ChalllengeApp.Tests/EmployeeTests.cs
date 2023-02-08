using ChallengeApp;

namespace ChalllengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckResultOfAddGrade()
        {
            //arange
            var employee = new Employee("Adam", "Kuliczkowski", "23");
            employee.AddGrade(80);
            employee.AddGrade(80);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(80, statistics.Average);
            Assert.AreEqual('A', statistics.AverageLetter);
        }
    }
}