namespace HackerRank.Stacks;

public class BlancedBrackets
{

    public static string Solve(string input)
    {
        var bracketDict = new Dictionary<char, char>()
        {
            {']', '['},
            {')', '('},
            {'}', '{'},
        };
        var bracketStack = new Stack<char>();

        foreach (var character in input)
        {
            var hasKey = bracketDict.ContainsKey(character);

            if (!hasKey)
            {
                bracketStack.Push(character);
                continue;
            }
            
            var hasPreviousBracket = bracketStack.TryPeek(out var previousBracket);
            if (hasKey && hasPreviousBracket && previousBracket != bracketDict[character])
                return "NO";

            if (hasKey && !hasPreviousBracket)
                return "NO";
            
            bracketStack.Pop();
        }

        return bracketStack.Any() ? "NO" : "YES";
    }
}