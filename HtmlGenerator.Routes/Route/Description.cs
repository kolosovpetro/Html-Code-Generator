namespace HtmlGenerator.Routes.Route
{
    public static class Description
    {
        public static class ClassicalAlgorithms
        {
            public const string SieveOfEratosthenes = "Generates primes up to given maximum.";
            public const string EuclideanGcd = "Finds GCD of two integers m and n.";

            public const string MaximumSubarraySum =
                "Finds maximum n-length subarray sum of given collection. Divide and Conquer.";

            public const string ClosestPairProblem = "Closest Pair Problem";
            public const string ShuntingYard = "Converts infix expression to postfix. Input: n-size infix string.";
            public const string KadaneAlgorithm = "Brutforce solution to the maximum sub-array problem.";
        }

        public static class DataStructures
        {
            public const string RootTitle = "Data Structures";
        }

        public static class HeapAlgorithms
        {
            public const string HeapPush = "Pushes new item to the heap.";
            public const string HeapPop = "Pops top element from the heap. Element is removed from the heap.";
            public const string HeapCalculateUp = "Re-heapifies the n-size heap from up.";
            public const string HeapCalculateDown = "Re-heapifies the n-size heap from down.";
            public const string FloydAlgorithm = "Re-heapifies the n-size heap in O(n) time.";
            public const string HeapSort = "Advanced sort algorithm. Complexity: O(nlogn).";
        }

        public static class BinaryTreeAlgorithms
        {
            public const string ExpressionTree =
                "Builds expression tree. Used in augmented calculators and compilers.";
            
            public const string PreOrderRecursive =
                "Process node N, then process Left subtree, then process Right subtree.";

            public const string InOrderRecursive = "Process Left subtree first, then node N, then Right subtree.";
            public const string OutOrderRecursive = "Process Right subtree, then node N, then Left subtree.";
            public const string PostOrderRecursive = "Process Left subtree, then Right subtree, then node N.";

            public const string PreOrderIterative =
                "Process node N, then process Left subtree, then process Right subtree.";

            public const string InOrderIterative = "Process Left subtree first, then node N, then Right subtree.";
            public const string PostOrderIterative = "Process Left subtree, then Right subtree, then node N.";

            public const string BreadthFirstIterative =
                "Visit all nodes on the current level before processing next node.";

            public const string Height = "Returns the height of the tree.";
            public const string Depth = "Returns depth of current node.";
        }

        public static class BinarySearchTreeAlgorithms
        {
            public const string Insert = "Inserts new node to BST and gives pointer to it.";
            public const string Search = "Searches for particular node in BST.";
            public const string Delete = "Deletes node from bst.";
            public const string Max = "Returns node with max key.";
            public const string Min = "Returns node with min key.";
            public const string Successor = "Returns Sucessor of given node.";
            public const string Predecessor = "Returns Predecessor of given node.";
            public const string Transplant = "Auxiliary method used in BST Delete.";
        }

        public static class GraphAlgorithms
        {
            public const string DijkstraAlgorithm = "Single shortest patch algorithm finder.";
            public const string BreadthFirst = "Level order traversal of graph nodes.";
            public const string DepthFirstIterative = "Recursively traversals all graph nodes.";
            public const string DepthFirstRecursive = "Iterative traversal of all graph nodes.";
            public const string KahnAlgorithm = "Presents graph as a linear sequence of nodes. Graph must be acyclic.";
        }

        public static class SortAlgorithms
        {
            public const string BubbleSort = "Simple Sort Algorithm. Sorts sequence of integers.";
            public const string CocktailSort = "Simple Sort Algorithm. Sorts sequence of integers.";
            public const string InsertionSort = "Simple Sort Algorithm. Sorts sequence of integers.";
            public const string SelectionSort = "Simple Sort Algorithm. Sorts sequence of integers.";
            public const string MergeSort = "Advanced Sort Algorithm. Sorts sequence of integers.";
            public const string QuickSort = "Advanced Sort Algorithm. Sorts sequence of integers.";
        }

        public static class SearchAlgorithms
        {
            public const string SimpleLinearSearch =
                "Searches for particular value in integer sequence. Returns true if found, otherwise false.";

            public const string ImprovedLinearSearch =
                "Searches for particular value in integer sequence. Returns true if found, otherwise false.";

            public const string ImprovedLinearSearchWithSentinel =
                "Searches for particular value in integer sequence. Returns true if found, otherwise false.";

            public const string BinarySearch =
                "Searches for particular value in integer sequence. Returns true if found, otherwise false. Sequence must be sorted. Complexity O(logn).";
        }
    }
}