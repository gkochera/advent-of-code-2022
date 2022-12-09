public class Day4a : IDay
{
    int total = 0;

    public void Run()
    {
        var lines = Utility.LoadFromFile("./inputs/Day4/Day4.txt");
        var lineCount = lines.Count();

        for (int i = 0; i < lineCount; i++)
        {
            string[] sections = lines[i].Split(',', 2);
            string s1; string s2;
            if (Convert.ToInt32(sections[0][0]) > Convert.ToInt32(sections[1][0]))
            {
                s1 = sections[1]; s2 = sections[0];
            }
            else
            {
                s1 = sections[0]; s2 = sections[1];
            }

            string[] t1 = s1.Split('-', 2);
            int n1 = Convert.ToInt32(t1[0]);
            int n2 = Convert.ToInt32(t1[1]);
            int z1 = n2 - n1 + 1;

            string[] t2 = s2.Split('-', 2);
            int n3 = Convert.ToInt32(t2[0]);
            int n4 = Convert.ToInt32(t2[1]);
            int z2 = n4 - n3 + 1;

            if ((z1 <= z2 && n1 >= n3 && n2 <= n4) || (z1 > z2 && n1 <= n3 && n4 <= n2))
            {
                total += 1;
            }

            Console.WriteLine($"s1: {s1}\t\ts2: {s2}\t\tn1: {n1}\t\tn2: {n2}\t\tz1: {z1}\t\tn3: {n3}\t\tn4: {n4}\t\tz2: {z2}\t\tSubset: {((z1 <= z2 && n1 >= n3 && n2 <= n4) || (z1 > z2 && n1 <= n3 && n4 <= n2))}");           
        }
        Console.WriteLine($"Total: {total}");
    }
}