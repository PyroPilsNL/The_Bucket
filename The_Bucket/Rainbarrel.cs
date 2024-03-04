namespace The_Bucket
{
    public class Rainbarrel : Container
    {
        public Rainbarrel(CapacityOptions capacityOption)
        {
            Capacity = (int)capacityOption;
        }

        public enum CapacityOptions
        {
            small = 80,
            medium = 100,
            large = 120
        }
    }
}