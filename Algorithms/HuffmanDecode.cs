namespace HackerRank.Algorithms;

public class CharNode {
    public char Data;
    public CharNode? Left;
    public CharNode? Right;
}

public class HuffmanDecode
{
    // word is encoded so that each character is encoded into bits and and tree is made
    // follow the bits until no leafs and that is the character restarting at the root 
    // until no bits left
    public static string Solve(string s, CharNode huffmanRoot)
    {
        var result = string.Empty;
        var currentNode = huffmanRoot;
        var subTree = huffmanRoot;
        foreach(var code in s.ToArray()) {
            if (code == '1') subTree = currentNode!.Right;
            else if (code == '0') subTree = currentNode!.Left;

            if (subTree!.Left == null && subTree.Right == null) {
                result += subTree.Data;
                subTree = huffmanRoot;
            }
        }

        return result;
    }
}