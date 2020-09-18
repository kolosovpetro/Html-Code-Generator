using System;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Concrete.ConcreteEntities;
using HtmlGenerator.Concrete.Parameters.Menu;
using HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms;
<<<<<<< HEAD
using HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.SearchAlgorithms;
=======
using HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.SearchAlgorithms;
>>>>>>> 7946357252483518a3d7a2f631861eb965e9f975
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
            IEntity classicalAlgorithms = new MenuEntity(new ClassicalAlgorithmsParameter());
            root.AddChild(classicalAlgorithms);

            IEntity sieveOfEratosthenes = new PageEntity(new SieveOfEratosthenesParameter());
            IEntity euclideanGcd = new PageEntity(new EuclideanGcdParameter());
            IEntity kadaneAlgorithm = new PageEntity(new KadaneAlgorithmParameter());
            IEntity maximumSubarraySum = new PageEntity(new MaximumSubarraySumParameter());
            IEntity shuntingYard = new PageEntity(new ShuntingYardParameter());
            classicalAlgorithms.AddChildRange(sieveOfEratosthenes, euclideanGcd, kadaneAlgorithm,
                maximumSubarraySum, shuntingYard);

            // search algorithms branch
            IEntity searchAlgorithms = new MenuEntity(new SearchAlgorithmsParameter());
            root.AddChild(searchAlgorithms);

            IEntity simpleLinearSearch = new PageEntity(new SimpleLinearSearchParameter());
            IEntity improvedLinearSearch = new PageEntity(new ImprovedLinearSearchParameter());
            IEntity improvedLinearSearchWithSentinel = new PageEntity(new ImprovedLinearSearchWithSentinelParameter());
            IEntity binarySearch = new PageEntity(new BinarySearchParameter());
            searchAlgorithms.AddChildRange(simpleLinearSearch, improvedLinearSearch, improvedLinearSearchWithSentinel,
                binarySearch);

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
            IEntity expressionTree = new PageEntity(new BinaryExpressionTreeParameter());
            IEntity breadthFirstTree = new PageEntity(new BinaryTreeBreadthFirstSearchParameter());
            IEntity inOrderIterative = new PageEntity(new BinaryTreeInOrderIterativeParameter());
            IEntity inOrderRecursive = new PageEntity(new BinaryTreeInOrderRecursiveParameter());
            IEntity outOrderRecursive = new PageEntity(new BinaryTreeOutOrderRecursiveParameter());
            IEntity postOrderIterative = new PageEntity(new BinaryTreePostOrderIterativeParameter());
            IEntity postOrderRecursive = new PageEntity(new BinaryTreePostOrderRecursiveParameter());
            IEntity preOrderIterative = new PageEntity(new BinaryTreePreOrderIterativeParameter());
            IEntity preOrderRecursive = new PageEntity(new BinaryTreePreOrderRecursiveParameter());
            IEntity btDepth = new PageEntity(new BinaryTreeDepthParameter());
            IEntity btHeight = new PageEntity(new BinaryTreeHeightParameter());
            binaryTreeAlgorithms.AddChildRange(expressionTree, breadthFirstTree, inOrderIterative,
                inOrderRecursive, outOrderRecursive, postOrderIterative, postOrderRecursive, preOrderIterative,
                preOrderRecursive, btDepth, btHeight
            );

            // binary search tree algorithms
            IEntity bstAlgorithms = new MenuEntity(new BinarySearchTreeAlgorithmsParameter());
            IEntity bstInsert = new PageEntity(new BinarySearchTreeInsertParameter());
            IEntity bstDelete = new PageEntity(new BinarySearchTreeDeleteParameter());
            IEntity bstMax = new PageEntity(new BinarySearchTreeMaxParameter());
            IEntity bstMin = new PageEntity(new BinarySearchTreeMinParameter());
            IEntity bstSearch = new PageEntity(new BinarySearchTreeSearchParameter());
            IEntity bstSuccessor = new PageEntity(new BinarySearchTreeSuccessorParameter());
            IEntity bstTransplant = new PageEntity(new BinarySearchTreeTransplantParameter());
            bstAlgorithms.AddChildRange(bstInsert, bstDelete, bstMax, bstMin, bstSearch,
                bstSuccessor, bstTransplant);

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

            IEntity graphBreadthFirst = new PageEntity(new GraphBreadthFirstParameter());
            IEntity graphDepthFirstIterative = new PageEntity(new GraphDepthFirstIterativeParameter());
            IEntity graphDepthFirstRecursive = new PageEntity(new GraphDepthFirstRecursiveParameter());
            IEntity dijkstraAlgorithm = new PageEntity(new GraphDijkstraAlgorithmParameter());
            IEntity kahnAlgorithm = new PageEntity(new GraphKahnAlgorithmParameter());
            graphAlgorithms.AddChildRange(graphBreadthFirst, graphDepthFirstIterative, graphDepthFirstRecursive, dijkstraAlgorithm, kahnAlgorithm);
            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}