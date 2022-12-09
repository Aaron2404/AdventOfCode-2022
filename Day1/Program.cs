var directory = AppContext.BaseDirectory.Split(Path.DirectorySeparatorChar);
var slice = new ArraySegment<string>(directory, 0, directory.Length - 4);
var path = Path.Combine(slice.ToArray());
IDictionary<int, int> elves = new Dictionary<int, int>();
var count = 0;
var totalCalories = 0;

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

var first = elves.Values.Max();
var second = elves.Values.Where(x => x < first).Max();
var third = elves.Values.Where(x => x < second).Max();
var answer = first + second + third;


Console.WriteLine("Calories combined: " + answer);