namespace HackerRank.Algorithms;

public class IceCream
{
    public static List<int> Solve(int money, List<int> costs)
    {
        var result = new List<int>();
        for (var index = 0; result.Count == 0 && index < costs.Count; index++)
        {
            var currentCost = costs[index];
            var otherCost = (money - currentCost);
            var otherCostIndex = costs.Slice(index + 1, costs.Count - (index + 1)).IndexOf(otherCost);
            if (otherCostIndex == -1) continue;
            
            result.AddRange( [index + 1, otherCostIndex + index + 2 ]);
        }

        return result;
    }
}