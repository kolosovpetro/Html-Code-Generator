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
            IEntity root = new MenuEntity(Path.Root, Titles.Title);
            IEntity algorithms = new MenuEntity(Path.ClassicAlgorithms, Titles.ClassicAlgorithms);
            root.AddChild(algorithms);
            
            // concrete algorithms
            IEntity sieve = new PageEntity(Path.SieveOfEratosthenes, Titles.SieveOfEratosthenes, Snippet.SieveSource);
            algorithms.AddChild(sieve);
            
            IEntity euclideanGcd = new PageEntity(Path.EuclideanGcd, Titles.EuclideanGcd, Snippet.EuclideanGcd);
            algorithms.AddChild(euclideanGcd);
            
            IEntity kadaneAlgorithm = new PageEntity(Path.KadaneAlgorithms, Titles.KadaneAlgorithm, Snippet.KadaneAlgorithm);
            algorithms.AddChild(kadaneAlgorithm);
            
            IEntity maximumSubarraySum = new PageEntity(Path.MaximumSubarraySum, Titles.MaximumSubarraySum, Snippet.MaximumSubarraySum);
            algorithms.AddChild(maximumSubarraySum);
            
            IEntity shuntingYard = new PageEntity(Path.ShuntingYard, Titles.ShuntingYard, Snippet.ShuntingYard);
            algorithms.AddChild(shuntingYard);
            
            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}