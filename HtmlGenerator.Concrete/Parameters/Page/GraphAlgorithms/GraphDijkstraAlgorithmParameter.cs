using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms
{
    public class GraphDijkstraAlgorithmParameter : IPageParameter
    {
        public string DirectoryName => Path.GraphAlgorithms.DijkstraAlgorithm;
        public string SubTitle => Title.GraphAlgorithms.DijkstraAlgorithm;
        public string SnippetPath => Snippet.GraphAlgorithms.DijkstraAlgorithm;
        public string Description => Routes.Route.Description.GraphAlgorithms.DijkstraAlgorithm;
    }
}