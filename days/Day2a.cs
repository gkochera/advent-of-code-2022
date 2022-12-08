
class Day2a {
    const string ROCK = "ROCK";
    const string PAPER = "PAPER";
    const string SCISSORS = "SCISSORS";
    private List<(string, string)> input = new();
    private string fileName = "./inputs/Day2/Example.txt";
    private int total = 0;

    private readonly Dictionary<string, string> THEM = new(){
        {"A", ROCK},
        {"B", PAPER},
        {"C", SCISSORS}
    };

    private readonly Dictionary<string, string> ME = new(){
        {"X", ROCK},
        {"Y", PAPER},
        {"Z", SCISSORS}
    };

    private readonly Dictionary<string, int> VALUES = new(){
        {ROCK, 1},
        {PAPER, 2},
        {SCISSORS, 3}
    };

    private enum STATUS {
        Win,
        Lose,
        Draw
    }

    private readonly Dictionary<STATUS, int> SCORES = new(){
        {STATUS.Lose, 0},
        {STATUS.Draw, 3},
        {STATUS.Win, 6}
    };


    public void Run() {
        Parse();
        input.ForEach(x => {
            (string them, string me) = x;
            them = THEM[them];
            me = ME[me];
            STATUS status = Solve(me, them);
            int score = GetScore(me, status);
            total += GetScore(me, status);
        });
        Console.WriteLine($"Total Score: {total}");
    }

    private void Parse()
    {
        string[] lines = File.ReadAllLines(fileName);
        List<(string, string)> array = new List<(string, string)>();
        foreach (var line in lines)
        {
            string[] values = line.Split(' ');
            array.Add((values[0], values[1]));
        }
        this.input = array;
    }

    private STATUS Solve(string me, string them)
    {
        if (me == them)
        {
            return STATUS.Draw;
        }
        if ((me == ROCK && them == SCISSORS) || (me == SCISSORS && them == PAPER) || (me == PAPER && them == ROCK))
        {
            return STATUS.Win;
        }
        return STATUS.Lose;
    }

    private int GetScore(string myChoice, STATUS outcome)
    {
        return VALUES[myChoice] + SCORES[outcome];
    }
}