namespace Games;

public class GameScorer
{
    public ScoreReport GenerateScoreReportFor(BowlingGame game)
    {
        // Winners, Losers, Average
        // To find the winners
        if(game.GetPlayers().Count == 1)
        {
            throw new InvalidGameException();
        }
        var players = game.GetPlayers();

        int highScore = players.Max(p => p.score);
        int lowScore = players.Min(p => p.score);

        return new ScoreReport
        {
            Winners = players.Where(p => p.score == highScore).ToList(),
            Losers = highScore == lowScore ? new() : players.Where(p => p.score == lowScore).ToList(),
            Average = players.Average(p => p.score)
        };
    }
}