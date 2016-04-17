using System;

namespace ConsoleCalculator.Client
{
    /// <summary>
    /// User friendly text messages of errors
    /// </summary>
    internal static class Messages
    {
        public const string INTRO_TEXT = "Client/Server Console Calculator 1.0\n\nAvailable operations for calculator: sum, sub, mult, div. Available variables: int, double\nExample command: sum 3 2.54 18\n";
        public const string ERROR_EMPTY_COMMAND = "Empty command. Enter the command and try again\n";
        public const string ERROR_CALC_INVALID = "Invalid command. Available operations: sum, sub, mult, div.\nAvailable variables: int, double\n";
        public const string ERROR_INVALID_COMMAND = "Invalid command. Check the input data and try again\n";
        public const string ERROR_CRITICAL = "Critical error. Please restart application and try again.\n";
    }
}
