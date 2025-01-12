namespace HackerRank.Stacks;

public class TruckTour
{
    // for each station as a starting point verify if we can visit all stations in order
    // this uses a mod operator to 'circle' from end of array to beginning
    // can also use a queue by dequeue and enqueue item 
    public static int Solve(List<List<int>> gasStations)
    {
        var fuel = 0;
        var index = 0;
        var start = 0;
        
        while(index < gasStations.Count()) {
            fuel = fuel + gasStations[index][0] - gasStations[index][1];
            
            if (fuel < 0){
                start += 1;
                index = start;
                fuel = 0;
            }
            else {
                index += 1;
            }
        }
        
        return start;
    }
}