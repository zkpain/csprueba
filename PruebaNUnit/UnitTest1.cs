using System;
using NUnit.Framework;

namespace PruebaNUnit
{
   
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("------------------------TestMethod1--------------------");            
            Assert.IsTrue(true);
        }
    }
}
