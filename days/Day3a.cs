public class Day3a : IDay
{
    int total = 0;
    public void Run()
    {
        var lines = Utility.LoadFromFile("./inputs/Day3/Day3.txt");
        foreach (var line in lines)
        {
            int length = line.Count();
            char[] firstHalf = line.Substring(0, (length / 2)).ToCharArray();
            char[] secondHalf = line.Substring(length / 2).ToCharArray();
            char common = FindCommonLetter(firstHalf, secondHalf);
            total += ScoreLetter(common);
        }
        Console.WriteLine($"Total: {total}");
    }

    private char FindCommonLetter(char[] first, char[] second)
    {
        int firstLength = first.Count();
        int secondLength = second.Count();

        for (int i = 0; i < firstLength; i++)
        {
            for (int j = 0; j < secondLength; j++)
            {
                if (first[i] == second[j])
                {
                    return first[i];
                }
            }
        }
        return '.';
    }

    private int ScoreLetter(char letter)
    {
        int value = (int)letter;
        if (97 <= value && value <= 122)
        {
            return value - 96;
        }
        if (65 <= value && value <= 90)
        {
            return value - 38;
        }
        return 0;
    }
}