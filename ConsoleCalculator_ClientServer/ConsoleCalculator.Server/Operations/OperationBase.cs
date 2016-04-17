using System;
using System.Globalization;

namespace ConsoleCalculator.Server
{
    /// <summary>
    /// The base class for all operations
    /// </summary>
    internal abstract class OperationBase
    {
        /// <summary>
        /// Template of operation completion
        /// </summary>
        /// <param name="splitedInput"></param>
        public string CompleteOperation(string[] splitedInput)
        {
            if (Validate(splitedInput))
                return Execute(splitedInput);
            else return null;
        }

        //Validate input
        protected abstract bool Validate(string[] splitedInput);

        //Perform operation: overriden for each Operation
        protected abstract string Execute(string[] splitedInput);
    }
}
