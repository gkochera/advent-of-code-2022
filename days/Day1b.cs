class Day1b {
    private int currentTotal = 0;
    private int[] maxTotals = {0, 0, 0};
    public void Run() {
        var numbers = Utility.LoadDataIntoArray("./inputs/Day1/Day1.txt");

        for (int j = 0; j < numbers.Count; j++)
        {
            if (string.IsNullOrEmpty(numbers[j]))
            {
                setMaxTotal();
            } 
            else 
            {
                currentTotal += Convert.ToInt32(numbers[j]);
            }
            if (j == numbers.Count - 1)
            {
                setMaxTotal();
            }
        };
        int max = 0;
        foreach (int m in maxTotals)
        {
            Console.WriteLine(m);
            max += m;
        }

        Console.WriteLine($"Sum of Largest 3: {max}");
    }

    private void setMaxTotal()
    {
        int limit = maxTotals.Count();
        for(int i = 0; i < limit; i++)
        {
            if (maxTotals[i] < currentTotal)
            {
                if (i < limit - 1)
                {
                    maxTotals[i+1] = maxTotals[i];
                }
                maxTotals[i] = currentTotal;
                break;
            }
        }
        currentTotal = 0;
    }
}