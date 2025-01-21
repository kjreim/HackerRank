namespace HackerRank.Queue;

public class MinimumBribes
{
    // Replay the swaps checking if the person is in the original or is within the bribe limit
    public static void Solve(List<int> currentQ, int size)
    {
        var originalQueue = currentQ.Select((o, index) => index + 1).ToList();
        var totalBribes = 0;
        var chaotic = false;
        for(var index = 0; index < size && !chaotic; index++) {
            var currentPerson = currentQ[index];
            var originalPerson = originalQueue[index];
            
            if (currentPerson == originalPerson) continue;
            
            var nextPerson = index < size - 1 ? originalQueue[index + 1] : -1;
            var nextNextPerson = index < size - 2 ? originalQueue[index + 2] : -1;
            
            if (currentPerson == nextPerson) {
                originalQueue[index + 1] = originalPerson;
                originalQueue[index] = nextPerson;
                totalBribes += 1;
                continue;
            }
            
            if (currentPerson == nextNextPerson) {
                originalQueue[index + 2] = nextPerson;
                originalQueue[index + 1] = originalPerson;
                originalQueue[index] = nextNextPerson;
                totalBribes += 2;
                continue;
            }
            
            chaotic = true;
        }
        
        if (chaotic) Console.WriteLine("Too chaotic");
        else Console.WriteLine(totalBribes);
    }

    // todo: study
    public static void Solve2(List<int> currentQ, int size)
    {
        var totalBribes = 0;
        var last = currentQ[currentQ.Count() - 1];
        var chatoic = false;
        
        for(var index = currentQ.Count() - 2; !chatoic && index >= 0; index--) {
            if (currentQ[index] > index + 3) {
                chatoic = true;
                break;
            }
            
            if (currentQ[index] == index + 3)
                totalBribes += 2;
            else if (currentQ[index] > last)
                totalBribes++;
            else
                last = currentQ[index];
        }
        
        if (chatoic) Console.WriteLine("Too chaotic");
        else Console.WriteLine(totalBribes);
    }
}

