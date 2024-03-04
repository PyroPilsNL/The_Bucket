namespace The_Bucket
{
    public abstract class Container
    {
        public int Capacity { get; protected set; }
        private int _content;

        public int Content
        {
            get { return _content; }
            set
            {
                if (value < 0 || value >= Capacity)
                {
                    Console.WriteLine("Content cannot be negative or exceed the capacity.");
                }
                else
                {
                    _content = value;
                }
            }
        }

        public void Empty()
        {
            Content = 0;
        }

        public void Fill(int amount)
        {
            if (amount < 0)
            {
                int emptied = _content + amount;
                if (emptied >= 0)
                {
                    _content = emptied;
                }
                else
                {
                    Console.WriteLine("This is already empty.");
                    _content = 0;
                }
            }
            else
            {
                int filled = _content + amount;
                if (filled <= Capacity)
                {
                    _content = filled;
                }
                else
                {
                    Console.WriteLine("This is overflown.");
                }
            }
        }
    }
}