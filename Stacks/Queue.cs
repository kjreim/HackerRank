namespace HackerRank.Stacks;

public class Queue
{
    // the left stack always takes in the new elements
    // when we get a pop or print we first check to see if right has any if so we pop/peek
    // else we push the left stack onto the right stack
    // this reverses the order which effectively becomes a queue
    // we pop/peek from the right stack until it is empty 
    public static void Solve(List<string> commands)
    {
        var leftStack = new Stack<string>();
        var rightStack = new Stack<string>();

        foreach (var command in commands)
        {
            var commandQuery = command.Split(' ');
            var type = commandQuery[0];
            switch (type)
            {
                case "1":
                    var item = commandQuery[1];
                    leftStack.Push(item);
                    break;
                case "2":
                    if (rightStack.Count == 0)
                    {
                        while (leftStack.Count > 0) 
                        {
                            rightStack.Push(leftStack.Pop());
                        }
                    }

                    rightStack.Pop();
                    break;
                case "3":
                    if (rightStack.Count == 0)
                    {
                        while (leftStack.Count > 0) 
                        {
                            rightStack.Push(leftStack.Pop());
                        }
                    }
                    Console.WriteLine(rightStack.Peek());
                    break;
                default:
                    break;
            }
        }
    }
}