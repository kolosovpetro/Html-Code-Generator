using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SortAlgorithms
{
    public class MergeSortParameter : IPageParameter
    {
        public string DirectoryName => Path.SortAlgorithms.MergeSort;
        public string SubTitle => Title.SortAlgorithms.MergeSort;
        public string SnippetPath => Snippet.SortAlgorithms.MergeSort;
        public string Description => Routes.Route.Description.SortAlgorithms.MergeSort;
    }
}