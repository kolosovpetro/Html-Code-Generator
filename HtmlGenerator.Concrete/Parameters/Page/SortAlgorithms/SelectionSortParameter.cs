using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SortAlgorithms
{
    public class SelectionSortParameter : IPageParameter
    {
        public string DirectoryName => Path.SortAlgorithms.SelectionSort;
        public string SubTitle => Title.SortAlgorithms.SelectionSort;
        public string SnippetPath => Snippet.SortAlgorithms.SelectionSort;
        public string Description => Routes.Route.Description.SortAlgorithms.SelectionSort;
    }
}