using System.Diagnostics;

namespace _06_Interface_Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();

            var externalLogger = new ExternalLogger();
            logger = new ExternalLoggerAdapter(externalLogger);


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
    
    public class ExternalLoggerAdapter : ILogger
    {
        private ExternalLogger _externalLogger;

        public ExternalLoggerAdapter(ExternalLogger externalLogger)
        {
            _externalLogger = externalLogger;
        }

        public void Error(string message)
        {
            _externalLogger.WriteError(message);
        }

        public void Info(string message)
        {
            _externalLogger.WriteInfo(message);
        }

        public void Warning(string message)
        {
            _externalLogger.WriteWarning(message);
        }
    }

    // Näiliselt kasutusel väline logger
    public class ExternalLogger
    {
        public void WriteInfo(string message) { }

        public void WriteWarning(string message) { }

        public void WriteError(string message) { }

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