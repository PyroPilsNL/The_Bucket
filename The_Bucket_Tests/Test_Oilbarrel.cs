namespace The_Bucket_Tests;
using The_Bucket;

public class Test_Oilbarrel
{
    [TestCase(159)]
    public void OilBarrel_CheckForDefaultValue_159(int Expectedresult)
    {
        //Arrage
        Oilbarrel a = new Oilbarrel();

        //Act


        //assert
        Assert.That(a.Capacity,Is.EqualTo(Expectedresult));
    }

    [TestCase(0, -160)]
    [TestCase(0, -159)]
    [TestCase(1, -158)]
    public void OilBarrel_CheckForNegativeFill_RightAmount(int Expectedresult, int fill)
    {
        //Arrage
        Oilbarrel a = new Oilbarrel();

        //Act
        a.Fill(159);
        a.Fill(fill);

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }
    [TestCase(0)]
    public void Empty_CheckForEmpty_RightAmount(int Expectedresult)
    {
        //Arrage
        Oilbarrel a = new Oilbarrel();

        //Act
        a.Fill(159);
        a.Empty();

        //assert
        Assert.That(a.Content,Is.EqualTo(Expectedresult));
    }
}