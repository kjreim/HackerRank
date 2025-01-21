namespace HackerRank.Stacks;

public class LargestRectangle
{

    public static int Solve(List<int> buildings)
    {
        var observedBuildings = new Stack<int>();
        var totalWidth = buildings.Count();
        var maxArea = int.MinValue;
        var area = 0;
        var rightmostBuilding = 0;

        for (var index = 0; index < totalWidth; index++)
        {
            // check if we have previous buildings and that the next building is smaller
            // if smaller calculate previous buildings area
            // else add building to previous and move to next building
            while (observedBuildings.Count > 0 && buildings[observedBuildings.Peek()] >= buildings[index])
            {
                rightmostBuilding = observedBuildings.Pop();

                // width is index if only 1 building in stack
                // each building has height > 0
                // else width = the index of the next building - observed building index - 1
                // - 
                int width = observedBuildings.Count() == 0
                    ? index
                    : index - observedBuildings.Peek() - 1;
                    // : index - buildingIndex;
                area = width * buildings[rightmostBuilding];
                maxArea = Math.Max(maxArea, area);
            }
            observedBuildings.Push(index);
        }

        while (observedBuildings.Count > 0)
        {
            rightmostBuilding = observedBuildings.Pop();
            var width = observedBuildings.Count() == 0 ? totalWidth : totalWidth - observedBuildings.Peek() - 1;
            area = buildings[rightmostBuilding] * width;
            maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}