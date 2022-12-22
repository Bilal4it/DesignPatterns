namespace IteratorDesignPattern
{
    public class Collection : ICollection
    {
        List<Product> products = new List<Product>();

        public Iterator CreateIterator()
        {

            return new Iterator(this);
        }

        public Product this[int index]
        {
            get { return products[index]; }
            set { products.Add(value); }
        }

        public int Count
        {
            get { return products.Count; }
        }


    }
}

