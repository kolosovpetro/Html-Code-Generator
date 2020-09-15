using System;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Concrete.ConcreteEntities;
using Path = HtmlGenerator.Routes.Route.Path;

namespace HtmlGenerator.UI
{
    public static class Program
    {
        private static void Main()
        {
            IEntity root = new MenuEntity(Path.Root);
            IEntity algorithms = new MenuEntity(Path.ClassicAlgorithms);
            IEntity dataStructures = new MenuEntity(Path.DataStructures);

            root.AddChild(algorithms);
            algorithms.AddChild(dataStructures);
            root.Commit();
            Console.WriteLine("Folders are created");
        }
    }
}