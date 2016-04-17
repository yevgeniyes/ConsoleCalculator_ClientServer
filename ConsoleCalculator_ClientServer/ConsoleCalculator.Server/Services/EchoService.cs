using ConsoleCalculator.Contracts.Services;

namespace ConsoleCalculator.Server.Services
{
    class EchoService : IEchoService
    {
        public string Echo(string[] splitedInput)
        {
            string operation = splitedInput[0];

            var fabric = new OperationFabric();
            var selectedOperarion = fabric.SelectOperation(operation);

            if (selectedOperarion != null)
            {
                return selectedOperarion.CompleteOperation(splitedInput);
            }
            else return null;
        }
    }
}
