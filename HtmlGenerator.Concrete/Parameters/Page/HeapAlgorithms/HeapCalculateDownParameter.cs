using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.HeapAlgorithms
{
    public class HeapCalculateDownParameter : IPageParameter
    {
        public string DirectoryName => Path.HeapAlgorithms.HeapCalculateDown;
        public string SubTitle => Title.HeapAlgorithms.HeapCalculateDown;
        public string SnippetPath => Snippet.HeapAlgorithms.HeapCalculateDown;
        public string Description => Routes.Route.Description.HeapAlgorithms.HeapCalculateDown;
    }
}