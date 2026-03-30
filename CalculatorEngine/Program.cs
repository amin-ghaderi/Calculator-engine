using System;
using System.Collections.Generic;
using CalculatorEngine;

namespace CalculatorEngine
{
    /// <summary>
    /// Entry point of the calculator application with chain calculation and history.
    /// Uses ICalculator abstraction for loose coupling.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            bool isRunning = true;

            List<string> history = new List<string>();

            while (isRunning)
            {
                ShowMenu();

                Console.Write("Select an option: ");
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        StartCalculation(calculator, history);
                        break;

                    case "2":
                        ShowHistory(history);
                        break;

                    case "0":
                        isRunning = false;
                        Console.WriteLine("👋 Goodbye!");
                        break;

                    default:
                        WriteError("Invalid option!");
                        break;
                }

                Pause();
            }
        }

        /// <summary>
        /// Displays main menu.
        /// </summary>
        static void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==== 🧮 Calculator ====");
            Console.ResetColor();

            Console.WriteLine("1. Start Calculation");
            Console.WriteLine("2. View History");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
        }

        /// <summary>
        /// Handles chain calculation mode using ICalculator abstraction.
        /// </summary>
        static void StartCalculation(ICalculator calculator, List<string> history)
        {
            double result = ReadNumber("Enter first number: ");

            history.Add($"Start: {result}");

            while (true)
            {
                Console.WriteLine($"\n📌 Current Result: {result}");
                Console.WriteLine("Choose operation: +  -  *  /  ^  %  sqrt  = (finish)");

                string? op = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(op))
                    continue;

                if (op == "=")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"✅ Final Result: {result}");
                    Console.ResetColor();

                    history.Add($"Final = {result}");
                    break;
                }

                try
                {
                    if (op == "sqrt")
                    {
                        result = calculator.SquareRoot(result);
                        history.Add($"√ → {result}");
                    }
                    else
                    {
                        double next = ReadNumber("Enter next number: ");

                        result = op switch
                        {
                            "+" => calculator.Add(result, next),
                            "-" => calculator.Subtract(result, next),
                            "*" => calculator.Multiply(result, next),
                            "/" => calculator.Divide(result, next),
                            "^" => calculator.Power(result, next),
                            "%" => calculator.Modulus(result, next),
                            _ => throw new Exception("Invalid operation")
                        };

                        history.Add($"{result}");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Result: {result}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    WriteError(ex.Message);
                }
            }
        }

        /// <summary>
        /// Displays calculation history.
        /// </summary>
        static void ShowHistory(List<string> history)
        {
            Console.WriteLine("\n📜 History:");

            if (history.Count == 0)
            {
                Console.WriteLine("No calculations yet.");
                return;
            }

            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Reads and validates numeric input from the user.
        /// </summary>
        static double ReadNumber(string message)
        {
            double number;

            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";

                if (double.TryParse(input, out number))
                    return number;

                WriteError("Invalid number. Try again.");
            }
        }

        /// <summary>
        /// Displays error messages in red color.
        /// </summary>
        static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Pauses the application until a key is pressed.
        /// </summary>
        static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}