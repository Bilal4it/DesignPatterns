namespace CommanDesignPatterns
{
    internal class StartCommand : ICommand
    {
        Calculator calculator;
        int number;

        public StartCommand(Calculator cal, int num)
        {
            calculator = cal;
            number = num;
        }

        public void Execute()
        {
            calculator.Start(number);
        }

        public void UnExecute()
        {
            calculator.Start(0);
        }
    }
}
