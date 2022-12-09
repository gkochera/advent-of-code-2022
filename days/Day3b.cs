public class Day3b : IDay
{
    int total = 0;
    public void Run()
    {
        var lines = Utility.LoadFromFile("./inputs/Day3/Day3.txt");
        var lineCount = lines.Count();

        for(int i = 0; i < lineCount - 2; i += 3)
        {
            char[] lineOne = lines[i].ToCharArray();
            char[] lineTwo = lines[i+1].ToCharArray();
            char[] lineThree = lines[i+2].ToCharArray();
            
            char common = FindCommonLetter(lineOne, lineTwo, lineThree);
            total += ScoreLetter(common);
        }
        
        Console.WriteLine($"Total: {total}");
    }

    private char FindCommonLetter(char[] first, char[] second, char[] third)
    {
        int firstLength = first.Count();
        int secondLength = second.Count();
        int thirdLength = third.Count();

        for (int i = 0; i < firstLength; i++)
        {
            for (int j = 0; j < secondLength; j++)
            {
                for (int k = 0; k < thirdLength; k++)
                {
                    if (first[i] == second[j] && second[j] == third[k])
                    {
                        return first[i];
                    }
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