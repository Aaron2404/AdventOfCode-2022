var directory = AppContext.BaseDirectory.Split(Path.DirectorySeparatorChar);
var slice = new ArraySegment<string>(directory, 0, directory.Length - 4);
var path = Path.Combine(slice.ToArray());

IDictionary<string, int> Outcomes = new Dictionary<string, int>
{
    { "A X", 3 },
    { "A Y", 4 },
    { "A Z", 8 },
    { "B X", 1 },
    { "B Y", 5 },
    { "B Z", 9 },
    { "C X", 2 },
    { "C Y", 6 },
    { "C Z", 7 }
};


var lines = File.ReadAllLines(path + "./Puzzle.txt");
var sum = lines.Select(round => Outcomes[round]).Sum();
Console.WriteLine(sum);