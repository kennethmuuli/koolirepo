using System.Diagnostics;

namespace _05_Inheritance_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new NullLogger();

            // ----- järgnevat koodi loggeri vahetamisel muuta ei tule -----

            var generator = new InvoiceGenerator(logger);
            generator.Run();
        }
    }

    public class InvoiceGenerator
    {
        private ILogger _logger;

        public InvoiceGenerator(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.Info("Generating invoices");

            // ...

            _logger.Info("Invoices are generated");
        }
    }

    // Interface ütleb, ette, et mõni klass kvalifitseeruks loggeriks peavad tal olema antud meetodid küljes
    // Baasklass siis kui on olemas mingeid meetode/loogikat, mida tahama pärivatele klassidele pakkuda (interface seda ei luba)
    // Kui baasklass mingit lisa loogikat ei paku siis kasuta üldiselt interface
    public interface ILogger
    {
        void Info(string message); 
        void Warning(string message);
        void Error(string message);
    }

    public class NullLogger : ILogger
    {
        public void Info(string message)
        {

        }
        public void Warning(string message)
        {

        }
        public void Error(string message)
        {

        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine("INFO: " + message);
        }
        public void Warning(string message)
        {
            Console.WriteLine("WARN: " + message);
        }
        public void Error(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }
    }

    public class DebugLogger : ILogger
    {
        public void Info(string message)
        {
            Debug.WriteLine("INFO: " + message);
        }
        public void Warning(string message)
        {
            Debug.WriteLine("WARN: " + message);
        }
        public void Error(string message)
        {
            Debug.WriteLine("ERROR: " + message);
        }
    }
}