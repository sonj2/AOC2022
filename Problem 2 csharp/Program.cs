// See https://aka.ms/new-console-template for more information

var sr = new StreamReader("input.txt");
string? s = "";
List<int> values = new List<int>();
int roundscore = 0;
int totalscore = 0;
while ((s = sr.ReadLine()) != null)
{
    switch (s[0])
    {
        case 'A': // Rock
            switch (s[2])
            {
                case 'Y': // Paper
                    roundscore += 8; // 6 + 2
                    break;
                case 'X': // Rock
                    roundscore += 4; // 3 + 1
                    break;
                case 'Z': // Scissors
                    roundscore += 3; // 0 + 3
                    break;
            }
            totalscore += roundscore;
            break;
        case 'B': // Paper
            switch (s[2])
            {
                case 'Y': // Paper
                    roundscore += 5; // 3 + 2
                    break;
                case 'X': // Rock
                    roundscore += 1; // 0 + 1
                    break;
                case 'Z': // Scissors
                    roundscore += 9; // 6 + 3
                    break;
            }
            totalscore += roundscore;
            break;
        case 'C': // Scissors
            switch (s[2])
            {
                case 'Y': // Paper
                    roundscore += 2; // 0 + 2
                    break;
                case 'X': // Rock
                    roundscore += 7; // 6 + 1
                    break;
                case 'Z': // Scissors
                    roundscore += 6; // 3 + 3
                    break;
            }
            totalscore += roundscore;
            break;
    }
    roundscore = 0;
}
Console.WriteLine(totalscore);