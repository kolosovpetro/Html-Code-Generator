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
            
            IEntity sieve = new PageEntity(Path.SieveOfEratosthenes, Titles.SieveOfEratosthenes, Snippet.SieveSource);

            root.AddChild(algorithms);
            algorithms.AddChild(sieve);
            ConcreteService.CreateFiles(root);
            Console.WriteLine("Folders are created");
        }
    }
}