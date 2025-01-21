namespace HackerRank.Stacks;

public class TwoStacks
{
    public static int Solve(int maxSum, List<int> towerA, List<int> towerB)
    {
        long total = 0;
        int indexB;
        var indexA = indexB = 0;
        while (indexA < towerA.Count && total + towerA[indexA] <= maxSum)
        {
            total += towerA[indexA];
            indexA++;
        }
        while (indexB < towerB.Count && total + towerB[indexB] <= maxSum)
        {
            total += towerB[indexB];
            indexB++;
        }
        var maxCount = indexA + indexB;
        while (indexA > 0 && indexB < towerB.Count)
        {
            indexA--;
            total -= towerA[indexA];
            while (indexB < towerB.Count && total + towerB[indexB] <= maxSum)
            {
                total += towerB[indexB];
                indexB++;
            }
            maxCount = Math.Max(maxCount, indexA + indexB);
        }
        return maxCount;
    }
}