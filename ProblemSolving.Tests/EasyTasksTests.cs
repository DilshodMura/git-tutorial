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
            List<int> inputNumbers = new List<int>() { 1,2,3,4,5};
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            List<string> expected = new List<string> () {"FooBuzzBar","Foo","Buzz","Foo","FooBuzzBar" };
            for (int i = 0; i < inputNumbers.Count-1; i++)
            {
                Assert.AreEqual(expected[i],resultFooBuzz[i]);
            }
        }

        [TestMethod]
        public void IsInputHappyPath_2()
        {
            List<int> inputNumbers = new List<int>() { 6, 7, 8, 9, 10 };
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            List<string> expected = new List<string>() {"FooBuzz","FooBuzzBar","Foo","Buzz","Foo" };
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                Assert.AreEqual(expected[i], resultFooBuzz[i]);
            }
        }

        [TestMethod]
        public void IsInputHappyPath_3()
        {
            List<int> inputNumbers = new List<int>() { 18, 999, 251, 1042, 11 };
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            List<string> expected = new List<string>() { "FooBuzz", "Buzz", "FooBuzzBar", "Foo", "FooBuzzBar" };
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                Assert.AreEqual(expected[i], resultFooBuzz[i]);
            }
        }

        [TestMethod]
        public void IsInputFailPath_1()
        {
            List<int> inputNumbers = new List<int>() { 300, 1000, 252, 1044, 12 };
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            List<string> expected = new List<string>() { "FooBuzzBar", "Buzz", "FooBuzzBar", "FooBuzzBar", "FooBuzzBar" };
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                Assert.AreNotEqual(expected[i], resultFooBuzz[i]);
            }
        }

        [TestMethod]
        public void IsInputFailPath_2()
        {
            List<int> inputNumbers = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            List<string> expected = new List<string>() { "Foo", "FooBuzzBar", "Foo", "FooBuzzBar", "FooBuzzBar" };
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                Assert.AreNotEqual(expected[i], resultFooBuzz[i]);
            }
        }

        [TestMethod]
        public void IsInputFailPath_3()
        {
            List<int> inputNumbers = new List<int>() { 10, 21, 32, 43, 54 };
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            List<string> expected = new List<string>() { "FooBuzzBar", "FooBuzzBar", "FooBuzzBar", "Foo", "FooBuzzBar" };
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                Assert.AreNotEqual(expected[i], resultFooBuzz[i]);
            }
        }

        [TestMethod]
        public void EmptyList()
        {
            List<int> inputNumbers = new List<int>();
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            Assert.IsNotNull(resultFooBuzz);
            Assert.IsTrue(resultFooBuzz.Count == 0);
            
        }

        [TestMethod]
        public void IsZero()
        {
            List<int> inputNumbers = new List<int>() { 0 };
            List<string> resultFooBuzz = _easyTasks.FooBuzz(inputNumbers);
            Assert.IsNotNull(resultFooBuzz);
            Assert.IsTrue(resultFooBuzz.Count > 0);
            
        }
        #endregion
    }
}
