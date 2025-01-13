namespace HackerRank.Algorithms;

public class TextEditor
{
    // use a string builder while keeping track of cursor position
    // alternative is to use 2 stacks similar to how you would implement
    // a queue using 2 stacks. Moving the cursor would move items between
    // the 2 stacks.
    public static void Solve(List<string> commands)
    {
        foreach (var command in commands)
        {
            var operations = command.Split(' ');
            var type = operations[0];
            switch (type)
            {
                case "1" :
                    break;
                case "2" :
                    break;
                case "3" :
                    break;
                case "4" :
                    break;
            }
        }
    }
}