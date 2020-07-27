using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SQLite;
using System.Configuration;

namespace Biblioteca.DAO
{
    public class DatabaseHelper 
    {
        public string connectionString = @"Data Source="+ConfigurationManager.AppSettings["SQLitePath"];

    }
}
