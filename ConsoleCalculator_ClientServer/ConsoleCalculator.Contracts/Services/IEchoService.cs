using NFX.Glue;

namespace ConsoleCalculator.Contracts.Services
{
    [Glued]
    public interface IEchoService
    {
        string Echo(string[] text);
    }
}
