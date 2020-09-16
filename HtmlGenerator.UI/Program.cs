﻿using System;
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
            IEntity root = new MenuEntity(Path.MainRoot, Titles.MainTitle);

            // algorithms branch
            IEntity algorithms = new MenuEntity(Path.ClassicalAlgorithms.Root, Titles.ClassicalAlgorithms.Root);
            root.AddChild(algorithms);

            IEntity sieve = new PageEntity(Path.ClassicalAlgorithms.SieveOfEratosthenes,
                Titles.ClassicalAlgorithms.SieveOfEratosthenes,
                Snippet.ClassicalAlgorithms.SieveSource);
            algorithms.AddChild(sieve);

            IEntity euclideanGcd = new PageEntity(Path.ClassicalAlgorithms.EuclideanGcd,
                Titles.ClassicalAlgorithms.EuclideanGcd,
                Snippet.ClassicalAlgorithms.EuclideanGcd);
            algorithms.AddChild(euclideanGcd);

            IEntity kadaneAlgorithm =
                new PageEntity(Path.ClassicalAlgorithms.KadaneAlgorithms, Titles.ClassicalAlgorithms.KadaneAlgorithm,
                    Snippet.ClassicalAlgorithms.KadaneAlgorithm);
            algorithms.AddChild(kadaneAlgorithm);

            IEntity maximumSubarraySum = new PageEntity(Path.ClassicalAlgorithms.MaximumSubarraySum,
                Titles.ClassicalAlgorithms.MaximumSubarraySum,
                Snippet.ClassicalAlgorithms.MaximumSubarraySum);
            algorithms.AddChild(maximumSubarraySum);

            IEntity shuntingYard = new PageEntity(Path.ClassicalAlgorithms.ShuntingYard,
                Titles.ClassicalAlgorithms.ShuntingYard,
                Snippet.ClassicalAlgorithms.ShuntingYard);
            algorithms.AddChild(shuntingYard);

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

            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}