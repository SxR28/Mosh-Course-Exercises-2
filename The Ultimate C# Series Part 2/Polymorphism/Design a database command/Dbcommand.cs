using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Exercise
{
    public class Dbcommand
    {
        private string _DbConnection;
        public string languageToBeSentToDB;
        
        public Dbcommand(string Dbconnection, string langToBeSent)
        {
            _DbConnection = Dbconnection;

            DbConnectionTest(Dbconnection);
            LanguageToBeSentTest(langToBeSent);
            
            Execute(Dbconnection, langToBeSent);
        }

        public void Execute(string Dbconnection, string langToBeSent)
        {
            Console.WriteLine($"{Dbconnection} is now opened !");
            Console.Clear();

            for (int i = 0; i < 3; i++)
                Console.WriteLine($"Running perfectly, creating collumns and inserting data with {langToBeSent}");

            Console.Clear();
            Console.WriteLine("Connection closed !");
        }
        
        public void DbConnectionTest(string Dbconnection)
        {
            if (Dbconnection == null)
                throw new Exception("Connection is null");
            else
            {
                Console.WriteLine("Connection is fine");
                Console.Clear();
            }
        }

        public void LanguageToBeSentTest(string langToBeSent)
        {
            if (langToBeSent == null)
                throw new Exception("The language Is null !");
            else if (langToBeSent == " ")
                throw new Exception("The language is empty");
            else
            {
                Console.WriteLine("Everything fine !");
                Console.Clear();
            }
        }
    }
}