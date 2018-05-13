using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Assignments;

namespace UserConsole
{
    public class Program
    {
        private static void Main()
        {
            var log = new Log();
            var userTasks = new UserTasks();

            do
            {
                PrintMenu();
                var userInput = userTasks.GetUserInput();
                try
                {
                    switch (userInput)
                    {
                        case 1:
                        {
                            //1. Add numbers
                            var firstNumber = userTasks.GetUserInput("Please enter the first number: ");
                            var secondNumber = userTasks.GetUserInput("Please enter the second Number: ");
                            var result = userTasks.AddNumbers(firstNumber, secondNumber);
                            Console.WriteLine("The result is: " + result);
                            log.WriteToLog(
                                $"Add Numbers: The user typed first number = {firstNumber}, second number = {secondNumber} and the result = {result}");
                            break;
                        }
                        case 2:
                        {
                            //2.Mul numbers
                            var firstNumber = userTasks.GetUserInput("Please enter the first number: ");
                            var secondNumber = userTasks.GetUserInput("Please enter the second Number: ");
                            var result = userTasks.MultiplyNumbers(firstNumber, secondNumber);
                            Console.WriteLine(
                                "The result is: " + userTasks.MultiplyNumbers(firstNumber, secondNumber));
                            log.WriteToLog(
                                $"Mul Numbers: The user typed first number = {firstNumber}, second number = {secondNumber} and the result = {result}");
                            break;
                        }
                        case 3:
                        {
                            //3.Divide numbers
                            var firstNumber = userTasks.GetUserInput("Please enter the first number: ");
                            var secondNumber = userTasks.GetUserInput("Please enter the second Number: ");
                            var result = userTasks.DivideNumbers(firstNumber, secondNumber);
                            Console.WriteLine("The result is: " + result);
                            log.WriteToLog(
                                $"Divide Numbers: The user typed first number = {firstNumber}, second number = {secondNumber} and the result = {result}");
                            break;
                        }
                        case 4:
                        {
                            //4.Show odd numbers in range
                            var firstNumberInRange =
                                userTasks.GetUserInput("Please enter the first number in range: ");
                            var lastNumberInRange = userTasks.GetUserInput("Please enter the last Number in range: ");
                            var oddNumbersInRange =
                                userTasks.ShowOddNumbersInRange(firstNumberInRange, lastNumberInRange);
                            log.WriteToLog(
                                $"Odd Numbers: The user typed first number in range = {firstNumberInRange}, last number in range = {lastNumberInRange} and the odd numbers are: {oddNumbersInRange}");
                            break;
                        }
                        case 5:
                        {
                            //5.print square
                            var squareSize = userTasks.GetUserInput("Please enter the size of the square: ");
                            userTasks.PrintSquare(squareSize);
                            log.WriteToLog($"Print Square: The user typed the number {squareSize}");
                            break;
                        }
                        case 6:
                        {
                            //6.Print triangle
                            var triangleSize = userTasks.GetUserInput("Please enter the size of the triangle: ");
                            userTasks.PrintTriangle(triangleSize);
                            log.WriteToLog($"Print Triangle: The user typed the number {triangleSize}");
                            break;
                        }
                        case 7:
                        {
                            //7. Think for X seconds
                            var secondsToThink = userTasks.GetUserInput("How many second to think?: ");
                            userTasks.ThinkInSeconds(secondsToThink);
                            log.WriteToLog($"Think for X seconds: The user typed the number {secondsToThink}");
                            break;
                        }
                        case 8:
                        {
                            //8. Display the log file
                            Console.Write(log.GetLog());
                            break;
                        }
                        case 9:
                        {
                            //9.Exit
                            return;
                        }
                        default:
                        {
                            continue;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.IsNullOrEmpty(e.Message) ? e.ToString() : e.Message);
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            } while (true);
        }


        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select task from the menu and click Enter:");
            Console.WriteLine("1. Add numbers\n" +
                              "2. Mul numbers\n" +
                              "3. Divide numbers\n" +
                              "4. Show odd numbers in range\n" +
                              "5. print square\n" +
                              "6. Print triangle\n" +
                              "7. Think for X seconds\n" +
                              "8. Display the log file\n" +
                              "9. Exit ");
        }
    }
}