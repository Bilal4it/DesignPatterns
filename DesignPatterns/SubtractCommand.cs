namespace CommanDesignPatterns
{
    internal class SubtractCommand : ICommand
    {
        Calculator calculator;
        int number;
        public SubtractCommand(Calculator cal, int num)
        {
            calculator = cal;
            number = num;
        }
        public void Execute()
        {
            calculator.Subtract(number);
        }

        public void UnExecute()
        {
            calculator.Add(number);
        }
    }
}
