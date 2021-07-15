using System;

namespace Exercise
{
    public class SQL_DataBase : DBConnection
    {
        public SQL_DataBase(string connectionstring) : base(connectionstring)
        {
            
        }
        
        public override void Open()
        {
            Console.WriteLine("Sql database opened !");
        }
        
        public override void Close()
        {
            Console.WriteLine("Sql database closed");
        }
    }
}