namespace HackerRank.Algorithms;

public class TowerBreakers
{
    public static int Solve(int n, int m)
    {
        if (m == 1) return 2;
        var winner = n % 2;
        
        return winner == 0 ? 2 : 1;
    }
}