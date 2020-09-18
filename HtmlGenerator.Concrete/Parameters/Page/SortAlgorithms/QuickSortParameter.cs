using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SortAlgorithms
{
    public class QuickSortParameter : IPageParameter
    {
        public string DirectoryName => Path.SortAlgorithms.QuickSort;
        public string SubTitle => Title.SortAlgorithms.QuickSort;
        public string SnippetPath => Snippet.SortAlgorithms.QuickSort;
        public string Description => Routes.Route.Description.SortAlgorithms.QuickSort;
    }
}