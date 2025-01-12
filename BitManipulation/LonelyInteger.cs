namespace HackerRank.BitManipulation;

public class LonelyInteger
{

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