namespace HackerRank.Stacks;

public class Leaderboard
{
    internal class LeaderboardComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

    public static List<int> Solve(List<int> leaderboard, List<int> scores)
    {
        var uniqueScores = new SortedSet<int>(leaderboard, new LeaderboardComparer());
        var denseRankedLeaderboard = uniqueScores.ToList();
        var result = new List<int>();
        var index = denseRankedLeaderboard.Count - 1;

        foreach (var score in scores)
        {
            while (index >= 0 && score >= denseRankedLeaderboard[index])
                index--;
            result.Add(index + 2);
        }
        return result;
    }

    public static List<int> BinarySearchSolve(List<int> leaderboard, List<int> scores)
    {
        var uniqueScores = new SortedSet<int>(leaderboard, new LeaderboardComparer());
        var denseRankedLeaderboard = uniqueScores.ToList();

        return scores.Select(s => BinarySearch(denseRankedLeaderboard, s)).ToList();
    }

    private static int BinarySearch(List<int> denseRankedLeaderboard, int score)
    {
        var start = 0;
        var end = denseRankedLeaderboard.Count - 1;
        while (start <= end)
        {
            var midPoint = (start + end) / 2;
            
            if (denseRankedLeaderboard[midPoint] == score) return midPoint + 1;
            else if (score > denseRankedLeaderboard[midPoint]) end = midPoint - 1;
            else start = midPoint + 1;
        }

        return start + 1;
    }
}