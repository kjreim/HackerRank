namespace HackerRank.Algorithms;

public class CeaserCipher
{
    public static string Solve(string s, int k)
    {
        var result = string.Empty;
        
        foreach(char character in s) {
            result += Encode(character, k);
        }
        
        return result;

        char Encode(char c, int key) {
            if (!char.IsLetter(c)) return c;
            
            char start = char.IsUpper(c) ? 'A' : 'a';
            
            return (char) (((c + key - start) % 26) + start);
        }
    }
}