namespace CommanDesignPatterns
{
    internal class Calculator
    {
        int value = 0;

        public void Start(int val)
        {
            value = val;
        }

        public void Add(int val)
        {
            value += val;
        }

        public void Subtract(int val)
        {
            value -= val;
        }

        public int GetValue()
        {
            return value;
        }

    }
}







