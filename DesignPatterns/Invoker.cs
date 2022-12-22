namespace CommanDesignPatterns
{

    internal class Invoker
    {
        public ICommand Command { get; set; }

        public void Invoke()
        {
            Command.Execute();
        }

        public void Undo()
        {
            Command.UnExecute();
        }

    }
}
