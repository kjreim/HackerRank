namespace HackerRank.Algorithms;

public class BalancedSums
{
    public static string Solve(List<int> items)
    {
        var total = items.Sum();
        var left = 0;
        foreach(var item in items) {
            if (left == total - item - left) {
                return "YES";
            } 
            left += item;
        }
        return "NO";
    }
    
}