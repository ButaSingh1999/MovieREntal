using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalProject
{
    public class DB
    {
        string ConnectionString = @"Data Source=LAPTOP-24212K92\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Connection;

        public DB()
        {
            Connection = new SqlConnection(ConnectionString);
        }
    }
}
