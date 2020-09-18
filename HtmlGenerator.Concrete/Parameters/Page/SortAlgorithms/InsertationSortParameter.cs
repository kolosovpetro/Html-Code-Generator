using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SortAlgorithms
{
    public class InsertationSortParameter : IPageParameter
    {
        public string DirectoryName => Path.SortAlgorithms.InsertionSort;
        public string SubTitle => Title.SortAlgorithms.InsertionSort;
        public string SnippetPath => Snippet.SortAlgorithms.InsertionSort;
        public string Description => Routes.Route.Description.SortAlgorithms.InsertionSort;
    }
}