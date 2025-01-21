namespace HackerRank.Algorithms;

public class SherlockString
{
    public static string Solve(string input)
    {
        if (input.Length < 2) return "YES";
        var frequencies = input.ToCharArray().GroupBy(c => c).Select(g => g.Count()).ToList();
        frequencies.Sort();
        
        var min = frequencies[0];
        var max = frequencies[^1];
        var nextMin = frequencies[1];
        var nextMax = frequencies[^2];

        if (min == max) return "YES";
        if (min + 1 == max && min == nextMax) return "YES";
        if (min == 1 && max == nextMin) return "YES";
        return "NO";
    }
    public static string isValid(string s)
    {
        var dict = s.ToArray().GroupBy(c => c).Select(g => g.Count())
            .GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());
            
        if (dict.Count() == 1)
        {
            return "YES";
        }
        if (dict.Count() > 2)
        {
            return "NO";
        }
        
        var firstCount = dict.Keys.First();
        var lastCount = dict.Keys.Last();
        
        if ((firstCount == 1 && dict[firstCount] == 1) || (lastCount == 1 && dict[lastCount] == 1))
        {
            return "YES";
        }
        
        if (Math.Abs(firstCount - lastCount) > 1)
        {
            return "NO";
        }
        
        if (firstCount > lastCount && dict[firstCount] > 1)
        {
            return "NO";
        }
        
        if (firstCount < lastCount && dict[lastCount] > 1)
        {
            return "NO";
        }

        return "YES";
    }
}