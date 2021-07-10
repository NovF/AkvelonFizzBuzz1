namespace AkvelonFizzBuzz
{
    public class FizzBuzzOrchestrator : IFizzBuzzOrchestrator
    {
        private readonly IFizzBuzzInputReader _inputReader;
        private readonly IFizzBuzzDetector _detector;
        private readonly IFizzBuzzResultReporter _reporter;

        public FizzBuzzOrchestrator(
            IFizzBuzzInputReader inputReader,
            IFizzBuzzDetector detector,
            IFizzBuzzResultReporter reporter)
        {
            _inputReader = inputReader;
            _detector = detector;
            _reporter = reporter;
        }

        public void ExecuteFizzBuzz()
        {
            var input = _inputReader.ReadInput();
            var result = _detector.GetOverlappings(input);
            _reporter.Report(result);
        }
    }
}