namespace The_Bucket;

public class Bucket : Container
{
    public Bucket() : this(12)
    {
    }

    public Bucket(int capacity)
    {
        if (capacity < 10 || capacity >= 2500)
        {
            if (capacity < 0)
            {
                throw new NegativeNumberException("Cannot use Negative Numbers");
            }
            Console.WriteLine("Bucket is too large or too small! Pls select a number between 10 and 2500");
            Capacity = 12;
        }
        else
        {
            Capacity = capacity;
        }
    }

    public void FillBucketWithOtherBucket(Bucket otherBucket)
    {
        int spaceLeft = Capacity - Content;

        if (spaceLeft <= 0)
        {
            Console.WriteLine("This bucket is already full.");
            return;
        }

        if (otherBucket.Content <= spaceLeft)
        {
            Content += otherBucket.Content;
            otherBucket.Empty();
            Console.WriteLine("Filled this bucket with the content of the other bucket.");
        }
        else
        {
            Content = Capacity;
            int remainingContent = otherBucket.Content - spaceLeft;
            otherBucket.Content = remainingContent;
            Console.WriteLine("Filled this bucket to its capacity with the content of the other bucket. Leftover content in other bucket.");
        }
    }
}