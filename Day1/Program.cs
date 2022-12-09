var directory = AppContext.BaseDirectory.Split(Path.DirectorySeparatorChar);
var slice = new ArraySegment<string>(directory, 0, directory.Length - 4);
var path = Path.Combine(slice.ToArray());
IDictionary<int, int> elves = new Dictionary<int, int>();
var count = 0;
var totalCalories = 0;
var highest = 0;
var highestElf = 0;

foreach (var line in File.ReadLines(path + @"./Calories.txt"))
    if (line.Length == 0)
    {
        elves.Add(count, totalCalories);
        count++;
        totalCalories = 0;
    }
    else
    {
        var calories = int.Parse(line);
        totalCalories += calories;
    }

foreach (var (key, currentNumber) in elves)
{
    if (currentNumber > highest)
    {
        highest = currentNumber;
        highestElf = key;
    }
}

Console.WriteLine("{0} Has the the most calories with {1} calories", highestElf, highest);