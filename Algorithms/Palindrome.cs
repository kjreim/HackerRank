namespace HackerRank.Algorithms;


public class Palindrome
{
    public static string Solve(string input, int inputLength, int changesAllowed)
    {
        var characters = input.ToCharArray();
        var misMatches = new List<(int, int)>();
        
        for (var index = 0; index < inputLength / 2; index++)
        {
            var right = inputLength - index - 1;
            if (characters[index] != characters[right])
                misMatches.Add((index, right));
        }

        if (misMatches.Count > changesAllowed) return "-1";


        foreach (var mismatch in misMatches)
        {
            characters[mismatch.Item1] = characters[mismatch.Item2] = (char) Math.Max(+characters[mismatch.Item1], +characters[mismatch.Item2]);
            changesAllowed--;
        }
        
        for (var index = 0; index < inputLength / 2; index++)
        {
            if (changesAllowed <= 0) break;

            if (characters[index] != '9')
            {
                var right = inputLength - index - 1;
                if (misMatches.Contains((index, right)))
                {
                    characters[index] = characters[right] =  '9';
                    changesAllowed -= 1;
                }
                else if (changesAllowed >= 2)
                {
                    characters[index] = characters[right] =  '9';
                    changesAllowed -= 2;
                }
            }
        }
        
        if (inputLength % 2 == 1 && changesAllowed == 1) characters[inputLength / 2] = '9';
        
        return new string(characters);
    }
}