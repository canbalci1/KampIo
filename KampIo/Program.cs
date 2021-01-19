using System;

namespace KampIo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustumerManger customerManager = new CustumerManger();
            customerManager.Logger = new DataBaseLogger();
            customerManager.Add();
            Console.ReadLine();

            
        }
    }

    class CustumerManger
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Custumer Add");

        }


    }

    class DataBaseLogger : ILogger
    {
        public void Log()
        {

            Console.WriteLine("Logged to database");
        }
    }
    class FileLoger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class SmsLoger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS");
        }
    }
    class Logger : ILogger
    {
        public void Log()
        {
            throw new NotImplementedException();
        }
    }

    interface ILogger
    {

        void Log();

    }

}
