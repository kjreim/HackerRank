namespace HackerRank.Stacks;

public class LargestRectangle
{

    public static int Solve(List<int> buildings)
    {
        var smallerBuildings = new Stack<int>();
        var totalWidth = buildings.Count();
        var maxArea = int.MinValue;
        var area = 0;
        var leftmostBuilding = 0;

        for (var index = 0; index < totalWidth; index++)
        {
            // check if we have previous buildings and that the next building is smaller
            // if smaller calculate previous buildings area
            // else add building to previous and move to next building
            while (smallerBuildings.Count > 0 && buildings[smallerBuildings.Peek()] >= buildings[index])
            {
                leftmostBuilding = smallerBuildings.Pop();

                // width is 1 if only 1 building was in stack
                // else width = the index of the next building - observed building index - 1
                // - 
                int width = smallerBuildings.Count() == 0
                    ? index
                    : index - smallerBuildings.Peek() - 1;
                    // : index - buildingIndex;
                area = width * buildings[leftmostBuilding];
                maxArea = Math.Max(maxArea, area);
            }
            smallerBuildings.Push(index);
        }

        while (smallerBuildings.Count > 0)
        {
            leftmostBuilding = smallerBuildings.Pop();
            var width = smallerBuildings.Count() == 0 ? totalWidth : totalWidth - smallerBuildings.Peek() - 1;
            area = buildings[leftmostBuilding] * width;
            maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}