namespace HackerRank.Heap;

public class Command
{
    public int Type;
    public int Data;

    public static Command Create(string commandString)
    {
        var parts = commandString.Split(' ');
        var type = int.Parse(parts[0]);
        var data = parts.Length > 1 ? int.Parse(parts[1]) : -1;
        
        return new Command { Type = type, Data = data };
    }
}
public class MinHeap
{

    public static void Solve(List<Command> commands)
    {
        var minHeap = new PriorityQueue<int, int>();

        foreach (var command in commands)
        {
            switch (command.Type)
            {
                case 1:
                    minHeap.Enqueue(command.Data, command.Data);
                    break;
                case 2:
                    minHeap.Remove(command.Data, out var element, out var priority);
                    break;
                case 3:
                    var min = minHeap.Peek();
                    Console.WriteLine(min);
                    break;
            }
        }
    }

    // performance issue
    public static void SolveWithList(List<Command> commands)
    {
        var sorted = new SortedList<int, int>();
        foreach (var command in commands)
        {
            switch (command.Type)
            {
                case 1:
                    sorted.Add(command.Data, command.Data);
                    break;
                case 2:
                    sorted.Remove(command.Data);
                    break;
                case 3:
                    var min = sorted.First();
                    Console.WriteLine(min.Key);
                    break;
            }
        }
    }
}