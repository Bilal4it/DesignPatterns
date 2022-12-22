namespace IteratorDesignPattern
{
    internal interface IIterator
    {
        Product First();
        Product Next();

        bool IsDone { get; }

        Product CurrentProduct { get; }

    }
}
