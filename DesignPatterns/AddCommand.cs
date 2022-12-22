namespace CommanDesignPatterns
{
    internal class AddCommand : ICommand
    {
        Calculator calculator;
        int number;
        public AddCommand(Calculator cal, int num)
        {
            calculator = cal;
            number = num;
        }

        public void Execute()
        {
            calculator.Add(number);
        }

        public void UnExecute()
        {
            calculator.Subtract(number);
        }
    }
}
