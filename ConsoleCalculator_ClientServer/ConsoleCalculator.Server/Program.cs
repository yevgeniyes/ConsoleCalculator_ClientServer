using System;
using NFX.ApplicationModel;
using NFX;

namespace ConsoleCalculator.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var application = new ServiceBaseApplication(args, null))
                {
                    Console.WriteLine("server is running...");
                    Console.WriteLine("Glue servers:");
                    foreach (var server in App.Glue.Servers)
                        Console.WriteLine("   " + server);

                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error:");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
