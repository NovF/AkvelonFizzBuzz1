using System;

namespace AkvelonFizzBuzz
{
    public class FizzBuzzResultReporter : IFizzBuzzResultReporter
    {
        public void Report(FizzBuzzDetectionResult result)
        {
            // Printing results

            Console.WriteLine($"Fizz count: {result.FizzCount}");
            Console.WriteLine($"Buzz count: {result.BuzzCount}");
            
            for (int k = 0; k < result.FizzBuzzedInput.Length; k++)
            {
                Console.WriteLine(result.FizzBuzzedInput[k]);
            }

            Console.ReadKey();
        }
    }
}