using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AkvelonFizzBuzz.UnitTests1
{
    [TestClass]
    public class FizzBuzzDetectorTests
    {
        [TestMethod]
        public void GetOverlappings_WrongFizzCount()
        {
            // Arrange
            var fizzCount = new FizzBuzzDetector();
            const string input = "one two three four five six seven eight nine ten";
            int expected = 3;
            
            // Act
            var result = fizzCount.GetOverlappings(input);

            // Assert   
            Assert.AreEqual(expected, result.FizzCount);
        }
       
        [TestMethod]
        public void GetOverlappings_WrongBuzzCount()
        {
            // Arrange
            var buzzCount = new FizzBuzzDetector();
            const string input = "one two three four five six seven eight nine ten";
            int expected = 2;
            
            // Act
            var result = buzzCount.GetOverlappings(input);

            // Assert
            Assert.AreEqual(expected, result.BuzzCount);
        }
        
        [TestMethod]
        public void GetOverlappings_ResultWords()
        {
            // Arrange
            var FizzBuzzedInput = new FizzBuzzDetector();
            const string input = "one two three four five six seven";
            string[] expected = { "one", "two", "Fizz", "four", "five", "Fizz", "seveBuzz"};
            
            // Act
            var result = FizzBuzzedInput.GetOverlappings(input);

            // Assert
           CollectionAssert.AreEqual(expected, result.FizzBuzzedInput);
        }
    }
}