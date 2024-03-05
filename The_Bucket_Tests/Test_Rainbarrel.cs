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

    [TestCase(0, Rainbarrel.CapacityOptions.small, 80)]
    [TestCase(0, Rainbarrel.CapacityOptions.medium, 100)]
    [TestCase(0, Rainbarrel.CapacityOptions.large, 120)]
    public void Empty_CheckForEmpty_RightAmount(int Expectedresult, Rainbarrel.CapacityOptions options, int MaxFill)
    {
        //Arrage
        Rainbarrel a = new Rainbarrel(options);

        //Act
        a.Fill(MaxFill);
        a.Empty();

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }

    [TestCase(0, Rainbarrel.CapacityOptions.small, -80)]
    [TestCase(0, Rainbarrel.CapacityOptions.small, -81)]
    [TestCase(1, Rainbarrel.CapacityOptions.small, -79)]
    [TestCase(0, Rainbarrel.CapacityOptions.medium, -100)]
    [TestCase(0, Rainbarrel.CapacityOptions.medium, -101)]
    [TestCase(1, Rainbarrel.CapacityOptions.medium, -99)]
    [TestCase(0, Rainbarrel.CapacityOptions.large, -120)]
    [TestCase(0, Rainbarrel.CapacityOptions.large, -121)]
    [TestCase(1, Rainbarrel.CapacityOptions.large, -119)]
    public void OilBarrel_CheckForNegativeFill_RightAmount(int Expectedresult, Rainbarrel.CapacityOptions options, int NegativeFill)
    {
        //Arrage
        Rainbarrel a = new Rainbarrel(options);

        //Act
        a.Fill(159);
        a.Fill(NegativeFill);

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }
}
