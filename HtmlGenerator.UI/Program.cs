using System;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Concrete.ConcreteEntities;
using HtmlGenerator.Concrete.Parameters.Menu;
using HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.HeapAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.SearchAlgorithms;
using HtmlGenerator.Concrete.Parameters.Page.SortAlgorithms;
using HtmlGenerator.Services.Concrete;

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

            IEntity bubbleSort = new PageEntity(new BubbleSorParameter());
            IEntity cocktailSort = new PageEntity(new CocktailSortParameter());
            IEntity insertionSort = new PageEntity(new InsertationSortParameter());
            IEntity mergeSort = new PageEntity(new MergeSortParameter());
            IEntity quickSort = new PageEntity(new QuickSortParameter());
            IEntity selectionSort = new PageEntity(new SelectionSortParameter());
            sortAlgorithms.AddChildRange(bubbleSort, cocktailSort, insertionSort, mergeSort, quickSort, selectionSort);

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
            treeAlgorithms.AddChild(bstAlgorithms);
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

            IEntity heapPush = new PageEntity(new HeapPushParamter());
            IEntity heapPop = new PageEntity(new HeapPopParameter());
            IEntity heapCalculateUp = new PageEntity(new HeapCalculateUpParameter());
            IEntity heapCalculateDown = new PageEntity(new HeapCalculateDownParameter());
            IEntity floydHeapify = new PageEntity(new FloydHeapifyParameter());
            IEntity heapSort = new PageEntity(new HeapSortParameter());
            heapAlgorithms.AddChildRange(heapPush, heapPop, heapCalculateUp,
                heapCalculateDown, floydHeapify, heapSort);

            // graph algorithms
            IEntity graphAlgorithms = new MenuEntity(new GraphAlgorithmsParameter());
            root.AddChild(graphAlgorithms);

            IEntity graphBreadthFirst = new PageEntity(new GraphBreadthFirstParameter());
            IEntity graphDepthFirstIterative = new PageEntity(new GraphDepthFirstIterativeParameter());
            IEntity graphDepthFirstRecursive = new PageEntity(new GraphDepthFirstRecursiveParameter());
            IEntity dijkstraAlgorithm = new PageEntity(new GraphDijkstraAlgorithmParameter());
            IEntity kahnAlgorithm = new PageEntity(new GraphKahnAlgorithmParameter());
            graphAlgorithms.AddChildRange(graphBreadthFirst, graphDepthFirstIterative, graphDepthFirstRecursive, 
                dijkstraAlgorithm, kahnAlgorithm);
            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}