var directory = AppContext.BaseDirectory.Split(Path.DirectorySeparatorChar);
var slice = new ArraySegment<string>(directory, 0, directory.Length - 4);
var path = Path.Combine(slice.ToArray());
var totalScore = 0;

IDictionary<string, int> priorities = new Dictionary<string, int>
{
    { "a", 1 },
    { "b", 2 },
    { "c", 3 },
    { "d", 4 },
    { "e", 5 },
    { "f", 6 },
    { "g", 7 },
    { "h", 8 },
    { "i", 9 },
    { "j", 10 },
    { "k", 11 },
    { "l", 12 },
    { "m", 13 },
    { "n", 14 },
    { "o", 15 },
    { "p", 16 },
    { "q", 17 },
    { "r", 18 },
    { "s", 19 },
    { "t", 20 },
    { "u", 21 },
    { "v", 22 },
    { "w", 23 },
    { "x", 24 },
    { "y", 25 },
    { "z", 26 }
};

foreach (var line in File.ReadLines(path + @"./Input.txt"))
{
    var firstCompartment = line.Substring(0, line.Length / 2);
    var secondCompartment = line.Substring(line.Length / 2, line.Length / 2);
    var commonValue = "";

    var common = firstCompartment.Intersect(secondCompartment);
    foreach (var commonvalue in common) commonValue = commonvalue.ToString();

    var a = priorities.Where(a => a.Key.Equals(commonValue));
    var c = priorities.Where(a => a.Key.ToUpper().Equals(commonValue));
    totalScore += a.Sum(value => value.Value);
    totalScore += c.Sum(value => value.Value + 26);
}
Console.WriteLine("Total score is: " + totalScore);