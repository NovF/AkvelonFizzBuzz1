namespace AkvelonFizzBuzz
{
    public class FizzBuzzDetector : IFizzBuzzDetector
    {
        public FizzBuzzDetectionResult GetOverlappings(string input)
        {
            //Splitting input string into array of words

            string[] words = input.Split(' ');
            int fizzCount = 0;
            int buzzCount = 0;

            //Changing every third word to "Fizz"

            for (int i = 2; i < words.Length; i += 3)
            {
                words[i] = "Fizz";
                fizzCount++;
            }

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    // Checking if the number of letters is a multiple of five 
                    // Before and after Buzz expansion

                    if (words[i].Length > 4 + 8 * j)
                    {
                        // Changing every fifth letter of any every word to Buzz
                        // considering expansion of a word after Buzz substitution

                        words[i] = words[i].Remove(4 + 8 * j, 1);
                        words[i] = words[i].Insert(4 + 8 * j, "Buzz");
                        buzzCount++;
                    }
                }
            }

            return new FizzBuzzDetectionResult
            {
                FizzBuzzedInput = words,
                FizzCount = fizzCount,
                BuzzCount = buzzCount
            };
        }
    }
}