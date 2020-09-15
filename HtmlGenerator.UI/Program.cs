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
            IEntity root = new MenuEntity(Path.MainRoot, Titles.Title);

            // algorithms branch
            IEntity algorithms = new MenuEntity(Path.ClassicalAlgorithms.Root, Titles.ClassicAlgorithms);
            root.AddChild(algorithms);

            IEntity sieve = new PageEntity(Path.ClassicalAlgorithms.SieveOfEratosthenes, Titles.SieveOfEratosthenes,
                Snippet.SieveSource);
            algorithms.AddChild(sieve);

            IEntity euclideanGcd = new PageEntity(Path.ClassicalAlgorithms.EuclideanGcd, Titles.EuclideanGcd,
                Snippet.EuclideanGcd);
            algorithms.AddChild(euclideanGcd);

            IEntity kadaneAlgorithm =
                new PageEntity(Path.ClassicalAlgorithms.KadaneAlgorithms, Titles.KadaneAlgorithm,
                    Snippet.KadaneAlgorithm);
            algorithms.AddChild(kadaneAlgorithm);

            IEntity maximumSubarraySum = new PageEntity(Path.ClassicalAlgorithms.MaximumSubarraySum,
                Titles.MaximumSubarraySum,
                Snippet.MaximumSubarraySum);
            algorithms.AddChild(maximumSubarraySum);

            IEntity shuntingYard = new PageEntity(Path.ClassicalAlgorithms.ShuntingYard, Titles.ShuntingYard,
                Snippet.ShuntingYard);
            algorithms.AddChild(shuntingYard);

            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");

            // 
        }
    }
}