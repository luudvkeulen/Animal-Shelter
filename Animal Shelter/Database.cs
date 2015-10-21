using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace AnimalShelter
{
    public class Database
    {
        private static readonly string ConnectionString = "Data Source=localhost;User Id=SE2;Password=8044;";

        public static OracleConnection Connection
        {
            get
            {
                OracleConnection connection = new OracleConnection(ConnectionString);
                connection.Open();
                return connection;
            }
        }
    }
}
