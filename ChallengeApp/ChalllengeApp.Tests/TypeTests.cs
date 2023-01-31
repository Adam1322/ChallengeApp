using ChallengeApp;

namespace ChalllengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoCharNumber()
        {
            //arange
            char letter1= 'c';
            char letter2 = 'c';

            //act
            
            //assert
            Assert.AreEqual(letter1, letter2);
        }

        [Test]
        public void TwoStringName()
        {
            //arange
            string name1 = "Kazik";
            string name2 = "Kazik";

            //act
            
            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void TwoFloatNumber()
        {
            //arange
            float number1 = 53.3f;
            float number2 = 53.3f;
 
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TwoIntNumbers()
        {
            //arange
            int number1 = 5;
            int number2 = 8;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TwoVarName()
        {
            //arange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Robert");
            //act
            
            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
