namespace HtmlGenerator.Routes.Route
{
    public static class Snippet
    {
        public static class ClassicalAlgorithms
        {
            public const string SieveSource =
                Path.MainRoot + "snippet_source/classical_algorithms/sieve_of_eratosthenes.txt";

            public const string EuclideanGcd = Path.MainRoot + "snippet_source/classical_algorithms/euclidean_gcd.txt";

            public const string MaximumSubarraySum =
                Path.MainRoot + "snippet_source/classical_algorithms/maximum_subarray_sum.txt";

            public const string ShuntingYard = Path.MainRoot + "snippet_source/classical_algorithms/shunting_yard.txt";

            public const string KadaneAlgorithm =
                Path.MainRoot + "snippet_source/classical_algorithms/kadane_algorithm.txt";
        }

        public static class GraphAlgorithms
        {
            public const string DijkstraAlgorithm =
                Path.MainRoot + "snippet_source/graph_algorithms/dijkstra_algorithm.txt";

            public const string BreadthFirst =
                Path.MainRoot + "snippet_source/graph_algorithms/breadth_first_iterative.txt";

            public const string DepthFirstIterative =
                Path.MainRoot + "snippet_source/graph_algorithms/depth_first_iterative.txt";

            public const string DepthFirstRecursive =
                Path.MainRoot + "snippet_source/graph_algorithms/depth_first_recursive.txt";

            public const string KahnAlgorithm =
                Path.MainRoot + "snippet_source/graph_algorithms/kahn_algorithm.txt";
        }
        
        public static class SortAlgorithms
        {
            public const string BubbleSort =
                Path.MainRoot + "snippet_source/sort_algorithms/bubble_sort.txt";

            public const string CocktailSort =
                Path.MainRoot + "snippet_source/sort_algorithms/cocktail_sort.txt";

            public const string InsertionSort =
                Path.MainRoot + "snippet_source/sort_algorithms/insertion_sort.txt";

            public const string MergeSort =
                Path.MainRoot + "snippet_source/sort_algorithms/merge_sort.txt";

            public const string QuickSort =
                Path.MainRoot + "snippet_source/sort_algorithms/quick_sort.txt";
            
            public const string SelectionSort =
                Path.MainRoot + "snippet_source/sort_algorithms/selection_sort.txt";
        }
    }
}