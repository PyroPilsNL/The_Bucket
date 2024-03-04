// See https://aka.ms/new-console-template for more information

using The_Bucket;

Rainbarrel a = new Rainbarrel(Rainbarrel.CapacityOptions.large);
Console.WriteLine(a.Capacity);

Oilbarrel b = new Oilbarrel();
Console.WriteLine(b.Capacity);

Bucket c = new Bucket(12);
Console.WriteLine(c.Capacity);

Bucket d = new Bucket();
Console.WriteLine(d.Capacity);

d.Content = -1;
Console.WriteLine(d.Content);

d.Empty();
Console.WriteLine(d.Content);