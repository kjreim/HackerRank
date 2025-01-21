namespace HackerRank.Algorithms;

public class ArrayManipulation
{
    public static long Solve(int n, List<List<int>> queries)
    {
        var result = Enumerable.Repeat(0, n + 2).ToArray();
        long currentMax = 0;
        foreach(var query in queries) {
            var addition = query[2];
            var start = query[0];
            var end = query[1];
            result[start] += addition;
            result[end + 1] -= addition;
            
        }
        long runningTotal = 0;
        for(var index = 0; index <= n; index++){
            runningTotal += result[index];
            currentMax = Math.Max(currentMax, runningTotal);
        }
        return currentMax;
    }
}