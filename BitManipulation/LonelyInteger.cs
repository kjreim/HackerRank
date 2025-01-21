namespace HackerRank.BitManipulation;

public class LonelyInteger
{

    // assumes that there for (n - 1)/2 there is a matching pair
    // the last element is a single
    // the xor element will eventually give the result as adding 2 of the same resets
    public static int Solve(List<int> a)
    {
        int res = a[0];
        for (int i = 1; i < a.Count; i++)
        {
            res = res ^ a[i];
        }
        return res;
    }

    public static int SolveHashMap(List<int> a)
    {
        var robinson = new HashSet<int>();
        
        foreach(var item in a) {
            if (robinson.Contains(item))
                robinson.Remove(item);
            else
                robinson.Add(item);
        }
        
        return robinson.First();
    }
}