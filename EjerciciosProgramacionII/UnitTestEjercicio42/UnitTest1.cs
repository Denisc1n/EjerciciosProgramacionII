using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio42;

namespace UnitTestEjercicio42
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MetodoExceptionTest()
        {
            //arrange
            int numTest1 = 1;
            int numTest2 = 0;

            ClaseException.MetodoException(numTest1, numTest2);
            Assert.That.Equals( new object() );
        }

        
    }
}
