namespace The_Bucket;

public class Bucket : Container
{
    public Bucket() : this(12)
    {
    }

    public Bucket(int capacity)
    {
        if (capacity <= 10 || capacity >= 2500)
        {
            Console.WriteLine("Bucket is too large or too small! Pls select a number between 10 and 2500");
            Capacity = 12;
        }
        else
        {
            Capacity = capacity;
        }
    }
}