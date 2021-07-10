namespace AkvelonFizzBuzz
{
    public class FizzBuzzInputValidator : IValidator
    {
        private readonly int _minLength;
        private readonly int _maxLength;

        public FizzBuzzInputValidator(int minLength, int maxLength)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }

        public ValidationResult Validate(string input)
        { 
            // Checking the input length

            if (string.IsNullOrWhiteSpace(input) || input.Length < _minLength || input.Length > _maxLength)
            {
                return new ValidationResult
                {
                    IsValid = false,
                    ErrorMessage = "The string is either less than 7 characters or greater than 100"
                };
            }

            return new ValidationResult
            {
                IsValid = true
            };
        }
    }
}