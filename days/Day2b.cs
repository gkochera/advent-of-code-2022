class Day2b {
    const string ROCK = "ROCK";
    const string PAPER = "PAPER";
    const string SCISSORS = "SCISSORS";
    private List<(string, string)> input = new();
    private string fileName = "./inputs/Day2/Day2.txt";
    private int total = 0;

    private enum STATUS {
    Win,
    Lose,
    Draw
    }

    private readonly Dictionary<string, string> THEM = new(){
        {"A", ROCK},
        {"B", PAPER},
        {"C", SCISSORS}
    };

    private readonly Dictionary<string, STATUS> ME = new(){
        {"X", STATUS.Lose},
        {"Y", STATUS.Draw},
        {"Z", STATUS.Win}
    };

    private readonly Dictionary<string, int> VALUES = new(){
        {ROCK, 1},
        {PAPER, 2},
        {SCISSORS, 3}
    };

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
            STATUS status = ME[me];
            total += GetScore(Solve(them, status), status);
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

    private string Solve(string them, STATUS status)
    {
        if (status == STATUS.Win)
        {
            if (them == SCISSORS)
            {
                return ROCK;
            }
            if (them == PAPER)
            {
                return SCISSORS;
            }
            if (them == ROCK)
            {
                return PAPER;
            }
        }
        if (status == STATUS.Lose)
        {
            if (them == SCISSORS)
            {
                return PAPER;
            }
            if (them == PAPER)
            {
                return ROCK;
            }
            if (them == ROCK)
            {
                return SCISSORS;
            }
        }
        return them;
    }

    private int GetScore(string myChoice, STATUS outcome)
    {
        return VALUES[myChoice] + SCORES[outcome];
    }
}