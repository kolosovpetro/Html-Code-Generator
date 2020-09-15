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
            IEntity root = new MenuEntity(Path.MainRoot);
            IEntity algorithms = new MenuEntity(Path.ClassicalAlgorithms.Root);
            IEntity dataStructures = new MenuEntity(Path.DataStructures.Root);

            root.AddChild(algorithms);
            algorithms.AddChild(dataStructures);

            root.Path.Should().Be(Path.MainRoot);
            algorithms.Path.Should().Be(Path.MainRoot + Path.ClassicalAlgorithms.Root);
            dataStructures.Path.Should().Be(Path.MainRoot + Path.ClassicalAlgorithms.Root + Path.DataStructures.Root);
        }
    }
}