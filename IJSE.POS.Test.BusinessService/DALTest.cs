using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IJSE.POS.DataAccess.DAL;
using IJSE.POS.Common.Models;

using System.Data;
using System.Data.Entity;
using System.Linq;


namespace IJSE.POS.Test.BusinessService
{
    /// <summary>
    /// Summary description for DALTest
    /// </summary>
    [TestClass]
    public class DALTest
    {
        public DALTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            int expected = 10;

            int actual = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerInsertTest()
        {
            PosContext db = new PosContext();
            Customer newCustomer = 
              new Customer
              { Name = "Test1", Address = "TestAddress", Creditlimit = 1000 };

            db.Customer.Add(newCustomer);
            db.SaveChanges();
            //using System.Linq; //using System.Data; //using System.Data.Entity;
            Customer findCustomer = 
                db.Customer.Where(C => C.Name == "Test1").FirstOrDefault();

            Assert.AreEqual(newCustomer.Name, findCustomer.Name);

            if (findCustomer != null)
            {
                db.Customer.Remove(findCustomer); // remove from Db
            }

        }


    }
}
