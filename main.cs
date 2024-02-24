using System;

class Program
{
    public static void Main(string[] args)
    {
        int previousNum = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Program Terminated.");
                break;
            }

            int num;
            bool isNumeric = int.TryParse(input, out num);

            if (isNumeric)
            {
                int currentNum = int.Parse(input);
                int sum = previousNum + currentNum;
                Console.WriteLine($"Adding {previousNum} to {currentNum} = {sum}.");
                previousNum = currentNum;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    Console.WriteLine($"Current Message is: {message}{input}");
                }
                else
                {
                    Console.WriteLine($"Current Message is: {input}");
                }
                message += input + " ";
            }
        }

        Console.WriteLine("Current message is: " + message);
    }
  }