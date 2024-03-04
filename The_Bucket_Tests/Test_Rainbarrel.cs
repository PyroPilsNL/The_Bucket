using The_Bucket;

namespace The_Bucket_Tests;

public class Test_Rainbarrel
{
    [TestCase(80, Rainbarrel.CapacityOptions.small)]
    [TestCase(100, Rainbarrel.CapacityOptions.medium)]
    [TestCase(120, Rainbarrel.CapacityOptions.large)]
    public void Rainbarrel_CheckCapacityOptions_80_100_120(int Expectedresult, Rainbarrel.CapacityOptions options)
    {
        //Arrage
        Rainbarrel a = new Rainbarrel(options);

        //Act


        //assert
        Assert.That(a.Capacity,Is.EqualTo(Expectedresult));
    }


    [TestCase(10, 10)]
    [TestCase(100, 101)]
    [TestCase(99, 99)]
    public void Fill_CheckIfFilled_RightAmount(int Expectedresult, int fill)
    {
        //Arrage
        Rainbarrel a = new Rainbarrel(Rainbarrel.CapacityOptions.medium);

        //Act
        a.Fill(fill);

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }
}