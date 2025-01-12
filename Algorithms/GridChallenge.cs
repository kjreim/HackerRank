namespace HackerRank.Algorithms;

public class GridChallenge
{
    // check if rows can be arranged so that the columns going down are in alphabetical order
    public static string Solve(List<string> grid)
    {
        char[] columns = null;
        foreach (var row in grid)
        {
            var characters = row.ToList();
            characters.Sort();
            
            if (columns != null)
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    if (columns[i] > characters[i])
                    {
                        return "NO";
                    }
                }
            }
            
            columns = characters.ToArray();
        }
        
        return "YES";
    }
}