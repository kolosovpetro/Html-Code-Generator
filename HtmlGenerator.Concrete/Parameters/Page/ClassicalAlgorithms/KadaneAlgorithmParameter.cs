using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms
{
    public class KadaneAlgorithmParameter : IPageParameter
    {
        public string DirectoryName => Path.ClassicalAlgorithms.KadaneAlgorithm;
        public string SubTitle => Title.ClassicalAlgorithms.KadaneAlgorithm;
        public string SnippetPath => Snippet.ClassicalAlgorithms.KadaneAlgorithm;
        public string Description => Routes.Route.Description.ClassicalAlgorithms.KadaneAlgorithm;
    }
}