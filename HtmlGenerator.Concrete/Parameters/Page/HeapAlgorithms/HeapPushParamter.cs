using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.HeapAlgorithms
{
    public class HeapPushParamter : IPageParameter
    {
        public string DirectoryName => Path.HeapAlgorithms.HeapPush;
        public string SubTitle => Title.HeapAlgorithms.HeapPush;
        public string SnippetPath => Snippet.HeapAlgorithms.HeapPush;
        public string Description => Routes.Route.Description.HeapAlgorithms.HeapPush;
    }
}