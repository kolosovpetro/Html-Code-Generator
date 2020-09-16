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
            IEntity root = new MenuEntity(Path.Root, Title.Root);

            // classical algorithms branch
            IEntity classicalAlgorithms =
                new MenuEntity(Path.ClassicalAlgorithms.Root, Title.ClassicalAlgorithms.Root);
            root.AddChild(classicalAlgorithms);

            IEntity sieve = new PageEntity(Path.ClassicalAlgorithms.SieveOfEratosthenes,
                Title.ClassicalAlgorithms.SieveOfEratosthenes,
                Snippet.ClassicalAlgorithms.SieveSource);
            classicalAlgorithms.AddChild(sieve);

            IEntity euclideanGcd = new PageEntity(Path.ClassicalAlgorithms.EuclideanGcd,
                Title.ClassicalAlgorithms.EuclideanGcd,
                Snippet.ClassicalAlgorithms.EuclideanGcd);
            classicalAlgorithms.AddChild(euclideanGcd);

            IEntity kadaneAlgorithm =
                new PageEntity(Path.ClassicalAlgorithms.KadaneAlgorithms, Title.ClassicalAlgorithms.KadaneAlgorithm,
                    Snippet.ClassicalAlgorithms.KadaneAlgorithm);
            classicalAlgorithms.AddChild(kadaneAlgorithm);

            IEntity maximumSubarraySum = new PageEntity(Path.ClassicalAlgorithms.MaximumSubarraySum,
                Title.ClassicalAlgorithms.MaximumSubarraySum,
                Snippet.ClassicalAlgorithms.MaximumSubarraySum);
            classicalAlgorithms.AddChild(maximumSubarraySum);

            IEntity shuntingYard = new PageEntity(Path.ClassicalAlgorithms.ShuntingYard,
                Title.ClassicalAlgorithms.ShuntingYard,
                Snippet.ClassicalAlgorithms.ShuntingYard);
            classicalAlgorithms.AddChild(shuntingYard);

            // search algorithms branch
            IEntity searchAlgorithms = new MenuEntity(Path.SearchAlgorithms.Root, Title.SearchAlgorithms.Root);
            root.AddChild(searchAlgorithms);

            IEntity simpleLinearSearch = new PageEntity(Path.SearchAlgorithms.SimpleLinearSearch,
                Title.SearchAlgorithms.SimpleLinearSearch,
                Snippet.SearchAlgorithms.SimpleLinearSearch);
            searchAlgorithms.AddChild(simpleLinearSearch);

            IEntity improvedLinearSearch = new PageEntity(Path.SearchAlgorithms.ImproveLinearSearch,
                Title.SearchAlgorithms.ImproveLinearSearch,
                Snippet.SearchAlgorithms.ImproveLinearSearch);
            searchAlgorithms.AddChild(improvedLinearSearch);

            IEntity improvedLinearSearchWithSentinel = new PageEntity(
                Path.SearchAlgorithms.ImproveLinearSearchWithSentinel,
                Title.SearchAlgorithms.ImproveLinearSearchWithSentinel,
                Snippet.SearchAlgorithms.ImproveLinearSearchWithSentinel);
            searchAlgorithms.AddChild(improvedLinearSearchWithSentinel);

            IEntity binarySearch = new PageEntity(Path.SearchAlgorithms.BinarySearch,
                Title.SearchAlgorithms.BinarySearch,
                Snippet.SearchAlgorithms.BinarySearch);
            searchAlgorithms.AddChild(binarySearch);


            // sort algorithms branch
            IEntity sortAlgorithms = new MenuEntity(Path.SortAlgorithms.Root, Title.SortAlgorithms.Root);
            root.AddChild(sortAlgorithms);

            IEntity bubbleSort = new PageEntity(Path.SortAlgorithms.BubbleSort, Title.SortAlgorithms.BubbleSort,
                Snippet.SortAlgorithms.BubbleSort);
            sortAlgorithms.AddChild(bubbleSort);

            IEntity cocktailSort = new PageEntity(Path.SortAlgorithms.CocktailSort, Title.SortAlgorithms.CocktailSort,
                Snippet.SortAlgorithms.CocktailSort);
            sortAlgorithms.AddChild(cocktailSort);

            IEntity insertionSort = new PageEntity(Path.SortAlgorithms.InsertionSort,
                Title.SortAlgorithms.InsertionSort,
                Snippet.SortAlgorithms.InsertionSort);
            sortAlgorithms.AddChild(insertionSort);

            IEntity mergeSort = new PageEntity(Path.SortAlgorithms.MergeSort, Title.SortAlgorithms.MergeSort,
                Snippet.SortAlgorithms.MergeSort);
            sortAlgorithms.AddChild(mergeSort);

            IEntity quickSort = new PageEntity(Path.SortAlgorithms.QuickSort, Title.SortAlgorithms.QuickSort,
                Snippet.SortAlgorithms.QuickSort);
            sortAlgorithms.AddChild(quickSort);

            IEntity selectionSort = new PageEntity(Path.SortAlgorithms.SelectionSort,
                Title.SortAlgorithms.SelectionSort,
                Snippet.SortAlgorithms.SelectionSort);
            sortAlgorithms.AddChild(selectionSort);

            // tree algorithms
            IEntity treeAlgorithms = new MenuEntity(Path.TreeAlgorithms.Root, Title.TreeAlgorithms.Root);
            root.AddChild(treeAlgorithms);

            // binary tree algorithms
            IEntity binaryTreeAlgorithms = new MenuEntity(Path.BtAlgorithms.Root, Title.BtAlgorithms.Root);
            treeAlgorithms.AddChild(binaryTreeAlgorithms);

            // concrete binary tree algorithms
            IEntity breadthFirstTree = new PageEntity(Path.BtAlgorithms.BreadthFirstIterative,
                Title.BtAlgorithms.BreadthFirstIterative,
                Snippet.BtAlgorithms.BreadthFirstIterative);
            binaryTreeAlgorithms.AddChild(breadthFirstTree);

            IEntity inOrderIterative = new PageEntity(Path.BtAlgorithms.InOrderIterative,
                Title.BtAlgorithms.InOrderIterative,
                Snippet.BtAlgorithms.InOrderIterative);
            binaryTreeAlgorithms.AddChild(inOrderIterative);

            IEntity inOrderRecursive = new PageEntity(Path.BtAlgorithms.InOrderRecursive,
                Title.BtAlgorithms.InOrderRecursive,
                Snippet.BtAlgorithms.InOrderRecursive);
            binaryTreeAlgorithms.AddChild(inOrderRecursive);

            IEntity outOrderRecursive = new PageEntity(Path.BtAlgorithms.OutOrderRecursive,
                Title.BtAlgorithms.OutOrderRecursive,
                Snippet.BtAlgorithms.OutOrderRecursive);
            binaryTreeAlgorithms.AddChild(outOrderRecursive);

            IEntity postOrderIterative = new PageEntity(Path.BtAlgorithms.PostOrderIterative,
                Title.BtAlgorithms.PostOrderIterative,
                Snippet.BtAlgorithms.PostOrderIterative);
            binaryTreeAlgorithms.AddChild(postOrderIterative);

            IEntity postOrderRecursive = new PageEntity(Path.BtAlgorithms.PostOrderRecursive,
                Title.BtAlgorithms.PostOrderRecursive,
                Snippet.BtAlgorithms.PostOrderRecursive);
            binaryTreeAlgorithms.AddChild(postOrderRecursive);

            IEntity preOrderIterative = new PageEntity(Path.BtAlgorithms.PreOrderIterative,
                Title.BtAlgorithms.PreOrderIterative,
                Snippet.BtAlgorithms.PreOrderIterative);
            binaryTreeAlgorithms.AddChild(preOrderIterative);

            IEntity preOrderRecursive = new PageEntity(Path.BtAlgorithms.PreOrderRecursive,
                Title.BtAlgorithms.PreOrderRecursive,
                Snippet.BtAlgorithms.PreOrderRecursive);
            binaryTreeAlgorithms.AddChild(preOrderRecursive);

            IEntity btDepth = new PageEntity(Path.BtAlgorithms.Depth,
                Title.BtAlgorithms.Depth,
                Snippet.BtAlgorithms.Depth);
            binaryTreeAlgorithms.AddChild(btDepth);

            IEntity btHeight = new PageEntity(Path.BtAlgorithms.Height,
                Title.BtAlgorithms.Height,
                Snippet.BtAlgorithms.Height);
            binaryTreeAlgorithms.AddChild(btHeight);

            // binary search tree algorithms
            IEntity bstAlgorithms = new MenuEntity(Path.BstAlgorithms.Root, Title.BstAlgorithms.Root);
            treeAlgorithms.AddChild(bstAlgorithms);

            IEntity bstInsert = new PageEntity(Path.BstAlgorithms.Insert,
                Title.BstAlgorithms.Insert,
                Snippet.BstAlgorithms.Insert);
            bstAlgorithms.AddChild(bstInsert);

            IEntity bstDelete = new PageEntity(Path.BstAlgorithms.Delete,
                Title.BstAlgorithms.Delete,
                Snippet.BstAlgorithms.Delete);
            bstAlgorithms.AddChild(bstDelete);

            IEntity bstMax = new PageEntity(Path.BstAlgorithms.Max,
                Title.BstAlgorithms.Max,
                Snippet.BstAlgorithms.Max);
            bstAlgorithms.AddChild(bstMax);

            IEntity bstMin = new PageEntity(Path.BstAlgorithms.Min,
                Title.BstAlgorithms.Min,
                Snippet.BstAlgorithms.Min);
            bstAlgorithms.AddChild(bstMin);

            IEntity bstPredecessor = new PageEntity(Path.BstAlgorithms.Predecessor,
                Title.BstAlgorithms.Predecessor,
                Snippet.BstAlgorithms.Predecessor);
            bstAlgorithms.AddChild(bstPredecessor);

            IEntity bstSearch = new PageEntity(Path.BstAlgorithms.Search,
                Title.BstAlgorithms.Search,
                Snippet.BstAlgorithms.Search);
            bstAlgorithms.AddChild(bstSearch);

            IEntity bstSuccessor = new PageEntity(Path.BstAlgorithms.Successor,
                Title.BstAlgorithms.Successor,
                Snippet.BstAlgorithms.Successor);
            bstAlgorithms.AddChild(bstSuccessor);

            IEntity bstTransplant = new PageEntity(Path.BstAlgorithms.Transplant,
                Title.BstAlgorithms.Transplant,
                Snippet.BstAlgorithms.Transplant);
            bstAlgorithms.AddChild(bstTransplant);

            // heap algorithms
            IEntity heapAlgorithms = new MenuEntity(Path.HeapAlgorithms.Root, Title.HeapAlgorithms.Root);
            treeAlgorithms.AddChild(heapAlgorithms);

            IEntity heapPush = new PageEntity(Path.HeapAlgorithms.HeapPush,
                Title.HeapAlgorithms.HeapPush,
                Snippet.HeapAlgorithms.HeapPush);
            heapAlgorithms.AddChild(heapPush);

            IEntity heapPop = new PageEntity(Path.HeapAlgorithms.HeapPop,
                Title.HeapAlgorithms.HeapPop,
                Snippet.HeapAlgorithms.HeapPop);
            heapAlgorithms.AddChild(heapPop);

            IEntity heapCalculateUp = new PageEntity(Path.HeapAlgorithms.HeapCalculateUp,
                Title.HeapAlgorithms.HeapCalculateUp,
                Snippet.HeapAlgorithms.HeapCalculateUp);
            heapAlgorithms.AddChild(heapCalculateUp);

            IEntity heapCalculateDown = new PageEntity(Path.HeapAlgorithms.HeapCalculateDown,
                Title.HeapAlgorithms.HeapCalculateDown,
                Snippet.HeapAlgorithms.HeapCalculateDown);
            heapAlgorithms.AddChild(heapCalculateDown);

            IEntity floydHeapify = new PageEntity(Path.HeapAlgorithms.FloydAlgorithm,
                Title.HeapAlgorithms.FloydAlgorithm,
                Snippet.HeapAlgorithms.FloydAlgorithm);
            heapAlgorithms.AddChild(floydHeapify);

            IEntity heapSort = new PageEntity(Path.HeapAlgorithms.HeapSort,
                Title.HeapAlgorithms.HeapSort,
                Snippet.HeapAlgorithms.HeapSort);
            heapAlgorithms.AddChild(heapSort);

            // graph algorithms
            IEntity graphAlgorithms = new MenuEntity(Path.GraphAlgorithms.Root, Title.GraphAlgorithms.Root);
            root.AddChild(graphAlgorithms);

            IEntity graphBreadthFirst = new PageEntity(Path.GraphAlgorithms.BreadthFirst,
                Title.GraphAlgorithms.BreadthFirst,
                Snippet.GraphAlgorithms.BreadthFirst);
            graphAlgorithms.AddChild(graphBreadthFirst);

            IEntity graphDepthFirstIterative = new PageEntity(Path.GraphAlgorithms.DepthFirstIterative,
                Title.GraphAlgorithms.DepthFirstIterative,
                Snippet.GraphAlgorithms.DepthFirstIterative);
            graphAlgorithms.AddChild(graphDepthFirstIterative);

            IEntity graphDepthFirstRecursive = new PageEntity(Path.GraphAlgorithms.DepthFirstRecursive,
                Title.GraphAlgorithms.DepthFirstRecursive,
                Snippet.GraphAlgorithms.DepthFirstRecursive);
            graphAlgorithms.AddChild(graphDepthFirstRecursive);

            IEntity dijkstraAlgorithm = new PageEntity(Path.GraphAlgorithms.DijkstraAlgorithm,
                Title.GraphAlgorithms.DijkstraAlgorithm,
                Snippet.GraphAlgorithms.DijkstraAlgorithm);
            graphAlgorithms.AddChild(dijkstraAlgorithm);

            IEntity kahnAlgorithm = new PageEntity(Path.GraphAlgorithms.KahnAlgorithm,
                Title.GraphAlgorithms.KahnAlgorithm,
                Snippet.GraphAlgorithms.KahnAlgorithm);
            graphAlgorithms.AddChild(kahnAlgorithm);

            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}