namespace HackerRank.Algorithms;

public class MaxSubArray
{
    public static List<int> MaxSubarray(List<int> items)
    {
        var subSequenceMax = GetSubSequenceMax();
        
        var subArrayMax = int.MinValue;
        var current = 0;
        var hasPositive = false;
        var maxNegative = int.MinValue;
        foreach (var item in items)
        {
            current += item;
            if (current < 0) current = 0;
            subArrayMax = Math.Max(current, subArrayMax);

            if (item > 0) hasPositive = true;
            if (item < 0) maxNegative = Math.Max(item, maxNegative);
        }
        
        if (!hasPositive) subArrayMax = maxNegative;
        
        return [subArrayMax, subSequenceMax];

        int GetSubSequenceMax()
        {
            return items.Any(i => i > 0)
                ? items.Where(i => i > 0).Sum()
                : items.Max();
        }
    }
}