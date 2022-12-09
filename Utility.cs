public static class Utility 
{
    public static string[] LoadFromFile(string fileName)
    {
        return File.ReadAllLines(fileName);
    }

    public static List<string> ConvertToStringList(string[] lines)
    {
        var array = new List<string>();
        foreach (var line in lines)
        {
            array.Add(line);
        }
        return array;
    }
}