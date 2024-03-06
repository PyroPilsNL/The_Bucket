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

    [TestCase(25, 10, 10, 20, 0)]
    [TestCase(25, 20, 10, 20, 5)]
    [TestCase(25, 25, 10, 25, 10)]
    [TestCase(25, 10, 30, 10, 10)]
    public void FillBucketWithOtherBucket_CheckContentAfterFill(int capacityA, int contentA, int contentB, int expectedContentA, int expectedContentB)
    {
        // Arrange
        Bucket a = new Bucket(capacityA);
        Bucket b = new Bucket(25);

        a.Fill(contentA);
        b.Fill(contentB);

        // Act
        a.FillBucketWithOtherBucket(b);

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

}