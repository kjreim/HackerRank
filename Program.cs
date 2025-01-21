// See https://aka.ms/new-console-template for more information

using HackerRank.Algorithms;
using HackerRank.Heap;
using HackerRank.LinkedList;
using HackerRank.Stacks;
using HackerRank.Trees;

// var start = new SinglyLinkedListNode(16)
// {
//     next = new SinglyLinkedListNode(13)
//     {
//         next = new SinglyLinkedListNode(1)
//         {
//             next = new SinglyLinkedListNode(7)
//         }
//     }   
// };
// var buildings = new int[] { -2, -3, -1, -4, -6 };
// var k = 1;
// var data = 5;
// var result = MaxSubArray.MaxSubarray(buildings.ToList());
//
// Console.WriteLine(result[0] + " : " + result[1]);

//
// int t = Convert.ToInt32(Console.ReadLine().Trim());
// var commands = new List<Command>();
// for (int tItr = 0; tItr < t; tItr++)
// {
//     var line = Console.ReadLine();
//     commands.Add(Command.Create(line));
// }
//
// MinHeap.Solve(commands);

// var input = new List<int>() { 176641, 818878, 590130,846132,359913,699520,974627,806346,343832,619769,760242,693331,832192,775549,353117,23950,496548,183204,971799,393071,727476,351337,811496,24595,417701,664960,745806,538176,230403,942316,21481,605695,598531,651683,558460,583357,530911,721611,308228,724620,429167,909353,330152,116815,986067,713467,906132,428600,927889,567272,647109,992614,747948,192884,879696,262543,782487,829272,470060,427956,751730,597177,870616,754791,421830,11676,425656,841955,693419,462693,245403,192649,750201,180732,17450,44723,527618,174579,515786,444844,210843,563425,809540,752036,608529,748313,667439,255643,387412,320353,704213,755272,267902,657989,651762,325654,582887,382501,715426,897450,};
// var q = new List<int>() { 2 };
// var result = FixedLength.solve(input, q);
// result.ForEach(Console.WriteLine);

var nodes = new TrieNode?[3];

nodes.ToList().ForEach(n =>
{
    if (n == null) Console.WriteLine("null");
    else Console.WriteLine(n);
});