using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms
{
    public class GraphKahnAlgorithmParameter : IPageParameter
    {
        public string DirectoryName => Path.GraphAlgorithms.KahnAlgorithm;
        public string SubTitle => Title.GraphAlgorithms.KahnAlgorithm;
        public string SnippetPath => Snippet.GraphAlgorithms.KahnAlgorithm;
        public string Description => Routes.Route.Description.GraphAlgorithms.KahnAlgorithm;
    }
}