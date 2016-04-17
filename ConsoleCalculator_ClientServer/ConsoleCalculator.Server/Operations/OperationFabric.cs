using System;
using System.Globalization;

namespace ConsoleCalculator.Server
{
    internal class OperationFabric
    {
        /// <summary>
        /// Method of selecting the operation
        /// </summary>
        /// <param name="operation"></param>
        /// <returns>Instance of the selected operation class</returns>

        public OperationBase SelectOperation(string operation)
        {
            OperationBase choosenOperation = null;

            switch (operation)
            {
                case "sum":
                    choosenOperation = new SumOperation();
                    break;
                case "sub":
                    choosenOperation = new SubOperation();
                    break;
                case "mult":
                    choosenOperation = new MultOperation();
                    break;
                case "div":
                    choosenOperation = new DivOperation();
                    break;
            }
            return choosenOperation;
        }
    }
}
