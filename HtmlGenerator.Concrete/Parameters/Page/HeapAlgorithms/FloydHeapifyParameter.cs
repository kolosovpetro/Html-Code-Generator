using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.HeapAlgorithms
{
    public class FloydHeapifyParameter : IPageParameter
    {
        public string DirectoryName => Path.HeapAlgorithms.FloydAlgorithm;
        public string SubTitle => Title.HeapAlgorithms.FloydAlgorithm;
        public string SnippetPath => Snippet.HeapAlgorithms.FloydAlgorithm;
        public string Description => Routes.Route.Description.HeapAlgorithms.FloydAlgorithm;
    }
}