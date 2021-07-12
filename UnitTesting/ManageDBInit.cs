using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass()]
    public class ManageDBInit
    {

        [AssemblyInitialize()]
        public static void InitializeAssembly(TestContext ctx)
        {
         
            // testing database using configuration setttings
            SqlDatabaseTestClass.TestService.DeployDatabaseProject();
            SqlDatabaseTestClass.TestService.GenerateData();
       
        }
       
       
    }
}
