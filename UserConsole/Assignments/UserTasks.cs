using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignments
{
    public class UserTasks
    {
        public int GetUserInput(string instructions = null)
        {
            int userInput;
            if (instructions != null)
            {
                Console.Write(instructions);
            }
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Please enter a valid number: ");
            }
            return userInput;
        }

        public int AddNumbers(int firstNumberToAdd, int secondNumberToAdd)
        {
            var addNumbersResult = firstNumberToAdd + secondNumberToAdd;
            return addNumbersResult;
        }

        public int MultiplyNumbers(int firstNumber, int secondNumber)
        {
            var multiplyResult = firstNumber * secondNumber;
            return multiplyResult;
        }

        public float DivideNumbers(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException("We are not allowing divide by zero");
            var divisionResult = (float) firstNumber / secondNumber;
            return divisionResult;
        }

        public string ShowOddNumbersInRange(int firstInRange, int lastInRange)
        {
            string oddNumbers = null;
            for (var i = firstInRange; i <= lastInRange; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
                oddNumbers = oddNumbers + " " +  i;
            }
            if (oddNumbers == null)
                Console.WriteLine("There are no odd numbers in the range");
            return oddNumbers?.Trim() ?? "There are no odd numbers in the range";
        }

        public void PrintSquare(int squareSize)
        {
            for (var i = 0; i < squareSize; i++)
            {
                for (var j = 0; j < squareSize; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangle(int triangleSize)
        {
            var triangleRow = 1;
            for (var i = 0; i < triangleSize; i++)
            {
                for (var j = 0; j < triangleRow; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                triangleRow++;
            }
        }

        public void ThinkInSeconds(int secondsToThink)
        {
            var myClock = 0;
            do
            {
                Thread.Sleep(1000);
                Console.Write("*");
                myClock++;
            } while (myClock < secondsToThink);
            Console.WriteLine();
        }
    }
}