// See https://aka.ms/new-console-template for more information

using The_Bucket;

// Rainbarrel a = new Rainbarrel(Rainbarrel.CapacityOptions.large);
// Console.WriteLine(a.Capacity);

// Oilbarrel b = new Oilbarrel();
// Console.WriteLine(b.Capacity);
//
// b.Fill(159);
//
// b.Fill(-158);
// Console.WriteLine(b.Content);

// Bucket c = new Bucket(12);
// Console.WriteLine(c.Capacity);

// Bucket d = new Bucket(0);
// Console.WriteLine(d.Capacity);
//
// d.Content = 12;
// Console.WriteLine(d.Content);
//
// d.Empty();
// Console.WriteLine(d.Content);
//
// d.Fill(13);
// Console.WriteLine(d.Content);

Bucket e = new Bucket(25);
e.Fill(20);
Console.WriteLine(e.Content);
Bucket f = new Bucket(25);
f.Fill(10);
Console.WriteLine(f.Content);

Console.WriteLine("===========");

f.FillBucketWithOtherBucket(e);
Console.WriteLine(e.Content);
Console.WriteLine(f.Content);
