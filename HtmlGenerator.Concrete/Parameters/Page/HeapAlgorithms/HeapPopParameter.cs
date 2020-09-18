using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.HeapAlgorithms
{
    public class HeapPopParameter : IPageParameter
    {
        public string DirectoryName => Path.HeapAlgorithms.HeapPop;
        public string SubTitle => Title.HeapAlgorithms.HeapPop;
        public string SnippetPath => Snippet.HeapAlgorithms.HeapPop;
        public string Description => Routes.Route.Description.HeapAlgorithms.HeapPop;
    }
}