using Xunit;

namespace InterviewQuestions.BinaryTree
{
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.Value == value)
                return true;

            if (value < root.Value)
                return Contains(root.Left, value);

            return Contains(root.Right, value);
        }
    }

    public class BinaryTreeTest
    {
        [Fact]
        public void Does_Tree_Contain()
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Assert.True(BinarySearchTree.Contains(n2, 3));
        }
    }
}
