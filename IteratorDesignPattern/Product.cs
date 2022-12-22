namespace IteratorDesignPattern
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return String.Format("ID = {0}, Name = {1}", Id, Name);
        }
    }
}
