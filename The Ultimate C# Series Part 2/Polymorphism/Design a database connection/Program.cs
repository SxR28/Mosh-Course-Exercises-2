using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Oracle_DataBase oracle = new Oracle_DataBase("1234");
            SQL_DataBase sql = new SQL_DataBase("1234");
            
            oracle.Open();
            oracle.Close();
            
            sql.Open();
            sql.Close();
        }
    }
}