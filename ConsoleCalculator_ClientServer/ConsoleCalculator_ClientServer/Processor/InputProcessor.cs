﻿using System;
using System.Globalization;

namespace ConsoleCalculator.Client
{
    internal class InputProcessor
    {
        /// <summary>
        /// Read input, validate and split, return splited input
        /// </summary>
        /// <returns>Array of splited strings</returns>
        public string[] ReadAndSplit()
        {
            Console.WriteLine("Enter the command:");

            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(Messages.ERROR_EMPTY_COMMAND);
                return null;
            }

            string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (splitedInput.Length < 2)
            {
                Console.WriteLine(Messages.ERROR_INVALID_COMMAND);
                return null;
            }

            return splitedInput;
        }
    }
}
