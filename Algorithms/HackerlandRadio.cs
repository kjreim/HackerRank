namespace HackerRank.Algorithms;

public class HackerLandRadio
{

    public static int Solve(int distance, List<int> houses)
    {
        houses.Sort();
        var houseIndex = 0;
        var radios = 0;
        while (houseIndex < houses.Count)
        {
            radios++;
            var left = houses[houseIndex];
            var mid = left + distance;
            while(houseIndex < houses.Count && houses[houseIndex] <= mid)
                houseIndex++;
            // could use < on first while than don't have to - 1 on index for mid??
            mid = houses[houseIndex - 1];
            var right = mid + distance;
            while(houseIndex < houses.Count && houses[houseIndex] <= right)
                houseIndex++;
        }
        
        return radios;
    }
}