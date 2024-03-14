using The_Bucket;

namespace The_Bucket_Tests;

public class Test_Bucket
{
    [TestCase(12)]
    public void Bucket_CheckForDefaultValue_12(int Expectedresult)
    {
        //Arrage
        Bucket a = new Bucket();

        //Act


        //assert
        Assert.That(a.Capacity,Is.EqualTo(Expectedresult));
    }

    [TestCase(12, 2500)]
    [TestCase(2499, 2499)]
    [TestCase(12, 2501)]
    public void Bucket_CheckForMaxValueLowerThen_2500(int Expectedresult, int capacity)
    {
        //Arrage
        Bucket a = new Bucket(capacity);

        //Act


        //assert
        Assert.That(a.Capacity,Is.EqualTo(Expectedresult));
    }

    [TestCase(12, 9)]
    [TestCase(10, 10)]
    public void Bucket_CheckForMinValueHigherThen_100(int Expectedresult, int capacity)
    {
        //Arrage
        Bucket a = new Bucket(capacity);

        //Act


        //assert
        Assert.That(a.Capacity,Is.EqualTo(Expectedresult));
    }

    [TestCase(12, 12)]
    [TestCase(12, 13)]
    [TestCase(11, 11)]
    public void Fill_CheckForPositiveFill_RightAmount(int Expectedresult, int fill)
    {
        //Arrage
        Bucket a = new Bucket();

        //Act
        a.Fill(fill);

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }

    [TestCase(0, -12)]
    [TestCase(0, -13)]
    [TestCase(1, -11)]
    public void Fill_CheckForNegativeFill_RightAmount(int Expectedresult, int fill)
    {
        //Arrage
        Bucket a = new Bucket();

        //Act
        a.Fill(12);
        a.Fill(fill);

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }

    [TestCase(0)]
    public void Empty_CheckForEmpty_RightAmount(int Expectedresult)
    {
        //Arrage
        Bucket a = new Bucket();

        //Act
        a.Fill(12);
        a.Empty();

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }

    [TestCase(10, 10, 20, 0)] // A= 0 / B = 20
    [TestCase(20, 10, 25, 5)] // A = 25 / B = 5
    [TestCase(25, 10, 25, 10)] // A = 25 / B = 10
    [TestCase(10, 30, 25, 10)] //A = 25 / B = 10
    public void FillBucketWithOtherBucket_CheckContentAfterFill(int contentA, int contentB, int expectedContentA, int expectedContentB)
    {
        // Arrange
        Bucket a = new Bucket(25);
        Bucket b = new Bucket(25);

        a.Fill(contentA); // 10
        b.Fill(contentB); // 30

        // Act
        a.FillBucketWithOtherBucket(b); //a = 25, b = 15

        // Assert
        Assert.That(a.Content, Is.EqualTo(expectedContentA));
        Assert.That(b.Content, Is.EqualTo(expectedContentB));
    }

    [Test]
    public void Bucket_Constructor_NegativeCapacity_ThrowsException()
    {
        // Arrange & Act & Assert
        Assert.Throws<NegativeNumberException>(() => new Bucket(-5));
    }
    [TestCase(12, 12, false)]
    [TestCase(12, 13, true)]
    [TestCase(12, 11, false)]
    public void OverflowTestEvent(int input, int amount, bool expectedResult)
    {
        bool tested = false;

        Bucket bucket = new Bucket(input);

        bucket.Overfloat += (o, e) =>
        {
            tested = true;
        };

        bucket.Fill(amount);

        Assert.AreEqual(expectedResult, tested);
    }

    [TestCase(12,12,true)]
    [TestCase(12,13,false)]
    [TestCase(12,11,false)]
    public void FulltestenEvent(int input, int amount, bool result)
    {
        bool tested = false;

        Bucket emmer = new Bucket(input);

        emmer.Full += (o, e) => tested = true;

        emmer.Fill(amount);

        Assert.AreEqual(result, tested);
    }


}