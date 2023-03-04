using System.Diagnostics;

namespace _04_Inheritance_Loggers
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
        private BaseLogger _logger;

        public InvoiceGenerator(BaseLogger logger)
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

    public abstract class BaseLogger
    {
        public abstract void Info(string message);
        public abstract void Warning(string message);
        public abstract void Error(string message);
    }

    public class NullLogger : BaseLogger
    {
        public override void Info(string message)
        {
            
        }
        public override void Warning(string message)
        {
            
        }
        public override void Error(string message)
        {
            
        }
    }

    public class ConsoleLogger : BaseLogger
    {
        public override void Info(string message)
        {
            Console.WriteLine("INFO: " + message);
        }
        public override void Warning(string message)
        {
            Console.WriteLine("WARN: " + message);
        }
        public override void Error(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }
    }

    public class DebugLogger : BaseLogger 
    {
        public override void Info(string message)
        {
            Debug.WriteLine("INFO: " + message);
        }
        public override void Warning(string message)
        {
            Debug.WriteLine("WARN: " + message);
        }
        public override void Error(string message)
        {
            Debug.WriteLine("ERROR: " + message);
        }
    }
}