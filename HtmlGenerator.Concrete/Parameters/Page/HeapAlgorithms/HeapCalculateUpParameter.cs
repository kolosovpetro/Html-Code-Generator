using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.HeapAlgorithms
{
    public class HeapCalculateUpParameter : IPageParameter
    {
        public string DirectoryName => Path.HeapAlgorithms.HeapCalculateUp;
        public string SubTitle => Title.HeapAlgorithms.HeapCalculateUp;
        public string SnippetPath => Snippet.HeapAlgorithms.HeapCalculateUp;
        public string Description => Routes.Route.Description.HeapAlgorithms.HeapCalculateUp;
    }
}