namespace HackerRank.Stacks;

public class GasStation
{
    public int Fuel;
    public int Distance;

    public static GasStation Create(List<int> station)
    {
        GasStation gs = new GasStation
        {
            Fuel = station[0],
            Distance = station[1]
        };
        return gs;
    }
}
public class TruckTour
{
    // for each station as a starting point verify if we can visit all stations in order
    // this uses a mod operator to 'circle' from end of array to beginning
    // can also use a queue by dequeue and enqueue item 
    // assumes there is a solution
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
    
    public static int SolveWithQueue(List<List<int>> gasStations)
    {
        var pumpsInOrder = QueuePumps();
        var stationsCount = gasStations.Count;

        for (var current = 1; current < stationsCount; current++)
        {
            var fuel = 0;
            foreach (var pump in pumpsInOrder)
            {
                fuel += pump.Fuel;
                fuel -= pump.Distance;
                if (fuel < 0) break;
            }

            if (fuel > 0) return current;

            var cycle = pumpsInOrder.Dequeue();
            pumpsInOrder.Enqueue(cycle);
        }
        // did not find a station
        return -1;
        
        Queue<GasStation> QueuePumps()
        {
            return new Queue<GasStation>(gasStations.Select(GasStation.Create));
        }
    }
    
}