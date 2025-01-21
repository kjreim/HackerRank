namespace HackerRank.Algorithms;

public class FixedLength
{
    public static List<int> solve(List<int> arr, List<int> queries)
    {
        var result = new List<int>();
        foreach(var query in queries) {
            var maxes = GetMaxFromWindows(query, arr);
            var minOfMaxes = maxes.Min();
            result.Add(minOfMaxes);
        }
        return result;
    }

    private static int GetMinMax(List<int> items, int window)
    {
        var currentMax = items.Take(window).Max();

        for (var start = window + 1; start <= items.Count; start++)
        {
            var firstItemIndex = start - window;
            var dequeuedIndex = firstItemIndex - 1;
            if (items[dequeuedIndex] >= currentMax)
                currentMax = Math.Min(currentMax, items.Skip(firstItemIndex).Take(window).Max());
        }

        return currentMax;
    }
    
    // timing out
    private static List<int> GetMaxFromWindows(int size, List<int> values) {
        var window = new Queue<int>();
        var windowMax = -1;
        var index = 0;
        var result = new List<int>();
        while (window.Count < size) {
            windowMax = Math.Max(values[index], windowMax);
            window.Enqueue(values[index]);
            index++;
        }
        result.Add(windowMax);
        while(index < values.Count) {       
            var removed = window.Dequeue();
            window.Enqueue(values[index]);
            if (removed == windowMax)
            {
                windowMax = window.Max();
            }
            result.Add(windowMax);
            index++;
        }
        return result;
    }
}