using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class TreeAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.TreeAlgorithms.Root;
        public string SubTitle => Title.TreeAlgorithms.Root;
    }
}