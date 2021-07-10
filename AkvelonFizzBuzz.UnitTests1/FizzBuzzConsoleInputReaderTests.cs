using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AkvelonFizzBuzz.UnitTests1
{
    [TestClass]
    public class FizzBuzzConsoleInputReaderTests
    {
        [TestMethod]
        public void ReadInput_TooManyWords()
        {
            // Arrange
            var validator = new FizzBuzzInputValidator(7, 100);
            const string input = "one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three one two three ";

            // Act
            var result = validator.Validate(input);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(result.ErrorMessage, "The string is either less than 7 characters or greater than 100");
        }
        
        [TestMethod]
        public void ReadInput_NotEnoughWords()
        {
            // Arrange
            var validator = new FizzBuzzInputValidator(7, 100);
            const string input = "one";

            // Act
            var result = validator.Validate(input);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(result.ErrorMessage, "The string is either less than 7 characters or greater than 100");
        }
        
        [TestMethod]
        public void ReadInput_IsValid()
        {
            // Arrange
            var validator = new FizzBuzzInputValidator(7, 100);
            const string input = "one two three four five six seven";

            // Act
            var result = validator.Validate(input);

            // Assert
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(result.ErrorMessage, null);
        }
    }   
}
