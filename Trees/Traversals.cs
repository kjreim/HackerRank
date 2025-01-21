namespace HackerRank.Trees;

public class Node
{
    public int Data;
    public Node? Left;
    public Node? Right;
}

public class Traversals
{

    public static void InOrder(Node? root)
    {
        if (root == null) return;
        InOrder(root.Left);
        Console.WriteLine(root.Data + " ");
        InOrder(root.Right);
    }

    public static void PreOrder(Node? root)
    {
        if (root == null) return;
        
        Console.Write(root.Data + " ");
        PreOrder(root.Left);
        PreOrder(root.Right);
    }

    public static void PostOrder(Node? root)
    {
        if (root == null) return;
        PostOrder(root.Left);
        PostOrder(root.Right);
        Console.WriteLine(root.Data + " ");
    }

    public static void LevelOrder(Node? root)
    {
        if (root == null) return;
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            Console.Write(node.Data + " ");
            if (node.Left != null) queue.Enqueue(node.Left);
            if (node.Right != null) queue.Enqueue(node.Right);
        }
    }

    public static Node? GetLeastCommonAncestor(Node? root, int value1, int value2)
    {
        if (root == null) return null;
        
        if (root.Data == value1 || root.Data == value2) return root;
        
        var leftLca = GetLeastCommonAncestor(root.Left, value1, value2);
        var rightLca = GetLeastCommonAncestor(root.Right, value1, value2);

        if (leftLca != null && rightLca != null) return root;
        
        return leftLca ?? rightLca;
    }
}