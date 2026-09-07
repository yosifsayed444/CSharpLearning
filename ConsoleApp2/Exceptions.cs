using System;
using System.Collections.Generic;
using System.Text;



namespace ConsoleApp2
{
    class DBNotFoundException : ApplicationException
    {
        public DBNotFoundException()
        {
            Console.WriteLine("Database not found.");
        }
        public DBNotFoundException(string message)
        {
            Console.WriteLine(message);
        }
    }

    class App
    {
        string db = null;
        public void ConnectDB()
        {
            if (db == null)
            {
                throw new DBNotFoundException();

            }

        }
    }
}