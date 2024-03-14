// See https://aka.ms/new-console-template for more information

using The_Bucket;

Rainbarrel tank = new Rainbarrel(Rainbarrel.CapacityOptions.medium);
tank.Overflow += Container_Overflow;
tank.Full += Container_full;
tank.Overfloat += Container_overfloating;

tank.Fill(160); // This will cause overflow and trigger the event

static void Container_Overflow(object sender, EventArgs e)
{
    Console.WriteLine("(Event) Container overflowed!");
}

static void Container_full(object sender, EventArgs e)
{
    Console.WriteLine(" (Event) Container is fulled to the max!");
}
static void Container_overfloating(object sender, AmountArgs e)
{
    var a = sender as Container;
    Console.WriteLine("(Event) It will been overflown, do want that? Y/N");
    string userInput = Console.ReadLine();
    if (userInput != null && userInput.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase))
    {
        a.OnOverflow(EventArgs.Empty);
        int b = a.Content + e.Amount - (a.Capacity*2);
        Console.WriteLine($"(Event) Its overflown by: {b}");
    }
    else
    {
        a.OnFull(EventArgs.Empty);
    }
}
