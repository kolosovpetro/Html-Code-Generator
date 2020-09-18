using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class ClassicalAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.ClassicalAlgorithms.Root;
        public string SubTitle => Title.ClassicalAlgorithms.Root;
    }
}