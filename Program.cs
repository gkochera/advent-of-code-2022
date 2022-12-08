// See https://aka.ms/new-console-template for more information
Console.WriteLine("Advent-Of-Code 2022 Runner");
Day2b program = new();
program.Run();

class Utility {
    public static List<string> LoadDataIntoArray(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        var array = new List<string>();
        foreach (var line in lines)
        {
            array.Add(line);
        }
        return array;
    }
}