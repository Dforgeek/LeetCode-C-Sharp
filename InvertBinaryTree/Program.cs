using System.Xml.Xsl;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        var newLeft = InvertTree(root.right);
        var newRight = InvertTree(root.left);

        root.left = newLeft;
        root.right = newRight;

        return root;
        
        
    }


    public static void Main()
    {
        TreeNode left = new TreeNode(2);
        left.right = new TreeNode(10);
        TreeNode right = new TreeNode(3);
        TreeNode head = new TreeNode(1, left, right);

        var answer = InvertTree(head);
        //int[] answer = new[] { head.val, head.left.val, head.right.val };
    }
}