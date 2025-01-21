namespace HackerRank.Algorithms;

public class MissingNumber
{
    public static int Solve(int[] a) {
        var uniqueNumbers = new HashSet<int>();
        foreach(var item in a) {
            if (item > 0)
                uniqueNumbers.Add(item);
        }

        var min = 1;
        for (var index = 1; index <= a.Length + 1; index++)
        {
            if (!uniqueNumbers.Contains(index))
            {
                return index;
            }
        }

        return min;
    }
}