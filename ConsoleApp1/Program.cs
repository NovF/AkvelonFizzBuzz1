namespace AkvelonFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new FizzBuzzInputValidator(7, 100);
            var inputReader = new FizzBuzzConsoleInputReader(validator);
            var solver = new FizzBuzzDetector();
            var reporter = new FizzBuzzResultReporter();
            var orchestrator = new FizzBuzzOrchestrator(inputReader, solver, reporter);

            orchestrator.ExecuteFizzBuzz();
        }
    }
}