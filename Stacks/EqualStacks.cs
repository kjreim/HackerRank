namespace HackerRank.Stacks;

public class EqualStacks
{

    public static int Solve(List<int> towerA, List<int> towerB, List<int> towerC)
    {
        var sumA = towerA.Sum();
        var sumB = towerB.Sum();
        var sumC = towerC.Sum();

        var aIndex = 0;
        var bIndex = 0;
        var cIndex = 0;

        while (!(sumA == sumB && sumB == sumC))
        {
            if (sumA > sumB || sumA > sumC)
            {
                sumA -= towerA[aIndex];
                aIndex++;
            }
            else if (sumB > sumA || sumB > sumC)
            {
                sumB -= towerB[bIndex];
                bIndex++;
            }
            else if (sumC > sumA || sumC > sumB)
            {
                sumC -= towerC[cIndex];
                cIndex++;
            }

            if (aIndex == towerA.Count || bIndex == towerB.Count || cIndex == towerC.Count)
                return 0;
        }

        return sumA;
    }
}