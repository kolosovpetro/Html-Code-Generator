using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class GraphAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.GraphAlgorithms.Root;
        public string SubTitle => Title.GraphAlgorithms.Root;
    }
}