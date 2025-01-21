namespace HackerRank.Heap;

public class Cookies
{
    
    public static int Solve(int minSweetness, List<int> cookies)
    {
        var queue = CreateCookieQueue(cookies);
        var combinations = 0; 
        while (queue.Count > 1 && queue.Peek() < minSweetness) {
            var cookie1 = queue.Dequeue();
            var cookie2 = queue.Dequeue();
            var combinedCookie = CombineCookies(cookie1, cookie2);
            queue.Enqueue(combinedCookie, combinedCookie);
            combinations++;
        }
        
        return queue.Peek() >= minSweetness ? combinations : -1;

        int CombineCookies(int one, int two)
        {
            return one + (2 * two);
        }
    }

    private static PriorityQueue<int, int> CreateCookieQueue(List<int> cookies)
    {
        var queue = new PriorityQueue<int, int>();
        foreach(var item in cookies) {
            queue.Enqueue(item, item);
        }

        return queue;
    }
}