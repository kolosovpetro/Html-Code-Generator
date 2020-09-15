using FluentAssertions;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Concrete.ConcreteEntities;
using HtmlGenerator.Routes.Route;
using NUnit.Framework;

namespace HtmlGenerator.Concrete.Tests.Tests
{
    [TestFixture]
    public class MenuEntityTests
    {
        public void Menu_Entity_Test()
        {
            IEntity root = new MenuEntity(Path.Root);
            IEntity algorithms = new MenuEntity(Path.ClassicAlgorithms);
            IEntity dataStructures = new MenuEntity(Path.DataStructures);

            root.AddChild(algorithms);
            algorithms.AddChild(dataStructures);

            root.Path.Should().Be(Path.Root);
            algorithms.Path.Should().Be(Path.Root + Path.ClassicAlgorithms);
            dataStructures.Path.Should().Be(Path.Root + Path.ClassicAlgorithms + Path.DataStructures);
        }
    }
}