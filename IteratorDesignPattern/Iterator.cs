namespace IteratorDesignPattern
{
    public class Iterator : IIterator
    {
        Collection collection;
        int current = 0;

        public Iterator(Collection coll)
        {
            collection = coll;
        }

        public bool IsDone
        {
            get { return current < collection.Count; }
        }

        public Product CurrentProduct
        {
            get { return collection[current]; }
        }

        public Product First()
        {
            return collection[0];
        }

        public Product Next()
        {
            current += 1;
            return collection[current];
        }

    }
}