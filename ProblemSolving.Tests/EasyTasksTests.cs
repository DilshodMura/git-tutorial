using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Core;

namespace ProblemSolving.Tests
{
    [TestClass]
    public class EasyTasksTests
    {
        [TestMethod]
        public void IsFibonacciHappyPath_13()
        {
            var input = 13;
            var easyTasks = new EasyTasks(); //creating an instance of EasyTasks
            bool isFibonacci = easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsTrue(isFibonacci);
        }

        [TestMethod]
        public void IsFibonacciFailPath_14()
        {
            var input = 14;
            var easyTasks = new EasyTasks(); //creating an instance of EasyTasks
            bool isFibonacci = easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsFalse(isFibonacci);
        }
    }
}
