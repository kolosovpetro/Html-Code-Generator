using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SearchAlgorithms
{
    public class BinarySearch : IPageParameter
    {
        public string DirectoryName => Path.SearchAlgorithms.BinarySearch;
        public string SubTitle => Title.SearchAlgorithms.BinarySearch;
        public string SnippetPath => Snippet.SearchAlgorithms.BinarySearch;
        public string Description => Routes.Route.Description.SearchAlgorithms.BinarySearch;
    }
}