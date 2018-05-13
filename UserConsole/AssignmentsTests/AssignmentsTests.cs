using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignments;
using NUnit.Framework;

namespace AssignmentsTests
{
    [TestFixture]
    public class AssignmentsTests
    {
        [Test]
        public void AddNumbersShouldAddTwoNumbers()
        {
            var userTasks = new UserTasks();
            const int firstNumber = 2;
            const int secondNumber = 4;
            var addNumbersResult = userTasks.AddNumbers(firstNumber,secondNumber);
            Assert.AreEqual(addNumbersResult,6);
        }

        [Test]
        public void MultiplyNumbersShouldMultiplyNumbers()
        {
            var userTask = new UserTasks();
            int firstNumber = 2;
            int secondNumber = 4;
            var multiplyNumbersResult = userTask.MultiplyNumbers(firstNumber,secondNumber);
            Assert.AreEqual(multiplyNumbersResult,8);
        }

    }
}
