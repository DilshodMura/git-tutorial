using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Core;
using System;

namespace ProblemSolving.Tests
{
    [TestClass]
    public class EasyTasksTests
    {
        EasyTasks easyTasks = new EasyTasks();
        int input; 
        public void Initialize()
        {
            easyTasks.IsFibonacci(input);
            bool isFibonacci = Convert.ToBoolean(input);
            Assert.IsTrue(isFibonacci);
        }
        [TestMethod]
        public void IsFibonacciHappyPath_13()
        {
            input = 13; 
            Initialize();
        }
        [TestMethod]
        public void IsFibonacciHappyPath_55()
        {
            var input = 55;
            var easyTasks = new EasyTasks(); //creating an instance of EasyTasks
            bool isFibonacci = easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsTrue(isFibonacci);
        }
        [TestMethod]
        public void IsFibonacciHappyPath_21()
        {
            var input = 21;
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
        [TestMethod]
        public void IsFibonacciFailPath_12()
        {
            var input = 12;
            var easyTasks = new EasyTasks(); //creating an instance of EasyTasks
            bool isFibonacci = easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsFalse(isFibonacci);
        }
        [TestMethod]
        public void IsFibonacciFailPath_10()
        {
            var input = 10;
            var easyTasks = new EasyTasks(); //creating an instance of EasyTasks
            bool isFibonacci = easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsFalse(isFibonacci);
        }
        [TestMethod]
        public void IsSuminputHappyPath()
        {
            var presetValueOne = 15;
            var presetValueTwo = 5;
            var easyTasks = new EasyTasks();
            int isSuminputHappyPath = easyTasks.SumOfTwo(presetValueOne, presetValueTwo);
            Assert.AreEqual(20, isSuminputHappyPath);
        }
        [TestMethod]
        public void IsSuminputHappyPath_2()
        {
            var presetValueOne = 16;
            var presetValueTwo = 30;
            var easyTasks = new EasyTasks();
            int isSuminputHappyPath = easyTasks.SumOfTwo(presetValueOne, presetValueTwo);
            Assert.AreEqual(46, isSuminputHappyPath);
        }
        [TestMethod]
        public void IsSuminputHappyPath_3()
        {
            var presetValueOne = 195;
            var presetValueTwo = 200;
            var easyTasks = new EasyTasks();
            int isSuminputHappyPath = easyTasks.SumOfTwo(presetValueOne, presetValueTwo);
            Assert.AreEqual(395, isSuminputHappyPath);
        }
        [TestMethod]
        public void IsSumInputFailPath_1()
        {
            var presetValueOne = 10;
            var presentValueTwo = 5;
            var easyTasks = new EasyTasks();
            int failPath = easyTasks.SumOfTwo(presetValueOne, presentValueTwo);
            Assert.AreNotEqual(25, failPath);
        }
        [TestMethod]
        public void IsSumInputFailPath_2()
        {
            var presetValueOne = 15;
            var presentValueTwo = 5;
            var easyTasks = new EasyTasks();
            int failPath = easyTasks.SumOfTwo(presetValueOne, presentValueTwo);
            Assert.AreNotEqual(25, failPath);
        }
        [TestMethod]
        public void IsSumInputFailPath_3()
        {
            var presetValueOne = 13;
            var presentValueTwo = 6;
            var easyTasks = new EasyTasks();
            int failPath = easyTasks.SumOfTwo(presetValueOne, presentValueTwo);
            Assert.AreNotEqual(25, failPath);
        }
    }
}
