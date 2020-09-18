using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class SortAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.SortAlgorithms.Root;
        public string SubTitle => Title.SortAlgorithms.Root;
    }
}