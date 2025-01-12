namespace HackerRank.Algorithms;

public class DiagonalDifference
{
    public static int Solve(List<List<int>> arr)
    {
        var leftToRight = 0;
        var rightToLeft = 0;
        
        var length = arr[0].Count();
        
        for(var index = 0; index < length; index++) {
            leftToRight += arr[index][index];
            
            var rightToLeftIndex = length - index - 1;
            rightToLeft += arr[index][rightToLeftIndex];
        }
        
        return Math.Abs(leftToRight - rightToLeft);
    }
}