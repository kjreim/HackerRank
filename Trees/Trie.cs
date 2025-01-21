namespace HackerRank.Trees;

public class TrieNode
{
    public readonly TrieNode?[] Child = new TrieNode[27];
    public bool WordEnd = false;
}

public class Trie
{
    private readonly TrieNode _root = new TrieNode();

    private bool Insert(string word)
    {
        bool hasPrefix = false;
        bool isPrefix = true;
        
        var currentNode = _root;

        foreach (var character in word)
        {
            if (currentNode!.WordEnd) hasPrefix = true;
            
            var index  = character - 'a';
            if (currentNode.Child[index] == null)
            {
                currentNode.Child[index] = new TrieNode();
                isPrefix = false;   
            }
            
            currentNode = currentNode.Child[index];
        }

        currentNode!.WordEnd = true;

        return hasPrefix || isPrefix;
    }
    
    public static string Solve(List<string> words)
    {
        var trie = new Trie();
        
        foreach(var word in words) {
            var prefix = trie.Insert(word);
            
            if (prefix)
            {
                return "BAD SET";
            }
        }

        return "GOOD SET";
    }
}

