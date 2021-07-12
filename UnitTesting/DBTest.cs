using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalStore;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace UnitTesting
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void TestDBName()
        {
            SqlConnectionStringBuilder conStrBuild = new SqlConnectionStringBuilder(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = VideoRentalDB; Integrated Security = True");
            string nameDB = conStrBuild.InitialCatalog;

            Assert.AreEqual(nameDB, "VideoRentalDB");
        }
    }
}
