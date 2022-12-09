var directory = AppContext.BaseDirectory.Split(Path.DirectorySeparatorChar);
var slice = new ArraySegment<string>(directory, 0, directory.Length - 4);
var path = Path.Combine(slice.ToArray());

IDictionary<string, int> Outcomes = new Dictionary<string, int>
{
    { "A X", 4 },
    { "A Y", 8 },
    { "A Z", 3 },
    { "B X", 1 },
    { "B Y", 5 },
    { "B Z", 9 },
    { "C X", 7 },
    { "C Y", 2 },
    { "C Z", 6 }
};
var lines = File.ReadAllLines(path + "./Puzzle.txt");
var sum = lines.Select(round => Outcomes[round]).Sum();
Console.WriteLine(sum);