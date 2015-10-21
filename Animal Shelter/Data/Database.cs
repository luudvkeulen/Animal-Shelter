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
            using(OracleConnection connection = Connection)
            {
                string sqlquery = "SELECT count(*) from ALL_TABLES where TABLE_NAME = 'ANIMALS'";
                OracleCommand command = new OracleCommand(sqlquery, connection);
                OracleDataReader ODR = command.ExecuteReader();
                ODR.Read();
                if (Convert.ToBoolean(ODR.GetInt32(0)))
                {
                    return;
                }
                else
                {
                    sqlquery = @"CREATE TABLE ANIMALS
                                (
                                  CHIPREGISTRATIONNUMBER VARCHAR2(5) NOT NULL 
                                , DATEOFBIRTH DATE 
                                , NAME VARCHAR2(128) 
                                , RESERVED NUMBER(1) DEFAULT 0 NOT NULL
                                , PRICE NUMBER(6,2) NOT NULL
                                , LASTWALKDATE DATE
                                , BADHABITS VARCHAR2(255) 
                                , CONSTRAINT TABLE1_PK PRIMARY KEY 
                                  (
                                    CHIPREGISTRATIONNUMBER 
                                  )
                                  ENABLE 
                                )";
                    command = new OracleCommand(sqlquery, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
