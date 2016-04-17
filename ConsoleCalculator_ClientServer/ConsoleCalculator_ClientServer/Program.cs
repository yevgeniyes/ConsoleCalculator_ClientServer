using System;
using NFX.ApplicationModel;
using NFX;

namespace ConsoleCalculator.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var application = new ServiceBaseApplication(args, null))
            {
                try
                {
                    var processor = new OperationProcessor();
                    processor.Run();
                }
                catch
                {
                    Console.WriteLine(Messages.ERROR_CRITICAL);
                    Console.ReadKey();
                }
            }
        }
    }
}
