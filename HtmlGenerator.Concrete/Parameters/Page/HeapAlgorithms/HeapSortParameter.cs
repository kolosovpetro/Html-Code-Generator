using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.HeapAlgorithms
{
    public class HeapSortParameter : IPageParameter
    {
        public string DirectoryName => Path.HeapAlgorithms.HeapSort;
        public string SubTitle => Title.HeapAlgorithms.HeapSort;
        public string SnippetPath => Snippet.HeapAlgorithms.HeapSort;
        public string Description => Routes.Route.Description.HeapAlgorithms.HeapSort;
    }
}