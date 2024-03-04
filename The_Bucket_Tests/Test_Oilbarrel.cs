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
}