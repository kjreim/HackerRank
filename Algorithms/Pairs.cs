namespace HackerRank.Algorithms;

public class Pairs
{
    // each item is both part of a pair and the result of another and k
    // meaning for each item in the array if we get difference between
    // itself and the total k and check if that is in our hashset then we have a pair
    public static int Solve(int k, List<int> arr)
    {
        var pairs = 0;
        var calculatedValues = new HashSet<int>(arr);
        foreach (var item in calculatedValues) {
            if (calculatedValues.Contains(item - k)) pairs++;
        }
        return pairs;
    }
}