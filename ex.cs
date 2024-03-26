string line = "part1,part2,part3";
string[] parts = line.Split(',');

foreach (string part in parts)
{
    Console.WriteLine(part);
}
