using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_spGetAllCustomersTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_spGetAllRentedVideoTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            this.dbo_spGetAllCustomersTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_spGetAllCustomersTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_spGetAllRentedVideoTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            // 
            // dbo_spGetAllCustomersTest_TestAction
            // 
            dbo_spGetAllCustomersTest_TestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(dbo_spGetAllCustomersTest_TestAction, "dbo_spGetAllCustomersTest_TestAction");
            // 
            // dbo_spGetAllRentedVideoTest_TestAction
            // 
            dbo_spGetAllRentedVideoTest_TestAction.Conditions.Add(checksumCondition2);
            resources.ApplyResources(dbo_spGetAllRentedVideoTest_TestAction, "dbo_spGetAllRentedVideoTest_TestAction");
            // 
            // checksumCondition2
            // 
            checksumCondition2.Checksum = null;
            checksumCondition2.Enabled = true;
            checksumCondition2.Name = "checksumCondition2";
            // 
            // dbo_spGetAllCustomersTestData
            // 
            this.dbo_spGetAllCustomersTestData.PosttestAction = null;
            this.dbo_spGetAllCustomersTestData.PretestAction = null;
            this.dbo_spGetAllCustomersTestData.TestAction = dbo_spGetAllCustomersTest_TestAction;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "-1014419952";
            checksumCondition1.Enabled = false;
            checksumCondition1.Name = "checksumCondition1";
        }

        #endregion


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
        #endregion

        [TestMethod()]
        public void dbo_spGetAllCustomersTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_spGetAllCustomersTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

       
        private SqlDatabaseTestActions dbo_spGetAllCustomersTestData;
  
    }
}
