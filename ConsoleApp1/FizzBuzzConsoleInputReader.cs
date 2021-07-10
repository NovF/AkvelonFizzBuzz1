using System;

namespace AkvelonFizzBuzz
{
    public class FizzBuzzConsoleInputReader : IFizzBuzzInputReader
    {
        private readonly IValidator _validator;

        public FizzBuzzConsoleInputReader(IValidator validator)
        {
            _validator = validator;
        }

        public string ReadInput()
        {
            Console.WriteLine("Input 7 - 100 lowercase letters");
            var input = Console.ReadLine();
            ValidationResult result;
            
            while (!(result = _validator.Validate(input)).IsValid)
            {
                Console.WriteLine(result.ErrorMessage);
                input = Console.ReadLine();
            }

            return input;
        }
    }
}