using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator;
namespace UnitTestProject1
{
    [TestClass]// dinh nghia de test nhieu chuc nang
    public class UnitTest1
    {
        private Caculation c;
        public TestContext TestContext { get; set; }
        [TestInitialize]// Thiet lap du lieu dung chung cho test case
        public void Setup()// chay lan dau tien truoc cac test case
        {
            c = new Caculation(10, 5);
        }

        [TestMethod]//1 test case 1
        public void TestAddOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 15;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);

        }
        //test case: a= 10, b= 5, kq= 15
        [TestMethod]//1 test case 1
        public void TestSubOperator()
        {
            int expected, actual;
            // Caculation c = new Caculation(10, 5);
            expected = 5;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]//1 test case 1
        public void TestMulOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 50;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]//1 test case 1
        public void TestDivOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]//1 test case 1
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivbyZeror()
        {
           
          c = new Caculation(10, 0);
            
          c.Exectute("/");            
        }
        // Lien ket TestData voi project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv",DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            int a,b,expected,actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected= int.Parse(TestContext.DataRow[2].ToString());
            c= new Caculation(a,b);
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);

        }
    }
}
