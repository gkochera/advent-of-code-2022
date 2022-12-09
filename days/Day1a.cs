class Day1a {
    public static void Run() {
        var lines = Utility.LoadFromFile("./inputs/Day1/Day1.txt");
        var numbers = Utility.ConvertToStringList(lines);
    
        var currentTotal = 0;
        var maxTotal = 0;

        numbers.ForEach(x => {
            if (string.IsNullOrEmpty(x))
            {
                if (currentTotal > maxTotal)
                {
                    maxTotal = currentTotal;
                }
                currentTotal = 0;
            } else {
                currentTotal += Convert.ToInt32(x);
            }
        });

        Console.WriteLine($"Largest Total: {maxTotal}");
    }
}