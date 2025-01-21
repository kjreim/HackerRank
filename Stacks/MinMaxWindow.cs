namespace HackerRank.Stacks;

public class MinMaxWindow
{

    public static long[] Solve(List<long> items)
    {
        items.Add(-1);
        int total = items.Count;
        int index = 0;
        var minimums = new long[items.Count - 1];
        var stack = new Stack<int>();

        while (index < total)
        {
            if (stack.Count == 0 || items[index] > items[stack.Peek()]) stack.Push(index++);
            else
            {
                long current = items[stack.Pop()];
                int len = stack.Count == 0 ? index : index - stack.Peek() - 1;
                var next = minimums[len - 1];
                minimums[len - 1] = Math.Max(current, minimums[len - 1]);
            }
        }

        for (var i = total - 3; i >= 0; i--)
        {
            minimums[i] = Math.Max(minimums[i], minimums[i + 1]);
        }
        
        return minimums;
    }
    
    // given a sublist of size k find the sublist that has the minimum differnce between the max and min of the sublist
    // sort the array so that the first and last elements of any sublist are the min and max respectively
    public static int maxMin(int k, List<int> arr)
    {
        arr.Sort();
        var size = arr.Count();
        var window = size - k;
        var best = int.MaxValue;
        for(var index = 0; index <= window; index++){
            var left = index;
            var right = k - 1 + index;
            var compare = arr[right] - arr[left];
            best = Math.Min(best, compare);
        }
        return best;
    }
}