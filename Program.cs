using System;

namespace GradeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of inputs");
                int numberOfInputs = Convert.ToInt32(Console.ReadLine());
                if (!(numberOfInputs > 0 && numberOfInputs <= 60))
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    return;
                }
                int[] inputList = new int[60];
                Console.WriteLine("Enter the grades");
                for (int i = 0; i < numberOfInputs; i++)
                {
                    inputList[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n\nOUTPUT");
                for (int j = 0; j < numberOfInputs; j++)
                {
                    CalculateGrade(inputList[j]);
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }

        }

        private static void CalculateGrade(int score)
        {
            if (score < 0 || score > 100)
            {
                Console.WriteLine("Invalid Score");
                return;
            }
            int difference = 5 - (score % 5);
            if (difference < 3)
            {
                int finalScore = score + difference;
                if (finalScore >= 40)
                {
                    Console.WriteLine(finalScore);
                }
                else
                {
                    Console.WriteLine(score);
                }
            }
            else
            {
                Console.WriteLine(score);
            }
        }
    }
}
