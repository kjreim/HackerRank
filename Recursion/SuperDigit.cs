namespace HackerRank.Recursion;

public class SuperDigit
{
    // get sum of all digits in string repeat until only a single digit is left in sum
    public static int Solve(string n, int k)
    {
        if (n.Length == 1) return int.Parse(n) * k;
        long current = GetSum(n) * k;
        
        while(current > 9) {
            current = GetSum(current.ToString());
        }
        
        return Convert.ToInt32(current);
        
        long GetSum(string numbers) {
            long result = 0;
            foreach(var number in numbers) {
                result += (long) char.GetNumericValue(number);
            }
            return result;
        }
    }
}