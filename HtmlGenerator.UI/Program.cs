using System;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Concrete.ConcreteEntities;
using HtmlGenerator.Routes.Route;
using HtmlGenerator.Services.Concrete;
using Path = HtmlGenerator.Routes.Route.Path;

namespace HtmlGenerator.UI
{
    public static class Program
    {
        private static void Main()
        {
            // root
            IEntity root = new MenuEntity(Path.MainRoot, Titles.MainTitle);

            // classical algorithms branch
            IEntity classicalAlgorithms =
                new MenuEntity(Path.ClassicalAlgorithms.Root, Titles.ClassicalAlgorithms.Root);
            root.AddChild(classicalAlgorithms);

            IEntity sieve = new PageEntity(Path.ClassicalAlgorithms.SieveOfEratosthenes,
                Titles.ClassicalAlgorithms.SieveOfEratosthenes,
                Snippet.ClassicalAlgorithms.SieveSource);
            classicalAlgorithms.AddChild(sieve);

            IEntity euclideanGcd = new PageEntity(Path.ClassicalAlgorithms.EuclideanGcd,
                Titles.ClassicalAlgorithms.EuclideanGcd,
                Snippet.ClassicalAlgorithms.EuclideanGcd);
            classicalAlgorithms.AddChild(euclideanGcd);

            IEntity kadaneAlgorithm =
                new PageEntity(Path.ClassicalAlgorithms.KadaneAlgorithms, Titles.ClassicalAlgorithms.KadaneAlgorithm,
                    Snippet.ClassicalAlgorithms.KadaneAlgorithm);
            classicalAlgorithms.AddChild(kadaneAlgorithm);

            IEntity maximumSubarraySum = new PageEntity(Path.ClassicalAlgorithms.MaximumSubarraySum,
                Titles.ClassicalAlgorithms.MaximumSubarraySum,
                Snippet.ClassicalAlgorithms.MaximumSubarraySum);
            classicalAlgorithms.AddChild(maximumSubarraySum);

            IEntity shuntingYard = new PageEntity(Path.ClassicalAlgorithms.ShuntingYard,
                Titles.ClassicalAlgorithms.ShuntingYard,
                Snippet.ClassicalAlgorithms.ShuntingYard);
            classicalAlgorithms.AddChild(shuntingYard);

            // search algorithms branch
            IEntity searchAlgorithms = new MenuEntity(Path.SearchAlgorithms.Root, Titles.SortAlgorithms.RootTitle);
            root.AddChild(searchAlgorithms);

            IEntity simpleLinearSearch = new PageEntity(Path.SearchAlgorithms.SimpleLinearSearch,
                Titles.SearchAlgorithms.SimpleLinearSearch,
                Snippet.SearchAlgorithms.SimpleLinearSearch);
            searchAlgorithms.AddChild(simpleLinearSearch);

            IEntity improvedLinearSearch = new PageEntity(Path.SearchAlgorithms.ImproveLinearSearch,
                Titles.SearchAlgorithms.ImproveLinearSearch,
                Snippet.SearchAlgorithms.ImproveLinearSearch);
            searchAlgorithms.AddChild(improvedLinearSearch);

            IEntity improvedLinearSearchWithSentinel = new PageEntity(
                Path.SearchAlgorithms.ImproveLinearSearchWithSentinel,
                Titles.SearchAlgorithms.ImproveLinearSearchWithSentinel,
                Snippet.SearchAlgorithms.ImproveLinearSearchWithSentinel);
            searchAlgorithms.AddChild(improvedLinearSearchWithSentinel);

            IEntity binarySearch = new PageEntity(Path.SearchAlgorithms.BinarySearch,
                Titles.SearchAlgorithms.BinarySearch,
                Snippet.SearchAlgorithms.BinarySearch);
            searchAlgorithms.AddChild(binarySearch);


            // sort algorithms branch
            IEntity sortAlgorithms = new MenuEntity(Path.SortAlgorithms.Root, Titles.SortAlgorithms.RootTitle);
            root.AddChild(sortAlgorithms);

            IEntity bubbleSort = new PageEntity(Path.SortAlgorithms.BubbleSort, Titles.SortAlgorithms.BubbleSort,
                Snippet.SortAlgorithms.BubbleSort);
            sortAlgorithms.AddChild(bubbleSort);

            IEntity cocktailSort = new PageEntity(Path.SortAlgorithms.CocktailSort, Titles.SortAlgorithms.CocktailSort,
                Snippet.SortAlgorithms.CocktailSort);
            sortAlgorithms.AddChild(cocktailSort);

            IEntity insertionSort = new PageEntity(Path.SortAlgorithms.InsertionSort,
                Titles.SortAlgorithms.InsertionSort,
                Snippet.SortAlgorithms.InsertionSort);
            sortAlgorithms.AddChild(insertionSort);

            IEntity mergeSort = new PageEntity(Path.SortAlgorithms.MergeSort, Titles.SortAlgorithms.MergeSort,
                Snippet.SortAlgorithms.MergeSort);
            sortAlgorithms.AddChild(mergeSort);

            IEntity quickSort = new PageEntity(Path.SortAlgorithms.QuickSort, Titles.SortAlgorithms.QuickSort,
                Snippet.SortAlgorithms.QuickSort);
            sortAlgorithms.AddChild(quickSort);

            IEntity selectionSort = new PageEntity(Path.SortAlgorithms.SelectionSort,
                Titles.SortAlgorithms.SelectionSort,
                Snippet.SortAlgorithms.SelectionSort);
            sortAlgorithms.AddChild(selectionSort);

            // tree algorithms
            IEntity treeAlgorithms = new MenuEntity(Path.TreeAlgorithms.Root, Titles.TreeAlgorithms.RootTitle);
            root.AddChild(treeAlgorithms);

            // binary tree algorithms
            IEntity binaryTreeAlgorithms = new MenuEntity(Path.BtAlgorithms.Root, Titles.BtAlgorithms.RootTitle);
            treeAlgorithms.AddChild(binaryTreeAlgorithms);

            // concrete binary tree algorithms
            IEntity breadthFirstTree = new PageEntity(Path.BtAlgorithms.BreadthFirstIterative,
                Titles.BtAlgorithms.BreadthFirstIterative,
                Snippet.BtAlgorithms.BreadthFirstIterative);
            binaryTreeAlgorithms.AddChild(breadthFirstTree);

            IEntity inOrderIterative = new PageEntity(Path.BtAlgorithms.InOrderIterative,
                Titles.BtAlgorithms.InOrderIterative,
                Snippet.BtAlgorithms.InOrderIterative);
            binaryTreeAlgorithms.AddChild(inOrderIterative);

            IEntity inOrderRecursive = new PageEntity(Path.BtAlgorithms.InOrderRecursive,
                Titles.BtAlgorithms.InOrderRecursive,
                Snippet.BtAlgorithms.InOrderRecursive);
            binaryTreeAlgorithms.AddChild(inOrderRecursive);

            IEntity outOrderRecursive = new PageEntity(Path.BtAlgorithms.OutOrderRecursive,
                Titles.BtAlgorithms.OutOrderRecursive,
                Snippet.BtAlgorithms.OutOrderRecursive);
            binaryTreeAlgorithms.AddChild(outOrderRecursive);

            IEntity postOrderIterative = new PageEntity(Path.BtAlgorithms.PostOrderIterative,
                Titles.BtAlgorithms.PostOrderIterative,
                Snippet.BtAlgorithms.PostOrderIterative);
            binaryTreeAlgorithms.AddChild(postOrderIterative);

            IEntity postOrderRecursive = new PageEntity(Path.BtAlgorithms.PostOrderRecursive,
                Titles.BtAlgorithms.PostOrderRecursive,
                Snippet.BtAlgorithms.PostOrderRecursive);
            binaryTreeAlgorithms.AddChild(postOrderRecursive);

            IEntity preOrderIterative = new PageEntity(Path.BtAlgorithms.PreOrderIterative,
                Titles.BtAlgorithms.PreOrderIterative,
                Snippet.BtAlgorithms.PreOrderIterative);
            binaryTreeAlgorithms.AddChild(preOrderIterative);

            IEntity preOrderRecursive = new PageEntity(Path.BtAlgorithms.PreOrderRecursive,
                Titles.BtAlgorithms.PreOrderRecursive,
                Snippet.BtAlgorithms.PreOrderRecursive);
            binaryTreeAlgorithms.AddChild(preOrderRecursive);

            IEntity btDepth = new PageEntity(Path.BtAlgorithms.Depth,
                Titles.BtAlgorithms.Depth,
                Snippet.BtAlgorithms.Depth);
            binaryTreeAlgorithms.AddChild(btDepth);

            IEntity btHeight = new PageEntity(Path.BtAlgorithms.Height,
                Titles.BtAlgorithms.Height,
                Snippet.BtAlgorithms.Height);
            binaryTreeAlgorithms.AddChild(btHeight);

            // binary search tree algorithms
            IEntity bstAlgorithms = new MenuEntity(Path.BstAlgorithms.Root, Titles.BstAlgorithms.Root);
            treeAlgorithms.AddChild(bstAlgorithms);

            IEntity bstInsert = new PageEntity(Path.BstAlgorithms.Insert,
                Titles.BstAlgorithms.Insert,
                Snippet.BstAlgorithms.Insert);
            bstAlgorithms.AddChild(bstInsert);

            IEntity bstDelete = new PageEntity(Path.BstAlgorithms.Delete,
                Titles.BstAlgorithms.Delete,
                Snippet.BstAlgorithms.Delete);
            bstAlgorithms.AddChild(bstDelete);

            IEntity bstMax = new PageEntity(Path.BstAlgorithms.Max,
                Titles.BstAlgorithms.Max,
                Snippet.BstAlgorithms.Max);
            bstAlgorithms.AddChild(bstMax);

            IEntity bstMin = new PageEntity(Path.BstAlgorithms.Min,
                Titles.BstAlgorithms.Min,
                Snippet.BstAlgorithms.Min);
            bstAlgorithms.AddChild(bstMin);

            IEntity bstPredecessor = new PageEntity(Path.BstAlgorithms.Predecessor,
                Titles.BstAlgorithms.Predecessor,
                Snippet.BstAlgorithms.Predecessor);
            bstAlgorithms.AddChild(bstPredecessor);

            IEntity bstSearch = new PageEntity(Path.BstAlgorithms.Search,
                Titles.BstAlgorithms.Search,
                Snippet.BstAlgorithms.Search);
            bstAlgorithms.AddChild(bstSearch);

            IEntity bstSuccessor = new PageEntity(Path.BstAlgorithms.Successor,
                Titles.BstAlgorithms.Successor,
                Snippet.BstAlgorithms.Successor);
            bstAlgorithms.AddChild(bstSuccessor);

            IEntity bstTransplant = new PageEntity(Path.BstAlgorithms.Transplant,
                Titles.BstAlgorithms.Transplant,
                Snippet.BstAlgorithms.Transplant);
            bstAlgorithms.AddChild(bstTransplant);

            // heap algorithms
            IEntity heapAlgorithms = new MenuEntity(Path.HeapAlgorithms.Root, Titles.HeapAlgorithms.RootTitle);
            treeAlgorithms.AddChild(heapAlgorithms);

            IEntity heapPush = new PageEntity(Path.HeapAlgorithms.HeapPush,
                Titles.HeapAlgorithms.HeapPush,
                Snippet.HeapAlgorithms.HeapPush);
            heapAlgorithms.AddChild(heapPush);

            IEntity heapPop = new PageEntity(Path.HeapAlgorithms.HeapPop,
                Titles.HeapAlgorithms.HeapPop,
                Snippet.HeapAlgorithms.HeapPop);
            heapAlgorithms.AddChild(heapPop);

            IEntity heapCalculateUp = new PageEntity(Path.HeapAlgorithms.HeapCalculateUp,
                Titles.HeapAlgorithms.HeapCalculateUp,
                Snippet.HeapAlgorithms.HeapCalculateUp);
            heapAlgorithms.AddChild(heapCalculateUp);

            IEntity heapCalculateDown = new PageEntity(Path.HeapAlgorithms.HeapCalculateDown,
                Titles.HeapAlgorithms.HeapCalculateDown,
                Snippet.HeapAlgorithms.HeapCalculateDown);
            heapAlgorithms.AddChild(heapCalculateDown);

            IEntity floydHeapify = new PageEntity(Path.HeapAlgorithms.FloydAlgorithm,
                Titles.HeapAlgorithms.FloydAlgorithm,
                Snippet.HeapAlgorithms.FloydAlgorithm);
            heapAlgorithms.AddChild(floydHeapify);

            IEntity heapSort = new PageEntity(Path.HeapAlgorithms.HeapSort,
                Titles.HeapAlgorithms.HeapSort,
                Snippet.HeapAlgorithms.HeapSort);
            heapAlgorithms.AddChild(heapSort);

            // graph algorithms
            IEntity graphAlgorithms = new MenuEntity(Path.GraphAlgorithms.Root, Titles.GraphAlgorithms.RootTitle);
            root.AddChild(graphAlgorithms);

            IEntity graphBreadthFirst = new PageEntity(Path.GraphAlgorithms.BreadthFirst,
                Titles.GraphAlgorithms.BreadthFirst,
                Snippet.GraphAlgorithms.BreadthFirst);
            graphAlgorithms.AddChild(graphBreadthFirst);

            IEntity graphDepthFirstIterative = new PageEntity(Path.GraphAlgorithms.DepthFirstIterative,
                Titles.GraphAlgorithms.DepthFirstIterative,
                Snippet.GraphAlgorithms.DepthFirstIterative);
            graphAlgorithms.AddChild(graphDepthFirstIterative);

            IEntity graphDepthFirstRecursive = new PageEntity(Path.GraphAlgorithms.DepthFirstRecursive,
                Titles.GraphAlgorithms.DepthFirstRecursive,
                Snippet.GraphAlgorithms.DepthFirstRecursive);
            graphAlgorithms.AddChild(graphDepthFirstRecursive);

            IEntity dijkstraAlgorithm = new PageEntity(Path.GraphAlgorithms.DijkstraAlgorithm,
                Titles.GraphAlgorithms.DijkstraAlgorithm,
                Snippet.GraphAlgorithms.DijkstraAlgorithm);
            graphAlgorithms.AddChild(dijkstraAlgorithm);

            IEntity kahnAlgorithm = new PageEntity(Path.GraphAlgorithms.KahnAlgorithm,
                Titles.GraphAlgorithms.KahnAlgorithm,
                Snippet.GraphAlgorithms.KahnAlgorithm);
            graphAlgorithms.AddChild(kahnAlgorithm);

            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}