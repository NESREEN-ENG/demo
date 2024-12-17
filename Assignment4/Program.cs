using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;



class Program
{
    static void Main()
    {
        #region Number13
        /*
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();
        string reversedString = ReverseStringWithBuilder(userInput);

        Console.WriteLine("Reversed string: " + reversedString);
    }

    // Method to reverse a string using StringBuilder
    static string ReverseStringWithBuilder(string input)
    {
        StringBuilder sb = new StringBuilder(input);
        int length = sb.Length;

        for (int i = 0; i < length / 2; i++)
        {
            // Swap characters at i and (length - 1 - i)
            char temp = sb[i];
            sb[i] = sb[length - 1 - i];
            sb[length - 1 - i] = temp;
        }

        return sb.ToString();
     
         */
        #endregion
        #region Number14

        /*
        Console.Write("Enter an integer: ");
        int userInput = int.Parse(Console.ReadLine());
        int reversedInteger = ReverseInteger(userInput);

        // Display the reversed integer
        Console.WriteLine("Reversed integer: " + reversedInteger);
        // Method to reverse an integer
        static int ReverseInteger(int number)
        {
            int reversed = 0;
            int isNegative = number < 0 ? -1 : 1; // Preserve sign
            number = Math.Abs(number);

            while (number > 0)
            {
                int remainder = number % 10;
                reversed = reversed * 10 + remainder;
                number /= 10;
            }

            return reversed * isNegative;
        }
        */
        #endregion
        #region Number15
        /*
        Console.Write("Input starting number of range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Input ending number of range: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"The prime numbers between {start} and {end} are:");
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
        // Method to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; // Numbers less than or equal to 1 are not prime
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; // Divisible by a number other than 1 and itself
                }
            }

            return true; // Number is prime
        }
        */
        #endregion
        #region Number16
        /*
        Console.Write("Enter a number to convert: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binary = ConvertToBinary(decimalNumber);
        Console.WriteLine($"The Binary of {decimalNumber} is {binary}.");
        // Method to convert a decimal number to binary
        static string ConvertToBinary(int number)
        {
            string binary = "";

            if (number == 0)
            {
                return "0"; 
            }

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary; 
                number /= 2;
            }

            return binary;
        }
        */
        #endregion
        #region Number17
        /*
              Console.WriteLine("Enter coordinates of the first point (x1, y1): ");
              double x1 = double.Parse(Console.ReadLine());
              double y1 = double.Parse(Console.ReadLine());

              Console.WriteLine("Enter coordinates of the second point (x2, y2): ");
              double x2 = double.Parse(Console.ReadLine());
              double y2 = double.Parse(Console.ReadLine());

              Console.WriteLine("Enter coordinates of the third point (x3, y3): ");
              double x3 = double.Parse(Console.ReadLine());
              double y3 = double.Parse(Console.ReadLine());


              if (ArePointsCollinear(x1, y1, x2, y2, x3, y3))
              {
                  Console.WriteLine("The points lie on the same straight line.");
              }
              else
              {
                  Console.WriteLine("The points do not lie on the same straight line.");
              }
              // Method to check if three points are collinear
              static bool ArePointsCollinear(double x1, double y1, double x2, double y2, double x3, double y3)
              {
                  // Calculate the slope between the first two points and the last two points
                  // Use the cross product to avoid division by zero
                  double crossProduct = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
                  return Math.Abs(crossProduct) < 1e-10; 
              }
        */
        #endregion
        #region Number18
        /*
        Console.Write("Enter the time taken by the worker to complete the task (in hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        // Evaluate worker efficiency based on the time taken
        if (timeTaken >= 2 && timeTaken <= 3)
        {
            Console.WriteLine("The worker is highly efficient.");
        }
        else if (timeTaken > 3 && timeTaken <= 4)
        {
            Console.WriteLine("The worker needs to increase their speed.");
        }
        else if (timeTaken > 4 && timeTaken <= 5)
        {
            Console.WriteLine("The worker needs training to improve their speed.");
        }
        else if (timeTaken > 5)
        {
            Console.WriteLine("The worker is required to leave the company.");
        }
        else
        {
            Console.WriteLine("Invalid input. Time taken should be 2 hours or more.");
        }
        */
        #endregion
    }




}

