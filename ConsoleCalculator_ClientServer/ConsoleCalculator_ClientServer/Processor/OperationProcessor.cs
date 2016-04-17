using System;
using System.Globalization;
using NFX;
using NFX.Environment;
using ConsoleCalculator.Client.ClientServices;

namespace ConsoleCalculator.Client
{
    internal class OperationProcessor
    {
        public OperationProcessor()
        {
            Console.WriteLine(Messages.INTRO_TEXT);
            ConfigAttribute.Apply(this, App.ConfigRoot);
        }

        [Config("$test-service-node")]
        private string m_TestServiceNode;

        /// <summary>
        ///Main logic: read, validate and split input, select operation, complete operation based on operation tag ("math" or "file") 
        /// </summary>

        public void Run()
        {
            while (true)
            {
                var inputProcessor = new InputProcessor();
                string[] splitedInput = inputProcessor.ReadAndSplit();

                if (splitedInput == null) continue;

                //request here
                try
                {
                    using (var client = new EchoServiceClient(m_TestServiceNode))
                    {
                        var responce = client.Echo(splitedInput);
                        if (responce != null)
                        {
                            Console.WriteLine("Result: " + responce + "\n");
                        }
                        else Console.WriteLine(Messages.ERROR_CALC_INVALID);
                    }
                }
                
                catch (Exception error)
                {
                    Console.WriteLine(error.ToMessageWithType());
                }
            }
        }
    }
}
