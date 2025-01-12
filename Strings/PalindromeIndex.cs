namespace HackerRank.Strings;

public class PalindromeIndex
{
    public static int Solve(string s)
    {
        var start = 0;
        var end = s.Length - 1;

        while (start < end) {
            if (s[start] != s[end]) {
                if (IsPalindrome(start + 1, end)) return start;
                if (IsPalindrome(start, end - 1)) return end;
            }

            start += 1;
            end -= 1;
        }
        return -1;

        bool IsPalindrome(int start, int end) {

            while (start < end) {
                if (s[start] != s[end]) return false;
                start += 1;
                end -= 1;
            }

            return true;
        }
    }
}