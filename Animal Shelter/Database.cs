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

        public static void Initialize()
        {
            using (Connection)
            {
                string CommandString = "SELECT TABLE_NAME FROM ALL_TABLES WHERE TABLE_NAME = 'ANIMALS'";
                OracleCommand OC = new OracleCommand(CommandString, Connection);
                try
                {
                    OracleDataReader ODR = OC.ExecuteReader();
                    if (ODR.HasRows)
                    {
                        return;
                    }
                    else
                    {
                        CommandString = 
                        @"CREATE TABLE ANIMALS 
                        (CHIPREGISTRATIONNUMBER VARCHAR2(5) NOT NULL, 
                        ISRESERVED NUMBER(1) DEFAULT 0 NOT NULL, 
                        NAME VARCHAR2(255) NOT NULL, 
                        DATEOFBIRTH DATE NOT NULL, 
                        CONSTRAINT ANIMALS_PK PRIMARY KEY(CHIPREGISTRATIONNUMBER))";
                    }
                }
                catch (OracleException OE)
                {
                    System.Diagnostics.Debug.Write(OE.Message);
                }
            }
        }
    }
}
