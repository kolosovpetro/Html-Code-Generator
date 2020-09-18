using System;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Concrete.ConcreteEntities;
using HtmlGenerator.Concrete.Parameters.Menu;
using HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms;
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
            IEntity root = new MenuEntity(new RootParameter());

            // classical algorithms branch
            IEntity classicalAlgorithms =
                new MenuEntity(new ClassicalAlgorithmsParameter());
            root.AddChild(classicalAlgorithms);

            IEntity sieveOfEratosthenes = new PageEntity(Path.ClassicalAlgorithms.SieveOfEratosthenes,
                Title.ClassicalAlgorithms.SieveOfEratosthenes,
                Snippet.ClassicalAlgorithms.SieveSource, Description.ClassicalAlgorithms.SieveOfEratosthenes);
            classicalAlgorithms.AddChild(sieveOfEratosthenes);

            IEntity euclideanGcd = new PageEntity(Path.ClassicalAlgorithms.EuclideanGcd,
                Title.ClassicalAlgorithms.EuclideanGcd,
                Snippet.ClassicalAlgorithms.EuclideanGcd, Description.ClassicalAlgorithms.EuclideanGcd);
            classicalAlgorithms.AddChild(euclideanGcd);

            IEntity kadaneAlgorithm =
                new PageEntity(Path.ClassicalAlgorithms.KadaneAlgorithms, Title.ClassicalAlgorithms.KadaneAlgorithm,
                    Snippet.ClassicalAlgorithms.KadaneAlgorithm, Description.ClassicalAlgorithms.KadaneAlgorithm);
            classicalAlgorithms.AddChild(kadaneAlgorithm);

            IEntity maximumSubarraySum = new PageEntity(Path.ClassicalAlgorithms.MaximumSubarraySum,
                Title.ClassicalAlgorithms.MaximumSubarraySum,
                Snippet.ClassicalAlgorithms.MaximumSubarraySum, Description.ClassicalAlgorithms.MaximumSubarraySum);
            classicalAlgorithms.AddChild(maximumSubarraySum);

            IEntity shuntingYard = new PageEntity(Path.ClassicalAlgorithms.ShuntingYard,
                Title.ClassicalAlgorithms.ShuntingYard,
                Snippet.ClassicalAlgorithms.ShuntingYard, Description.ClassicalAlgorithms.ShuntingYard);
            classicalAlgorithms.AddChild(shuntingYard);

            // search algorithms branch
            IEntity searchAlgorithms = new MenuEntity(new SearchAlgorithmsParameter());
            root.AddChild(searchAlgorithms);

            IEntity simpleLinearSearch = new PageEntity(Path.SearchAlgorithms.SimpleLinearSearch,
                Title.SearchAlgorithms.SimpleLinearSearch,
                Snippet.SearchAlgorithms.SimpleLinearSearch, Description.SearchAlgorithms.SimpleLinearSearch);
            searchAlgorithms.AddChild(simpleLinearSearch);

            IEntity improvedLinearSearch = new PageEntity(Path.SearchAlgorithms.ImproveLinearSearch,
                Title.SearchAlgorithms.ImproveLinearSearch,
                Snippet.SearchAlgorithms.ImproveLinearSearch, Description.SearchAlgorithms.ImproveLinearSearch);
            searchAlgorithms.AddChild(improvedLinearSearch);

            IEntity improvedLinearSearchWithSentinel = new PageEntity(
                Path.SearchAlgorithms.ImproveLinearSearchWithSentinel,
                Title.SearchAlgorithms.ImproveLinearSearchWithSentinel,
                Snippet.SearchAlgorithms.ImproveLinearSearchWithSentinel,
                Description.SearchAlgorithms.ImproveLinearSearchWithSentinel);
            searchAlgorithms.AddChild(improvedLinearSearchWithSentinel);

            IEntity binarySearch = new PageEntity(Path.SearchAlgorithms.BinarySearch,
                Title.SearchAlgorithms.BinarySearch,
                Snippet.SearchAlgorithms.BinarySearch, Description.SearchAlgorithms.BinarySearch);
            searchAlgorithms.AddChild(binarySearch);


            // sort algorithms branch
            IEntity sortAlgorithms = new MenuEntity(new SortAlgorithmsParameter());
            root.AddChild(sortAlgorithms);

            IEntity bubbleSort = new PageEntity(Path.SortAlgorithms.BubbleSort, Title.SortAlgorithms.BubbleSort,
                Snippet.SortAlgorithms.BubbleSort, Description.SortAlgorithms.BubbleSort);
            sortAlgorithms.AddChild(bubbleSort);

            IEntity cocktailSort = new PageEntity(Path.SortAlgorithms.CocktailSort, Title.SortAlgorithms.CocktailSort,
                Snippet.SortAlgorithms.CocktailSort, Description.SortAlgorithms.CocktailSort);
            sortAlgorithms.AddChild(cocktailSort);

            IEntity insertionSort = new PageEntity(Path.SortAlgorithms.InsertionSort,
                Title.SortAlgorithms.InsertionSort,
                Snippet.SortAlgorithms.InsertionSort, Description.SortAlgorithms.InsertionSort);
            sortAlgorithms.AddChild(insertionSort);

            IEntity mergeSort = new PageEntity(Path.SortAlgorithms.MergeSort, Title.SortAlgorithms.MergeSort,
                Snippet.SortAlgorithms.MergeSort, Description.SortAlgorithms.MergeSort);
            sortAlgorithms.AddChild(mergeSort);

            IEntity quickSort = new PageEntity(Path.SortAlgorithms.QuickSort, Title.SortAlgorithms.QuickSort,
                Snippet.SortAlgorithms.QuickSort, Description.SortAlgorithms.QuickSort);
            sortAlgorithms.AddChild(quickSort);

            IEntity selectionSort = new PageEntity(Path.SortAlgorithms.SelectionSort,
                Title.SortAlgorithms.SelectionSort,
                Snippet.SortAlgorithms.SelectionSort, Description.SortAlgorithms.SelectionSort);
            sortAlgorithms.AddChild(selectionSort);

            // tree algorithms
            IEntity treeAlgorithms = new MenuEntity(new TreeAlgorithmsParameter());
            root.AddChild(treeAlgorithms);

            // binary tree algorithms
            IEntity binaryTreeAlgorithms = new MenuEntity(new BinaryTreeAlgorithmsParameter());
            treeAlgorithms.AddChild(binaryTreeAlgorithms);

            // concrete binary tree algorithms
            IEntity expressionTree = new PageEntity(Path.BinaryTreeAlgorithms.ExpressionTree,
                Title.BtAlgorithms.ExpressionTree,
                Snippet.BtAlgorithms.ExpressionTree, Description.BinaryTreeAlgorithms.ExpressionTree);
            binaryTreeAlgorithms.AddChild(expressionTree);

            IEntity breadthFirstTree = new PageEntity(Path.BinaryTreeAlgorithms.BreadthFirstIterative,
                Title.BtAlgorithms.BreadthFirstIterative,
                Snippet.BtAlgorithms.BreadthFirstIterative, Description.BinaryTreeAlgorithms.BreadthFirstIterative);
            binaryTreeAlgorithms.AddChild(breadthFirstTree);

            IEntity inOrderIterative = new PageEntity(Path.BinaryTreeAlgorithms.InOrderIterative,
                Title.BtAlgorithms.InOrderIterative,
                Snippet.BtAlgorithms.InOrderIterative, Description.BinaryTreeAlgorithms.InOrderIterative);
            binaryTreeAlgorithms.AddChild(inOrderIterative);

            IEntity inOrderRecursive = new PageEntity(Path.BinaryTreeAlgorithms.InOrderRecursive,
                Title.BtAlgorithms.InOrderRecursive,
                Snippet.BtAlgorithms.InOrderRecursive, Description.BinaryTreeAlgorithms.InOrderRecursive);
            binaryTreeAlgorithms.AddChild(inOrderRecursive);

            IEntity outOrderRecursive = new PageEntity(Path.BinaryTreeAlgorithms.OutOrderRecursive,
                Title.BtAlgorithms.OutOrderRecursive,
                Snippet.BtAlgorithms.OutOrderRecursive, Description.BinaryTreeAlgorithms.OutOrderRecursive);
            binaryTreeAlgorithms.AddChild(outOrderRecursive);

            IEntity postOrderIterative = new PageEntity(Path.BinaryTreeAlgorithms.PostOrderIterative,
                Title.BtAlgorithms.PostOrderIterative,
                Snippet.BtAlgorithms.PostOrderIterative, Description.BinaryTreeAlgorithms.PostOrderIterative);
            binaryTreeAlgorithms.AddChild(postOrderIterative);

            IEntity postOrderRecursive = new PageEntity(Path.BinaryTreeAlgorithms.PostOrderRecursive,
                Title.BtAlgorithms.PostOrderRecursive,
                Snippet.BtAlgorithms.PostOrderRecursive, Description.BinaryTreeAlgorithms.PostOrderRecursive);
            binaryTreeAlgorithms.AddChild(postOrderRecursive);

            IEntity preOrderIterative = new PageEntity(Path.BinaryTreeAlgorithms.PreOrderIterative,
                Title.BtAlgorithms.PreOrderIterative,
                Snippet.BtAlgorithms.PreOrderIterative, Description.BinaryTreeAlgorithms.PreOrderIterative);
            binaryTreeAlgorithms.AddChild(preOrderIterative);

            IEntity preOrderRecursive = new PageEntity(Path.BinaryTreeAlgorithms.PreOrderRecursive,
                Title.BtAlgorithms.PreOrderRecursive,
                Snippet.BtAlgorithms.PreOrderRecursive, Description.BinaryTreeAlgorithms.PreOrderRecursive);
            binaryTreeAlgorithms.AddChild(preOrderRecursive);

            IEntity btDepth = new PageEntity(Path.BinaryTreeAlgorithms.Depth,
                Title.BtAlgorithms.Depth,
                Snippet.BtAlgorithms.Depth, Description.BinaryTreeAlgorithms.Depth);
            binaryTreeAlgorithms.AddChild(btDepth);

            IEntity btHeight = new PageEntity(Path.BinaryTreeAlgorithms.Height,
                Title.BtAlgorithms.Height,
                Snippet.BtAlgorithms.Height, Description.BinaryTreeAlgorithms.Height);
            binaryTreeAlgorithms.AddChild(btHeight);

            // binary search tree algorithms
            IEntity bstAlgorithms = new MenuEntity(new BinarySearchTreeAlgorithmsParameter());
            treeAlgorithms.AddChild(bstAlgorithms);

            IEntity bstInsert = new PageEntity(new BinarySearchTreeInsertParameter());
            bstAlgorithms.AddChild(bstInsert);

            IEntity bstDelete = new PageEntity(new BinarySearchTreeDeleteParameter());
            bstAlgorithms.AddChild(bstDelete);

            IEntity bstMax = new PageEntity(new BinarySearchTreeMaxParameter());
            bstAlgorithms.AddChild(bstMax);

            IEntity bstMin = new PageEntity(new BinarySearchTreeMinParameter());
            bstAlgorithms.AddChild(bstMin);

            IEntity bstSearch = new PageEntity(new BinarySearchTreeSearchParameter());
            bstAlgorithms.AddChild(bstSearch);

            IEntity bstSuccessor = new PageEntity(new BinarySearchTreeSuccessorParameter());
            bstAlgorithms.AddChild(bstSuccessor);

            IEntity bstTransplant = new PageEntity(new BinarySearchTreeTransplantParameter());
            bstAlgorithms.AddChild(bstTransplant);

            // heap algorithms
            IEntity heapAlgorithms = new MenuEntity(new HeapAlgorithmsParameter());
            treeAlgorithms.AddChild(heapAlgorithms);

            IEntity heapPush = new PageEntity(Path.HeapAlgorithms.HeapPush,
                Title.HeapAlgorithms.HeapPush,
                Snippet.HeapAlgorithms.HeapPush, Description.HeapAlgorithms.HeapPush);
            heapAlgorithms.AddChild(heapPush);

            IEntity heapPop = new PageEntity(Path.HeapAlgorithms.HeapPop,
                Title.HeapAlgorithms.HeapPop,
                Snippet.HeapAlgorithms.HeapPop, Description.HeapAlgorithms.HeapPop);
            heapAlgorithms.AddChild(heapPop);

            IEntity heapCalculateUp = new PageEntity(Path.HeapAlgorithms.HeapCalculateUp,
                Title.HeapAlgorithms.HeapCalculateUp,
                Snippet.HeapAlgorithms.HeapCalculateUp, Description.HeapAlgorithms.HeapCalculateUp);
            heapAlgorithms.AddChild(heapCalculateUp);

            IEntity heapCalculateDown = new PageEntity(Path.HeapAlgorithms.HeapCalculateDown,
                Title.HeapAlgorithms.HeapCalculateDown,
                Snippet.HeapAlgorithms.HeapCalculateDown, Description.HeapAlgorithms.HeapCalculateDown);
            heapAlgorithms.AddChild(heapCalculateDown);

            IEntity floydHeapify = new PageEntity(Path.HeapAlgorithms.FloydAlgorithm,
                Title.HeapAlgorithms.FloydAlgorithm,
                Snippet.HeapAlgorithms.FloydAlgorithm, Description.HeapAlgorithms.FloydAlgorithm);
            heapAlgorithms.AddChild(floydHeapify);

            IEntity heapSort = new PageEntity(Path.HeapAlgorithms.HeapSort,
                Title.HeapAlgorithms.HeapSort,
                Snippet.HeapAlgorithms.HeapSort, Description.HeapAlgorithms.HeapSort);
            heapAlgorithms.AddChild(heapSort);

            // graph algorithms
            IEntity graphAlgorithms = new MenuEntity(new GraphAlgorithmsParameter());
            root.AddChild(graphAlgorithms);

            IEntity graphBreadthFirst = new PageEntity(Path.GraphAlgorithms.BreadthFirst,
                Title.GraphAlgorithms.BreadthFirst,
                Snippet.GraphAlgorithms.BreadthFirst, Description.GraphAlgorithms.BreadthFirst);
            graphAlgorithms.AddChild(graphBreadthFirst);

            IEntity graphDepthFirstIterative = new PageEntity(Path.GraphAlgorithms.DepthFirstIterative,
                Title.GraphAlgorithms.DepthFirstIterative,
                Snippet.GraphAlgorithms.DepthFirstIterative, Description.GraphAlgorithms.DepthFirstIterative);
            graphAlgorithms.AddChild(graphDepthFirstIterative);

            IEntity graphDepthFirstRecursive = new PageEntity(Path.GraphAlgorithms.DepthFirstRecursive,
                Title.GraphAlgorithms.DepthFirstRecursive,
                Snippet.GraphAlgorithms.DepthFirstRecursive, Description.GraphAlgorithms.DepthFirstRecursive);
            graphAlgorithms.AddChild(graphDepthFirstRecursive);

            IEntity dijkstraAlgorithm = new PageEntity(Path.GraphAlgorithms.DijkstraAlgorithm,
                Title.GraphAlgorithms.DijkstraAlgorithm,
                Snippet.GraphAlgorithms.DijkstraAlgorithm, Description.GraphAlgorithms.DijkstraAlgorithm);
            graphAlgorithms.AddChild(dijkstraAlgorithm);

            IEntity kahnAlgorithm = new PageEntity(Path.GraphAlgorithms.KahnAlgorithm,
                Title.GraphAlgorithms.KahnAlgorithm,
                Snippet.GraphAlgorithms.KahnAlgorithm, Description.GraphAlgorithms.KahnAlgorithm);
            graphAlgorithms.AddChild(kahnAlgorithm);

            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}