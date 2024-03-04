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
                if (value < 0 || value > Capacity)
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
    }
}