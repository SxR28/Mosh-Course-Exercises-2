using System;

namespace Exercise
{
    public class Oracle_DataBase : DBConnection
    {
        public Oracle_DataBase(string connectionstring) : base(connectionstring)
        {
            
        }
        
        public override void Open()
        {
            Console.WriteLine("Oracle database opened !");
        }
        
        public override void Close()
        {
            Console.WriteLine("Oracle database closed");
        }
    }
}