using System;

namespace Exercise
{
    public abstract class DBConnection
    {
        private string _connectionString;
        public DateTime Timeout { get; set; }

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
            
            if (connectionString == null)
                throw new Exception("String is null");
            else if (connectionString == String.Empty)
                throw new Exception("String is empty");
            else
            {
                Console.WriteLine($"{connectionString} is valid");
                Console.Clear();
            }
        }

        public abstract void Open();

        public abstract void Close();

    }
}