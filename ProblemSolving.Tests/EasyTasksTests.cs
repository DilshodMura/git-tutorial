using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Core;
using System;
using System.Collections.Generic;

namespace ProblemSolving.Tests
{
    [TestClass]
    public class EasyTasksTests
    {
        //class level
        private EasyTasks _easyTasks;
        
        // Initializes on call of every test method
        [TestInitialize]
        public void Initialize()
        {
            _easyTasks = new EasyTasks();
            //method level
        }
        #region "Fibonacci"
        [TestMethod]
        public void IsFibonacciHappyPath_13()
        {
            int input = 13; 
            var isFibonacci = _easyTasks.IsFibonacci(input);
            Assert.IsTrue(isFibonacci);
        }

        [TestMethod]
        public void IsFibonacciHappyPath_55()
        {
            var input = 55;
            bool isFibonacci = _easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsTrue(isFibonacci);
        }

        [TestMethod]
        public void IsFibonacciHappyPath_21()
        {
            var input = 21;
            bool isFibonacci = _easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsTrue(isFibonacci);
        }

        [TestMethod]
        public void IsFibonacciFailPath_14()
        {
            var input = 14;
            bool isFibonacci = _easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsFalse(isFibonacci);
        }

        [TestMethod]
        public void IsFibonacciFailPath_12()
        {
            var input = 12;
            bool isFibonacci = _easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsFalse(isFibonacci);
        }

        [TestMethod]
        public void IsFibonacciFailPath_10()
        {
            var input = 10;
            bool isFibonacci = _easyTasks.IsFibonacci(input); //calling method using instance of EasyTasks
            Assert.IsFalse(isFibonacci);
        }
        #endregion

        #region "InputSum"
        [TestMethod]
        public void IsSuminputHappyPath()
        {
            var presetValueOne = 15;
            var presetValueTwo = 5;
            int isSuminputHappyPath = _easyTasks.SumOfTwo(presetValueOne, presetValueTwo);
            Assert.AreEqual(20, isSuminputHappyPath);
        }

        [TestMethod]
        public void IsSuminputHappyPath_2()
        {
            var presetValueOne = 16;
            var presetValueTwo = 30;
            int isSuminputHappyPath = _easyTasks.SumOfTwo(presetValueOne, presetValueTwo);
            Assert.AreEqual(46, isSuminputHappyPath);
        }

        [TestMethod]
        public void IsSuminputHappyPath_3()
        {
            var presetValueOne = 195;
            var presetValueTwo = 200;
            var easyTasks = new EasyTasks();
            int isSuminputHappyPath = _easyTasks.SumOfTwo(presetValueOne, presetValueTwo);
            Assert.AreEqual(395, isSuminputHappyPath);
        }

        [TestMethod]
        public void IsSumInputFailPath_1()
        {
            var presetValueOne = 10;
            var presentValueTwo = 5;
            int failPath = _easyTasks.SumOfTwo(presetValueOne, presentValueTwo);
            Assert.AreNotEqual(25, failPath);
        }

        [TestMethod]
        public void IsSumInputFailPath_2()
        {
            var presetValueOne = 15;
            var presentValueTwo = 5;
            int failPath = _easyTasks.SumOfTwo(presetValueOne, presentValueTwo);
            Assert.AreNotEqual(25, failPath);
        }

        [TestMethod]
        public void IsSumInputFailPath_3()
        {
            var presetValueOne = 13;
            var presentValueTwo = 6;
            int failPath = _easyTasks.SumOfTwo(presetValueOne, presentValueTwo);
            Assert.AreNotEqual(25, failPath);
        }
        #endregion

        #region"FooBuzz"
        [TestMethod]
        public void IsInputHappyPath()
        {
            List<int> inputNumbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            List<string> output = _easyTasks.FooBuzz(inputNumbers);
                       
        }

        #endregion
    }
}
