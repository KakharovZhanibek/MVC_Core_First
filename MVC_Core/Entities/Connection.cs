using MVC_Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core.Entities
{
    public class ConnectionMSSQL : IConnection
    {
        public string GetConnection()
        {
            return "Connected to MSSQL";
        }
    }
    public class ConnectionOracle : IConnection
    {
        public string GetConnection()
        {
            return "Connected to Oracle";
        }
    }
    public class ConnectionPostgreSQL : IConnection
    {
        public string GetConnection()
        {
            return "Connected to PostgreSQL";
        }
    }
}
