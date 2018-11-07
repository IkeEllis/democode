using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace TestDatabase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var datatable = DAL.CustomerRepository.GetAllCustomers();
            ApprovalTests.Approvals.Verify(datatable.ToFormattedTableString());


        }
    }
}
