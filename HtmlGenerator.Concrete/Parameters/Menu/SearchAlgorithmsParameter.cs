using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class SearchAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.SearchAlgorithms.Root;
        public string SubTitle => Title.SearchAlgorithms.Root;
    }
}