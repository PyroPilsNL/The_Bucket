namespace The_Bucket
{
    public delegate void OverflowEventHandler(object sender, EventArgs e);
    public delegate void FullEventHandler(object sender, EventArgs e);
    public class AmountArgs : EventArgs
    {
        public int Amount { get; }

        public AmountArgs(int amount)
        {
            Amount = amount;
        }
    }

    public delegate void OverfloatEventHandler(object sender, AmountArgs e);
    public abstract class Container
    {
        public event OverflowEventHandler Overflow;
        public event FullEventHandler Full;
        public event OverfloatEventHandler Overfloat;
        public int Capacity { get; protected set; }
        private int _content;


        public int Content
        {
            get { return _content; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Content cannot be negative.");
                }
                else if (value > Capacity)
                {
                    Console.WriteLine("Content cannot exceed the capacity.");
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
                    if (Capacity == Content)
                    {
                        OnFull(EventArgs.Empty);
                    }
                }
                else
                {
                    // Console.WriteLine("This is overflown.");
                    _content = Capacity;

                    OnOverfloat(new AmountArgs(amount));
                }
            }
        }

        public virtual void OnOverflow(EventArgs e)
        {
            Overflow?.Invoke(this, e);
        }
        public virtual void OnFull(EventArgs e)
        {
            Full?.Invoke(this, e);
        }
        public virtual void OnOverfloat(AmountArgs e)
        {
            Overfloat?.Invoke(this, e);
        }
        }
    }